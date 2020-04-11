namespace Gerer_Vos_Fichiers.FileControls
{
    partial class RenameFileControl
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.txt_rename_file = new System.Windows.Forms.TextBox();
            this.btn_rename_file = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txt_rename_file
            // 
            this.txt_rename_file.Location = new System.Drawing.Point(11, 13);
            this.txt_rename_file.Name = "txt_rename_file";
            this.txt_rename_file.Size = new System.Drawing.Size(225, 20);
            this.txt_rename_file.TabIndex = 0;
            // 
            // btn_rename_file
            // 
            this.btn_rename_file.Location = new System.Drawing.Point(241, 11);
            this.btn_rename_file.Name = "btn_rename_file";
            this.btn_rename_file.Size = new System.Drawing.Size(178, 23);
            this.btn_rename_file.TabIndex = 1;
            this.btn_rename_file.Text = "Rename";
            this.btn_rename_file.UseVisualStyleBackColor = true;
            this.btn_rename_file.Click += new System.EventHandler(this.btn_rename_file_Click);
            // 
            // RenameFileControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btn_rename_file);
            this.Controls.Add(this.txt_rename_file);
            this.Name = "RenameFileControl";
            this.Size = new System.Drawing.Size(435, 45);
            this.Load += new System.EventHandler(this.RenameFileControl_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txt_rename_file;
        private System.Windows.Forms.Button btn_rename_file;
    }
}
