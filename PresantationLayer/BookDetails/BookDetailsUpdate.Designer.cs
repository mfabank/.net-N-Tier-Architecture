
namespace MFABooks.PresantationLayer.BookDetails
{
    partial class BookDetailsUpdate
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BookDetailsUpdate));
            this.id_textbox = new System.Windows.Forms.Panel();
            this.home_btn = new System.Windows.Forms.Button();
            this.delete_btn = new System.Windows.Forms.Button();
            this.bookDetails_textbox = new System.Windows.Forms.TextBox();
            this.authorName_textbox = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.booksDetails_lbl = new System.Windows.Forms.Label();
            this.authorName_lbl = new System.Windows.Forms.Label();
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
            this.id_textbox.Controls.Add(this.bookDetails_textbox);
            this.id_textbox.Controls.Add(this.authorName_textbox);
            this.id_textbox.Controls.Add(this.textBox1);
            this.id_textbox.Controls.Add(this.booksDetails_lbl);
            this.id_textbox.Controls.Add(this.authorName_lbl);
            this.id_textbox.Controls.Add(this.id_lbl);
            this.id_textbox.Location = new System.Drawing.Point(13, 253);
            this.id_textbox.Name = "id_textbox";
            this.id_textbox.Size = new System.Drawing.Size(775, 185);
            this.id_textbox.TabIndex = 13;
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
            // bookDetails_textbox
            // 
            this.bookDetails_textbox.Location = new System.Drawing.Point(445, 75);
            this.bookDetails_textbox.Name = "bookDetails_textbox";
            this.bookDetails_textbox.Size = new System.Drawing.Size(150, 20);
            this.bookDetails_textbox.TabIndex = 11;
            // 
            // authorName_textbox
            // 
            this.authorName_textbox.Location = new System.Drawing.Point(174, 73);
            this.authorName_textbox.Name = "authorName_textbox";
            this.authorName_textbox.Size = new System.Drawing.Size(150, 20);
            this.authorName_textbox.TabIndex = 10;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(56, 75);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(33, 20);
            this.textBox1.TabIndex = 9;
            // 
            // booksDetails_lbl
            // 
            this.booksDetails_lbl.AutoSize = true;
            this.booksDetails_lbl.Location = new System.Drawing.Point(351, 78);
            this.booksDetails_lbl.Name = "booksDetails_lbl";
            this.booksDetails_lbl.Size = new System.Drawing.Size(73, 13);
            this.booksDetails_lbl.TabIndex = 2;
            this.booksDetails_lbl.Text = "Book DETAİL";
            // 
            // authorName_lbl
            // 
            this.authorName_lbl.AutoSize = true;
            this.authorName_lbl.Location = new System.Drawing.Point(115, 77);
            this.authorName_lbl.Name = "authorName_lbl";
            this.authorName_lbl.Size = new System.Drawing.Size(53, 13);
            this.authorName_lbl.TabIndex = 1;
            this.authorName_lbl.Text = "AUTHOR";
            // 
            // id_lbl
            // 
            this.id_lbl.AutoSize = true;
            this.id_lbl.Location = new System.Drawing.Point(18, 78);
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
            this.dataGridView1.TabIndex = 12;
            this.dataGridView1.Click += new System.EventHandler(this.dataGridView1_Click);
            // 
            // BookDetailsUpdate
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.id_textbox);
            this.Controls.Add(this.dataGridView1);
            this.Name = "BookDetailsUpdate";
            this.Text = "BookDetailsUpdate";
            this.Load += new System.EventHandler(this.BookDetailsUpdate_Load);
            this.id_textbox.ResumeLayout(false);
            this.id_textbox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel id_textbox;
        private System.Windows.Forms.Button home_btn;
        private System.Windows.Forms.Button delete_btn;
        private System.Windows.Forms.TextBox bookDetails_textbox;
        private System.Windows.Forms.TextBox authorName_textbox;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label booksDetails_lbl;
        private System.Windows.Forms.Label authorName_lbl;
        private System.Windows.Forms.Label id_lbl;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}