#region [namespaces]
using System;
using System.Windows.Forms;
using System.IO;
using System.Drawing;
using FileManagerService;
using DealWithFiles;
using Gerer_Vos_Fichiers.FileControls;


#endregion

namespace DamanFichiers
{
    public partial class mainUI : Form
    {
        public static string CurrentPath = "";
        public static ListView lst;
        private static FileManager fileManager = new FileManager();
        private static FileCRUD fileCrud = new FileCRUD();
        #region Program Intialize
        public mainUI(){InitializeComponent();}        
        private void mainUI_Load(object sender, EventArgs e)
        {
            lst = lst_files;
            fileManager.treeViewFill(viewFolders);
            lbl_details.Text =  fileManager.getFolderInfos(viewFolders.Nodes[0]);
        }
        #endregion
        #region Deal With List View
        private void MenuItemRemoveFile_Click(object sender, EventArgs e)
        {
            fileCrud.FileDelete(lst_files.SelectedItems[0]);
            fileManager.refreshList(CurrentPath, lst);
        }
        private void btn_reset_folders_Click(object sender, EventArgs e)
        {
            foreach (TreeNode tr in viewFolders.Nodes)
            {
                if (tr.IsExpanded)
                {
                    tr.Collapse();
                }
            }
        }

        #endregion
        #region Deal With Tree View
        private void viewFoldersBeforeExpand(object sender, TreeViewCancelEventArgs e)
        {
            
            lst_files.Items.Clear();
            fileManager.listViewFill(e.Node, lst_files);
            fileManager.treeViewItemSubFolders(e.Node);
            e.Node.ImageIndex = 1;
            lbl_details.Text = fileManager.getFolderInfos(e.Node);
            CurrentPath =  e.Node.Tag.ToString();
            
        }
        private void viewFoldersBeforeCollapse(object sender, TreeViewCancelEventArgs e)
        {
            e.Node.Nodes.Clear();
            e.Node.Nodes.Add("");
            e.Node.ImageIndex = 0;
        }
        #endregion

        private void MenuItemDetailsFile_Click(object sender, EventArgs e)
        {
            fileCrud.FileDetails(lst_files.SelectedItems[0]);
        }

        private void MenuItemRenameFile_Click(object sender, EventArgs e)
        {
            string fileName = lst_files.SelectedItems[0].Tag.ToString();
            RenameFileControl renameFileControl = new RenameFileControl();
            this.Controls.Add(renameFileControl);
            renameFileControl.BringToFront();
            renameFileControl.fileName = fileName;
            
            int FormHeight = this.Height;
            int FormWidth = this.Width;

            renameFileControl.Location = new Point(
                (FormWidth / 2) - (renameFileControl.Width / 2)
                , (FormHeight / 2) - (renameFileControl.Height / 2));
            foreach (TreeNode tr in viewFolders.Nodes)
            {
                if (tr.IsExpanded)
                {
                    tr.Collapse();
                }
            }
            

            

        }

        private void MenuItemOpenFile_Click(object sender, EventArgs e)
        {
            ListViewItem listViewItem = lst_files.SelectedItems[0];
            fileCrud.FileRead(listViewItem);
           
        }

        private void MenuItemMoveFile_Click(object sender, EventArgs e)
        {
            string fileName = lst_files.SelectedItems[0].Tag.ToString();
            FolderBrowserDialog F = new FolderBrowserDialog();
            if(F.ShowDialog() == DialogResult.OK)
            {

                fileCrud.FileMove(fileName,F.SelectedPath);
                
            }
            fileManager.refreshList(CurrentPath, lst);
            foreach (TreeNode tr in viewFolders.Nodes)
            {
                if (tr.IsExpanded)
                {
                    tr.Collapse();
                }
            }
        }
    }
}
