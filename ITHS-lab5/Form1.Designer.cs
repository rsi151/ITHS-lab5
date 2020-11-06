namespace ITHS_lab5
{
    partial class Scraper
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
            this.TextBoxURL = new System.Windows.Forms.TextBox();
            this.ButtonExtract = new System.Windows.Forms.Button();
            this.ButtonSave = new System.Windows.Forms.Button();
            this.LabelNumberOfURL = new System.Windows.Forms.Label();
            this.ListBoxURL = new System.Windows.Forms.ListBox();
            this.LabelSavedResult = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // TextBoxURL
            // 
            this.TextBoxURL.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TextBoxURL.Location = new System.Drawing.Point(10, 11);
            this.TextBoxURL.Margin = new System.Windows.Forms.Padding(2);
            this.TextBoxURL.Name = "TextBoxURL";
            this.TextBoxURL.Size = new System.Drawing.Size(366, 20);
            this.TextBoxURL.TabIndex = 0;
            this.TextBoxURL.Text = "https://www.gp.se/";
            this.TextBoxURL.KeyDown += new System.Windows.Forms.KeyEventHandler(this.URLTextBox_KeyDown);
            // 
            // ButtonExtract
            // 
            this.ButtonExtract.Location = new System.Drawing.Point(389, 11);
            this.ButtonExtract.Margin = new System.Windows.Forms.Padding(2);
            this.ButtonExtract.Name = "ButtonExtract";
            this.ButtonExtract.Size = new System.Drawing.Size(56, 19);
            this.ButtonExtract.TabIndex = 1;
            this.ButtonExtract.Text = "Extract";
            this.ButtonExtract.UseVisualStyleBackColor = true;
            this.ButtonExtract.Click += new System.EventHandler(this.ExtractButton_Click);
            // 
            // ButtonSave
            // 
            this.ButtonSave.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ButtonSave.Enabled = false;
            this.ButtonSave.Location = new System.Drawing.Point(462, 11);
            this.ButtonSave.Margin = new System.Windows.Forms.Padding(2);
            this.ButtonSave.Name = "ButtonSave";
            this.ButtonSave.Size = new System.Drawing.Size(80, 19);
            this.ButtonSave.TabIndex = 2;
            this.ButtonSave.Text = "Save images";
            this.ButtonSave.UseVisualStyleBackColor = false;
            this.ButtonSave.Click += new System.EventHandler(this.SaveButton_Click);
            // 
            // LabelNumberOfURL
            // 
            this.LabelNumberOfURL.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.LabelNumberOfURL.AutoSize = true;
            this.LabelNumberOfURL.Location = new System.Drawing.Point(9, 363);
            this.LabelNumberOfURL.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LabelNumberOfURL.Name = "LabelNumberOfURL";
            this.LabelNumberOfURL.Size = new System.Drawing.Size(29, 13);
            this.LabelNumberOfURL.TabIndex = 4;
            this.LabelNumberOfURL.Text = "label";
            this.LabelNumberOfURL.Visible = false;
            // 
            // ListBoxURL
            // 
            this.ListBoxURL.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ListBoxURL.FormattingEnabled = true;
            this.ListBoxURL.Location = new System.Drawing.Point(10, 44);
            this.ListBoxURL.Margin = new System.Windows.Forms.Padding(2);
            this.ListBoxURL.Name = "ListBoxURL";
            this.ListBoxURL.Size = new System.Drawing.Size(580, 303);
            this.ListBoxURL.TabIndex = 5;
            // 
            // LabelSavedResult
            // 
            this.LabelSavedResult.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.LabelSavedResult.AutoSize = true;
            this.LabelSavedResult.Location = new System.Drawing.Point(347, 364);
            this.LabelSavedResult.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LabelSavedResult.Name = "LabelSavedResult";
            this.LabelSavedResult.Size = new System.Drawing.Size(29, 13);
            this.LabelSavedResult.TabIndex = 6;
            this.LabelSavedResult.Text = "label";
            this.LabelSavedResult.Visible = false;
            // 
            // Scraper
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(602, 392);
            this.Controls.Add(this.LabelSavedResult);
            this.Controls.Add(this.ListBoxURL);
            this.Controls.Add(this.LabelNumberOfURL);
            this.Controls.Add(this.ButtonSave);
            this.Controls.Add(this.ButtonExtract);
            this.Controls.Add(this.TextBoxURL);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MinimumSize = new System.Drawing.Size(618, 431);
            this.Name = "Scraper";
            this.Text = "Web Scraper";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TextBoxURL;
        private System.Windows.Forms.Button ButtonExtract;
        private System.Windows.Forms.Button ButtonSave;
        private System.Windows.Forms.Label LabelNumberOfURL;
        private System.Windows.Forms.ListBox ListBoxURL;
        private System.Windows.Forms.Label LabelSavedResult;
    }
}
