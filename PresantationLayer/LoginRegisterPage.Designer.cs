
namespace MFABooks
{
    partial class LoginRegisterPage
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginRegisterPage));
            this.login_lbl1 = new System.Windows.Forms.Label();
            this.login_lbl2 = new System.Windows.Forms.Label();
            this.login_lbl3 = new System.Windows.Forms.Label();
            this.login_txt1 = new System.Windows.Forms.TextBox();
            this.login_txt2 = new System.Windows.Forms.TextBox();
            this.login_btn1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // login_lbl1
            // 
            this.login_lbl1.AutoSize = true;
            this.login_lbl1.BackColor = System.Drawing.Color.Transparent;
            this.login_lbl1.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.login_lbl1.Location = new System.Drawing.Point(234, 104);
            this.login_lbl1.Name = "login_lbl1";
            this.login_lbl1.Size = new System.Drawing.Size(421, 39);
            this.login_lbl1.TabIndex = 0;
            this.login_lbl1.Text = "Welcome to MFA Library";
            // 
            // login_lbl2
            // 
            this.login_lbl2.AutoSize = true;
            this.login_lbl2.BackColor = System.Drawing.Color.Transparent;
            this.login_lbl2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.login_lbl2.Location = new System.Drawing.Point(241, 199);
            this.login_lbl2.Name = "login_lbl2";
            this.login_lbl2.Size = new System.Drawing.Size(131, 24);
            this.login_lbl2.TabIndex = 1;
            this.login_lbl2.Text = "USERNAME ";
            // 
            // login_lbl3
            // 
            this.login_lbl3.AutoSize = true;
            this.login_lbl3.BackColor = System.Drawing.Color.Transparent;
            this.login_lbl3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.login_lbl3.Location = new System.Drawing.Point(241, 247);
            this.login_lbl3.Name = "login_lbl3";
            this.login_lbl3.Size = new System.Drawing.Size(126, 24);
            this.login_lbl3.TabIndex = 2;
            this.login_lbl3.Text = "PASSWORD";
            // 
            // login_txt1
            // 
            this.login_txt1.Location = new System.Drawing.Point(443, 204);
            this.login_txt1.Name = "login_txt1";
            this.login_txt1.Size = new System.Drawing.Size(212, 20);
            this.login_txt1.TabIndex = 3;
            // 
            // login_txt2
            // 
            this.login_txt2.Location = new System.Drawing.Point(443, 247);
            this.login_txt2.Name = "login_txt2";
            this.login_txt2.Size = new System.Drawing.Size(212, 20);
            this.login_txt2.TabIndex = 4;
            // 
            // login_btn1
            // 
            this.login_btn1.BackColor = System.Drawing.Color.Transparent;
            this.login_btn1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.login_btn1.Location = new System.Drawing.Point(679, 199);
            this.login_btn1.Name = "login_btn1";
            this.login_btn1.Size = new System.Drawing.Size(92, 68);
            this.login_btn1.TabIndex = 5;
            this.login_btn1.Text = "LOGIN";
            this.login_btn1.UseVisualStyleBackColor = false;
            this.login_btn1.Click += new System.EventHandler(this.login_btn1_Click);
            // 
            // LoginRegisterPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.login_btn1);
            this.Controls.Add(this.login_txt2);
            this.Controls.Add(this.login_txt1);
            this.Controls.Add(this.login_lbl3);
            this.Controls.Add(this.login_lbl2);
            this.Controls.Add(this.login_lbl1);
            this.Name = "LoginRegisterPage";
            this.Text = "Login | Register ";
            this.Load += new System.EventHandler(this.LoginRegisterPage_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label login_lbl1;
        private System.Windows.Forms.Label login_lbl2;
        private System.Windows.Forms.Label login_lbl3;
        private System.Windows.Forms.TextBox login_txt1;
        private System.Windows.Forms.TextBox login_txt2;
        private System.Windows.Forms.Button login_btn1;
    }
}

