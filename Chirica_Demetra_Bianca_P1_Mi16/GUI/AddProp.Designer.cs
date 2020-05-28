namespace MyPhotosGUI
{
    partial class AddProp
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
            this.tbNumeProp = new System.Windows.Forms.TextBox();
            this.tbValoareProp = new System.Windows.Forms.TextBox();
            this.Add_Prop = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.msgLabelAddP = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(43, 75);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(95, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nume Proprietate :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(43, 134);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(97, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Valoare Proprietate";
            // 
            // tbNumeProp
            // 
            this.tbNumeProp.Location = new System.Drawing.Point(175, 72);
            this.tbNumeProp.Name = "tbNumeProp";
            this.tbNumeProp.Size = new System.Drawing.Size(100, 20);
            this.tbNumeProp.TabIndex = 2;
            // 
            // tbValoareProp
            // 
            this.tbValoareProp.Location = new System.Drawing.Point(175, 127);
            this.tbValoareProp.Name = "tbValoareProp";
            this.tbValoareProp.Size = new System.Drawing.Size(100, 20);
            this.tbValoareProp.TabIndex = 3;
            // 
            // Add_Prop
            // 
            this.Add_Prop.Location = new System.Drawing.Point(123, 192);
            this.Add_Prop.Name = "Add_Prop";
            this.Add_Prop.Size = new System.Drawing.Size(75, 23);
            this.Add_Prop.TabIndex = 4;
            this.Add_Prop.Text = "Add";
            this.Add_Prop.UseVisualStyleBackColor = true;
            this.Add_Prop.Click += new System.EventHandler(this.Add_Prop_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(43, 28);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(50, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Photo Id:";
            // 
            // textBox1
            // 
            this.textBox1.Enabled = false;
            this.textBox1.Location = new System.Drawing.Point(175, 25);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 6;
            // 
            // msgLabelAddP
            // 
            this.msgLabelAddP.AutoSize = true;
            this.msgLabelAddP.Location = new System.Drawing.Point(147, 235);
            this.msgLabelAddP.Name = "msgLabelAddP";
            this.msgLabelAddP.Size = new System.Drawing.Size(0, 13);
            this.msgLabelAddP.TabIndex = 7;
            // 
            // AddProp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(345, 273);
            this.Controls.Add(this.msgLabelAddP);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.Add_Prop);
            this.Controls.Add(this.tbValoareProp);
            this.Controls.Add(this.tbNumeProp);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "AddProp";
            this.Text = "AddProp";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbNumeProp;
        private System.Windows.Forms.TextBox tbValoareProp;
        private System.Windows.Forms.Button Add_Prop;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label msgLabelAddP;
    }
}