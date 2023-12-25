namespace AVI
{
    partial class Form_login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_login));
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_usuario = new System.Windows.Forms.TextBox();
            this.txt_senha = new System.Windows.Forms.TextBox();
            this.bnt_login = new System.Windows.Forms.Button();
            this.lbl_redefinir_senha = new System.Windows.Forms.LinkLabel();
            this.rdb_mostrar_senha = new System.Windows.Forms.RadioButton();
            this.btn_cancelar = new System.Windows.Forms.Button();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.Pnl_login = new System.Windows.Forms.Panel();
            this.btn_acess = new System.Windows.Forms.Button();
            this.Pnl_login.SuspendLayout();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("NSimSun", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label2.Location = new System.Drawing.Point(10, 118);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Senha:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("NSimSun", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label1.Location = new System.Drawing.Point(13, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(97, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Usuario:";
            // 
            // txt_usuario
            // 
            this.txt_usuario.Location = new System.Drawing.Point(13, 53);
            this.txt_usuario.Name = "txt_usuario";
            this.txt_usuario.Size = new System.Drawing.Size(274, 29);
            this.txt_usuario.TabIndex = 2;
            this.txt_usuario.TextChanged += new System.EventHandler(this.txt_usuario_TextChanged);
            this.txt_usuario.Enter += new System.EventHandler(this.txt_usuario_Enter);
            this.txt_usuario.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txt_usuario_KeyDown);
            // 
            // txt_senha
            // 
            this.txt_senha.Location = new System.Drawing.Point(13, 152);
            this.txt_senha.Name = "txt_senha";
            this.txt_senha.Size = new System.Drawing.Size(174, 29);
            this.txt_senha.TabIndex = 3;
            this.txt_senha.UseSystemPasswordChar = true;
            this.txt_senha.TextChanged += new System.EventHandler(this.txt_senha_TextChanged);
            this.txt_senha.Enter += new System.EventHandler(this.txt_senha_Enter);
            this.txt_senha.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txt_senha_KeyDown);
            // 
            // bnt_login
            // 
            this.bnt_login.BackColor = System.Drawing.Color.Transparent;
            this.bnt_login.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bnt_login.BackgroundImage")));
            this.bnt_login.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bnt_login.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bnt_login.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bnt_login.Font = new System.Drawing.Font("NSimSun", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.bnt_login.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bnt_login.Location = new System.Drawing.Point(13, 196);
            this.bnt_login.Name = "bnt_login";
            this.bnt_login.Size = new System.Drawing.Size(87, 30);
            this.bnt_login.TabIndex = 4;
            this.bnt_login.Text = "&Login";
            this.bnt_login.UseVisualStyleBackColor = false;
            this.bnt_login.Click += new System.EventHandler(this.bnt_login_Click);
            this.bnt_login.Enter += new System.EventHandler(this.bnt_login_Enter);
            this.bnt_login.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Enter);
            // 
            // lbl_redefinir_senha
            // 
            this.lbl_redefinir_senha.ActiveLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.lbl_redefinir_senha.AutoSize = true;
            this.lbl_redefinir_senha.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lbl_redefinir_senha.DisabledLinkColor = System.Drawing.Color.Yellow;
            this.lbl_redefinir_senha.Font = new System.Drawing.Font("NSimSun", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbl_redefinir_senha.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline;
            this.lbl_redefinir_senha.LinkColor = System.Drawing.Color.Lime;
            this.lbl_redefinir_senha.LinkVisited = true;
            this.lbl_redefinir_senha.Location = new System.Drawing.Point(209, 210);
            this.lbl_redefinir_senha.Name = "lbl_redefinir_senha";
            this.lbl_redefinir_senha.Size = new System.Drawing.Size(142, 16);
            this.lbl_redefinir_senha.TabIndex = 6;
            this.lbl_redefinir_senha.TabStop = true;
            this.lbl_redefinir_senha.Text = "Redefinir Senha";
            this.lbl_redefinir_senha.VisitedLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lbl_redefinir_senha.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lbl_redefinir_senha_LinkClicked);
            this.lbl_redefinir_senha.Enter += new System.EventHandler(this.lbl_redefinir_senha_Enter);
            // 
            // rdb_mostrar_senha
            // 
            this.rdb_mostrar_senha.AutoSize = true;
            this.rdb_mostrar_senha.Cursor = System.Windows.Forms.Cursors.Hand;
            this.rdb_mostrar_senha.Font = new System.Drawing.Font("NSimSun", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.rdb_mostrar_senha.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.rdb_mostrar_senha.Location = new System.Drawing.Point(209, 155);
            this.rdb_mostrar_senha.Name = "rdb_mostrar_senha";
            this.rdb_mostrar_senha.Padding = new System.Windows.Forms.Padding(0, 1, 0, 0);
            this.rdb_mostrar_senha.Size = new System.Drawing.Size(142, 21);
            this.rdb_mostrar_senha.TabIndex = 9;
            this.rdb_mostrar_senha.TabStop = true;
            this.rdb_mostrar_senha.Text = "mostrar Senha";
            this.rdb_mostrar_senha.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.rdb_mostrar_senha.UseVisualStyleBackColor = true;
            this.rdb_mostrar_senha.CheckedChanged += new System.EventHandler(this.rdb_mostrar_senha_CheckedChanged);
            this.rdb_mostrar_senha.Click += new System.EventHandler(this.rdb_mostrar_senha_Click);
            this.rdb_mostrar_senha.Enter += new System.EventHandler(this.rdb_mostrar_senha_Enter);
            this.rdb_mostrar_senha.KeyDown += new System.Windows.Forms.KeyEventHandler(this.rdb_mostrar_senha_KeyDown);
            // 
            // btn_cancelar
            // 
            this.btn_cancelar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_cancelar.BackgroundImage")));
            this.btn_cancelar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_cancelar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_cancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_cancelar.Font = new System.Drawing.Font("NSimSun", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_cancelar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btn_cancelar.Location = new System.Drawing.Point(316, 258);
            this.btn_cancelar.Name = "btn_cancelar";
            this.btn_cancelar.Size = new System.Drawing.Size(87, 30);
            this.btn_cancelar.TabIndex = 7;
            this.btn_cancelar.Text = "&Encerrar";
            this.btn_cancelar.UseVisualStyleBackColor = true;
            this.btn_cancelar.Click += new System.EventHandler(this.txt_cancelar_Click);
            this.btn_cancelar.Enter += new System.EventHandler(this.btn_cancelar_Enter);
            // 
            // Pnl_login
            // 
            this.Pnl_login.BackColor = System.Drawing.Color.Transparent;
            this.Pnl_login.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Pnl_login.Controls.Add(this.btn_acess);
            this.Pnl_login.Controls.Add(this.rdb_mostrar_senha);
            this.Pnl_login.Controls.Add(this.label1);
            this.Pnl_login.Controls.Add(this.lbl_redefinir_senha);
            this.Pnl_login.Controls.Add(this.txt_usuario);
            this.Pnl_login.Controls.Add(this.txt_senha);
            this.Pnl_login.Controls.Add(this.btn_cancelar);
            this.Pnl_login.Controls.Add(this.bnt_login);
            this.Pnl_login.Controls.Add(this.label2);
            this.Pnl_login.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Pnl_login.Location = new System.Drawing.Point(12, 12);
            this.Pnl_login.Name = "Pnl_login";
            this.Pnl_login.Size = new System.Drawing.Size(421, 293);
            this.Pnl_login.TabIndex = 8;
            this.Pnl_login.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // btn_acess
            // 
            this.btn_acess.BackColor = System.Drawing.Color.Transparent;
            this.btn_acess.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_acess.BackgroundImage")));
            this.btn_acess.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_acess.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_acess.Font = new System.Drawing.Font("SimSun", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_acess.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btn_acess.Location = new System.Drawing.Point(13, 257);
            this.btn_acess.Name = "btn_acess";
            this.btn_acess.Size = new System.Drawing.Size(111, 31);
            this.btn_acess.TabIndex = 9;
            this.btn_acess.Text = "&Acess.";
            this.btn_acess.UseVisualStyleBackColor = false;
            this.btn_acess.Click += new System.EventHandler(this.btn_acess_Click);
            this.btn_acess.Paint += new System.Windows.Forms.PaintEventHandler(this.btn_acess_Paint);
            this.btn_acess.Enter += new System.EventHandler(this.btn_acess_Enter);
            // 
            // Form_login
            // 
            this.AcceptButton = this.bnt_login;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.CancelButton = this.btn_cancelar;
            this.ClientSize = new System.Drawing.Size(490, 363);
            this.Controls.Add(this.Pnl_login);
            this.Name = "Form_login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AVI";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form_login_FormClosing);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form_login_FormClosed);
            this.Load += new System.EventHandler(this.Form_login_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form_login_KeyDown);
            this.Pnl_login.ResumeLayout(false);
            this.Pnl_login.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Label label2;
        private Label label1;
        private TextBox txt_usuario;
        private TextBox txt_senha;
        private Button bnt_login;
        private LinkLabel lbl_redefinir_senha;
        private RadioButton rdb_mostrar_senha;
        private Button btn_cancelar;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private Panel Pnl_login;
        private Button btn_acess;
    }
}