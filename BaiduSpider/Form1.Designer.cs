namespace BaiduSpider
{
    partial class PicSpider
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.g_basic = new System.Windows.Forms.GroupBox();
            this.n_pageno = new System.Windows.Forms.NumericUpDown();
            this.outPath = new System.Windows.Forms.TextBox();
            this.keyword = new System.Windows.Forms.TextBox();
            this.btn_selectPath = new System.Windows.Forms.Button();
            this.btn_download = new System.Windows.Forms.Button();
            this.t_outPath = new System.Windows.Forms.Label();
            this.t_pageno = new System.Windows.Forms.Label();
            this.t_keyword = new System.Windows.Forms.Label();
            this.g_select = new System.Windows.Forms.GroupBox();
            this.checkCopyRight = new System.Windows.Forms.CheckBox();
            this.checkHD = new System.Windows.Forms.CheckBox();
            this.cb_size = new System.Windows.Forms.ComboBox();
            this.cb_mainColor = new System.Windows.Forms.ComboBox();
            this.n_width = new System.Windows.Forms.NumericUpDown();
            this.n_high = new System.Windows.Forms.NumericUpDown();
            this.t_width = new System.Windows.Forms.Label();
            this.t_high = new System.Windows.Forms.Label();
            this.checkBox = new System.Windows.Forms.CheckBox();
            this.t_size = new System.Windows.Forms.Label();
            this.t_mainColor = new System.Windows.Forms.Label();
            this.result = new System.Windows.Forms.TextBox();
            this.g_basic.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.n_pageno)).BeginInit();
            this.g_select.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.n_width)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.n_high)).BeginInit();
            this.SuspendLayout();
            // 
            // g_basic
            // 
            this.g_basic.Controls.Add(this.n_pageno);
            this.g_basic.Controls.Add(this.outPath);
            this.g_basic.Controls.Add(this.keyword);
            this.g_basic.Controls.Add(this.btn_selectPath);
            this.g_basic.Controls.Add(this.btn_download);
            this.g_basic.Controls.Add(this.t_outPath);
            this.g_basic.Controls.Add(this.t_pageno);
            this.g_basic.Controls.Add(this.t_keyword);
            this.g_basic.Location = new System.Drawing.Point(13, 13);
            this.g_basic.Name = "g_basic";
            this.g_basic.Size = new System.Drawing.Size(461, 90);
            this.g_basic.TabIndex = 0;
            this.g_basic.TabStop = false;
            this.g_basic.Text = "基本功能";
            this.g_basic.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // n_pageno
            // 
            this.n_pageno.Location = new System.Drawing.Point(219, 17);
            this.n_pageno.Name = "n_pageno";
            this.n_pageno.Size = new System.Drawing.Size(120, 21);
            this.n_pageno.TabIndex = 8;
            // 
            // outPath
            // 
            this.outPath.Location = new System.Drawing.Point(65, 50);
            this.outPath.Name = "outPath";
            this.outPath.Size = new System.Drawing.Size(274, 21);
            this.outPath.TabIndex = 7;
            // 
            // keyword
            // 
            this.keyword.Location = new System.Drawing.Point(65, 16);
            this.keyword.Name = "keyword";
            this.keyword.Size = new System.Drawing.Size(101, 21);
            this.keyword.TabIndex = 5;
            // 
            // btn_selectPath
            // 
            this.btn_selectPath.Location = new System.Drawing.Point(353, 48);
            this.btn_selectPath.Name = "btn_selectPath";
            this.btn_selectPath.Size = new System.Drawing.Size(75, 23);
            this.btn_selectPath.TabIndex = 4;
            this.btn_selectPath.Text = "路径选择";
            this.btn_selectPath.UseVisualStyleBackColor = true;
            this.btn_selectPath.Click += new System.EventHandler(this.btn_selectPath_Click);
            // 
            // btn_download
            // 
            this.btn_download.Location = new System.Drawing.Point(353, 14);
            this.btn_download.Name = "btn_download";
            this.btn_download.Size = new System.Drawing.Size(75, 23);
            this.btn_download.TabIndex = 3;
            this.btn_download.Text = "下载";
            this.btn_download.UseVisualStyleBackColor = true;
            this.btn_download.Click += new System.EventHandler(this.btn_download_Click);
            // 
            // t_outPath
            // 
            this.t_outPath.AutoSize = true;
            this.t_outPath.Location = new System.Drawing.Point(6, 53);
            this.t_outPath.Name = "t_outPath";
            this.t_outPath.Size = new System.Drawing.Size(53, 12);
            this.t_outPath.TabIndex = 2;
            this.t_outPath.Text = "输出路径";
            // 
            // t_pageno
            // 
            this.t_pageno.AutoSize = true;
            this.t_pageno.Location = new System.Drawing.Point(184, 21);
            this.t_pageno.Name = "t_pageno";
            this.t_pageno.Size = new System.Drawing.Size(29, 12);
            this.t_pageno.TabIndex = 1;
            this.t_pageno.Text = "页数";
            // 
            // t_keyword
            // 
            this.t_keyword.AutoSize = true;
            this.t_keyword.Location = new System.Drawing.Point(18, 21);
            this.t_keyword.Name = "t_keyword";
            this.t_keyword.Size = new System.Drawing.Size(41, 12);
            this.t_keyword.TabIndex = 0;
            this.t_keyword.Text = "关键字";
            // 
            // g_select
            // 
            this.g_select.Controls.Add(this.checkCopyRight);
            this.g_select.Controls.Add(this.checkHD);
            this.g_select.Controls.Add(this.cb_size);
            this.g_select.Controls.Add(this.cb_mainColor);
            this.g_select.Controls.Add(this.n_width);
            this.g_select.Controls.Add(this.n_high);
            this.g_select.Controls.Add(this.t_width);
            this.g_select.Controls.Add(this.t_high);
            this.g_select.Controls.Add(this.checkBox);
            this.g_select.Controls.Add(this.t_size);
            this.g_select.Controls.Add(this.t_mainColor);
            this.g_select.Location = new System.Drawing.Point(13, 109);
            this.g_select.Name = "g_select";
            this.g_select.Size = new System.Drawing.Size(461, 94);
            this.g_select.TabIndex = 1;
            this.g_select.TabStop = false;
            this.g_select.Text = "筛选设置";
            // 
            // checkCopyRight
            // 
            this.checkCopyRight.AutoSize = true;
            this.checkCopyRight.Location = new System.Drawing.Point(326, 20);
            this.checkCopyRight.Name = "checkCopyRight";
            this.checkCopyRight.Size = new System.Drawing.Size(48, 16);
            this.checkCopyRight.TabIndex = 12;
            this.checkCopyRight.Text = "版权";
            this.checkCopyRight.UseVisualStyleBackColor = true;
            // 
            // checkHD
            // 
            this.checkHD.AutoSize = true;
            this.checkHD.Location = new System.Drawing.Point(233, 21);
            this.checkHD.Name = "checkHD";
            this.checkHD.Size = new System.Drawing.Size(48, 16);
            this.checkHD.TabIndex = 11;
            this.checkHD.Text = "高清";
            this.checkHD.UseVisualStyleBackColor = true;
            // 
            // cb_size
            // 
            this.cb_size.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_size.FormattingEnabled = true;
            this.cb_size.Items.AddRange(new object[] {
            "全部尺寸",
            "小尺寸",
            "中尺寸",
            "大尺寸",
            "特大型尺寸"});
            this.cb_size.Location = new System.Drawing.Point(80, 52);
            this.cb_size.Name = "cb_size";
            this.cb_size.Size = new System.Drawing.Size(121, 20);
            this.cb_size.TabIndex = 10;
            // 
            // cb_mainColor
            // 
            this.cb_mainColor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_mainColor.FormattingEnabled = true;
            this.cb_mainColor.Items.AddRange(new object[] {
            "全部颜色",
            "红色",
            "黄色",
            "绿色",
            "青色",
            "蓝色",
            "紫色",
            "粉色",
            "棕色",
            "橙色",
            "黑色",
            "白色",
            "黑白"});
            this.cb_mainColor.Location = new System.Drawing.Point(80, 18);
            this.cb_mainColor.Name = "cb_mainColor";
            this.cb_mainColor.Size = new System.Drawing.Size(121, 20);
            this.cb_mainColor.TabIndex = 8;
            this.cb_mainColor.SelectedIndexChanged += new System.EventHandler(this.cb__mainColor_SelectedIndexChanged);
            // 
            // n_width
            // 
            this.n_width.Enabled = false;
            this.n_width.Location = new System.Drawing.Point(347, 53);
            this.n_width.Maximum = new decimal(new int[] {
            9000,
            0,
            0,
            0});
            this.n_width.Name = "n_width";
            this.n_width.Size = new System.Drawing.Size(66, 21);
            this.n_width.TabIndex = 7;
            // 
            // n_high
            // 
            this.n_high.Enabled = false;
            this.n_high.Location = new System.Drawing.Point(254, 53);
            this.n_high.Maximum = new decimal(new int[] {
            9000,
            0,
            0,
            0});
            this.n_high.Name = "n_high";
            this.n_high.Size = new System.Drawing.Size(64, 21);
            this.n_high.TabIndex = 6;
            // 
            // t_width
            // 
            this.t_width.AutoSize = true;
            this.t_width.Location = new System.Drawing.Point(324, 57);
            this.t_width.Name = "t_width";
            this.t_width.Size = new System.Drawing.Size(17, 12);
            this.t_width.TabIndex = 5;
            this.t_width.Text = "宽";
            // 
            // t_high
            // 
            this.t_high.AutoSize = true;
            this.t_high.Location = new System.Drawing.Point(231, 57);
            this.t_high.Name = "t_high";
            this.t_high.Size = new System.Drawing.Size(17, 12);
            this.t_high.TabIndex = 4;
            this.t_high.Text = "高";
            // 
            // checkBox
            // 
            this.checkBox.AutoSize = true;
            this.checkBox.Location = new System.Drawing.Point(210, 57);
            this.checkBox.Name = "checkBox";
            this.checkBox.Size = new System.Drawing.Size(15, 14);
            this.checkBox.TabIndex = 3;
            this.checkBox.UseVisualStyleBackColor = true;
            this.checkBox.CheckedChanged += new System.EventHandler(this.checkBox_CheckedChanged);
            // 
            // t_size
            // 
            this.t_size.AutoSize = true;
            this.t_size.Location = new System.Drawing.Point(21, 55);
            this.t_size.Name = "t_size";
            this.t_size.Size = new System.Drawing.Size(53, 12);
            this.t_size.TabIndex = 2;
            this.t_size.Text = "图片尺寸";
            // 
            // t_mainColor
            // 
            this.t_mainColor.AutoSize = true;
            this.t_mainColor.Location = new System.Drawing.Point(9, 21);
            this.t_mainColor.Name = "t_mainColor";
            this.t_mainColor.Size = new System.Drawing.Size(65, 12);
            this.t_mainColor.TabIndex = 0;
            this.t_mainColor.Text = "图片主色调";
            // 
            // result
            // 
            this.result.Location = new System.Drawing.Point(13, 209);
            this.result.Multiline = true;
            this.result.Name = "result";
            this.result.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.result.Size = new System.Drawing.Size(461, 292);
            this.result.TabIndex = 2;
            this.result.TextChanged += new System.EventHandler(this.result_TextChanged);
            // 
            // PicSpider
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(484, 513);
            this.Controls.Add(this.result);
            this.Controls.Add(this.g_select);
            this.Controls.Add(this.g_basic);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "PicSpider";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "图片爬虫";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.PicSpider_FormClosing);
            this.Load += new System.EventHandler(this.PicSpider_Load);
            this.g_basic.ResumeLayout(false);
            this.g_basic.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.n_pageno)).EndInit();
            this.g_select.ResumeLayout(false);
            this.g_select.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.n_width)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.n_high)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox g_basic;
        private System.Windows.Forms.GroupBox g_select;
        private System.Windows.Forms.TextBox result;
        private System.Windows.Forms.NumericUpDown n_pageno;
        private System.Windows.Forms.TextBox outPath;
        private System.Windows.Forms.TextBox keyword;
        private System.Windows.Forms.Button btn_selectPath;
        private System.Windows.Forms.Button btn_download;
        private System.Windows.Forms.Label t_outPath;
        private System.Windows.Forms.Label t_pageno;
        private System.Windows.Forms.Label t_keyword;
        private System.Windows.Forms.ComboBox cb_size;
        private System.Windows.Forms.ComboBox cb_mainColor;
        private System.Windows.Forms.NumericUpDown n_width;
        private System.Windows.Forms.NumericUpDown n_high;
        private System.Windows.Forms.Label t_width;
        private System.Windows.Forms.Label t_high;
        private System.Windows.Forms.CheckBox checkBox;
        private System.Windows.Forms.Label t_size;
        private System.Windows.Forms.Label t_mainColor;
        private System.Windows.Forms.CheckBox checkHD;
        private System.Windows.Forms.CheckBox checkCopyRight;
    }
}

