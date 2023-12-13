namespace USSProjeto
{
    partial class Login
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
            System.Windows.Forms.PictureBox Logo;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            this.EntraLogin = new System.Windows.Forms.TextBox();
            this.Usuario = new System.Windows.Forms.Label();
            this.Senha = new System.Windows.Forms.Label();
            this.EntraSenha = new System.Windows.Forms.TextBox();
            this.Verifica = new System.Windows.Forms.Button();
            Logo = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(Logo)).BeginInit();
            this.SuspendLayout();
            // 
            // Logo
            // 
            Logo.Anchor = System.Windows.Forms.AnchorStyles.None;
            Logo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            Logo.Image = ((System.Drawing.Image)(resources.GetObject("Logo.Image")));
            Logo.InitialImage = null;
            Logo.Location = new System.Drawing.Point(37, 30);
            Logo.Name = "Logo";
            Logo.Size = new System.Drawing.Size(300, 167);
            Logo.TabIndex = 0;
            Logo.TabStop = false;
            // 
            // EntraLogin
            // 
            this.EntraLogin.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.EntraLogin.Font = new System.Drawing.Font("Microsoft Tai Le", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EntraLogin.Location = new System.Drawing.Point(37, 260);
            this.EntraLogin.Name = "EntraLogin";
            this.EntraLogin.Size = new System.Drawing.Size(300, 32);
            this.EntraLogin.TabIndex = 1;
            this.EntraLogin.Tag = "EntraLogin";
            // 
            // Usuario
            // 
            this.Usuario.AutoSize = true;
            this.Usuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Usuario.Location = new System.Drawing.Point(33, 233);
            this.Usuario.Name = "Usuario";
            this.Usuario.Size = new System.Drawing.Size(74, 24);
            this.Usuario.TabIndex = 2;
            this.Usuario.Text = "Usuário";
            // 
            // Senha
            // 
            this.Senha.AutoSize = true;
            this.Senha.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Senha.Location = new System.Drawing.Point(33, 311);
            this.Senha.Name = "Senha";
            this.Senha.Size = new System.Drawing.Size(65, 24);
            this.Senha.TabIndex = 4;
            this.Senha.Text = "Senha";
            // 
            // EntraSenha
            // 
            this.EntraSenha.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.EntraSenha.Font = new System.Drawing.Font("Microsoft Tai Le", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EntraSenha.Location = new System.Drawing.Point(37, 338);
            this.EntraSenha.Name = "EntraSenha";
            this.EntraSenha.Size = new System.Drawing.Size(300, 32);
            this.EntraSenha.TabIndex = 3;
            this.EntraSenha.Tag = "";
            this.EntraSenha.UseSystemPasswordChar = true;
            // 
            // Verifica
            // 
            this.Verifica.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Verifica.Location = new System.Drawing.Point(104, 411);
            this.Verifica.Name = "Verifica";
            this.Verifica.Size = new System.Drawing.Size(163, 41);
            this.Verifica.TabIndex = 5;
            this.Verifica.Text = "ENTRAR";
            this.Verifica.UseVisualStyleBackColor = true;
            this.Verifica.Click += new System.EventHandler(this.Verificar);
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(384, 491);
            this.Controls.Add(this.Verifica);
            this.Controls.Add(this.Senha);
            this.Controls.Add(this.EntraSenha);
            this.Controls.Add(this.Usuario);
            this.Controls.Add(this.EntraLogin);
            this.Controls.Add(Logo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Login";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.Login_Load);
            ((System.ComponentModel.ISupportInitialize)(Logo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox EntraLogin;
        private System.Windows.Forms.Label Usuario;
        private System.Windows.Forms.Label Senha;
        private System.Windows.Forms.TextBox EntraSenha;
        private System.Windows.Forms.Button Verifica;
    }
}