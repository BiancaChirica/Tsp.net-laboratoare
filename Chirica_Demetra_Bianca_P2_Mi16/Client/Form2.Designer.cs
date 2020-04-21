namespace MyPhotosGUI
{
    partial class Form2
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.dTPicker = new System.Windows.Forms.DateTimePicker();
            this.rtDescription = new System.Windows.Forms.RichTextBox();
            this.tbPath = new System.Windows.Forms.TextBox();
            this.f2ok = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.msgLabelf2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(57, 73);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Path :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(57, 134);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Data creare :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(57, 187);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Descriere :";
            // 
            // dTPicker
            // 
            this.dTPicker.Location = new System.Drawing.Point(174, 134);
            this.dTPicker.Name = "dTPicker";
            this.dTPicker.Size = new System.Drawing.Size(229, 20);
            this.dTPicker.TabIndex = 3;
            // 
            // rtDescription
            // 
            this.rtDescription.Location = new System.Drawing.Point(174, 187);
            this.rtDescription.Name = "rtDescription";
            this.rtDescription.Size = new System.Drawing.Size(229, 96);
            this.rtDescription.TabIndex = 4;
            this.rtDescription.Text = "";
            // 
            // tbPath
            // 
            this.tbPath.Enabled = false;
            this.tbPath.Location = new System.Drawing.Point(174, 65);
            this.tbPath.Name = "tbPath";
            this.tbPath.Size = new System.Drawing.Size(229, 20);
            this.tbPath.TabIndex = 5;
            // 
            // f2ok
            // 
            this.f2ok.Location = new System.Drawing.Point(245, 359);
            this.f2ok.Name = "f2ok";
            this.f2ok.Size = new System.Drawing.Size(75, 23);
            this.f2ok.TabIndex = 6;
            this.f2ok.Text = "Ok";
            this.f2ok.UseVisualStyleBackColor = true;
            this.f2ok.Click += new System.EventHandler(this.f2ok_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Enabled = false;
            this.label4.Location = new System.Drawing.Point(232, 23);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(117, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Add a Photo or a Video";
            // 
            // msgLabelf2
            // 
            this.msgLabelf2.AutoSize = true;
            this.msgLabelf2.Location = new System.Drawing.Point(242, 320);
            this.msgLabelf2.Name = "msgLabelf2";
            this.msgLabelf2.Size = new System.Drawing.Size(0, 13);
            this.msgLabelf2.TabIndex = 8;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(495, 450);
            this.Controls.Add(this.msgLabelf2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.f2ok);
            this.Controls.Add(this.tbPath);
            this.Controls.Add(this.rtDescription);
            this.Controls.Add(this.dTPicker);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form2";
            this.Text = "Form2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker dTPicker;
        private System.Windows.Forms.RichTextBox rtDescription;
        private System.Windows.Forms.TextBox tbPath;
        private System.Windows.Forms.Button f2ok;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label msgLabelf2;
    }
}