using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OrganizeMusic
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            string inputDirectory = System.Environment.GetEnvironmentVariable("homepath");

            string outputDirectory = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
            outputDirectory += System.IO.Path.DirectorySeparatorChar + "OrganizeMusic";

            inputDirectoryTextBox.Text = inputDirectory;
            outputDirectoryTextBox.Text = outputDirectory;
        }

        private void inputDirectorySelect_HelpRequest(object sender, EventArgs e)
        {
        }

        private void outputDirectorySelect_HelpRequest(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void inputDirectoryButton_Click(object sender, EventArgs e)
        {
            if (inputDirectoryDialog.ShowDialog() == DialogResult.OK)
            {
                inputDirectoryTextBox.Text = inputDirectoryDialog.SelectedPath;
            }
        }

        private void outputDirectoryButton_Click(object sender, EventArgs e)
        {
            if(outputDirectoryDialog.ShowDialog() == DialogResult.OK)
            {
                outputDirectoryTextBox.Text = outputDirectoryDialog.SelectedPath;
            }
        }

        private void runButton_Click(object sender, EventArgs e)
        {
            new OrganizeMusicController(inputDirectoryTextBox.Text, outputDirectoryTextBox.Text).sortMusic();

            runButton.Enabled = false;
        }
    }
}
