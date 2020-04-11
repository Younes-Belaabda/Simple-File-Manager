using System;
using System.Windows.Forms;
using System.IO;
using System.Diagnostics;
namespace DealWithFiles
{
    public class FileCRUD
    {
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
    }
}
