using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyPhotosGUI
{
    public partial class AddProp : Form
    {
        public String numeProp;
        public String valProp;
        public AddProp(int idP)
        {
            InitializeComponent();
            textBox1.Text = idP.ToString();

        }

        private void Add_Prop_Click(object sender, EventArgs e)
        {
            if (tbNumeProp.Text.Equals("") || tbValoareProp.Text.Equals(""))
            {
                msgLabelAddP.Text = "Please complete the fields.";
                return;
            }
            numeProp = tbNumeProp.Text;
            valProp = tbValoareProp.Text;
            this.Close();
        }
    }
}
