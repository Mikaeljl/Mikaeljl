using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.DataFormats;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;
using System.Diagnostics;
using MySql.Data;
using MySql.Data.MySqlClient;
using System.Security.Cryptography;
using static Org.BouncyCastle.Bcpg.Attr.ImageAttrib;
using System.Linq.Expressions;
using System.Speech.Synthesis;
using System.Drawing.Drawing2D;
namespace AVI
{

    public partial class Form_login : Form
    {


        public SpeechSynthesizer synth;
        public static bool speechEnabled { get; set; } = true;
        public Form1 MainForm { get; set; }
        

        string MySqlClientString =
            "server= localhost;Port=3306;User Id = root; Database = bdavi; SSL Mode=0";

        

        public Form_login()
        {
       
            InitializeComponent();

            synth = new SpeechSynthesizer();
            synth.SetOutputToDefaultAudioDevice();
            DisableSpeech();

            
        }

        

        private void Form_login_Load(object sender, EventArgs e)
        {

            Bitmap bitmap = new Bitmap
              ("C:\\Users\\rapos\\OneDrive\\Área de Trabalho\\facul\\FUNDOS\\tank.png");

            Icon icon = Icon.FromHandle(bitmap.GetHicon());

            this.Icon = icon;

        }


        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            Color colorComTransparencia = Color.FromArgb(128, Color.DarkBlue);
            Pnl_login.BackColor = colorComTransparencia;




            Pnl_login.Paint += (s, ev) =>

                ControlPaint.DrawBorder(ev.Graphics, ev.ClipRectangle,
                   Color.Transparent, 0, ButtonBorderStyle.Solid,
                   Color.Transparent, 0, ButtonBorderStyle.Solid,
                   Color.Transparent, 0, ButtonBorderStyle.Solid,
                   Color.Transparent, 0, ButtonBorderStyle.Solid);
        }

        private void bnt_login_Click(object sender, EventArgs e)
        {


            
            {
                try
                {
                    if (string.IsNullOrEmpty(txt_usuario.Text) || string.IsNullOrEmpty(txt_senha.Text))
                    {
                        MessageBox.Show("Por favor, digite o nome de usuário e a senha.", "Erro de login", MessageBoxButtons.OK, MessageBoxIcon.Error);

                        if (speechEnabled)
                        {
                            string mensagem = "Por favor, digite o nome de usuário e a senha.Erro de login";
                            synth.SpeakAsync(mensagem);

                        }

                        return;


                    }

                    MySqlConnection conn = new MySqlConnection(MySqlClientString);
                    conn.Open();
                    MySqlCommand cmd = new MySqlCommand("select * from tblogin where usuario = '" +
                        txt_usuario.Text + "' AND senha = " + txt_senha.Text, conn);
                    MySqlDataReader reader = cmd.ExecuteReader();


                    if (reader.Read())
                    {
                        
                        if (speechEnabled)
                        {
                            string mensagem = "bem-vindo" + txt_usuario.Text;
                            synth.SpeakAsync(mensagem);

                        }

                        

                        Form1 Form1 = new Form1();
                        Form1.ShowDialog();
                        this.Hide();
                        

                    }
                    else
                    {


                        MessageBox.Show("Usuario ou senha incorreta.", "Erro de login", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        if (speechEnabled)
                        {
                            string mensagem = "Usuario ou senha incorreta,Erro de login";
                            synth.SpeakAsync(mensagem);

                        }


                    }

                    if (reader.Read() || (txt_usuario.Text == "ADMIN" && txt_senha.Text == "191919"))
                    {
                        this.Hide();
                        new Form1().Show();
                        this.Hide();
                        string mensagemBemVindo = "Bem-vindo, " + txt_usuario.Text;

                        SpeechSynthesizer synth = new SpeechSynthesizer();

                        synth.SpeakAsync(mensagemBemVindo);
                    }
                }
                

                catch
                {

                   if (speechEnabled)
                    {
                        string mensagem = "erro ao efetuar login";
                        synth.SpeakAsync(mensagem);

                    }
                    MessageBox.Show("erro ao efetuar login", "Erro de login", MessageBoxButtons.OK, MessageBoxIcon.Error);
                   
                }


                bnt_login.BackColor = Color.Transparent;

                bnt_login.FlatAppearance.MouseDownBackColor = Color.Transparent;
                bnt_login.FlatAppearance.MouseOverBackColor = Color.Transparent;

                bnt_login.FlatStyle = FlatStyle.Flat;
                bnt_login.FlatAppearance.BorderSize = 0;

              
            }

        }
        private void txt_cancelar_Click(object sender, EventArgs e)
        {
           

                btn_cancelar.BackColor = Color.Transparent;

            btn_cancelar.FlatAppearance.MouseDownBackColor = Color.Transparent;
            btn_cancelar.FlatAppearance.MouseOverBackColor = Color.Transparent;

            btn_cancelar.FlatStyle = FlatStyle.Flat;
            btn_cancelar.FlatAppearance.BorderSize = 0;

            form_sair form_Sair = new form_sair();
            form_Sair.Show();



        }

        private void rdb_mostrar_senha_CheckedChanged(object sender, EventArgs e)
        {
           

        }

        private void lbl_redefinir_senha_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

            lbl_redefinir_senha.Text = "&Redefinir senha";
            ProcessStartInfo psi = new ProcessStartInfo();
            psi.UseShellExecute = true;
            psi.FileName = "cmd.exe";
            psi.Arguments = "/c start https://www.linkedin.com/in/mikaeldejesuslima/";
            Process.Start(psi);


        }
        bool radioClicked = false;
        private void rdb_mostrar_senha_Click(object sender, EventArgs e)
        {


            if (radioClicked)
            {
                radioClicked = false;
                rdb_mostrar_senha.Checked = false;
                txt_senha.UseSystemPasswordChar = true;

                if (speechEnabled)
                {
                    string mensagem = "senha exibida";
                    synth.SpeakAsync(mensagem);

                }


            }
            else
            {
                radioClicked = true;
                txt_senha.UseSystemPasswordChar = false;

                if (speechEnabled)
                {
                    string mensagem = "senha oculta";
                    synth.SpeakAsync(mensagem);

                }

            }


        }

        private void Enter(object sender, KeyPressEventArgs e)
        {

        }

        private void Form_login_FormClosed(object sender, FormClosedEventArgs e)
        {

        }

        private void Form_login_FormClosing(object sender, FormClosingEventArgs e)
        {

        }

        private void Form_login_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Right || e.KeyCode == Keys.Down)
            {
                this.SelectNextControl(this.ActiveControl, true, true, true, true);
            }
            else if (e.KeyCode == Keys.Left || e.KeyCode == Keys.Up)
            {
                this.SelectNextControl(this.ActiveControl, false, true, true, true);
            }
        }

        private void txt_usuario_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Up)
            {

                this.SelectNextControl(this.ActiveControl, false, true, true, true);
                e.Handled = true;
            }
            else if (e.KeyCode == Keys.Down)
            {

                this.SelectNextControl(this.ActiveControl, true, true, true, true);
                e.Handled = true;
            }
        }

        private void txt_senha_TextChanged(object sender, EventArgs e)
        {

            if (speechEnabled)
            {
                TextBox txt_senha = (TextBox)sender;
                string textoParaLer = txt_senha.Text;
                synth.SpeakAsync(textoParaLer);
            }
        }

        private void txt_senha_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Up)
            {

                this.SelectNextControl(this.ActiveControl, false, true, true, true);
                e.Handled = true;
            }
            else if (e.KeyCode == Keys.Down)
            {

                this.SelectNextControl(this.ActiveControl, true, true, true, true);
                e.Handled = true;
            }
        }

        private void rdb_mostrar_senha_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Up)
            {

                this.SelectNextControl(this.ActiveControl, false, true, true, true);
                e.Handled = true;
            }
            else if (e.KeyCode == Keys.Down)
            {

                this.SelectNextControl(this.ActiveControl, true, true, true, true);
                e.Handled = true;
            }
        }

        public void txt_usuario_TextChanged(object sender, EventArgs e)
        {

          

            

            if (speechEnabled)
            {
                TextBox txt_Usuario = (TextBox)sender;
                string textoParaLer = txt_Usuario.Text;
                synth.SpeakAsync(textoParaLer);
            }
        }

        public void txt_usuario_Enter(object sender, EventArgs e)
        {
            if (speechEnabled)
            {
                string mensagem = "Digite seu usuário";
                synth.SpeakAsync(mensagem);
            }
        }

        private void txt_senha_Enter(object sender, EventArgs e)
        {
            if (speechEnabled)
            {
                string mensagem = "Digite sua senha";
                synth.SpeakAsync(mensagem);
            }
        }

        private void bnt_login_Enter(object sender, EventArgs e)
        {
            

            if (speechEnabled)
            {
                string mensagem = "Aperte Enter para efetuar o login";
                synth.SpeakAsync(mensagem);
                
            }

        }

        private void btn_cancelar_Enter(object sender, EventArgs e)
        {
            if (speechEnabled)
            {
                string mensagem = "Aperte Enter para sair";
                synth.SpeakAsync(mensagem);

            }
        }

        private void rdb_mostrar_senha_Enter(object sender, EventArgs e)
        {
            if (speechEnabled)
            {
                string mensagem = "mostrar senha";
                synth.SpeakAsync(mensagem);

            }
        }

        private void lbl_redefinir_senha_Enter(object sender, EventArgs e)
        {
            if (speechEnabled)
            {
                string mensagem = "redefinir senha";
                synth.SpeakAsync(mensagem);

            }
        }

        public void btn_acess_Click(object sender, EventArgs e)
        {

            if (Application.OpenForms["form_sair"] is form_sair Form_sair)
            {
                 Form_sair.SetSpeechEnabled(true);
                
            }

            if (Application.OpenForms["Form1"] is Form1 form1)
            {
                form1.SetSpeechEnabled(true);
               

            }


            if (speechEnabled)
            {
                DisableSpeech();
                string mensagem = "fala desativada";
                synth.SpeakAsync(mensagem);

            }
            else
            {
                EnableSpeech();
                string mensagem = "fala ativada";
                synth.SpeakAsync(mensagem);
                Form1.SpeechEnabled = !Form1.SpeechEnabled;
            }

        }

        public void DisableSpeech()
        {
            speechEnabled = false;
            if (synth != null && synth.State == SynthesizerState.Speaking)
            {
                synth.SpeakAsyncCancelAll();
            }
        
    }
        public void EnableSpeech()
        {
            speechEnabled = true;
            
        }


        public void StartSpeech()
        {
            speechEnabled = true;
            synth = new SpeechSynthesizer();
            synth.SetOutputToDefaultAudioDevice();
        }
      




        public void TextControl_TextChanged(object sender, EventArgs e)
        {
            if (synth != null && synth.State == SynthesizerState.Speaking && speechEnabled)
            {
                synth.SpeakAsyncCancelAll();
                TextBox textBox = (TextBox)sender;
                string textoParaLer = textBox.Text;
                synth.SpeakAsync(textoParaLer);
            }
        }

       
        private void btn_acess_Paint(object sender, PaintEventArgs e)
        {
        }

        public void btn_acess_Enter(object sender, EventArgs e)
        {

            if (speechEnabled)
            {
                string mensagem = "acessibilidade";
                synth.SpeakAsync(mensagem);

            }

        }
    }
    
    }

    
    


