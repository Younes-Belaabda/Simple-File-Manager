using System;
using System.Windows.Forms;
using System.IO;
using FileSystemService;
using DealWithFiles;

namespace FileManagerService
{
    public class FileManager
    {
        private static FileService fileExplorer = new FileService();

        //Fill Tree View With Logical Folders
        public void treeViewFill(TreeView treeView)
        {
            TreeNode treeNode = new TreeNode();
            String[] SpercialFoldersNames = { "Desktop" };
            try
            {
                foreach (String Path in fileExplorer.getSpecialFolders())
                {
                    treeNode = new TreeNode();
                    treeNode.Text = SpercialFoldersNames[0];
                    treeNode.Tag = Path;
                    treeNode.Nodes.Add("");
                    treeView.Nodes.Add(treeNode);
                }
                String[] LogicalPaths = fileExplorer.getAllRootPaths();
                foreach (String Path in LogicalPaths)
                {
                    treeNode = new TreeNode();
                    treeNode.Text = Path;
                    treeNode.Tag = Path;
                    treeNode.Nodes.Add("");
                    treeView.Nodes.Add(treeNode);
                }
            }
            catch (Exception Ex)
            {
                MessageBox.Show(Ex.Message, "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        //Get Subfolders For A Folder
        public void treeViewItemSubFolders(TreeNode treeNode)
        {
            TreeNode treeNode1;
            treeNode.Nodes.RemoveAt(0);
            DirectoryInfo[] directories = fileExplorer.getSubFolders(treeNode.Tag.ToString());

            foreach (DirectoryInfo directoryInfo in directories)
            {
                treeNode1 = new TreeNode();
                treeNode1.Tag = directoryInfo.FullName;
                treeNode1.Text = directoryInfo.Name;
                treeNode1.Nodes.Add("");
                treeNode.Nodes.Add(treeNode1);
            }


        }
        //Fill List View With Files
        public void listViewFill(TreeNode treeNode, ListView listView)
        {
            String[] Extensions = { ".doc", ".pdf", ".ppt", ".xls" };
            ListViewItem listViewItem;
            foreach (FileInfo fileInfo in fileExplorer.getFilesInfos(treeNode.Tag.ToString()))
            {
                if (
                    fileInfo.Extension == Extensions[0] ||
                    fileInfo.Extension == Extensions[1] ||
                    fileInfo.Extension == Extensions[2] ||
                    fileInfo.Extension == Extensions[3])
                {
                    listViewItem = new ListViewItem();
                    listViewItem.Text = fileInfo.Name;
                    listViewItem.Tag = fileInfo.FullName;
                    FileCRUD.tempFiles.Add(fileInfo);
                    switch (fileInfo.Extension)
                    {
                        case ".doc":
                            listViewItem.ImageIndex = 0;
                            break;
                        case ".pdf":
                            listViewItem.ImageIndex = 1;
                            break;
                        case ".xls":
                            listViewItem.ImageIndex = 2;
                            break;
                        case ".ppt":
                            listViewItem.ImageIndex = 3;
                            break;
                    }
                    listView.Items.Add(listViewItem);
                }

            }
        }
        //Get Folder Details 
        public string getFolderInfos(TreeNode treeNode)
        {
            string InfoMessage = "";
            DirectoryInfo directory = new DirectoryInfo(treeNode.Tag.ToString());
            DirectoryInfo[] directories = fileExplorer.getSubFolders(treeNode.Tag.ToString());
            int Count = 0;
            foreach (DirectoryInfo directoryInfo in directories)
            {
                Count++;
            }
            return InfoMessage += $"Ce Dossier Contient {Count} Sous Dossier \nDate Creation : {directory.CreationTime}";
        }

        public void refreshList(string Path, ListView listView)
        {
            
            listView.Items.Clear();
            String[] Extensions = { ".doc", ".pdf", ".ppt", ".xls" };
            ListViewItem listViewItem;
            foreach (FileInfo fileInfo in fileExplorer.getFilesInfos(Path))
            {
                if (
                    fileInfo.Extension == Extensions[0] ||
                    fileInfo.Extension == Extensions[1] ||
                    fileInfo.Extension == Extensions[2] ||
                    fileInfo.Extension == Extensions[3])
                {
                    listViewItem = new ListViewItem();
                    listViewItem.Text = fileInfo.Name;
                    listViewItem.Tag = fileInfo.FullName;
                    switch (fileInfo.Extension)
                    {
                        case ".doc":
                            listViewItem.ImageIndex = 0;
                            break;
                        case ".pdf":
                            listViewItem.ImageIndex = 1;
                            break;
                        case ".xls":
                            listViewItem.ImageIndex = 2;
                            break;
                        case ".ppt":
                            listViewItem.ImageIndex = 3;
                            break;
                    }
                    listView.Items.Add(listViewItem);
                }
            }
        }

       

    }
}
