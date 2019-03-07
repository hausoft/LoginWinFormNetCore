using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LoginFormNetCore
{
    public partial class FrmLogin : Form
    {
        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;

        [DllImportAttribute("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [DllImportAttribute("user32.dll")]
        public static extern bool ReleaseCapture();

        public FrmLogin()
        {
            InitializeComponent();
        }

        void SetLogin(bool isShowLogin)
        {
            pnLogin.Visible = isShowLogin;
            pnSignUp.Visible = !isShowLogin;
            if (isShowLogin)
            {
                btnLogIn.BackColor =Color.FromArgb(23, 155, 119);
                btnSignUp.BackColor = Color.FromArgb(160, 179, 176);
            }
            else
            {

                btnLogIn.BackColor = Color.FromArgb(160, 179, 176);
                btnSignUp.BackColor = Color.FromArgb(23, 155, 119);
            }
        }

        private void BtnSignUp_Click(object sender, EventArgs e)
        {
            SetLogin(false);
        }

        private void BtnLogIn_Click(object sender, EventArgs e)
        {
            SetLogin(true);
        }

        private void FrmLogin_Load(object sender, EventArgs e)
        {
            SetLogin(false);
        }

        private void LblLogin_EmailAddress_Click(object sender, EventArgs e)
        {
            txtLogin_EmailAddress.Focus();
        }
        private void TxtLogin_EmailAddress_Enter(object sender, EventArgs e)
        {
            lblLogin_EmailAddress.Visible = false;
        }
        private void TxtLogin_EmailAddress_Leave(object sender, EventArgs e)
        {
           
                lblLogin_EmailAddress.Visible = txtLogin_EmailAddress.Text == "";
        }

        private void LblLogin_Password_Click(object sender, EventArgs e)
        {
            txtLogin_Password.Focus();
        }

        private void TxtLogin_Password_Leave(object sender, EventArgs e)
        {
            lblLogin_Password.Visible = txtLogin_Password.Text=="";
        }

        private void TxtLogin_Password_Enter(object sender, EventArgs e)
        {
            lblLogin_Password.Visible = false;
        }

        private void TxtSign_FirstName_Enter(object sender, EventArgs e)
        {
            lblSign_FirstName.Visible = false;
        }

        private void LblSign_FirstName_Click(object sender, EventArgs e)
        {
            txtSign_FirstName.Focus();
        }

        private void TxtSign_FirstName_Leave(object sender, EventArgs e)
        {
            lblSign_FirstName.Visible = txtSign_FirstName.Text == "";
        }

        private void TxtSign_LastName_Leave(object sender, EventArgs e)
        {
            lblSign_LastName.Visible = txtSign_LastName.Text == "";
        }

        private void TxtSign_LastName_Enter(object sender, EventArgs e)
        {
            lblSign_LastName.Visible = false;
        }

        private void LblSign_LastName_Click(object sender, EventArgs e)
        {
            txtSign_LastName.Focus();
        }

        private void TxtSign_EmailAddress_Enter(object sender, EventArgs e)
        {
            lblSign_EmailAddress.Visible = false;
        }

        private void LblSign_EmailAddress_Click(object sender, EventArgs e)
        {
            txtSign_EmailAddress.Focus();
        }

        private void TxtSign_EmailAddress_Leave(object sender, EventArgs e)
        {
            lblSign_EmailAddress.Visible = txtSign_EmailAddress.Text=="";
        }

        private void LblSign_Password_Click(object sender, EventArgs e)
        {
            txtSign_Password.Focus();
        }

        private void TxtSign_Password_Leave(object sender, EventArgs e)
        {
            lblSign_Password.Visible = txtSign_Password.Text=="";
        }

        private void TxtSign_Password_Enter(object sender, EventArgs e)
        {
            lblSign_Password.Visible = false;
        }

        private void BtnGetStarted_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Get Started");
        }

        private void BtnLoginSystem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Login System");
        }

        private void BtnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void FrmLogin_MouseMove(object sender, MouseEventArgs e)
        {

            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }
    }
}
