using System;
using System.Windows.Forms;
using System.IO;
using System.Linq;
using System.Diagnostics;
using System.Collections.Generic;

namespace DealWithFiles
{
    public class FileCRUD
    {
        public static List<FileInfo> tempFiles = new List<FileInfo>();
        
        public event EventHandler myEvent;
        //Create File
        public void FileCreate()
        {

        }
        //Delete File
        public void FileDelete(ListViewItem listViewItem)
        {
            if (
                MessageBox.Show("Vous Voulez Vraiment Supprimer ", "Supprimer", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                File.Delete(listViewItem.Tag.ToString());
            }
        }
        //Update File

        public void FileUpdate(string oldPath, string newPath)
        {
            
            FileInfo F = new FileInfo(oldPath);
            string Path = "";
            string[] Paths = oldPath.Split('\\');
            for (int i = 0; i < Paths.Length - 1; i++)
            {
                Path += Paths[i] + '\\';
            }
            string finalPath = Path + newPath + F.Extension;
            //MessageBox.Show(finalPath);
            F.MoveTo(@"" + finalPath);

        }
        //Read File
        public void FileRead(ListViewItem listViewItem)
        {
            string fileName = listViewItem.Tag.ToString();
            Process.Start(fileName);
        }
        //Get File Infos
        public void FileDetails(ListViewItem listViewItem)
        {
            FileInfo fileInfo = new FileInfo(listViewItem.Tag.ToString());
            string FileDetailsMessage = "";
            FileDetailsMessage += $"Le nom du fichier : {fileInfo.Name}\n";
            FileDetailsMessage += $"Le Chemin : {fileInfo.FullName}\n";
            FileDetailsMessage += $"Date Creation : {fileInfo.CreationTime}\n";
            MessageBox.Show(FileDetailsMessage);

        }
        //File Move 
        public void FileMove(string oldPath,string newPath)
        {
            FileInfo F = new FileInfo(oldPath);
            string fileName = F.Name;
            string destination = @"" + newPath + "\\" + fileName;
            F.MoveTo(destination);
            
        }

        public List<FileInfo> getTempFile(string filename)
        {
            var query = from file in tempFiles
                        where file.Name.Contains(filename)
                        select file;
            return query.ToList();
        }
        public void RemplirListView(List<FileInfo> fileInfos,ListView listView)
        {
            
            if(fileInfos.Count == 0)
            {
                this.myEvent?.Invoke(this, EventArgs.Empty);
            }
            String[] Extensions = { ".doc", ".pdf", ".ppt", ".xls" };
            ListViewItem listViewItem = null;
            
            listView.Items.Clear();
            foreach(var file in fileInfos)
            {   listViewItem = new ListViewItem();
                listViewItem.Tag = file.FullName;
                listViewItem.Text = file.Name;
                if(file.Extension == Extensions[0]) { listViewItem.ImageIndex = 0; }
                if(file.Extension == Extensions[1]) { listViewItem.ImageIndex = 1; }
                if(file.Extension == Extensions[2]) { listViewItem.ImageIndex = 3; }
                if(file.Extension == Extensions[3]) { listViewItem.ImageIndex = 2; }
                listView.Items.Add(listViewItem);
            }
        }
    }
}
