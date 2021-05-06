
namespace MFABooks.PresantationLayer.Books
{
    partial class BookList
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BookList));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.home_btn = new System.Windows.Forms.Button();
            this.showlist_btn = new System.Windows.Forms.Button();
            this.id_textbox = new System.Windows.Forms.Panel();
            this.check4 = new System.Windows.Forms.CheckBox();
            this.check3 = new System.Windows.Forms.CheckBox();
            this.check2 = new System.Windows.Forms.CheckBox();
            this.check_1 = new System.Windows.Forms.CheckBox();
            this.radio2 = new System.Windows.Forms.RadioButton();
            this.radio_btn1 = new System.Windows.Forms.RadioButton();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.id_textbox.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(776, 213);
            this.dataGridView1.TabIndex = 6;
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
            // showlist_btn
            // 
            this.showlist_btn.BackColor = System.Drawing.Color.Transparent;
            this.showlist_btn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("showlist_btn.BackgroundImage")));
            this.showlist_btn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.showlist_btn.Location = new System.Drawing.Point(649, 9);
            this.showlist_btn.Name = "showlist_btn";
            this.showlist_btn.Size = new System.Drawing.Size(95, 84);
            this.showlist_btn.TabIndex = 16;
            this.showlist_btn.UseVisualStyleBackColor = false;
            this.showlist_btn.Click += new System.EventHandler(this.showlist_btn_Click);
            // 
            // id_textbox
            // 
            this.id_textbox.Controls.Add(this.check4);
            this.id_textbox.Controls.Add(this.check3);
            this.id_textbox.Controls.Add(this.check2);
            this.id_textbox.Controls.Add(this.check_1);
            this.id_textbox.Controls.Add(this.radio2);
            this.id_textbox.Controls.Add(this.radio_btn1);
            this.id_textbox.Controls.Add(this.home_btn);
            this.id_textbox.Controls.Add(this.showlist_btn);
            this.id_textbox.Location = new System.Drawing.Point(13, 253);
            this.id_textbox.Name = "id_textbox";
            this.id_textbox.Size = new System.Drawing.Size(775, 185);
            this.id_textbox.TabIndex = 7;
            // 
            // check4
            // 
            this.check4.AutoSize = true;
            this.check4.Location = new System.Drawing.Point(69, 135);
            this.check4.Name = "check4";
            this.check4.Size = new System.Drawing.Size(92, 17);
            this.check4.TabIndex = 23;
            this.check4.Text = "Type Of Book";
            this.check4.UseVisualStyleBackColor = true;
            // 
            // check3
            // 
            this.check3.AutoSize = true;
            this.check3.Location = new System.Drawing.Point(69, 112);
            this.check3.Name = "check3";
            this.check3.Size = new System.Drawing.Size(82, 17);
            this.check3.TabIndex = 22;
            this.check3.Text = "Page Count";
            this.check3.UseVisualStyleBackColor = true;
            // 
            // check2
            // 
            this.check2.AutoSize = true;
            this.check2.Location = new System.Drawing.Point(69, 89);
            this.check2.Name = "check2";
            this.check2.Size = new System.Drawing.Size(96, 17);
            this.check2.TabIndex = 21;
            this.check2.Text = "Name Of Book";
            this.check2.UseVisualStyleBackColor = true;
            // 
            // check_1
            // 
            this.check_1.AutoSize = true;
            this.check_1.Location = new System.Drawing.Point(69, 66);
            this.check_1.Name = "check_1";
            this.check_1.Size = new System.Drawing.Size(57, 17);
            this.check_1.TabIndex = 20;
            this.check_1.Text = "Author";
            this.check_1.UseVisualStyleBackColor = true;
            // 
            // radio2
            // 
            this.radio2.AutoSize = true;
            this.radio2.Location = new System.Drawing.Point(27, 43);
            this.radio2.Name = "radio2";
            this.radio2.Size = new System.Drawing.Size(116, 17);
            this.radio2.TabIndex = 19;
            this.radio2.TabStop = true;
            this.radio2.Text = "List Selected Areas";
            this.radio2.UseVisualStyleBackColor = true;
            this.radio2.CheckedChanged += new System.EventHandler(this.radio2_CheckedChanged);
            // 
            // radio_btn1
            // 
            this.radio_btn1.AutoSize = true;
            this.radio_btn1.Location = new System.Drawing.Point(27, 19);
            this.radio_btn1.Name = "radio_btn1";
            this.radio_btn1.Size = new System.Drawing.Size(85, 17);
            this.radio_btn1.TabIndex = 18;
            this.radio_btn1.TabStop = true;
            this.radio_btn1.Text = "List All Areas";
            this.radio_btn1.UseVisualStyleBackColor = true;
            this.radio_btn1.CheckedChanged += new System.EventHandler(this.radio_btn1_CheckedChanged);
            // 
            // BookList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.id_textbox);
            this.Name = "BookList";
            this.Text = "BookList";
            this.Load += new System.EventHandler(this.BookList_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.id_textbox.ResumeLayout(false);
            this.id_textbox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button home_btn;
        private System.Windows.Forms.Button showlist_btn;
        private System.Windows.Forms.Panel id_textbox;
        private System.Windows.Forms.CheckBox check4;
        private System.Windows.Forms.CheckBox check3;
        private System.Windows.Forms.CheckBox check2;
        private System.Windows.Forms.CheckBox check_1;
        private System.Windows.Forms.RadioButton radio2;
        private System.Windows.Forms.RadioButton radio_btn1;
    }
}