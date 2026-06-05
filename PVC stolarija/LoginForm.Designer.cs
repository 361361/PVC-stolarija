namespace PVC_stolarija
{
    partial class LoginForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginForm));
            label1 = new Label();
            label2 = new Label();
            txtUsername = new TextBox();
            txtPassword = new TextBox();
            btnLogin = new Button();
            lblStatus = new Label();
            Pozadina_LoginSlika = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)Pozadina_LoginSlika).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(106, 60);
            label1.Name = "label1";
            label1.Size = new Size(85, 15);
            label1.TabIndex = 0;
            label1.Text = "Korisničko Ime";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(106, 168);
            label2.Name = "label2";
            label2.Size = new Size(47, 15);
            label2.TabIndex = 1;
            label2.Text = "Lozinka";
            // 
            // txtUsername
            // 
            txtUsername.Location = new Point(106, 78);
            txtUsername.Name = "txtUsername";
            txtUsername.Size = new Size(205, 23);
            txtUsername.TabIndex = 2;
            // 
            // txtPassword
            // 
            txtPassword.Location = new Point(106, 186);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(205, 23);
            txtPassword.TabIndex = 3;
            txtPassword.UseSystemPasswordChar = true;
            // 
            // btnLogin
            // 
            btnLogin.Location = new Point(116, 229);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(75, 23);
            btnLogin.TabIndex = 4;
            btnLogin.Text = "Prijava";
            btnLogin.UseVisualStyleBackColor = true;
            btnLogin.Click += btnLogin_Click;
            // 
            // lblStatus
            // 
            lblStatus.AutoSize = true;
            lblStatus.Location = new Point(12, 244);
            lblStatus.Name = "lblStatus";
            lblStatus.Size = new Size(0, 15);
            lblStatus.TabIndex = 5;
            // 
            // Pozadina_LoginSlika
            // 
            Pozadina_LoginSlika.Image = (Image)resources.GetObject("Pozadina_LoginSlika.Image");
            Pozadina_LoginSlika.Location = new Point(-4, 0);
            Pozadina_LoginSlika.Name = "Pozadina_LoginSlika";
            Pozadina_LoginSlika.Size = new Size(1011, 610);
            Pozadina_LoginSlika.TabIndex = 6;
            Pozadina_LoginSlika.TabStop = false;
            // 
            // LoginForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(748, 534);
            Controls.Add(lblStatus);
            Controls.Add(btnLogin);
            Controls.Add(txtPassword);
            Controls.Add(txtUsername);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(Pozadina_LoginSlika);
            Name = "LoginForm";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)Pozadina_LoginSlika).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox txtUsername;
        private TextBox txtPassword;
        private Button btnLogin;
        private Label lblStatus;
        private PictureBox Pozadina_LoginSlika;
    }
}