namespace MyPhotosGUI
{
    partial class Form1
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
            this.AddPhoto = new System.Windows.Forms.Button();
            this.DeletePhoto = new System.Windows.Forms.Button();
            this.ShowAllPhotos = new System.Windows.Forms.Button();
            this.dtGridPhotos = new System.Windows.Forms.DataGridView();
            this.toolStripContainer1 = new System.Windows.Forms.ToolStripContainer();
            this.dtGridProp = new System.Windows.Forms.DataGridView();
            this.msgLabel = new System.Windows.Forms.Label();
            this.ofd = new System.Windows.Forms.OpenFileDialog();
            this.Add_Folder = new System.Windows.Forms.Button();
            this.Add_Property = new System.Windows.Forms.Button();
            this.DeleteProperty = new System.Windows.Forms.Button();
            this.Open_File = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.Mark_Deleted = new System.Windows.Forms.Button();
            this.Show_Property = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dtGridPhotos)).BeginInit();
            this.toolStripContainer1.ContentPanel.SuspendLayout();
            this.toolStripContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtGridProp)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // AddPhoto
            // 
            this.AddPhoto.Location = new System.Drawing.Point(12, 70);
            this.AddPhoto.Name = "AddPhoto";
            this.AddPhoto.Size = new System.Drawing.Size(75, 23);
            this.AddPhoto.TabIndex = 0;
            this.AddPhoto.Text = "Add File";
            this.AddPhoto.UseVisualStyleBackColor = true;
            this.AddPhoto.Click += new System.EventHandler(this.AddPhoto_Click);
            // 
            // DeletePhoto
            // 
            this.DeletePhoto.Location = new System.Drawing.Point(12, 158);
            this.DeletePhoto.Name = "DeletePhoto";
            this.DeletePhoto.Size = new System.Drawing.Size(84, 23);
            this.DeletePhoto.TabIndex = 1;
            this.DeletePhoto.Text = "Delete File";
            this.DeletePhoto.UseVisualStyleBackColor = true;
            this.DeletePhoto.Click += new System.EventHandler(this.DeletePhoto_Click);
            // 
            // ShowAllPhotos
            // 
            this.ShowAllPhotos.Location = new System.Drawing.Point(12, 28);
            this.ShowAllPhotos.Name = "ShowAllPhotos";
            this.ShowAllPhotos.Size = new System.Drawing.Size(94, 23);
            this.ShowAllPhotos.TabIndex = 2;
            this.ShowAllPhotos.Text = "Show Photos";
            this.ShowAllPhotos.UseVisualStyleBackColor = true;
            this.ShowAllPhotos.Click += new System.EventHandler(this.ShowAllPhotos_Click);
            // 
            // dtGridPhotos
            // 
            this.dtGridPhotos.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dtGridPhotos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtGridPhotos.Location = new System.Drawing.Point(3, 3);
            this.dtGridPhotos.MultiSelect = false;
            this.dtGridPhotos.Name = "dtGridPhotos";
            this.dtGridPhotos.ReadOnly = true;
            this.dtGridPhotos.Size = new System.Drawing.Size(542, 191);
            this.dtGridPhotos.TabIndex = 3;
            this.dtGridPhotos.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGrid_CellContentClick);
            // 
            // toolStripContainer1
            // 
            // 
            // toolStripContainer1.ContentPanel
            // 
            this.toolStripContainer1.ContentPanel.Controls.Add(this.dtGridPhotos);
            this.toolStripContainer1.ContentPanel.Controls.Add(this.dtGridProp);
            this.toolStripContainer1.ContentPanel.Controls.Add(this.pictureBox1);
            this.toolStripContainer1.ContentPanel.Size = new System.Drawing.Size(548, 387);
            this.toolStripContainer1.Location = new System.Drawing.Point(240, 12);
            this.toolStripContainer1.Name = "toolStripContainer1";
            this.toolStripContainer1.Size = new System.Drawing.Size(548, 412);
            this.toolStripContainer1.TabIndex = 4;
            this.toolStripContainer1.Text = "toolStripContainer1";
            // 
            // dtGridProp
            // 
            this.dtGridProp.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dtGridProp.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtGridProp.Location = new System.Drawing.Point(163, 218);
            this.dtGridProp.MultiSelect = false;
            this.dtGridProp.Name = "dtGridProp";
            this.dtGridProp.ReadOnly = true;
            this.dtGridProp.Size = new System.Drawing.Size(382, 166);
            this.dtGridProp.TabIndex = 4;
            this.dtGridProp.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtGridProp_CellContentClick);
            // 
            // msgLabel
            // 
            this.msgLabel.AutoSize = true;
            this.msgLabel.Location = new System.Drawing.Point(78, 9);
            this.msgLabel.Name = "msgLabel";
            this.msgLabel.Size = new System.Drawing.Size(0, 13);
            this.msgLabel.TabIndex = 5;
            // 
            // ofd
            // 
            this.ofd.FilterIndex = 2;
            this.ofd.InitialDirectory = "C:\\";
            this.ofd.ReadOnlyChecked = true;
            this.ofd.RestoreDirectory = true;
            this.ofd.Title = "Select photo or movie";
            // 
            // Add_Folder
            // 
            this.Add_Folder.Location = new System.Drawing.Point(12, 116);
            this.Add_Folder.Name = "Add_Folder";
            this.Add_Folder.Size = new System.Drawing.Size(75, 23);
            this.Add_Folder.TabIndex = 6;
            this.Add_Folder.Text = "Add Folder";
            this.Add_Folder.UseVisualStyleBackColor = true;
            this.Add_Folder.Click += new System.EventHandler(this.Add_Folder_Click);
            // 
            // Add_Property
            // 
            this.Add_Property.Location = new System.Drawing.Point(126, 70);
            this.Add_Property.Name = "Add_Property";
            this.Add_Property.Size = new System.Drawing.Size(84, 23);
            this.Add_Property.TabIndex = 7;
            this.Add_Property.Text = "Add Property";
            this.Add_Property.UseVisualStyleBackColor = true;
            this.Add_Property.Click += new System.EventHandler(this.Add_Property_Click);
            // 
            // DeleteProperty
            // 
            this.DeleteProperty.Location = new System.Drawing.Point(126, 116);
            this.DeleteProperty.Name = "DeleteProperty";
            this.DeleteProperty.Size = new System.Drawing.Size(108, 23);
            this.DeleteProperty.TabIndex = 8;
            this.DeleteProperty.Text = "Delete Property";
            this.DeleteProperty.UseVisualStyleBackColor = true;
            this.DeleteProperty.Click += new System.EventHandler(this.DeleteProperty_Click);
            // 
            // Open_File
            // 
            this.Open_File.Location = new System.Drawing.Point(12, 197);
            this.Open_File.Name = "Open_File";
            this.Open_File.Size = new System.Drawing.Size(75, 23);
            this.Open_File.TabIndex = 9;
            this.Open_File.Text = "Open File";
            this.Open_File.UseVisualStyleBackColor = true;
            this.Open_File.Click += new System.EventHandler(this.Open_File_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(3, 230);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(154, 142);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 10;
            this.pictureBox1.TabStop = false;
            // 
            // Mark_Deleted
            // 
            this.Mark_Deleted.Location = new System.Drawing.Point(126, 28);
            this.Mark_Deleted.Name = "Mark_Deleted";
            this.Mark_Deleted.Size = new System.Drawing.Size(84, 23);
            this.Mark_Deleted.TabIndex = 11;
            this.Mark_Deleted.Text = "Mark Deleted";
            this.Mark_Deleted.UseVisualStyleBackColor = true;
            this.Mark_Deleted.Click += new System.EventHandler(this.Mark_Deleted_Click);
            // 
            // Show_Property
            // 
            this.Show_Property.Location = new System.Drawing.Point(126, 158);
            this.Show_Property.Name = "Show_Property";
            this.Show_Property.Size = new System.Drawing.Size(84, 23);
            this.Show_Property.TabIndex = 12;
            this.Show_Property.Text = "Show Property";
            this.Show_Property.UseVisualStyleBackColor = true;
            this.Show_Property.Click += new System.EventHandler(this.Show_Property_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Show_Property);
            this.Controls.Add(this.Mark_Deleted);
            this.Controls.Add(this.Open_File);
            this.Controls.Add(this.DeleteProperty);
            this.Controls.Add(this.Add_Property);
            this.Controls.Add(this.Add_Folder);
            this.Controls.Add(this.msgLabel);
            this.Controls.Add(this.toolStripContainer1);
            this.Controls.Add(this.ShowAllPhotos);
            this.Controls.Add(this.DeletePhoto);
            this.Controls.Add(this.AddPhoto);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dtGridPhotos)).EndInit();
            this.toolStripContainer1.ContentPanel.ResumeLayout(false);
            this.toolStripContainer1.ResumeLayout(false);
            this.toolStripContainer1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtGridProp)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button AddPhoto;
        private System.Windows.Forms.Button DeletePhoto;
        private System.Windows.Forms.Button ShowAllPhotos;
        private System.Windows.Forms.DataGridView dtGridPhotos;
        private System.Windows.Forms.ToolStripContainer toolStripContainer1;
        private System.Windows.Forms.DataGridView dtGridProp;
        private System.Windows.Forms.Label msgLabel;
        private System.Windows.Forms.OpenFileDialog ofd;
        private System.Windows.Forms.Button Add_Folder;
        private System.Windows.Forms.Button Add_Property;
        private System.Windows.Forms.Button DeleteProperty;
        private System.Windows.Forms.Button Open_File;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button Mark_Deleted;
        private System.Windows.Forms.Button Show_Property;
    }
}

