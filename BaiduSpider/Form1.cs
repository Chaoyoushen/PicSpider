using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using Newtonsoft.Json.Linq;
using System.Text.RegularExpressions;
using System.Threading;

namespace BaiduSpider
{
    public partial class PicSpider : Form
    {
        private Boolean stopFlag = false;
        public PicSpider()
        {
            InitializeComponent();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void btn_download_Click(object sender, EventArgs e)
        {
            if (btn_download.Text == "下载")
            {
                if (String.IsNullOrEmpty(keyword.Text))
                {
                    MessageBox.Show("关键词为空", "提示", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                if (String.IsNullOrEmpty(outPath.Text))
                {
                    MessageBox.Show("输出路径为空", "提示", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                if (!Directory.Exists(outPath.Text))
                {
                    try
                    {
                        Directory.CreateDirectory(outPath.Text);
                    }
                    catch
                    {
                        MessageBox.Show("路径创建失败", "提示", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                }
                try
                {
                    using (FileStream fs = new FileStream(Path.Combine(outPath.Text, "test.txt"), FileMode.Create));
                    File.Delete(Path.Combine(outPath.Text, "test.txt"));
                }
                catch
                {
                    MessageBox.Show("路径无法写入", "提示", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                String url = getUrl();
                Thread thread = new Thread(() => { downloadAll(url, (int)n_pageno.Value + 1); });
                stopFlag = false;
                thread.Start();

                btn_download.Text = "停止";
            }
            else
            {
                stopFlag = true;
            }

        }

        private void btn_selectPath_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog folder = new FolderBrowserDialog();
            folder.Description = "请选择导出文件夹";
            folder.ShowNewFolderButton = true;
            folder.SelectedPath = Environment.CurrentDirectory;

            if(folder.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                outPath.Text = folder.SelectedPath;
            }

        }

        private void cb__mainColor_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void checkBox_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox.Checked)
            {
                cb_size.Enabled = false;
                n_high.Enabled = true;
                n_width.Enabled = true;
            }
            else
            {
                cb_size.Enabled = true;
                n_high.Enabled = false;
                n_width.Enabled = false;
            }
        }

        private void PicSpider_Load(object sender, EventArgs e)
        {
            cb_size.SelectedIndex = 0;
            cb_mainColor.SelectedIndex = 0;
        }

        private String getUrl()
        {
            //百度中关键词
            String queryWord, word;
            //图片尺寸选项
            String z = new string[]{"", "1", "2", "3", "9"}[cb_size.SelectedIndex];
            //图片主色调选项
            String ic = "";
            if(cb_mainColor.SelectedIndex != 0)
            {
                ic = Convert.ToString(Math.Pow(2, cb_mainColor.SelectedIndex - 1));
            }
            //高清选项
            String hd = "";
            if (checkHD.Checked)
            {
                hd = "1";
            }
            //版权选项
            String copyRight = "";
            if (checkCopyRight.Checked)
            {
                copyRight = "1";
            }

            String width, height;
            width = height = "";
            if (checkBox.Checked)
            {
                width = n_width.Value.ToString();
                height = n_high.Value.ToString();
            }

            queryWord = word = urlEncode(keyword.Text);
            String URL = String.Format("https://image.baidu.com/search/acjson?tn=resultjson_com&ipn=rj&ct=201326592&is=&fp=result&queryWord={0}&cl=2&lm=-1&ie=utf-8&oe=utf-8&adpicid=&st=-1&z={1}&ic={2}&hd={3}&latest=&copyright={4}&word={5}&s=&se=&tab=&width={6}&height={7}&face=0&istype=2&qc=&nc=1&fr=&expermode=&pn=[REPLACE]&rn=30&gsm=1e&1545279656267=",
                queryWord, z, ic, hd, copyRight, word, width, height);
            return URL;
        }

        private String urlEncode(String str)
        {
            StringBuilder sb = new StringBuilder();
            byte[] byteStr = System.Text.Encoding.UTF8.GetBytes(str);
            foreach(byte bt in byteStr)
            {
                sb.Append(@"%" + Convert.ToString(bt, 16));
            }
            return sb.ToString();
        }

        private void downloadAll(String URL ,int pages)
        {
            for (int i = 0;i<pages;i++)
            {
                if (stopFlag)
                {
                    break;
                }
                String url = URL.Replace("[REPLACE]", (30 * i).ToString());
                Stream stream = null;
                String html = null;
                try
                {
                    stream = Download.DownloadFile(url);
                    using (StreamReader sr = new StreamReader(stream))
                    {
                        html = sr.ReadToEnd();

                    }
                }
                catch
                {
                    continue;
                }


                JObject obj = JObject.Parse(html); 
                JArray ja = (JArray)obj["data"];
                int nums = 0, times = 0;
                while(nums < 30 && times < 10)
                {
                    times++;

                    for (int j = 0; j < ja.Count; j++)
                    {
                        if (stopFlag)
                        {
                            break;
                        }
                        try
                        {
                            String picUrl = ja[j]["thumbURL"].ToString();
                            String name = reName(picUrl.Substring(picUrl.LastIndexOf("/") + 1));
                            String savePath = Path.Combine(outPath.Text, name);
                            String referer = "http//image.baidu.com";


                            if (ja[j].ToString().Contains("replaceUrl"))
                            {
                                picUrl = ja[j]["replaceUrl"][0]["ObjURL"].ToString();
                                name = reName(picUrl.Substring(picUrl.LastIndexOf("/") + 1));
                                savePath = Path.Combine(outPath.Text, name);
                                referer = ja[j]["replaceUrl"][0]["FormURL"].ToString();
                            }

                            if (File.Exists(savePath))
                            {
                                continue;
                            }
                            if (Download.DownloadFile(picUrl, savePath, referer))
                            {
                                nums++;
                                this.Invoke(new Action(() =>
                                {
                                    result.Text += name + "图片下载成功" + Environment.NewLine;
                                }));

                            }
                            else
                            {
                                this.Invoke(new Action(() =>
                                {
                                    result.Text += name + "图片下载失败" + Environment.NewLine;
                                }));
                            }
                        }
                        catch
                        {
                            continue;
                        }

                    }
                    

                }


            }

                this.Invoke(new Action(() =>
                {
                    btn_download.Text = "下载";
                }));

        }

        private String reName(String filePath)
        {
            filePath = filePath.Replace(":", "_");
            filePath = filePath.Replace("*", "_");
            filePath = filePath.Replace("?", "_");
            filePath = filePath.Replace("\\", "_");
            filePath = filePath.Replace("/", "_");
            filePath = filePath.Replace("\"", "_");
            filePath = filePath.Replace("<", "_");
            filePath = filePath.Replace("|", "_");
            filePath = filePath.Replace(">", "_");
            filePath = filePath.Replace(" ", "_");
            return filePath;
        }

        private void result_TextChanged(object sender, EventArgs e)
        {
            this.result.Select(this.result.TextLength, 0);
            this.result.ScrollToCaret();
        }

        private void PicSpider_FormClosing(object sender, FormClosingEventArgs e)
        {
            stopFlag = true;
        }
    }
}
