namespace m3u8wmsAuthSignUpdater
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;
        
        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.btnSetHtml = new System.Windows.Forms.Button();
            this.lblGuide66Path = new System.Windows.Forms.Label();
            this.txtNewPath = new System.Windows.Forms.TextBox();
            this.btnSetPath = new System.Windows.Forms.Button();
            this.btnSetm3u8 = new System.Windows.Forms.Button();
            this.lblm3u8Path = new System.Windows.Forms.Label();
            this.btnChangePathm3u8 = new System.Windows.Forms.Button();
            this.btnRun = new System.Windows.Forms.Button();
            this.lblStatusHeader = new System.Windows.Forms.Label();
            this.lblStatusInfo = new System.Windows.Forms.Label();
            this.btnExit = new System.Windows.Forms.Label();
            this.tmrFadeIn = new System.Windows.Forms.Timer(this.components);
            this.tmeFadeOut = new System.Windows.Forms.Timer(this.components);
            this.btnShowM3u8 = new System.Windows.Forms.Label();
            this.lbltopHeader = new System.Windows.Forms.Label();
            this.btnHtmlTest = new System.Windows.Forms.Label();
            this.wmsExpire = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.CheckPathExists = false;
            this.openFileDialog1.DefaultExt = "m3u8";
            this.openFileDialog1.FileName = "openFileDialog1";
            this.openFileDialog1.InitialDirectory = "@\"C:\\\"";
            this.openFileDialog1.RestoreDirectory = true;
            this.openFileDialog1.Title = "Browse for .m3u8 File!";
            // 
            // btnSetHtml
            // 
            this.btnSetHtml.BackColor = System.Drawing.Color.Transparent;
            this.btnSetHtml.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnSetHtml.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnSetHtml.FlatAppearance.MouseOverBackColor = System.Drawing.Color.MidnightBlue;
            this.btnSetHtml.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSetHtml.Font = new System.Drawing.Font("Calibri", 12F, ((System.Drawing.FontStyle)(((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic) 
                | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSetHtml.ForeColor = System.Drawing.Color.White;
            this.btnSetHtml.Location = new System.Drawing.Point(23, 37);
            this.btnSetHtml.Margin = new System.Windows.Forms.Padding(0);
            this.btnSetHtml.Name = "btnSetHtml";
            this.btnSetHtml.Size = new System.Drawing.Size(114, 59);
            this.btnSetHtml.TabIndex = 3;
            this.btnSetHtml.TabStop = false;
            this.btnSetHtml.Text = "Change html Source";
            this.btnSetHtml.UseVisualStyleBackColor = false;
            this.btnSetHtml.Click += new System.EventHandler(this.btnSetHtml_Click);
            // 
            // lblGuide66Path
            // 
            this.lblGuide66Path.BackColor = System.Drawing.Color.Transparent;
            this.lblGuide66Path.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblGuide66Path.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblGuide66Path.Font = new System.Drawing.Font("Calibri", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGuide66Path.ForeColor = System.Drawing.Color.White;
            this.lblGuide66Path.Location = new System.Drawing.Point(165, 37);
            this.lblGuide66Path.Margin = new System.Windows.Forms.Padding(0);
            this.lblGuide66Path.Name = "lblGuide66Path";
            this.lblGuide66Path.Size = new System.Drawing.Size(369, 25);
            this.lblGuide66Path.TabIndex = 4;
            this.lblGuide66Path.Text = "Guide66 HTTP";
            this.lblGuide66Path.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtNewPath
            // 
            this.txtNewPath.BackColor = System.Drawing.Color.RoyalBlue;
            this.txtNewPath.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtNewPath.Font = new System.Drawing.Font("Calibri", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNewPath.ForeColor = System.Drawing.Color.White;
            this.txtNewPath.Location = new System.Drawing.Point(165, 69);
            this.txtNewPath.Margin = new System.Windows.Forms.Padding(0);
            this.txtNewPath.Name = "txtNewPath";
            this.txtNewPath.Size = new System.Drawing.Size(369, 27);
            this.txtNewPath.TabIndex = 5;
            this.txtNewPath.TabStop = false;
            this.txtNewPath.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtNewPath.Visible = false;
            // 
            // btnSetPath
            // 
            this.btnSetPath.BackColor = System.Drawing.Color.Transparent;
            this.btnSetPath.Enabled = false;
            this.btnSetPath.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnSetPath.FlatAppearance.MouseOverBackColor = System.Drawing.Color.MidnightBlue;
            this.btnSetPath.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSetPath.Font = new System.Drawing.Font("Calibri", 12F, ((System.Drawing.FontStyle)(((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic) 
                | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSetPath.ForeColor = System.Drawing.Color.White;
            this.btnSetPath.Location = new System.Drawing.Point(557, 37);
            this.btnSetPath.Margin = new System.Windows.Forms.Padding(0);
            this.btnSetPath.Name = "btnSetPath";
            this.btnSetPath.Size = new System.Drawing.Size(62, 41);
            this.btnSetPath.TabIndex = 6;
            this.btnSetPath.TabStop = false;
            this.btnSetPath.Text = "Set";
            this.btnSetPath.UseVisualStyleBackColor = false;
            this.btnSetPath.Click += new System.EventHandler(this.btnSetPath_Click);
            // 
            // btnSetm3u8
            // 
            this.btnSetm3u8.BackColor = System.Drawing.Color.Transparent;
            this.btnSetm3u8.Enabled = false;
            this.btnSetm3u8.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnSetm3u8.FlatAppearance.MouseOverBackColor = System.Drawing.Color.MidnightBlue;
            this.btnSetm3u8.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSetm3u8.Font = new System.Drawing.Font("Calibri", 12F, ((System.Drawing.FontStyle)(((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic) 
                | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSetm3u8.ForeColor = System.Drawing.Color.White;
            this.btnSetm3u8.Location = new System.Drawing.Point(557, 113);
            this.btnSetm3u8.Margin = new System.Windows.Forms.Padding(0);
            this.btnSetm3u8.Name = "btnSetm3u8";
            this.btnSetm3u8.Size = new System.Drawing.Size(62, 41);
            this.btnSetm3u8.TabIndex = 15;
            this.btnSetm3u8.TabStop = false;
            this.btnSetm3u8.Text = "Set";
            this.btnSetm3u8.UseVisualStyleBackColor = false;
            this.btnSetm3u8.Click += new System.EventHandler(this.btnSetm3u8_Click);
            // 
            // lblm3u8Path
            // 
            this.lblm3u8Path.BackColor = System.Drawing.Color.Transparent;
            this.lblm3u8Path.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblm3u8Path.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblm3u8Path.Font = new System.Drawing.Font("Calibri", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblm3u8Path.ForeColor = System.Drawing.Color.White;
            this.lblm3u8Path.Location = new System.Drawing.Point(165, 113);
            this.lblm3u8Path.Margin = new System.Windows.Forms.Padding(0);
            this.lblm3u8Path.Name = "lblm3u8Path";
            this.lblm3u8Path.Size = new System.Drawing.Size(369, 25);
            this.lblm3u8Path.TabIndex = 13;
            this.lblm3u8Path.Text = "m3u8 Playlist Path";
            this.lblm3u8Path.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnChangePathm3u8
            // 
            this.btnChangePathm3u8.BackColor = System.Drawing.Color.Transparent;
            this.btnChangePathm3u8.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnChangePathm3u8.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnChangePathm3u8.FlatAppearance.MouseOverBackColor = System.Drawing.Color.MidnightBlue;
            this.btnChangePathm3u8.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnChangePathm3u8.Font = new System.Drawing.Font("Calibri", 12F, ((System.Drawing.FontStyle)(((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic) 
                | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnChangePathm3u8.ForeColor = System.Drawing.Color.White;
            this.btnChangePathm3u8.Location = new System.Drawing.Point(23, 113);
            this.btnChangePathm3u8.Margin = new System.Windows.Forms.Padding(0);
            this.btnChangePathm3u8.Name = "btnChangePathm3u8";
            this.btnChangePathm3u8.Size = new System.Drawing.Size(114, 59);
            this.btnChangePathm3u8.TabIndex = 12;
            this.btnChangePathm3u8.TabStop = false;
            this.btnChangePathm3u8.Text = "Change .m3u8 Path";
            this.btnChangePathm3u8.UseVisualStyleBackColor = false;
            this.btnChangePathm3u8.Click += new System.EventHandler(this.btnChangePathm3u8_Click);
            // 
            // btnRun
            // 
            this.btnRun.BackColor = System.Drawing.Color.Transparent;
            this.btnRun.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnRun.FlatAppearance.MouseOverBackColor = System.Drawing.Color.MidnightBlue;
            this.btnRun.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRun.Font = new System.Drawing.Font("Calibri", 12F, ((System.Drawing.FontStyle)(((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic) 
                | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRun.ForeColor = System.Drawing.Color.White;
            this.btnRun.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.btnRun.Location = new System.Drawing.Point(23, 189);
            this.btnRun.Margin = new System.Windows.Forms.Padding(0);
            this.btnRun.Name = "btnRun";
            this.btnRun.Size = new System.Drawing.Size(114, 59);
            this.btnRun.TabIndex = 16;
            this.btnRun.TabStop = false;
            this.btnRun.Text = "Patch m3u8 Playlist";
            this.btnRun.UseVisualStyleBackColor = false;
            this.btnRun.Click += new System.EventHandler(this.btnRun_Click);
            // 
            // lblStatusHeader
            // 
            this.lblStatusHeader.BackColor = System.Drawing.Color.Transparent;
            this.lblStatusHeader.Font = new System.Drawing.Font("Calibri", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStatusHeader.ForeColor = System.Drawing.Color.White;
            this.lblStatusHeader.Location = new System.Drawing.Point(332, 159);
            this.lblStatusHeader.Margin = new System.Windows.Forms.Padding(0);
            this.lblStatusHeader.Name = "lblStatusHeader";
            this.lblStatusHeader.Size = new System.Drawing.Size(120, 20);
            this.lblStatusHeader.TabIndex = 17;
            this.lblStatusHeader.Text = "STATUS!";
            this.lblStatusHeader.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblStatusInfo
            // 
            this.lblStatusInfo.BackColor = System.Drawing.Color.Transparent;
            this.lblStatusInfo.Font = new System.Drawing.Font("Calibri", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStatusInfo.ForeColor = System.Drawing.Color.White;
            this.lblStatusInfo.Location = new System.Drawing.Point(165, 189);
            this.lblStatusInfo.Margin = new System.Windows.Forms.Padding(0);
            this.lblStatusInfo.Name = "lblStatusInfo";
            this.lblStatusInfo.Size = new System.Drawing.Size(454, 25);
            this.lblStatusInfo.TabIndex = 18;
            this.lblStatusInfo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.Color.Transparent;
            this.btnExit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExit.Font = new System.Drawing.Font("Calibri", 12F, ((System.Drawing.FontStyle)(((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic) 
                | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.ForeColor = System.Drawing.Color.White;
            this.btnExit.Location = new System.Drawing.Point(585, 231);
            this.btnExit.Margin = new System.Windows.Forms.Padding(0);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(45, 20);
            this.btnExit.TabIndex = 19;
            this.btnExit.Text = "Exit";
            this.btnExit.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // tmrFadeIn
            // 
            this.tmrFadeIn.Tick += new System.EventHandler(this.tmrFadeIn_Tick);
            // 
            // tmeFadeOut
            // 
            this.tmeFadeOut.Tick += new System.EventHandler(this.tmeFadeOut_Tick);
            // 
            // btnShowM3u8
            // 
            this.btnShowM3u8.BackColor = System.Drawing.Color.Transparent;
            this.btnShowM3u8.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnShowM3u8.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnShowM3u8.Font = new System.Drawing.Font("Calibri", 12F, ((System.Drawing.FontStyle)(((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic) 
                | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnShowM3u8.ForeColor = System.Drawing.Color.White;
            this.btnShowM3u8.Location = new System.Drawing.Point(484, 231);
            this.btnShowM3u8.Margin = new System.Windows.Forms.Padding(0);
            this.btnShowM3u8.Name = "btnShowM3u8";
            this.btnShowM3u8.Size = new System.Drawing.Size(90, 20);
            this.btnShowM3u8.TabIndex = 20;
            this.btnShowM3u8.Text = "Show m3u8";
            this.btnShowM3u8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnShowM3u8.Click += new System.EventHandler(this.btnShowM3u8_Click);
            // 
            // lbltopHeader
            // 
            this.lbltopHeader.BackColor = System.Drawing.Color.Transparent;
            this.lbltopHeader.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbltopHeader.ForeColor = System.Drawing.Color.White;
            this.lbltopHeader.Location = new System.Drawing.Point(0, 0);
            this.lbltopHeader.Margin = new System.Windows.Forms.Padding(0);
            this.lbltopHeader.Name = "lbltopHeader";
            this.lbltopHeader.Size = new System.Drawing.Size(204, 22);
            this.lbltopHeader.TabIndex = 21;
            this.lbltopHeader.Text = "m3u8_wmsAuthSign_Updater";
            this.lbltopHeader.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnHtmlTest
            // 
            this.btnHtmlTest.BackColor = System.Drawing.Color.Transparent;
            this.btnHtmlTest.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnHtmlTest.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHtmlTest.Font = new System.Drawing.Font("Calibri", 12F, ((System.Drawing.FontStyle)(((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic) 
                | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHtmlTest.ForeColor = System.Drawing.Color.White;
            this.btnHtmlTest.Location = new System.Drawing.Point(388, 231);
            this.btnHtmlTest.Margin = new System.Windows.Forms.Padding(0);
            this.btnHtmlTest.Name = "btnHtmlTest";
            this.btnHtmlTest.Size = new System.Drawing.Size(85, 20);
            this.btnHtmlTest.TabIndex = 22;
            this.btnHtmlTest.Text = "Test Html";
            this.btnHtmlTest.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnHtmlTest.Click += new System.EventHandler(this.btnHtmlTest_Click);
            // 
            // wmsExpire
            // 
            this.wmsExpire.BackColor = System.Drawing.Color.Transparent;
            this.wmsExpire.Cursor = System.Windows.Forms.Cursors.Hand;
            this.wmsExpire.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.wmsExpire.Font = new System.Drawing.Font("Calibri", 12F, ((System.Drawing.FontStyle)(((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic) 
                | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.wmsExpire.ForeColor = System.Drawing.Color.White;
            this.wmsExpire.Location = new System.Drawing.Point(222, 231);
            this.wmsExpire.Margin = new System.Windows.Forms.Padding(0);
            this.wmsExpire.Name = "wmsExpire";
            this.wmsExpire.Size = new System.Drawing.Size(155, 20);
            this.wmsExpire.TabIndex = 23;
            this.wmsExpire.Text = "m3u8 Expiration Time";
            this.wmsExpire.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.wmsExpire.Click += new System.EventHandler(this.wmsExpire_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.RoyalBlue;
            this.BackgroundImage = global::m3u8wmsAuthSignUpdater.Properties.Resources.BACKGROUND;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(640, 260);
            this.Controls.Add(this.wmsExpire);
            this.Controls.Add(this.btnHtmlTest);
            this.Controls.Add(this.lbltopHeader);
            this.Controls.Add(this.btnShowM3u8);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.lblStatusInfo);
            this.Controls.Add(this.lblStatusHeader);
            this.Controls.Add(this.btnRun);
            this.Controls.Add(this.btnSetm3u8);
            this.Controls.Add(this.lblm3u8Path);
            this.Controls.Add(this.btnChangePathm3u8);
            this.Controls.Add(this.btnSetPath);
            this.Controls.Add(this.txtNewPath);
            this.Controls.Add(this.lblGuide66Path);
            this.Controls.Add(this.btnSetHtml);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Opacity = 0D;
            this.ShowIcon = false;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Show;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "m3u8wmsAuthSignUpdater";
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseDown);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Button btnSetHtml;
        private System.Windows.Forms.Label lblGuide66Path;
        private System.Windows.Forms.TextBox txtNewPath;
        private System.Windows.Forms.Button btnSetPath;
        private System.Windows.Forms.Button btnSetm3u8;
        private System.Windows.Forms.Label lblm3u8Path;
        private System.Windows.Forms.Button btnChangePathm3u8;
        private System.Windows.Forms.Button btnRun;
        private System.Windows.Forms.Label lblStatusHeader;
        private System.Windows.Forms.Label lblStatusInfo;
        private System.Windows.Forms.Label btnExit;
        private System.Windows.Forms.Timer tmrFadeIn;
        private System.Windows.Forms.Timer tmeFadeOut;
        private System.Windows.Forms.Label btnShowM3u8;
        private System.Windows.Forms.Label lbltopHeader;
        private System.Windows.Forms.Label btnHtmlTest;
        private System.Windows.Forms.Label wmsExpire;
    }
}

