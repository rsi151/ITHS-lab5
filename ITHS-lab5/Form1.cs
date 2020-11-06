using System;
using System.Collections.Generic;
using System.IO;
using System.Net.Http;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ITHS_lab5
{
    public partial class Scraper : Form
    {
        public string path;
        int counter = 1;

        readonly HttpClient client = new HttpClient();

        public Scraper()
        {
            InitializeComponent();
        }
        private async void ExtractButton_Click(object sender, EventArgs e)
        {
            ListBoxURL.Items.Clear();
            try
            {
                if (TextBoxURL.Text.Contains("http"))
                {
                    await GetWebHTML(TextBoxURL.Text);
                    LabelNumberOfURL.Text = $"Number of images found: {ListBoxURL.Items.Count}";
                }
                else
                {
                    TextBoxURL.Text = "https://" + TextBoxURL.Text;
                    await GetWebHTML(TextBoxURL.Text);
                    LabelNumberOfURL.Text = $"Number of images found: {ListBoxURL.Items.Count}";
                }
            }
            catch
            {
                MessageBox.Show("Webpage not found!\n" +
                                "(Invalid URL?)");
                LabelNumberOfURL.Text = "No images found!";
            }

            if (ListBoxURL.Items.Count > 0)
            {
                ButtonSave.Enabled = true;
            }

            LabelNumberOfURL.Visible = true;
        }
        private async Task GetWebHTML(string url)
        {
            using (Task<string> download = client.GetStringAsync(url))
            {
                await download;
                string userInputURL;

                Regex regex = new Regex(@"(?<=<img.*src="").+?(?="".*"">)");
                if (regex.IsMatch(download.Result))
                {
                    foreach (Match match in regex.Matches(download.Result))
                    {
                        if (!match.Value.StartsWith("http"))
                        {
                            userInputURL = TextBoxURL.Text + match.Value;
                        }
                        else
                        {
                            userInputURL = match.Value;
                        }
                        ListBoxURL.Items.Add(userInputURL + Environment.NewLine);
                    }
                }
            }
        }
        private async void SaveButton_Click(object sender, EventArgs e)
        {
            int failedCounter = 0;
            ButtonSave.Enabled = false;

            List<Task<byte[]>> imageData = new List<Task<byte[]>>();
            FolderBrowserDialog imageFolderDialog = new FolderBrowserDialog();

            imageFolderDialog.ShowDialog();
            path = imageFolderDialog.SelectedPath;

            foreach (string url in ListBoxURL.Items)
            {
                try
                {
                    imageData.Add(client.GetByteArrayAsync(url.Trim()));
                }
                catch
                {
                    continue;
                }
            }

            LabelSavedResult.Visible = true;

            while (imageData.Count > 0)
            {
                Task<byte[]> task = null;
                try
                {
                    using (task = await Task.WhenAny(imageData))
                    {
                        await SaveFileAsync(task.Result);
                    }
                }
                catch
                {
                    failedCounter++;
                }
                finally
                {
                    imageData.Remove(task);
                }
                LabelSavedResult.Text = $"{counter - 1} images saved to disk. {failedCounter} failed.";
            }
            MessageBox.Show("Download complete!");
        }

        private async Task SaveFileAsync(byte[] imageDataArray)
        {
            string fileType;
            switch (imageDataArray[0])
            {
                case 255:
                    fileType = ".jpg";
                    break;
                case 137:
                    fileType = ".png";
                    break;
                case 47:
                    fileType = ".gif";
                    break;
                case 66:
                    fileType = ".bmp";
                    break;
                default:
                    throw new Exception();
            }
            using (FileStream fileStream = new FileStream(path + $"\\image{counter}" +
                                            fileType, FileMode.CreateNew))
            {
                await fileStream.WriteAsync(imageDataArray, 0, imageDataArray.Length);
            }
            counter++;
        }
        private void URLTextBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                ButtonExtract.PerformClick();
                e.SuppressKeyPress = true;
                e.Handled = true;
            }
        }
    }
}