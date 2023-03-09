using System;
using System.Windows.Forms;

namespace PBU
{
    public partial class Help : Form
    {
        public Help()
        {
            InitializeComponent();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("mailto:jbancroft@live.co.uk");
        }

        private void Help_Load(object sender, EventArgs e)
        {

        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("https://github.com/tjscience/RoboSharp");
        }
    }
}
