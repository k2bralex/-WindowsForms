using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.Unicode;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HomeTask_2
{
    public partial class Explorer : Form
    {
        Data newData;
        private string CurrentDirectory { get; set; }
        public Explorer()
        {
            InitializeComponent();
            newData = new Data();
            GetDiskData();
        }


        #region -----ClassMethods-----

        public void GetDiskData()
        {
            listBoxDisk.Items.AddRange(newData.DiskList.ToArray());
        }

        public void GetDirData(Data value)
        {

            foreach (var dir in value.DirList)
            {
                listBoxDirFiles.Items.Add(dir);
            }

            foreach (var file in value.FileList)
            {
                listBoxDirFiles.Items.Add(file);
            }

            DirectoryInfo newCurrDirectoryInfo = new DirectoryInfo(CurrentDirectory);
            if (newCurrDirectoryInfo.Parent != null)
                listBoxDirFiles.Items.Add("...");

        }

        #endregion

        #region -----ListBoxDisks-----

        private void listBoxDisk_SelectedIndexChanged(object sender, EventArgs e)
        {
            listBoxDirFiles.Items.Clear();
            newData.GetDirList(listBoxDisk.SelectedItem.ToString());
            CurrentDirectory = listBoxDisk.SelectedItem.ToString();
            newData.GetFileList(listBoxDisk.SelectedItem.ToString());

            GetDirData(newData);

            textBoxPath.Text = listBoxDisk.SelectedItem.ToString();
        }

        #endregion

        #region -----ListBoxDirectoriesAndFiles-----

        private void listBoxDirFiles_SelectedIndexChanged(object sender, EventArgs e)
        {
            toolStripStatusLabelTotalValue.Text =
                $"Всего элементов: {listBoxDirFiles.Items.Count}";
            toolStripStatusLabelSelected.Text =
                $"Выбран 1 элемент {listBoxDirFiles.SelectedItem.ToString()}";
        }

        private void listBoxDirFiles_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            
            if (listBoxDirFiles.SelectedIndex != -1)
            {
                if (listBoxDirFiles.SelectedItem.ToString() == "...")
                {
                    listBoxDirFiles.Items.Clear();

                    DirectoryInfo newCurrDirectoryInfo = new DirectoryInfo(CurrentDirectory);
                    if (newCurrDirectoryInfo.Parent != null) CurrentDirectory = newCurrDirectoryInfo.Parent.FullName;

                    newData.GetDirList(CurrentDirectory);
                    newData.GetFileList(CurrentDirectory);
                    GetDirData(newData);

                }
                else
                {
                    string pathName = listBoxDirFiles.SelectedItem.GetType().
                        GetProperty("Path")
                        ?.GetValue(listBoxDirFiles.SelectedItem)
                        ?.ToString();

                    if (Directory.Exists(pathName))
                    {
                        DirectoryInfo Dir = new DirectoryInfo(pathName);
                        if (!Dir.Attributes.HasFlag(FileAttributes.Hidden))
                        {
                            listBoxDirFiles.Items.Clear();
                            CurrentDirectory = pathName;
                            newData.GetDirList(pathName);
                            newData.GetFileList(pathName);
                            GetDirData(newData);

                            textBoxPath.Text = pathName;
                        }
                        else
                        {
                            MessageBox.Show("Скрытая папка. Отказано в доступе.");
                        }
                    }

                    if (File.Exists(pathName))
                    {
                        FileInfo file = new FileInfo(pathName);
                        if (!file.Attributes.HasFlag(FileAttributes.Hidden))
                        {
                            textBoxPath.Text = pathName;
                            Process.Start("notepad.exe", textBoxPath.Text);
                        }

                    }
                }
            }
            else
            {
                MessageBox.Show("Выберите каталог или файл из списка.");
            }
            toolStripStatusLabelTotalValue.Text =
                $"Всего элементов: {listBoxDirFiles.Items.Count}";
        }

        #endregion

        #region -----TextBoxPath-----

        private void textBoxPath_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                e.Handled = true;

                DirectoryInfo Dir = new DirectoryInfo(textBoxPath.Text);
                if (!Dir.Attributes.HasFlag(FileAttributes.Hidden))
                {
                    listBoxDirFiles.Items.Clear();

                    newData.GetDirList(textBoxPath.Text);
                    newData.GetFileList(textBoxPath.Text);
                    GetDirData(newData);

                    textBoxPath.Text = textBoxPath.Text;
                }
                else
                {
                    MessageBox.Show("Скрытая папка. Отказано в доступе.");
                }
            }
        }

        #endregion

        #region -----MainMenu-----

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AboutBox1 box = new AboutBox1();
            box.ShowDialog();
        }

        private void toolStripMenuHelp_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Спасение утопающих - дело рук самих утопающих.");
        }

        private void newToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string pathBoof = @$"C:\Temp\";
            string fileBoof = @$"C:\Temp\temp.txt";
            if (!Directory.Exists(pathBoof))
                Directory.CreateDirectory(pathBoof);
            if(!File.Exists(fileBoof))
                File.Create(fileBoof);
            Process.Start("notepad.exe", fileBoof);

        }

        private void openToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            var fOpen = new OpenFileDialog();
            fOpen.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*";
            fOpen.DefaultExt = ".txt";

            if (fOpen.ShowDialog() == DialogResult.Cancel)
            {
                return;
            }

            Process.Start("notepad.exe", fOpen.FileName);

        }

        #endregion

        #region -----NavigationButtons-----

        private void buttonBack_Click(object sender, EventArgs e)
        {
            listBoxDirFiles.Items.Clear();

            DirectoryInfo newCurrDirectoryInfo = new DirectoryInfo(CurrentDirectory);
            if (newCurrDirectoryInfo.Parent != null) CurrentDirectory = newCurrDirectoryInfo.Parent.FullName;

            newData.GetDirList(CurrentDirectory);
            newData.GetFileList(CurrentDirectory);
            GetDirData(newData);

            textBoxPath.Text = CurrentDirectory;
        }
        private void buttonForward_Click(object sender, EventArgs e)
        {
            if (listBoxDirFiles.SelectedIndex != -1)
            {
                string pathName = listBoxDirFiles.SelectedItem.GetType().
                    GetProperty("Path")
                    ?.GetValue(listBoxDirFiles.SelectedItem)
                    ?.ToString();

                if (Directory.Exists(pathName))
                {
                    DirectoryInfo Dir = new DirectoryInfo(pathName);
                    if (!Dir.Attributes.HasFlag(FileAttributes.Hidden))
                    {
                        listBoxDirFiles.Items.Clear();

                        newData.GetDirList(pathName);
                        newData.GetFileList(pathName);
                        GetDirData(newData);

                        textBoxPath.Text = pathName;
                    }
                    else
                    {
                        MessageBox.Show("Скрытая папка. Отказано в доступе.");
                    }
                }

                if (File.Exists(pathName))
                {
                    FileInfo file = new FileInfo(pathName);
                    if (!file.Attributes.HasFlag(FileAttributes.Hidden))
                    {
                        textBoxPath.Text = pathName;
                        Process.Start("notepad.exe", textBoxPath.Text);
                    }

                }

                CurrentDirectory = textBoxPath.Text;
            }
            else
            {
                MessageBox.Show("Выберите каталог или файл из списка.");
            }
        }




        #endregion

        private void newFolderStripButton1_Click(object sender, EventArgs e)
        {

        }

        private void cutToolStripButton_Click(object sender, EventArgs e)
        {

        }

        private void copyToolStripButton_Click(object sender, EventArgs e)
        {

        }

        private void pasteToolStripButton_Click(object sender, EventArgs e)
        {

        }

        private void helpToolStripButton_Click(object sender, EventArgs e)
        {

        }
    }
}
