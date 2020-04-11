using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DamanFichiers;
using DealWithFiles;
using FileManagerService;


namespace Gerer_Vos_Fichiers.FileControls
{
    public partial class RenameFileControl : UserControl
    {
        public string fileName;
        private static string newName;
        public RenameFileControl()
        {
            InitializeComponent();
        }

        private void RenameFileControl_Load(object sender, EventArgs e)
        {

        }
       
        private void btn_rename_file_Click(object sender, EventArgs e)
        {
            FileCRUD F = new FileCRUD();
            newName = txt_rename_file.Text;
            
            F.FileUpdate(fileName, newName);
            FileManager File = new FileManager();
            File.refreshList(mainUI.CurrentPath, mainUI.lst);
            
            this.Hide();
        }
    }
}
