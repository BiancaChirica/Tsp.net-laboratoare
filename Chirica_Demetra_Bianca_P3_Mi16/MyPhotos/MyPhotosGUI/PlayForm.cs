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
    public partial class PlayForm : Form
    {
        public PlayForm(String path)
        {
            InitializeComponent();
            axWindowsMediaPlayer1.URL = path;
            axWindowsMediaPlayer1.Ctlcontrols.play();
            this.FormClosing += PlayForm_Closing;
        }

        private void PlayForm_Closing(object sender, CancelEventArgs e)
        {
            axWindowsMediaPlayer1.Ctlcontrols.stop();
        }
    }
}
