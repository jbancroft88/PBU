using System;
using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace PBU
{
    public partial class MainGUI : Form
    {

        // Control Menu Bar Movement
        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;

        [DllImportAttribute("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [DllImportAttribute("user32.dll")]
        public static extern bool ReleaseCapture();

        public MainGUI()
        {
            InitializeComponent();
            customiseDesign();
        }


        // Sub Menu Interaction Classes
        private void customiseDesign()
        {
            panelBSub.Visible = false;
        }
        private void hideSubMenu(Panel subMenu)
        {
            if (subMenu.Visible == true)
                subMenu.Visible = false;

        }
        private void showSubMenu(Panel subMenu)
        {
            if (subMenu.Visible == false)
            {
                subMenu.Visible = true;
            }
            else
                subMenu.Visible = false;

        }

        // Buttons

        private void buttonA_Click(object sender, EventArgs e)
        {
            // Post Build Tasks
            hideSubMenu(panelBSub);
            //FormWindowLoad(new PostBuildTasks());   //UNDERCONSTRUCTION, WILL ROUTE TO LDCNET FORM FOR NOW
            FormWindowLoad(new LDCNET());
        }

        private void buttonB_Click(object sender, EventArgs e)
        {
            // LDC Sub Menu
            showSubMenu(panelBSub);
        }

        private void buttonB1_Click(object sender, EventArgs e)
        {
            // LDC Network
            hideSubMenu(panelBSub);
            FormWindowLoad(new LDCNET());
        }

        private void buttonB2_Click(object sender, EventArgs e)
        {
            // LDC USB
            hideSubMenu(panelBSub);
            FormWindowLoad(new LDCUSB());
        }
        private void ButtonB3_Click(object sender, EventArgs e)
        {
            hideSubMenu(panelBSub);
            FormWindowLoad(new LDCSER());
        }

        private void buttonC_Click(object sender, EventArgs e)
        {
            // Help
            hideSubMenu(panelBSub);
            FormWindowLoad(new Help());
        }

        private void buttonD_Click(object sender, EventArgs e)
        {
            // Exit
            foreach (var process in Process.GetProcessesByName("robocopy"))
            {
                process.Kill();
            }
            Application.Exit();
        }

        // Custom Window Controls (Move Window, Exit, Minimise)

        private void panelTopMenu_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }

        private void buttonTopExit_Click(object sender, EventArgs e)
        {
            foreach (var process in Process.GetProcessesByName("robocopy"))
            {
                process.Kill();
            }
            Application.Exit();
        }

        private void buttonTopMin_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        // Form Panel

        private Form actForm = null;

        private void FormWindowLoad(Form childForm)
        {
            if (actForm != null)
                actForm.Close();
            actForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            panelForm.Controls.Add(childForm);
            panelForm.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
