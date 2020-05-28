using System;
using System.Windows.Forms;

namespace MyPhotosGUI
{
    public partial class Form2 : Form
    {
        public String path;
        public DateTime date;
        public String description;

        public Form2(String path)
        {
            InitializeComponent();
            tbPath.Text = path;

        }

        private void  f2ok_Click(object sender, EventArgs e)
        {
            msgLabelf2.Text = "";
            // validate
            if (tbPath.Text == null || rtDescription.Text.Equals(""))
            {
                msgLabelf2.Text = "Please write description.";
            }
            else
            {
                path = tbPath.Text;
                date = dTPicker.Value;
                description = rtDescription.Text;
                this.Close();
            }

        }
    }
}
