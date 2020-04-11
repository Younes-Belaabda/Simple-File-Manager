namespace DamanFichiers
{
    partial class mainUI
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(mainUI));
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel7 = new System.Windows.Forms.Panel();
            this.lst_files = new System.Windows.Forms.ListView();
            this.contextFilesMenuStrip = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.MenuItemOpenFile = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuItemRemoveFile = new System.Windows.Forms.ToolStripMenuItem();
            this.copierToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuItemMoveFile = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuItemRenameFile = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuItemDetailsFile = new System.Windows.Forms.ToolStripMenuItem();
            this.Extension_ic = new System.Windows.Forms.ImageList(this.components);
            this.panel3 = new System.Windows.Forms.Panel();
            this.lbl_details = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.viewFolders = new System.Windows.Forms.TreeView();
            this.contextFoldersStrip = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.btn_reset_folders = new System.Windows.Forms.ToolStripMenuItem();
            this.Folder_ic = new System.Windows.Forms.ImageList(this.components);
            this.panel2.SuspendLayout();
            this.panel7.SuspendLayout();
            this.contextFilesMenuStrip.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel4.SuspendLayout();
            this.contextFoldersStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel2.Controls.Add(this.panel7);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(300, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(884, 575);
            this.panel2.TabIndex = 1;
            // 
            // panel7
            // 
            this.panel7.BackColor = System.Drawing.SystemColors.Control;
            this.panel7.Controls.Add(this.lst_files);
            this.panel7.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel7.Location = new System.Drawing.Point(0, 0);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(884, 575);
            this.panel7.TabIndex = 2;
            // 
            // lst_files
            // 
            this.lst_files.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.lst_files.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lst_files.ContextMenuStrip = this.contextFilesMenuStrip;
            this.lst_files.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lst_files.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lst_files.HideSelection = false;
            this.lst_files.LargeImageList = this.Extension_ic;
            this.lst_files.Location = new System.Drawing.Point(0, 0);
            this.lst_files.Margin = new System.Windows.Forms.Padding(100, 3, 3, 3);
            this.lst_files.Name = "lst_files";
            this.lst_files.Size = new System.Drawing.Size(884, 575);
            this.lst_files.SmallImageList = this.Extension_ic;
            this.lst_files.TabIndex = 0;
            this.lst_files.UseCompatibleStateImageBehavior = false;
            // 
            // contextFilesMenuStrip
            // 
            this.contextFilesMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MenuItemOpenFile,
            this.MenuItemRemoveFile,
            this.copierToolStripMenuItem,
            this.MenuItemMoveFile,
            this.MenuItemRenameFile,
            this.MenuItemDetailsFile});
            this.contextFilesMenuStrip.Name = "contextFilesMenuStrip";
            this.contextFilesMenuStrip.Size = new System.Drawing.Size(181, 158);
            // 
            // MenuItemOpenFile
            // 
            this.MenuItemOpenFile.Name = "MenuItemOpenFile";
            this.MenuItemOpenFile.Size = new System.Drawing.Size(180, 22);
            this.MenuItemOpenFile.Text = "Ouvrir";
            this.MenuItemOpenFile.Click += new System.EventHandler(this.MenuItemOpenFile_Click);
            // 
            // MenuItemRemoveFile
            // 
            this.MenuItemRemoveFile.Name = "MenuItemRemoveFile";
            this.MenuItemRemoveFile.Size = new System.Drawing.Size(180, 22);
            this.MenuItemRemoveFile.Text = "Supprimer";
            this.MenuItemRemoveFile.Click += new System.EventHandler(this.MenuItemRemoveFile_Click);
            // 
            // copierToolStripMenuItem
            // 
            this.copierToolStripMenuItem.Name = "copierToolStripMenuItem";
            this.copierToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.copierToolStripMenuItem.Text = "Copier";
            // 
            // MenuItemMoveFile
            // 
            this.MenuItemMoveFile.Name = "MenuItemMoveFile";
            this.MenuItemMoveFile.Size = new System.Drawing.Size(180, 22);
            this.MenuItemMoveFile.Text = "Deplacer";
            this.MenuItemMoveFile.Click += new System.EventHandler(this.MenuItemMoveFile_Click);
            // 
            // MenuItemRenameFile
            // 
            this.MenuItemRenameFile.Name = "MenuItemRenameFile";
            this.MenuItemRenameFile.Size = new System.Drawing.Size(180, 22);
            this.MenuItemRenameFile.Text = "Renommer";
            this.MenuItemRenameFile.Click += new System.EventHandler(this.MenuItemRenameFile_Click);
            // 
            // MenuItemDetailsFile
            // 
            this.MenuItemDetailsFile.Name = "MenuItemDetailsFile";
            this.MenuItemDetailsFile.Size = new System.Drawing.Size(180, 22);
            this.MenuItemDetailsFile.Text = "Details";
            this.MenuItemDetailsFile.Click += new System.EventHandler(this.MenuItemDetailsFile_Click);
            // 
            // Extension_ic
            // 
            this.Extension_ic.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("Extension_ic.ImageStream")));
            this.Extension_ic.TransparentColor = System.Drawing.Color.Transparent;
            this.Extension_ic.Images.SetKeyName(0, "doc.png");
            this.Extension_ic.Images.SetKeyName(1, "pdf.png");
            this.Extension_ic.Images.SetKeyName(2, "xls.png");
            this.Extension_ic.Images.SetKeyName(3, "ppt.png");
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.lbl_details);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel3.Location = new System.Drawing.Point(0, 529);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(300, 46);
            this.panel3.TabIndex = 0;
            // 
            // lbl_details
            // 
            this.lbl_details.AutoSize = true;
            this.lbl_details.Location = new System.Drawing.Point(12, 10);
            this.lbl_details.Name = "lbl_details";
            this.lbl_details.Size = new System.Drawing.Size(16, 13);
            this.lbl_details.TabIndex = 1;
            this.lbl_details.Text = "...";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.panel4);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(300, 575);
            this.panel1.TabIndex = 0;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.panel4.Controls.Add(this.viewFolders);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel4.Location = new System.Drawing.Point(0, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(300, 529);
            this.panel4.TabIndex = 1;
            // 
            // viewFolders
            // 
            this.viewFolders.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.viewFolders.ContextMenuStrip = this.contextFoldersStrip;
            this.viewFolders.Dock = System.Windows.Forms.DockStyle.Fill;
            this.viewFolders.ImageIndex = 0;
            this.viewFolders.ImageList = this.Folder_ic;
            this.viewFolders.Location = new System.Drawing.Point(0, 0);
            this.viewFolders.Name = "viewFolders";
            this.viewFolders.SelectedImageIndex = 0;
            this.viewFolders.Size = new System.Drawing.Size(300, 529);
            this.viewFolders.TabIndex = 0;
            this.viewFolders.BeforeCollapse += new System.Windows.Forms.TreeViewCancelEventHandler(this.viewFoldersBeforeCollapse);
            this.viewFolders.BeforeExpand += new System.Windows.Forms.TreeViewCancelEventHandler(this.viewFoldersBeforeExpand);
            // 
            // contextFoldersStrip
            // 
            this.contextFoldersStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btn_reset_folders});
            this.contextFoldersStrip.Name = "contextFilesMenuStrip";
            this.contextFoldersStrip.Size = new System.Drawing.Size(103, 26);
            // 
            // btn_reset_folders
            // 
            this.btn_reset_folders.Image = ((System.Drawing.Image)(resources.GetObject("btn_reset_folders.Image")));
            this.btn_reset_folders.Name = "btn_reset_folders";
            this.btn_reset_folders.Size = new System.Drawing.Size(102, 22);
            this.btn_reset_folders.Text = "Reset";
            this.btn_reset_folders.Click += new System.EventHandler(this.btn_reset_folders_Click);
            // 
            // Folder_ic
            // 
            this.Folder_ic.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("Folder_ic.ImageStream")));
            this.Folder_ic.TransparentColor = System.Drawing.Color.Transparent;
            this.Folder_ic.Images.SetKeyName(0, "folder_closed.png");
            this.Folder_ic.Images.SetKeyName(1, "folder_opened.png");
            // 
            // mainUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(1184, 575);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "mainUI";
            this.Text = "Daman Fichiers";
            this.Load += new System.EventHandler(this.mainUI_Load);
            this.panel2.ResumeLayout(false);
            this.panel7.ResumeLayout(false);
            this.contextFilesMenuStrip.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.contextFoldersStrip.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.TreeView viewFolders;
        private System.Windows.Forms.Label lbl_details;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.ListView lst_files;
        private System.Windows.Forms.ContextMenuStrip contextFilesMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem MenuItemOpenFile;
        private System.Windows.Forms.ToolStripMenuItem MenuItemRemoveFile;
        private System.Windows.Forms.ToolStripMenuItem copierToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem MenuItemMoveFile;
        private System.Windows.Forms.ToolStripMenuItem MenuItemRenameFile;
        private System.Windows.Forms.ContextMenuStrip contextFoldersStrip;
        private System.Windows.Forms.ToolStripMenuItem btn_reset_folders;
        private System.Windows.Forms.ToolStripMenuItem MenuItemDetailsFile;
        private System.Windows.Forms.ImageList Extension_ic;
        private System.Windows.Forms.ImageList Folder_ic;
    }
}

