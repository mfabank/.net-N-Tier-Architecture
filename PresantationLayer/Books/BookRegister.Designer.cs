
namespace MFABooks.PresantationLayer.Books
{
    partial class BookRegister
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BookRegister));
            this.id_textbox = new System.Windows.Forms.Panel();
            this.home_btn = new System.Windows.Forms.Button();
            this.delete_btn = new System.Windows.Forms.Button();
            this.typeofbook_textbox = new System.Windows.Forms.TextBox();
            this.pagecount_textbox = new System.Windows.Forms.TextBox();
            this.nameofbook_textbox = new System.Windows.Forms.TextBox();
            this.author_textbox = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.lastname_lbl = new System.Windows.Forms.Label();
            this.firstname_lbl = new System.Windows.Forms.Label();
            this.password_lbl = new System.Windows.Forms.Label();
            this.username_lbl = new System.Windows.Forms.Label();
            this.id_lbl = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.id_textbox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // id_textbox
            // 
            this.id_textbox.Controls.Add(this.home_btn);
            this.id_textbox.Controls.Add(this.delete_btn);
            this.id_textbox.Controls.Add(this.typeofbook_textbox);
            this.id_textbox.Controls.Add(this.pagecount_textbox);
            this.id_textbox.Controls.Add(this.nameofbook_textbox);
            this.id_textbox.Controls.Add(this.author_textbox);
            this.id_textbox.Controls.Add(this.textBox1);
            this.id_textbox.Controls.Add(this.lastname_lbl);
            this.id_textbox.Controls.Add(this.firstname_lbl);
            this.id_textbox.Controls.Add(this.password_lbl);
            this.id_textbox.Controls.Add(this.username_lbl);
            this.id_textbox.Controls.Add(this.id_lbl);
            this.id_textbox.Location = new System.Drawing.Point(13, 253);
            this.id_textbox.Name = "id_textbox";
            this.id_textbox.Size = new System.Drawing.Size(775, 185);
            this.id_textbox.TabIndex = 9;
            // 
            // home_btn
            // 
            this.home_btn.BackColor = System.Drawing.Color.Transparent;
            this.home_btn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("home_btn.BackgroundImage")));
            this.home_btn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.home_btn.Location = new System.Drawing.Point(649, 99);
            this.home_btn.Name = "home_btn";
            this.home_btn.Size = new System.Drawing.Size(95, 83);
            this.home_btn.TabIndex = 17;
            this.home_btn.UseVisualStyleBackColor = false;
            this.home_btn.Click += new System.EventHandler(this.home_btn_Click);
            // 
            // delete_btn
            // 
            this.delete_btn.BackColor = System.Drawing.Color.Transparent;
            this.delete_btn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("delete_btn.BackgroundImage")));
            this.delete_btn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.delete_btn.Location = new System.Drawing.Point(649, 9);
            this.delete_btn.Name = "delete_btn";
            this.delete_btn.Size = new System.Drawing.Size(95, 84);
            this.delete_btn.TabIndex = 16;
            this.delete_btn.UseVisualStyleBackColor = false;
            this.delete_btn.Click += new System.EventHandler(this.delete_btn_Click);
            // 
            // typeofbook_textbox
            // 
            this.typeofbook_textbox.Location = new System.Drawing.Point(407, 58);
            this.typeofbook_textbox.Name = "typeofbook_textbox";
            this.typeofbook_textbox.Size = new System.Drawing.Size(150, 20);
            this.typeofbook_textbox.TabIndex = 13;
            // 
            // pagecount_textbox
            // 
            this.pagecount_textbox.Location = new System.Drawing.Point(407, 35);
            this.pagecount_textbox.Name = "pagecount_textbox";
            this.pagecount_textbox.Size = new System.Drawing.Size(150, 20);
            this.pagecount_textbox.TabIndex = 12;
            // 
            // nameofbook_textbox
            // 
            this.nameofbook_textbox.Location = new System.Drawing.Point(112, 86);
            this.nameofbook_textbox.Name = "nameofbook_textbox";
            this.nameofbook_textbox.Size = new System.Drawing.Size(150, 20);
            this.nameofbook_textbox.TabIndex = 11;
            // 
            // author_textbox
            // 
            this.author_textbox.Location = new System.Drawing.Point(112, 64);
            this.author_textbox.Name = "author_textbox";
            this.author_textbox.Size = new System.Drawing.Size(150, 20);
            this.author_textbox.TabIndex = 10;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(112, 42);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(150, 20);
            this.textBox1.TabIndex = 9;
            // 
            // lastname_lbl
            // 
            this.lastname_lbl.AutoSize = true;
            this.lastname_lbl.Location = new System.Drawing.Point(317, 65);
            this.lastname_lbl.Name = "lastname_lbl";
            this.lastname_lbl.Size = new System.Drawing.Size(85, 13);
            this.lastname_lbl.TabIndex = 4;
            this.lastname_lbl.Text = "TYPE OF BOOK";
            // 
            // firstname_lbl
            // 
            this.firstname_lbl.AutoSize = true;
            this.firstname_lbl.Location = new System.Drawing.Point(317, 42);
            this.firstname_lbl.Name = "firstname_lbl";
            this.firstname_lbl.Size = new System.Drawing.Size(77, 13);
            this.firstname_lbl.TabIndex = 3;
            this.firstname_lbl.Text = "PAGE COUNT";
            // 
            // password_lbl
            // 
            this.password_lbl.AutoSize = true;
            this.password_lbl.Location = new System.Drawing.Point(22, 95);
            this.password_lbl.Name = "password_lbl";
            this.password_lbl.Size = new System.Drawing.Size(88, 13);
            this.password_lbl.TabIndex = 2;
            this.password_lbl.Text = "NAME OF BOOK";
            // 
            // username_lbl
            // 
            this.username_lbl.AutoSize = true;
            this.username_lbl.Location = new System.Drawing.Point(22, 71);
            this.username_lbl.Name = "username_lbl";
            this.username_lbl.Size = new System.Drawing.Size(53, 13);
            this.username_lbl.TabIndex = 1;
            this.username_lbl.Text = "AUTHOR";
            // 
            // id_lbl
            // 
            this.id_lbl.AutoSize = true;
            this.id_lbl.Location = new System.Drawing.Point(22, 45);
            this.id_lbl.Name = "id_lbl";
            this.id_lbl.Size = new System.Drawing.Size(21, 13);
            this.id_lbl.TabIndex = 0;
            this.id_lbl.Text = "ID ";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(776, 213);
            this.dataGridView1.TabIndex = 8;
            // 
            // BookRegister
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.id_textbox);
            this.Controls.Add(this.dataGridView1);
            this.Name = "BookRegister";
            this.Text = "BookRegister";
            this.Load += new System.EventHandler(this.BookRegister_Load);
            this.id_textbox.ResumeLayout(false);
            this.id_textbox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel id_textbox;
        private System.Windows.Forms.Button home_btn;
        private System.Windows.Forms.Button delete_btn;
        private System.Windows.Forms.TextBox typeofbook_textbox;
        private System.Windows.Forms.TextBox pagecount_textbox;
        private System.Windows.Forms.TextBox nameofbook_textbox;
        private System.Windows.Forms.TextBox author_textbox;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label lastname_lbl;
        private System.Windows.Forms.Label firstname_lbl;
        private System.Windows.Forms.Label password_lbl;
        private System.Windows.Forms.Label username_lbl;
        private System.Windows.Forms.Label id_lbl;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}