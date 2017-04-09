namespace OrganizeMusic
{
    partial class MainForm
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
            this.inputDirectoryDialog = new System.Windows.Forms.FolderBrowserDialog();
            this.outputDirectoryDialog = new System.Windows.Forms.FolderBrowserDialog();
            this.inputDirectoryTextBox = new System.Windows.Forms.TextBox();
            this.inputDirectoryButton = new System.Windows.Forms.Button();
            this.outputDirectoryTextBox = new System.Windows.Forms.TextBox();
            this.outputDirectoryButton = new System.Windows.Forms.Button();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.runButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // inputDirectoryDialog
            // 
            this.inputDirectoryDialog.Description = "Select the directory with garbled music";
            this.inputDirectoryDialog.RootFolder = System.Environment.SpecialFolder.MyComputer;
            this.inputDirectoryDialog.ShowNewFolderButton = false;
            this.inputDirectoryDialog.HelpRequest += new System.EventHandler(this.inputDirectorySelect_HelpRequest);
            // 
            // outputDirectoryDialog
            // 
            this.outputDirectoryDialog.Description = "Select a directory to placed the sorted music";
            this.outputDirectoryDialog.RootFolder = System.Environment.SpecialFolder.MyComputer;
            this.outputDirectoryDialog.HelpRequest += new System.EventHandler(this.outputDirectorySelect_HelpRequest);
            // 
            // inputDirectoryTextBox
            // 
            this.inputDirectoryTextBox.Location = new System.Drawing.Point(12, 12);
            this.inputDirectoryTextBox.Name = "inputDirectoryTextBox";
            this.inputDirectoryTextBox.ReadOnly = true;
            this.inputDirectoryTextBox.Size = new System.Drawing.Size(260, 20);
            this.inputDirectoryTextBox.TabIndex = 0;
            this.inputDirectoryTextBox.TabStop = false;
            this.inputDirectoryTextBox.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // inputDirectoryButton
            // 
            this.inputDirectoryButton.Location = new System.Drawing.Point(12, 38);
            this.inputDirectoryButton.Name = "inputDirectoryButton";
            this.inputDirectoryButton.Size = new System.Drawing.Size(75, 23);
            this.inputDirectoryButton.TabIndex = 1;
            this.inputDirectoryButton.Text = "Source";
            this.inputDirectoryButton.UseVisualStyleBackColor = true;
            this.inputDirectoryButton.Click += new System.EventHandler(this.inputDirectoryButton_Click);
            // 
            // outputDirectoryTextBox
            // 
            this.outputDirectoryTextBox.Location = new System.Drawing.Point(12, 67);
            this.outputDirectoryTextBox.Name = "outputDirectoryTextBox";
            this.outputDirectoryTextBox.ReadOnly = true;
            this.outputDirectoryTextBox.Size = new System.Drawing.Size(260, 20);
            this.outputDirectoryTextBox.TabIndex = 2;
            this.outputDirectoryTextBox.TabStop = false;
            // 
            // outputDirectoryButton
            // 
            this.outputDirectoryButton.Location = new System.Drawing.Point(12, 93);
            this.outputDirectoryButton.Name = "outputDirectoryButton";
            this.outputDirectoryButton.Size = new System.Drawing.Size(75, 23);
            this.outputDirectoryButton.TabIndex = 3;
            this.outputDirectoryButton.Text = "Output";
            this.outputDirectoryButton.UseVisualStyleBackColor = true;
            this.outputDirectoryButton.Click += new System.EventHandler(this.outputDirectoryButton_Click);
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(12, 226);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(260, 23);
            this.progressBar1.TabIndex = 4;
            // 
            // runButton
            // 
            this.runButton.Location = new System.Drawing.Point(12, 197);
            this.runButton.Name = "runButton";
            this.runButton.Size = new System.Drawing.Size(75, 23);
            this.runButton.TabIndex = 6;
            this.runButton.Text = "Run";
            this.runButton.UseVisualStyleBackColor = true;
            this.runButton.Click += new System.EventHandler(this.runButton_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.runButton);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.outputDirectoryButton);
            this.Controls.Add(this.outputDirectoryTextBox);
            this.Controls.Add(this.inputDirectoryButton);
            this.Controls.Add(this.inputDirectoryTextBox);
            this.Name = "MainForm";
            this.Text = "Organize Music";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.FolderBrowserDialog inputDirectoryDialog;
        private System.Windows.Forms.FolderBrowserDialog outputDirectoryDialog;
        private System.Windows.Forms.TextBox inputDirectoryTextBox;
        private System.Windows.Forms.Button inputDirectoryButton;
        private System.Windows.Forms.TextBox outputDirectoryTextBox;
        private System.Windows.Forms.Button outputDirectoryButton;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.Button runButton;
    }
}

