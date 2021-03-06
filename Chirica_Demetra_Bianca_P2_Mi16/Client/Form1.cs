﻿using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Windows.Forms;
using MyPhotos;

namespace MyPhotosGUI
{
    public partial class Form1 : Form
    {
        private int SelectedPhotoid;
        private String SelectedPhotoPath;

        private String pathProp;
        private string numeProp;
        private string valProp;

        private int idPropSelected;

        PhotoPropertyClient pc = new PhotoPropertyClient();


        public Form1()
        {
            SelectedPhotoid = -1;
            idPropSelected = -1;

            InitializeComponent();
            msgLabel.Text = "";
            InitializeDataGridPhoto();
            InitializeDataGridProprietati();
            ShowAllPhotos_Click(this, null);
        }

        private void AddPhoto_Click(object sender, EventArgs e)
        {
            msgLabel.Text = "";
            String path = null;

            // filtreaza imaginile
            var codecs = ImageCodecInfo.GetImageEncoders();
            var codecFilter = "Image Files|";
            foreach (var codec in codecs)
            {
                codecFilter += codec.FilenameExtension + ";";
            }

            // and video
            ofd.Filter = codecFilter + "| All Media Files|*.wav;*.aac;*.wma;*.wmv;*.avi;*.mpg;*.mpeg;*.m1v;*.mp2;*.mp3;*.mpa;*.mpe;*.m3u;*.mp4;*.mov;*.3g2;*.3gp2;*.3gp;*.3gpp;*.m4a;*.cda;*.aif;*.aifc;*.aiff;*.mid;*.midi;*.rmi;*.mkv;*.WAV;*.AAC;*.WMA;*.WMV;*.AVI;*.MPG;*.MPEG;*.M1V;*.MP2;*.MP3;*.MPA;*.MPE;*.M3U;*.MP4;*.MOV;*.3G2;*.3GP2;*.3GP;*.3GPP;*.M4A;*.CDA;*.AIF;*.AIFC;*.AIFF;*.MID;*.MIDI;*.RMI;*.MKV";


            if (ofd.ShowDialog() == DialogResult.OK)
            {
                path = ofd.FileName;
            }
            if (path == null)
            {
                msgLabel.Text = "Please select file.";
                return;
            }

            Save_Photo(path);
            ShowAllPhotos_Click(sender, e);
        }

        private int Save_Photo(String path)
        {
            Form2 f2 = new Form2(path);
            f2.ShowDialog(); // Shows Form2

            if (f2.path == null || f2.date == null || f2.description.Equals(""))
            {
                msgLabel.Text = "Add photo cancelled.";
                return -1;
            }

            var rezultat = pc.AddPhotoWCF(f2.path, f2.date, f2.description);
            msgLabel.Text = rezultat;

            return 1;
        }

        private void Add_Folder_Click(object sender, EventArgs e)
        {

            msgLabel.Text = "";

            using (var fbd = new FolderBrowserDialog())
            {
                DialogResult result = fbd.ShowDialog();

                if (result == DialogResult.OK && !string.IsNullOrWhiteSpace(fbd.SelectedPath))
                {
                    string[] files = Directory.GetFiles(fbd.SelectedPath);

                    foreach (String f in files)
                    {
                        if (Save_Photo(f) == -1)
                            break;
                    }
                    ShowAllPhotos_Click(sender, e);

                }
            }

        }


        private void DeletePhoto_Click(object sender, EventArgs e)
        {
            msgLabel.Text = "";
            if (SelectedPhotoid == -1)
            {
                msgLabel.Text = "Please select a photo to delete.";
                return;
            }

            var p = pc.GetPhotosByIdWCF(SelectedPhotoid);
            if (p.Deleted == false)
            {
                msgLabel.Text = "Photot not marked";
                return;
            }
            var result = pc.DeletePhotoWCF(SelectedPhotoid);
            SelectedPhotoid = -1;
            SelectedPhotoPath = null;
            //write label result
            msgLabel.Text = result;

            ShowAllPhotos_Click(sender, e);
            Show_Property_Click(this, null);
        }

        private void ShowAllPhotos_Click(object sender, EventArgs e)
        {
            //   msgLabel.Text = "";
            var photoList = pc.GetAllPhotosWCF();

            string[] row = new string[10];
            dtGridPhotos.Rows.Clear();
            foreach (Photo p in photoList)
            {
                row[0] = p.Path;
                string[] directories = p.Path.Split(Path.DirectorySeparatorChar);
                row[1] = directories[directories.Length - 1];
                row[2] = p.Data_creare.ToString();
                row[3] = p.Descriere;
                if ( pc.GetProprietatiByIdWCF(p.PhotoId).Length > 0)
                    row[4] = "true";
                else
                {
                    row[4] = "false";
                }
                row[5] = p.Deleted.ToString();
                row[6] = p.PhotoId.ToString();

                dtGridPhotos.Rows.Add(row);
            }

        }

        // get id from selected row
        private void dataGrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex > -1)
            {
                string id = this.dtGridPhotos[6, e.RowIndex].Value.ToString();

                try
                {
                    int result = Int32.Parse(id);
                    SelectedPhotoid = result;
                    Show_Property_Click(null,null);
                }
                catch (FormatException)
                {
                    Console.WriteLine($"Unable to parse '{id}'");
                }

            }
        }

        //initializare tabel 1
        private void InitializeDataGridPhoto()
        {
            dtGridPhotos.ColumnCount = 7;

            dtGridPhotos.ColumnHeadersDefaultCellStyle.BackColor = Color.Navy;
            dtGridPhotos.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;

            dtGridPhotos.Name = "Photos & Videos";

            dtGridPhotos.GridColor = Color.Black;
            dtGridPhotos.RowHeadersVisible = false;

            dtGridPhotos.Columns[0].Name = "Path";
            dtGridPhotos.Columns[1].Name = "Name";
            dtGridPhotos.Columns[2].Name = "Data creare";
            dtGridPhotos.Columns[3].Name = "Descriere";
            dtGridPhotos.Columns[4].Name = "Alte Proprietati";
            dtGridPhotos.Columns[5].Name = "Mark to delete";
            dtGridPhotos.Columns[6].Name = "Id";

            dtGridPhotos.SelectionMode =
                    DataGridViewSelectionMode.FullRowSelect;
            dtGridPhotos.MultiSelect = false;
        }

        //initializare tabel 2
        private void InitializeDataGridProprietati()
        {
            dtGridProp.ColumnCount = 5;

            dtGridProp.ColumnHeadersDefaultCellStyle.BackColor = Color.Navy;
            dtGridProp.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;

            dtGridProp.Name = "Proprietati";

            dtGridProp.GridColor = Color.Black;
            dtGridProp.RowHeadersVisible = false;

            dtGridProp.Columns[0].Name = "Path";
            dtGridProp.Columns[1].Name = "Name";
            dtGridProp.Columns[2].Name = "Nume Propriete";
            dtGridProp.Columns[3].Name = "Valoare";
            dtGridProp.Columns[4].Name = "IdProp";

            dtGridProp.SelectionMode =
                    DataGridViewSelectionMode.FullRowSelect;
            dtGridProp.MultiSelect = false;

        }


        private void Add_Property_Click(object sender, EventArgs e)
        {

            msgLabel.Text = "";
            if (SelectedPhotoid == -1)
            {
                msgLabel.Text = "Please select a photo to add property to.";
                return;
            }

            AddProp addP = new AddProp(SelectedPhotoid);
            addP.ShowDialog();

            if (addP.numeProp == null || addP.valProp == null)
            {
                msgLabel.Text = "Somthing went wrong.";
                return;
            }

            string result = pc.AddProprietateWCF(SelectedPhotoid, addP.numeProp, addP.valProp);
            msgLabel.Text = result;
            ShowAllPhotos_Click(this, null);
            Show_Property_Click(this, null);

        }

        private void Open_File_Click(object sender, EventArgs e)
        {

            msgLabel.Text = "";
            if (SelectedPhotoid < 1)
            {
                msgLabel.Text = "Please select a photo to open.";
                return;
            }
            var photoTemp = pc.GetPhotosByIdWCF(SelectedPhotoid);
            if (!File.Exists(photoTemp.Path))
            {
                msgLabel.Text = "Path not valid.Marked deleted";
                pc.MarkDeletedWCF(SelectedPhotoid);
                return;
            }

            var ph = pc.GetPhotosByIdWCF(SelectedPhotoid);
            var extension = Path.GetExtension(ph.Path);
            var videoExtensions = "| All Media Files|*.wav;*.aac;*.wma;*.wmv;*.avi;*.mpg;*.mpeg;*.m1v;*.mp2;*.mp3;*.mpa;*.mpe;*.m3u;*.mp4;*.mov;*.3g2;*.3gp2;*.3gp;*.3gpp;*.m4a;*.cda;*.aif;*.aifc;*.aiff;*.mid;*.midi;*.rmi;*.mkv;*.WAV;*.AAC;*.WMA;*.WMV;*.AVI;*.MPG;*.MPEG;*.M1V;*.MP2;*.MP3;*.MPA;*.MPE;*.M3U;*.MP4;*.MOV;*.3G2;*.3GP2;*.3GP;*.3GPP;*.M4A;*.CDA;*.AIF;*.AIFC;*.AIFF;*.MID;*.MIDI;*.RMI;*.MKV";
            if (videoExtensions.Contains(extension))
            {
                PlayForm pf = new PlayForm(ph.Path);
                pf.ShowDialog();
            }
            else
            //img
            pictureBox1.Image = new Bitmap(ph.Path);

        }

        private void Mark_Deleted_Click(object sender, EventArgs e)
        {
            msgLabel.Text = "";
            if (SelectedPhotoid == -1)
            {
                msgLabel.Text = "Please select a photo to mark deleted.";
                return;
            }
            var result = pc.MarkDeletedWCF(SelectedPhotoid);
            this.ShowAllPhotos_Click(this, null);
            msgLabel.Text = result;


        }

        private void Show_Property_Click(object sender, EventArgs e)
        {
            if (SelectedPhotoid == -1)
            {
                msgLabel.Text = "Please select a photo.";
                return;
            }
            var propList = pc.GetProprietatiByIdWCF(SelectedPhotoid);

            string[] row = new string[10];
            dtGridProp.Rows.Clear();
            foreach (Proprietate p in propList)
            {
                var ph = pc.GetPhotosByIdWCF(SelectedPhotoid);
                row[0] = ph.Path;
                string[] directories = ph.Path.Split(Path.DirectorySeparatorChar);
                row[1] = directories[directories.Length - 1];
                row[2] = p.NumeProprietate;
                row[3] = p.ValoareProprietate;
                row[4] = p.ProprietateId.ToString();

                dtGridProp.Rows.Add(row);
            }

        }

        private void DeleteProperty_Click(object sender, EventArgs e)
        {

            if (idPropSelected == -1)
            {
                msgLabel.Text = "Please select a property.";
                return;
            }

            var rez = pc.DeleteProprietateWCF(idPropSelected);
            msgLabel.Text = rez;
            ShowAllPhotos_Click(this, null);
            Show_Property_Click(null, null);
            idPropSelected = -1;
        }

        private void dtGridProp_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex > -1)
            {
               string idPropSelectedTemp = this.dtGridProp[4, e.RowIndex].Value.ToString().Trim();
                 numeProp = this.dtGridProp[2, e.RowIndex].Value.ToString().Trim();
                 valProp = this.dtGridProp[3, e.RowIndex].Value.ToString().Trim();

                Console.WriteLine(idPropSelectedTemp);

                try
                {
                    int result = Int32.Parse(idPropSelectedTemp);
                    idPropSelected = result;
                }
                catch (FormatException)
                {
                    Console.WriteLine($"Unable to parse '{idPropSelectedTemp}'");
                }

            }
        }

        private void Edit_Prop_Click(object sender, EventArgs e)
        {
            msgLabel.Text = "";
            if (idPropSelected  == -1)
            {
                msgLabel.Text = "Please select a property to edit.";
                return;
            }

            EditProp editP = new EditProp(idPropSelected, numeProp, valProp);
            editP.ShowDialog();

            if (editP.numeProp == null || editP.valProp == null)
            {
                msgLabel.Text = "Somthing went wrong.";
                return;
            }

            string result = pc.EditProprietateWCF(idPropSelected, editP.numeProp, editP.valProp);
            msgLabel.Text = result;
            ShowAllPhotos_Click(this, null);
            Show_Property_Click(this, null);
        }
    }
}
