using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrganizeMusic
{
    partial class OrganizeMusicController
    {
        public string inputDirectory { get; set; }
        public string outputDirectory { get; set; }

        public OrganizeMusicController(string input, string output)
        {
            this.inputDirectory = input;
            this.outputDirectory = output;

            Validate.validateInputDirectory(this.inputDirectory);
            Validate.validateOutputDirectory(this.outputDirectory);
        }

        public void sortMusic()
        {
            string[] allFiles = this.crawl(this.inputDirectory);
            this.handleFiles(allFiles);
        }

        private string[] crawl(string rootDir)
        {
            return System.IO.Directory.GetFiles(rootDir, "*mp3", System.IO.SearchOption.AllDirectories);
        }

        private void handleFiles(string[] fileList)
        {
            List<System.Threading.Tasks.Task> taskList = new List<System.Threading.Tasks.Task>();
            foreach(string filePath in fileList)
            {
                taskList.Add(System.Threading.Tasks.Task.Factory.StartNew(new MP3(filePath, this.outputDirectory).sortFile));
            }
            System.Threading.Tasks.Task.WaitAll(taskList.ToArray());
        }
    }
}
