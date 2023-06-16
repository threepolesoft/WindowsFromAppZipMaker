using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
using System.IO.Compression;
using Microsoft.VisualBasic;

namespace WindowsFromAppZipMaker
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public string first_folder_name = "";

        private void btnFolderOne_Click(object sender, EventArgs e)
        {

            FolderBrowserDialog fbd = new FolderBrowserDialog();


            if (fbd.ShowDialog()==DialogResult.OK)
            {
                lbFolderOne.Text = fbd.SelectedPath;

                first_folder_name=Path.GetFileName(fbd.SelectedPath);
            }
        }

        public string second_folder_name = "";
       

        private void BtnFolderTwo_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog fbd = new FolderBrowserDialog();

            if (fbd.ShowDialog() == DialogResult.OK)
            {
                lbFolderTwo.Text = fbd.SelectedPath;

                second_folder_name= Path.GetFileName(fbd.SelectedPath);
            }
        }

        private void btnCreateToZip_Click(object sender, EventArgs e)
        {
            try
            {

                if (string.IsNullOrEmpty(lbFolderOne.Text))
                {
                    MessageBox.Show("Message", "Select first folder and try again");
                    return;
                }

                if (string.IsNullOrEmpty(lbFolderTwo.Text))
                {
                    MessageBox.Show("Message", "Select first folder and try again");
                    return;
                }

                lbStatus.Text = "Preparing...";
                lbStatus.Update();


                string folder=Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData);

                string sff = Path.Combine(folder, "ZipTemp"+"\\"+"temp");

                if (new DirectoryInfo(sff).Exists)
                {
                    Directory.Delete(sff, true);
                }

                Directory.CreateDirectory(sff);

                copy(new DirectoryInfo(lbFolderOne.Text), new DirectoryInfo(sff + "\\" + first_folder_name));
                copy(new DirectoryInfo(lbFolderTwo.Text), new DirectoryInfo(sff + "\\" + second_folder_name));


                if (new FileInfo(lbFolderOne.Text + ".zip").Exists)
                {
                    if (MessageBox.Show("Zip output already exixts, want to replace it.", "Message", MessageBoxButtons.YesNo) == DialogResult.Yes)
                    {
                        File.Delete(lbFolderOne.Text + ".zip");
                        lbStatus.Text = "Replaceing...";
                        lbStatus.Update();
                        ZipFile.CreateFromDirectory(sff, lbFolderOne.Text + ".zip");

                        Directory.Delete(sff, true);

                        lbStatus.Text = "Finish";
                        lbStatus.Update();
                    }
                    else
                    {
                        Directory.Delete(sff, true);
                        lbStatus.Text = "Cancel";
                        lbStatus.Update();
                    }
                }
                else
                {
                    ZipFile.CreateFromDirectory(sff, lbFolderOne.Text + ".zip");
                    Directory.Delete(sff, true);
                    lbStatus.Text = "Finish";
                    lbStatus.Update();
                }

                

                //using (FileStream fileStream=new FileStream(lbFolderOne.Text+".zip", FileMode.Open))
                //{
                //    using (ZipArchive zipArchive=new ZipArchive(fileStream, ZipArchiveMode.Update))
                //    {
                //        ZipArchiveEntry zip;
                //        DirectoryInfo directoryInfo = new DirectoryInfo(lbFolderTwo.Text);

                //        FileInfo[] files = directoryInfo.GetFiles();

                //        foreach (var item in files)
                //        {
                //            zip = zipArchive.CreateEntryFromFile(lbFolderTwo.Text + "\\" + item.Name, second_folder_name + "/" + item.Name);
                //        }
                //    }
                //}
            }
            catch (Exception ex)
            {
                lbStatus.Text = ex.Message;
            }
        }

        public void copy(DirectoryInfo source, DirectoryInfo target)
        {
            Directory.CreateDirectory(target.FullName);


            foreach (var item in source.GetFiles())
            {
                item.CopyTo(Path.Combine(target.FullName, item.Name), true);
            }

            foreach (var item in source.GetDirectories())
            {
                DirectoryInfo directoryInfo = target.CreateSubdirectory(item.Name);

                copy(item, directoryInfo);
            }
        }
    }
}
