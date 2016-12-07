namespace WebFilesDownload
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.txbUrl = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnGo = new System.Windows.Forms.Button();
            this.btnDownload = new System.Windows.Forms.Button();
            this.txbFolder = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.rdbPdf = new System.Windows.Forms.RadioButton();
            this.rdbPub = new System.Windows.Forms.RadioButton();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.chklstFiles = new System.Windows.Forms.CheckedListBox();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.label4 = new System.Windows.Forms.Label();
            this.lblStatus = new System.Windows.Forms.Label();
            this.lblTotalFiles = new System.Windows.Forms.Label();
            this.lblTotalDownloaded = new System.Windows.Forms.Label();
            this.rdbMp3 = new System.Windows.Forms.RadioButton();
            this.SuspendLayout();
            // 
            // txbUrl
            // 
            this.txbUrl.Location = new System.Drawing.Point(49, 45);
            this.txbUrl.Name = "txbUrl";
            this.txbUrl.Size = new System.Drawing.Size(322, 20);
            this.txbUrl.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "URL";
            // 
            // btnGo
            // 
            this.btnGo.Location = new System.Drawing.Point(378, 43);
            this.btnGo.Name = "btnGo";
            this.btnGo.Size = new System.Drawing.Size(75, 23);
            this.btnGo.TabIndex = 2;
            this.btnGo.Text = "Go";
            this.btnGo.UseVisualStyleBackColor = true;
            this.btnGo.Click += new System.EventHandler(this.btnGo_Click);
            // 
            // btnDownload
            // 
            this.btnDownload.Location = new System.Drawing.Point(364, 267);
            this.btnDownload.Name = "btnDownload";
            this.btnDownload.Size = new System.Drawing.Size(89, 30);
            this.btnDownload.TabIndex = 3;
            this.btnDownload.Text = "Download";
            this.btnDownload.UseVisualStyleBackColor = true;
            this.btnDownload.Click += new System.EventHandler(this.btnDownload_Click);
            // 
            // txbFolder
            // 
            this.txbFolder.Location = new System.Drawing.Point(57, 273);
            this.txbFolder.Name = "txbFolder";
            this.txbFolder.Size = new System.Drawing.Size(254, 20);
            this.txbFolder.TabIndex = 5;
            this.txbFolder.Click += new System.EventHandler(this.txbFolder_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(15, 276);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(36, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Folder";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(15, 20);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "File type:";
            // 
            // rdbPdf
            // 
            this.rdbPdf.AutoSize = true;
            this.rdbPdf.Checked = true;
            this.rdbPdf.Location = new System.Drawing.Point(68, 20);
            this.rdbPdf.Name = "rdbPdf";
            this.rdbPdf.Size = new System.Drawing.Size(41, 17);
            this.rdbPdf.TabIndex = 8;
            this.rdbPdf.TabStop = true;
            this.rdbPdf.Text = "Pdf";
            this.rdbPdf.UseVisualStyleBackColor = true;
            this.rdbPdf.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // rdbPub
            // 
            this.rdbPub.AutoSize = true;
            this.rdbPub.Location = new System.Drawing.Point(119, 20);
            this.rdbPub.Name = "rdbPub";
            this.rdbPub.Size = new System.Drawing.Size(50, 17);
            this.rdbPub.TabIndex = 9;
            this.rdbPub.Text = "ePub";
            this.rdbPub.UseVisualStyleBackColor = true;
            // 
            // chklstFiles
            // 
            this.chklstFiles.FormattingEnabled = true;
            this.chklstFiles.Location = new System.Drawing.Point(18, 91);
            this.chklstFiles.Name = "chklstFiles";
            this.chklstFiles.Size = new System.Drawing.Size(435, 169);
            this.chklstFiles.TabIndex = 10;
            this.chklstFiles.SelectedIndexChanged += new System.EventHandler(this.chklstFiles_SelectedIndexChanged);
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(18, 346);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(435, 23);
            this.progressBar1.TabIndex = 11;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(18, 76);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(247, 13);
            this.label4.TabIndex = 12;
            this.label4.Text = "Uncheck the files that you don\'t want to download.";
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.Location = new System.Drawing.Point(18, 321);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(72, 13);
            this.lblStatus.TabIndex = 13;
            this.lblStatus.Text = "Downloading:";
            // 
            // lblTotalFiles
            // 
            this.lblTotalFiles.AutoSize = true;
            this.lblTotalFiles.Location = new System.Drawing.Point(352, 321);
            this.lblTotalFiles.Name = "lblTotalFiles";
            this.lblTotalFiles.Size = new System.Drawing.Size(55, 13);
            this.lblTotalFiles.TabIndex = 14;
            this.lblTotalFiles.Text = "Total files:";
            // 
            // lblTotalDownloaded
            // 
            this.lblTotalDownloaded.AutoSize = true;
            this.lblTotalDownloaded.Location = new System.Drawing.Point(186, 321);
            this.lblTotalDownloaded.Name = "lblTotalDownloaded";
            this.lblTotalDownloaded.Size = new System.Drawing.Size(95, 13);
            this.lblTotalDownloaded.TabIndex = 15;
            this.lblTotalDownloaded.Text = "Total downloaded:";
            this.lblTotalDownloaded.Visible = false;
            // 
            // rdbMp3
            // 
            this.rdbMp3.AutoSize = true;
            this.rdbMp3.Location = new System.Drawing.Point(179, 20);
            this.rdbMp3.Name = "rdbMp3";
            this.rdbMp3.Size = new System.Drawing.Size(45, 17);
            this.rdbMp3.TabIndex = 16;
            this.rdbMp3.Text = "mp3";
            this.rdbMp3.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(472, 382);
            this.Controls.Add(this.rdbMp3);
            this.Controls.Add(this.lblTotalDownloaded);
            this.Controls.Add(this.lblTotalFiles);
            this.Controls.Add(this.lblStatus);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.chklstFiles);
            this.Controls.Add(this.rdbPub);
            this.Controls.Add(this.rdbPdf);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txbFolder);
            this.Controls.Add(this.btnDownload);
            this.Controls.Add(this.btnGo);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txbUrl);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Web Files Download by  Antonio Sánchez";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txbUrl;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnGo;
        private System.Windows.Forms.Button btnDownload;
        private System.Windows.Forms.TextBox txbFolder;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.RadioButton rdbPdf;
        private System.Windows.Forms.RadioButton rdbPub;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.Windows.Forms.CheckedListBox chklstFiles;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.Label lblTotalFiles;
        private System.Windows.Forms.Label lblTotalDownloaded;
        private System.Windows.Forms.RadioButton rdbMp3;
    }
}

