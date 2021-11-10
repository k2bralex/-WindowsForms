using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Threading;

namespace HomeTask_2
{
    public class MyDirectory
    {
        public string Name { get; set; }
        public string Path { get; set; }

        public override string ToString()
        {
            return Name;
        }
    }

    public class MyFile
    {
        public string Name { get; set; }
        public string Path { get; set; }

        public override string ToString()
        {
            return Name;
        }
    }

    public class Data
    {
        public List<string> DiskList { get; set; } = new List<string>();
        public List<MyDirectory> DirList { get; set; } = new List<MyDirectory>();
        public List<MyFile> FileList { get; set; } = new List<MyFile>();

        public Data()
        {
            GetDiskList();
        }

        public void GetDiskList()
        {
            foreach (var drive in DriveInfo.GetDrives())
            {
                DiskList.Add(drive.Name);
            }
        }

        public void GetDirList(string dirName)
        {
            if (Directory.Exists(dirName))
            {
                DirList.Clear();
                foreach (var dir in Directory.GetDirectories(dirName))
                {
                    DirList.Add(new MyDirectory() {Path = dir, Name = new DirectoryInfo(dir).Name});
                }
            }
        }

        public void GetFileList(string dirName)
        {
            if (Directory.Exists(dirName))
            {
                FileList.Clear();
                foreach (var file in Directory.GetFiles(dirName))
                {
                    FileList.Add(new MyFile() {Path = file, Name = new FileInfo(file).Name});
                }
            }
        }
    }
}
