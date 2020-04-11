using System;
using System.IO;
using System.Collections.Generic;
using System.Windows.Forms;

namespace FileSystemService
{
    public class FileService
    {
        //Get All Root Folders
        public String[] getAllRootPaths()
        {
            return Directory.GetLogicalDrives();
        }
        //Get Special Folders Like [Desktop - Documents ... ]
        public List<String> getSpecialFolders()
        {
            List<String> specialFolders = new List<string>();
            specialFolders.Add(Environment.GetFolderPath(Environment.SpecialFolder.Desktop));
            return specialFolders;
        }
        //Get SubFolders For A Specific Path
        public DirectoryInfo[] getSubFolders(string Path)
        {
            try
            {
                DirectoryInfo directory = new DirectoryInfo(Path);
                return directory.GetDirectories();
            }
            catch (Exception Ex){}
            return new DirectoryInfo[] { };
        }
        //Get All Files From A Directory
        public  FileInfo[] getFilesInfos(string Path)
        {
            try
            {
                DirectoryInfo directory = new DirectoryInfo(Path);
                return directory.GetFiles();
            }
            catch(UnauthorizedAccessException Ex)
            {
                MessageBox.Show("You Don't Have Access To This File", "Access Denied", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            catch(Exception Ex) { }
                return new FileInfo[] { };
        }
    }
}
