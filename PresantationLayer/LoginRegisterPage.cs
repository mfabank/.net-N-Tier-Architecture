using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MFABooks.PresantationLayer;
using MFABooks.BusinessLogicLayer;
using MFABooks.PocosLayer;




namespace MFABooks
{
    public partial class LoginRegisterPage : Form
    {

        UsersBLL _userBLL;
        public LoginRegisterPage()
        {
            InitializeComponent();
            _userBLL = new UsersBLL();
        }

        private void login_btn1_Click(object sender, EventArgs e)
        {

            UsersPoco _usersPoco = new UsersPoco();
            _usersPoco = _userBLL.getQuery(login_txt1.Text,login_txt2.Text);

            if (_usersPoco.userName == null || _usersPoco.passWord == null) {
                MessageBox.Show("Hatalı Giriş");
            }
            else {
                this.Hide();
                MessageBox.Show("Hoş Geldiniz", _usersPoco.userName);
                AnaMenu loginScreen = new AnaMenu();
                loginScreen.Show();
            }



        }

        private void LoginRegisterPage_Load(object sender, EventArgs e)
        {
            login_txt2.PasswordChar = '*'; 
        }
    }
}
