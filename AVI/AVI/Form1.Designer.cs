namespace AVI
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btn_aula = new System.Windows.Forms.Button();
            this.abr_exe = new System.Windows.Forms.Button();
            this.tela_aula = new System.Windows.Forms.PictureBox();
            this.lbl_selecione = new System.Windows.Forms.Label();
            this.btn_sair = new System.Windows.Forms.Button();
            this.btn_duvida = new System.Windows.Forms.Button();
            this.btn_enviar_duvida = new System.Windows.Forms.Button();
            this.cbm_aula = new Siticone.Desktop.UI.WinForms.SiticoneComboBox();
            this.cbm_duvida = new Siticone.Desktop.UI.WinForms.SiticoneComboBox();
            this.txt_duvida = new Siticone.Desktop.UI.WinForms.SiticoneTextBox();
            this.ptb_acess = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.tela_aula)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptb_acess)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_aula
            // 
            this.btn_aula.BackColor = System.Drawing.Color.Transparent;
            this.btn_aula.BackgroundImage = global::AVI.Properties.Resources.btn_neon_azul;
            this.btn_aula.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_aula.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_aula.FlatAppearance.BorderColor = System.Drawing.Color.Red;
            this.btn_aula.FlatAppearance.BorderSize = 0;
            this.btn_aula.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_aula.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.btn_aula.Location = new System.Drawing.Point(5, 77);
            this.btn_aula.Name = "btn_aula";
            this.btn_aula.Size = new System.Drawing.Size(119, 37);
            this.btn_aula.TabIndex = 0;
            this.btn_aula.Text = "Selecionar Aula";
            this.btn_aula.UseVisualStyleBackColor = false;
            this.btn_aula.Click += new System.EventHandler(this.btn_aula_Click);
            this.btn_aula.Enter += new System.EventHandler(this.btn_aula_Enter);
            // 
            // abr_exe
            // 
            this.abr_exe.BackColor = System.Drawing.Color.Transparent;
            this.abr_exe.BackgroundImage = global::AVI.Properties.Resources.purple_neon_button_glowing_neon_button_png;
            this.abr_exe.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.abr_exe.Cursor = System.Windows.Forms.Cursors.Hand;
            this.abr_exe.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.abr_exe.ForeColor = System.Drawing.SystemColors.ControlText;
            this.abr_exe.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.abr_exe.Location = new System.Drawing.Point(126, 378);
            this.abr_exe.Name = "abr_exe";
            this.abr_exe.Size = new System.Drawing.Size(165, 51);
            this.abr_exe.TabIndex = 0;
            this.abr_exe.Text = "Execicios";
            this.abr_exe.UseVisualStyleBackColor = false;
            this.abr_exe.Click += new System.EventHandler(this.abr_exe_Click);
            this.abr_exe.Enter += new System.EventHandler(this.abr_exe_Enter);
            // 
            // tela_aula
            // 
            this.tela_aula.BackColor = System.Drawing.Color.Transparent;
            this.tela_aula.ImageLocation = "";
            this.tela_aula.InitialImage = null;
            this.tela_aula.Location = new System.Drawing.Point(139, 86);
            this.tela_aula.Name = "tela_aula";
            this.tela_aula.Size = new System.Drawing.Size(525, 259);
            this.tela_aula.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.tela_aula.TabIndex = 2;
            this.tela_aula.TabStop = false;
            this.tela_aula.Click += new System.EventHandler(this.tela_aula_Click);
            // 
            // lbl_selecione
            // 
            this.lbl_selecione.AutoSize = true;
            this.lbl_selecione.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(81)))), ((int)(((byte)(4)))), ((int)(((byte)(156)))));
            this.lbl_selecione.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lbl_selecione.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lbl_selecione.Font = new System.Drawing.Font("Trebuchet MS", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbl_selecione.ForeColor = System.Drawing.Color.White;
            this.lbl_selecione.Location = new System.Drawing.Point(207, 123);
            this.lbl_selecione.Name = "lbl_selecione";
            this.lbl_selecione.Size = new System.Drawing.Size(380, 72);
            this.lbl_selecione.TabIndex = 4;
            this.lbl_selecione.Text = " Clique em \"Selecionar Aula\" \r\npara iniciarmos... :)";
            this.lbl_selecione.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lbl_selecione.UseCompatibleTextRendering = true;
            this.lbl_selecione.Click += new System.EventHandler(this.lbl_selecione_Click);
            this.lbl_selecione.Paint += new System.Windows.Forms.PaintEventHandler(this.lbl_selecione_Paint);
            // 
            // btn_sair
            // 
            this.btn_sair.BackColor = System.Drawing.Color.Transparent;
            this.btn_sair.BackgroundImage = global::AVI.Properties.Resources.btn_neon_azul;
            this.btn_sair.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_sair.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_sair.FlatAppearance.BorderColor = System.Drawing.Color.Red;
            this.btn_sair.FlatAppearance.BorderSize = 0;
            this.btn_sair.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_sair.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.btn_sair.Location = new System.Drawing.Point(555, 378);
            this.btn_sair.Name = "btn_sair";
            this.btn_sair.Size = new System.Drawing.Size(121, 51);
            this.btn_sair.TabIndex = 5;
            this.btn_sair.Text = "&Sair";
            this.btn_sair.UseVisualStyleBackColor = false;
            this.btn_sair.Click += new System.EventHandler(this.button3_Click);
            this.btn_sair.Enter += new System.EventHandler(this.btn_sair_Enter);
            // 
            // btn_duvida
            // 
            this.btn_duvida.BackColor = System.Drawing.Color.Transparent;
            this.btn_duvida.BackgroundImage = global::AVI.Properties.Resources.purple_neon_button_glowing_neon_button_png;
            this.btn_duvida.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_duvida.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_duvida.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_duvida.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btn_duvida.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.btn_duvida.Location = new System.Drawing.Point(5, 162);
            this.btn_duvida.Name = "btn_duvida";
            this.btn_duvida.Size = new System.Drawing.Size(119, 51);
            this.btn_duvida.TabIndex = 6;
            this.btn_duvida.Text = "Duvidas";
            this.btn_duvida.UseVisualStyleBackColor = false;
            this.btn_duvida.Visible = false;
            this.btn_duvida.Click += new System.EventHandler(this.btn_duvida_Click);
            this.btn_duvida.Enter += new System.EventHandler(this.btn_duvida_Enter);
            this.btn_duvida.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.btn_duvida_KeyPress);
            // 
            // btn_enviar_duvida
            // 
            this.btn_enviar_duvida.BackColor = System.Drawing.Color.Transparent;
            this.btn_enviar_duvida.BackgroundImage = global::AVI.Properties.Resources.btn_neon_azul;
            this.btn_enviar_duvida.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_enviar_duvida.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_enviar_duvida.FlatAppearance.BorderColor = System.Drawing.Color.Red;
            this.btn_enviar_duvida.FlatAppearance.BorderSize = 0;
            this.btn_enviar_duvida.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_enviar_duvida.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.btn_enviar_duvida.Location = new System.Drawing.Point(5, 329);
            this.btn_enviar_duvida.Name = "btn_enviar_duvida";
            this.btn_enviar_duvida.Size = new System.Drawing.Size(66, 29);
            this.btn_enviar_duvida.TabIndex = 9;
            this.btn_enviar_duvida.Text = "Enviar";
            this.btn_enviar_duvida.UseVisualStyleBackColor = false;
            this.btn_enviar_duvida.Visible = false;
            this.btn_enviar_duvida.Click += new System.EventHandler(this.btn_enviar_duvida_Click);
            this.btn_enviar_duvida.Enter += new System.EventHandler(this.btn_enviar_duvida_Enter);
            // 
            // cbm_aula
            // 
            this.cbm_aula.BackColor = System.Drawing.Color.Transparent;
            this.cbm_aula.BorderColor = System.Drawing.Color.White;
            this.cbm_aula.BorderRadius = 5;
            this.cbm_aula.BorderThickness = 2;
            this.cbm_aula.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbm_aula.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbm_aula.FillColor = System.Drawing.Color.DarkTurquoise;
            this.cbm_aula.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbm_aula.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbm_aula.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.cbm_aula.ForeColor = System.Drawing.Color.Black;
            this.cbm_aula.ItemHeight = 30;
            this.cbm_aula.Items.AddRange(new object[] {
            "<selecione>",
            "Aula:1",
            "Aula:2",
            "Aula:3",
            "Aula:4",
            "Aula:5"});
            this.cbm_aula.Location = new System.Drawing.Point(5, 120);
            this.cbm_aula.Name = "cbm_aula";
            this.cbm_aula.Size = new System.Drawing.Size(119, 36);
            this.cbm_aula.StartIndex = 0;
            this.cbm_aula.TabIndex = 10;
            this.cbm_aula.TextRenderingHint = System.Drawing.Text.TextRenderingHint.SystemDefault;
            this.cbm_aula.TextTransform = Siticone.Desktop.UI.WinForms.Enums.TextTransform.LowerCase;
            this.cbm_aula.Visible = false;
            this.cbm_aula.SelectedIndexChanged += new System.EventHandler(this.cbm_aula_SelectedIndexChanged);
            this.cbm_aula.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cbm_aula_KeyPress);
            this.cbm_aula.KeyUp += new System.Windows.Forms.KeyEventHandler(this.cbm_aula_KeyUp);
            this.cbm_aula.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.cbm_aula_PreviewKeyDown);
            // 
            // cbm_duvida
            // 
            this.cbm_duvida.BackColor = System.Drawing.Color.Transparent;
            this.cbm_duvida.BorderColor = System.Drawing.Color.White;
            this.cbm_duvida.BorderRadius = 5;
            this.cbm_duvida.BorderThickness = 2;
            this.cbm_duvida.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbm_duvida.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbm_duvida.FillColor = System.Drawing.Color.SlateBlue;
            this.cbm_duvida.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbm_duvida.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbm_duvida.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.cbm_duvida.ForeColor = System.Drawing.Color.Black;
            this.cbm_duvida.ItemHeight = 30;
            this.cbm_duvida.Items.AddRange(new object[] {
            "<selecione>",
            "Duvida:1",
            "Duvida:2",
            "Duvida:3",
            "Duvida:4",
            "Duvida:5"});
            this.cbm_duvida.Location = new System.Drawing.Point(5, 214);
            this.cbm_duvida.Name = "cbm_duvida";
            this.cbm_duvida.Size = new System.Drawing.Size(119, 36);
            this.cbm_duvida.StartIndex = 0;
            this.cbm_duvida.TabIndex = 11;
            this.cbm_duvida.TextRenderingHint = System.Drawing.Text.TextRenderingHint.SystemDefault;
            this.cbm_duvida.TextTransform = Siticone.Desktop.UI.WinForms.Enums.TextTransform.LowerCase;
            this.cbm_duvida.Visible = false;
            this.cbm_duvida.SelectedIndexChanged += new System.EventHandler(this.cbm_duvida_SelectedIndexChanged_1);
            this.cbm_duvida.KeyUp += new System.Windows.Forms.KeyEventHandler(this.cbm_duvida_KeyUp);
            // 
            // txt_duvida
            // 
            this.txt_duvida.BackColor = System.Drawing.Color.Transparent;
            this.txt_duvida.BorderColor = System.Drawing.Color.Fuchsia;
            this.txt_duvida.BorderRadius = 5;
            this.txt_duvida.BorderThickness = 2;
            this.txt_duvida.DefaultText = "";
            this.txt_duvida.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txt_duvida.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txt_duvida.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_duvida.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_duvida.FillColor = System.Drawing.Color.Navy;
            this.txt_duvida.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_duvida.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txt_duvida.ForeColor = System.Drawing.Color.White;
            this.txt_duvida.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_duvida.Location = new System.Drawing.Point(5, 256);
            this.txt_duvida.Multiline = true;
            this.txt_duvida.Name = "txt_duvida";
            this.txt_duvida.PasswordChar = '\0';
            this.txt_duvida.PlaceholderForeColor = System.Drawing.Color.DimGray;
            this.txt_duvida.PlaceholderText = "Digite sua duvida...";
            this.txt_duvida.SelectedText = "";
            this.txt_duvida.Size = new System.Drawing.Size(119, 67);
            this.txt_duvida.TabIndex = 13;
            this.txt_duvida.Tag = "";
            this.txt_duvida.Visible = false;
            this.txt_duvida.TextChanged += new System.EventHandler(this.txt_duvida_TextChanged_1);
            this.txt_duvida.Enter += new System.EventHandler(this.txt_duvida_Enter_1);
            this.txt_duvida.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txt_duvida_KeyDown);
            // 
            // ptb_acess
            // 
            this.ptb_acess.BackColor = System.Drawing.Color.Transparent;
            this.ptb_acess.Location = new System.Drawing.Point(542, 243);
            this.ptb_acess.Name = "ptb_acess";
            this.ptb_acess.Size = new System.Drawing.Size(122, 102);
            this.ptb_acess.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ptb_acess.TabIndex = 14;
            this.ptb_acess.TabStop = false;
            this.ptb_acess.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.BackgroundImage = global::AVI.Properties.Resources.de7db393b15490a5a298bc243ce43067;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(803, 450);
            this.Controls.Add(this.ptb_acess);
            this.Controls.Add(this.txt_duvida);
            this.Controls.Add(this.cbm_duvida);
            this.Controls.Add(this.cbm_aula);
            this.Controls.Add(this.btn_enviar_duvida);
            this.Controls.Add(this.btn_duvida);
            this.Controls.Add(this.btn_sair);
            this.Controls.Add(this.lbl_selecione);
            this.Controls.Add(this.tela_aula);
            this.Controls.Add(this.abr_exe);
            this.Controls.Add(this.btn_aula);
            this.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AVI";
            this.Load += new System.EventHandler(this.Form1_Load_1);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.tela_aula)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptb_acess)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button btn_aula;
        private Button abr_exe;
        private PictureBox tela_aula;
        private Button btn_sair;
        private Button btn_duvida;
        private Button btn_enviar_duvida;
        public Label lbl_selecione;
        private Siticone.Desktop.UI.WinForms.SiticoneComboBox cbm_aula;
        private Siticone.Desktop.UI.WinForms.SiticoneComboBox cbm_duvida;
        private Siticone.Desktop.UI.WinForms.SiticoneTextBox txt_duvida;
        private PictureBox ptb_acess;
    }
}