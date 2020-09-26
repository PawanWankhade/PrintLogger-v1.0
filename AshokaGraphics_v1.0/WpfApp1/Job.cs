using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AshokaGraphics
{
    class Job
    {
        public int Id { get; set; }
        public string JobDate { get; set; }
        public string FilePath { get; set; }
        public string PercentComplete { get; set; }
        public string JobStartTime { get; set; }
        public string JobEndTime { get; set; }
        public string TimeRequired { get; set; }



        public bool CheckFileExists(string path)
        {
            return File.Exists(path);
        }

        private string[] ReadFileContent(string path)
        {
            if (File.Exists(path))
            {
                string[] fileContent = File.ReadAllLines(path);
                Array.Reverse(fileContent);
                return fileContent;
            }
            return null;
        }

        public bool ChangeFileAttribute(string path)
        {
            //try
            //{
            //    System.Diagnostics.Process process = new System.Diagnostics.Process();
            //    System.Diagnostics.ProcessStartInfo startInfo = new System.Diagnostics.ProcessStartInfo();
            //    startInfo.WindowStyle = System.Diagnostics.ProcessWindowStyle.Hidden;
            //    startInfo.FileName = "cmd.exe";
            //    startInfo.Arguments = "/C copy /b Image1.jpg + Archive.rar Image2.jpg";
            //    process.StartInfo = startInfo;
            //    process.Start();
            //}
            //catch (Exception ex)
            //{
            //    throw ex;
            //}
            return false;
        }

        public List<Job> GetAllJobs(string path)
        {
            try
            {
                var FileContent = this.ReadFileContent(path);
                if (FileContent != null)
                {
                    int count = 1;
                    List<Job> jobs = new List<Job>();
                    foreach (var item in FileContent)
                    {
                        int id = count++;
                        string[] ar = item.Split(';');
                        //extract Filepath
                        string arrElementObj = ar[0];
                        //string filePath = arrElementObj.Substring(arrElementObj.IndexOf(":\\") - 1, arrElementObj.Length - 10);
                        string filePath = arrElementObj.Substring(arrElementObj.IndexOf(":\\") - 1);
                        string jobEndTime = arrElementObj.Substring(0, arrElementObj.IndexOf(":\\") - 2);


                        //extract date and time
                        arrElementObj = ar[1];
                        string[] temp = arrElementObj.Split('-');
                        //DateTime jobDate = Convert.ToDateTime(temp[0] + " " + temp[1]);
                        string jobDate = temp[0];
                        string jobTime = temp[1];

                        //extract time required 
                        string timeRequired = ar[2];

                        //extract percent complete
                        string percentComplete = ar[3];

                        jobs.Add(new Job { Id = id, JobDate = jobDate, JobStartTime = jobTime, JobEndTime = jobEndTime, FilePath = filePath, TimeRequired = timeRequired, PercentComplete = percentComplete });

                    }
                    return jobs;
                }
                else
                {
                    return null;
                }

            }
            catch (Exception)
            {
                throw;
            }

        }

    }
}

