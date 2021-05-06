using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MFABooks.PresantationLayer.Users;
using MFABooks.PresantationLayer.Books;
using MFABooks.PresantationLayer.BookDetails;

namespace MFABooks.PresantationLayer
{
    public partial class AnaMenu : Form
    {
        public AnaMenu()
        {
            InitializeComponent();
        }

        private void newUserToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UserRegister addUser = new UserRegister();
            this.Hide();
            addUser.Show();
        }

        private void updateUserToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UserUpdate updateUser = new UserUpdate();
            this.Hide();
            updateUser.Show();

        }

        private void deleteUserToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UserDelete userDelete = new UserDelete();
            this.Hide();
            userDelete.Show();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LoginRegisterPage comeBack = new LoginRegisterPage();
            this.Hide();
            comeBack.Show();
        }

        private void userlistUserReporsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UserList userList = new UserList();
            this.Hide();
            userList.Show();

        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Designed By MFA");
        }

        private void newBookToolStripMenuItem_Click(object sender, EventArgs e)
        {
            BookRegister addUser = new BookRegister();
            this.Hide();
            addUser.Show();
        }

        private void deleteBookToolStripMenuItem_Click(object sender, EventArgs e)
        {
            BookDelete deleteBook = new BookDelete();
            this.Hide();
            deleteBook.Show();

        }

        private void booklistBookReportsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            BookList bookList = new BookList();
            this.Hide();
            bookList.Show();
        }

        private void newDetailToolStripMenuItem_Click(object sender, EventArgs e)
        {
            BookDetailsRegister registerDetails = new BookDetailsRegister();
            this.Hide();
            registerDetails.Show();

        }

        private void updateDetailToolStripMenuItem_Click(object sender, EventArgs e)
        {
            BookDetailsUpdate updateDetails = new BookDetailsUpdate();
            this.Hide();
            updateDetails.Show();
        }

        private void deleteDetailToolStripMenuItem_Click(object sender, EventArgs e)
        {
            BookDetailsDelete deleteDetails = new BookDetailsDelete();
            this.Hide();
            deleteDetails.Show();
        }

        private void updateBookToolStripMenuItem_Click(object sender, EventArgs e)
        {
            BookUpdate bookUpdate = new BookUpdate();
            this.Hide();
            bookUpdate.Show();
        }
    }
}
