using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using HtmlAgilityPack;

namespace WebFilesDownload
{
    public partial class Form1 : Form
    {
        private const string msgCaption = "Web Files Download";
        private string extension;
        private List<string> fileLinks = new List<string>();
        private int countFiles = 0;
        //private double totalKbDownloaded = 0.00;
        private long totalBytesDownloaded = 0;

        public Form1()
        {
            InitializeComponent();
            GetFileExtension();
            txbFolder.Text = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            btnDownload.Enabled = false;
            lblTotalFiles.Text = $"Total files: {countFiles} / {fileLinks.Count}";
        }

        private void btnDownload_Click(object sender, EventArgs e)
        {
            DownloadFiles();
        }

        private void txbFolder_Click(object sender, EventArgs e)
        {
            DialogResult result = folderBrowserDialog1.ShowDialog();
            if (result == DialogResult.OK)
            {
                string path = folderBrowserDialog1.SelectedPath;
                txbFolder.Text = path;
            }
        }

        private void DownloadFiles()
        {
            var filePath = txbFolder.Text;
            if (string.IsNullOrEmpty(filePath))
            {
                MessageBox.Show("Select the folder where you want to save your files!", msgCaption);
            }
            else
            {
                btnDownload.Text = "Downloading...";
                btnDownload.Enabled = false;

                foreach (var file in fileLinks)
                {
                    var fileName = GetFileName(file);


                    if (fileName.Length > 0)
                    {
                        try
                        {
                            using (WebClient webClient = new WebClient())
                            {
                                webClient.DownloadFileCompleted += new AsyncCompletedEventHandler(Completed);
                                webClient.DownloadProgressChanged += new DownloadProgressChangedEventHandler(ProgressChanged);
                                webClient.DownloadFileAsync(new Uri(file), filePath + "\\" + fileName.ToString());
                            }

                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("Error: {0}", ex.Message);
                        }
                    }
                }

                btnDownload.Text = "Download";
                btnDownload.Enabled = true;
            }

        }

        private void ProgressChanged(object sender, DownloadProgressChangedEventArgs e)
        {
            
            progressBar1.Value = e.ProgressPercentage;
            //lblStatus.Text = string.Format("Downloading: {0} of {1} kb", (e.BytesReceived / 1024), (e.TotalBytesToReceive / 1024));
            //totalKbDownloaded += (e.TotalBytesToReceive / 1024);
            //lblTotalDownloaded.Text = string.Format("Total downloaded: {0} kb", totalKbDownloaded);

            lblStatus.Text = string.Format("Downloading: {0} of {1}", SizeSuffix(e.BytesReceived), SizeSuffix(e.TotalBytesToReceive));
            totalBytesDownloaded += e.TotalBytesToReceive;
            //lblTotalDownloaded.Text = string.Format("Total downloaded: {0}", SizeSuffix(totalBytesDownloaded));
        }


        private static readonly string[] SizeSuffixes = { "bytes", "KB", "MB", "GB", "TB", "PB", "EB", "ZB", "YB" };
        private static string SizeSuffix(Int64 value)
        {
            if (value < 0) { return "-" + SizeSuffix(-value); }
            if (value == 0) { return "0.0 bytes"; }

            Int32 mag = (Int32)Math.Log(value, 1024);
            Decimal adjustedSize = (Decimal)value / (1L << (mag * 10));

            return string.Format("{0:n1} {1}", adjustedSize, SizeSuffixes[mag]);
        }



        private void Completed(object sender, AsyncCompletedEventArgs e)
        {
            if(countFiles < fileLinks.Count)
                countFiles++;

            progressBar1.Value = 0;
            lblTotalFiles.Text = "Total files: " + countFiles + " / " + fileLinks.Count;
        }

        private string GetFileName(string file)
        {
            string result = file.Split('/').Last();

            if (result.Contains("%20"))
                result = result.Replace("%20", "_");
            if (result.Contains("%ba"))
                result = result.Replace("%ba", "");

            return result;
        }

        private void GetFiles()
        {
            try
            {
                using (WebClient wc = new WebClient())
                {
                    string sourceCode = wc.DownloadString(txbUrl.Text);

                    // Clear lists
                    chklstFiles.Items.Clear();
                    fileLinks.Clear();

                    HtmlAgilityPack.HtmlDocument doc = new HtmlAgilityPack.HtmlDocument();
                    doc.LoadHtml(sourceCode);

                    HtmlNode node = doc.DocumentNode;
                    HtmlNodeCollection nodes = node.SelectNodes("//a[@href]");

                    List<string> links = new List<string>();
                    foreach (HtmlNode item in nodes)
                    {
                        string link = item.Attributes["href"].Value;
                        if (link.Contains(extension))
                        {
                            // If link starts with / then is absolute path
                            if (link.StartsWith("/"))
                            {
                                string fileName = GetFileName(link);
                                link = txbUrl.Text + fileName;
                            }

                            links.Add(link.Contains("http") ? link : txbUrl.Text + link);
                        }
                    }

                    foreach (string file in links)
                    {
                        if (file.LastIndexOf(extension) != 1)
                        {
                            fileLinks.Add(file.ToString());

                            string itemName = GetFileName(file);
                            if (!string.IsNullOrEmpty(itemName))
                                chklstFiles.Items.Add(itemName, CheckState.Checked);
                        }
                    }

                    if (chklstFiles.Items.Count > 0)
                        btnDownload.Enabled = true;
                    else
                    {
                        btnDownload.Enabled = false;
                        MessageBox.Show(string.Format("No {0} files were found!", extension), msgCaption);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, msgCaption);
            }

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            GetFileExtension();
        }

        private void GetFileExtension()
        {
            if (rdbPdf.Checked)
                extension = "." + rdbPdf.Text.ToLower();
            else if(rdbPub.Checked)
                extension = "." + rdbPub.Text.ToLower();
            else
                extension = "." + rdbMp3.Text.ToLower();
        }

        private void btnGo_Click(object sender, EventArgs e)
        {
            GetFiles();
        }

        private void chklstFiles_SelectedIndexChanged(object sender, EventArgs e)
        {
            CheckedListBox clb = (CheckedListBox)sender;
            // file = (string)clb.SelectedItem;

            // To can check the status of the item and remove the file if the status is uncheck 
            int index = clb.SelectedIndex;

            try
            {
                if (clb.CheckedItems.Count < 0)
                {
                    btnDownload.Enabled = false;
                }
                else
                {
                    if (index != -1 && clb.GetItemCheckState(index) == CheckState.Unchecked)
                    {
                        fileLinks.RemoveAt(index);
                        chklstFiles.Items.RemoveAt(index);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: {0}", ex.Message);
            }
            

        }
    }
}
