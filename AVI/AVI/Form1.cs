using AVI.Properties;
using MySqlX.XDevAPI;
using System.Diagnostics;
using System.Net.Mail;
using System.Speech.Synthesis;




namespace AVI
{
    
    public partial class Form1 : Form
    {
        public static bool SpeechEnabled { get; set; }
        private SpeechSynthesizer synth;
        
        public Form1()
        {
            InitializeComponent();
            

            synth = new SpeechSynthesizer();
            synth.SetOutputToDefaultAudioDevice();
            cbm_duvida.SelectedIndex = 0;

        }

        private void btn_aula_Click(object sender, EventArgs e)
        {
            cbm_aula.Visible = true;
            lbl_selecione.Visible = false;
            cbm_duvida.Visible = false;
            txt_duvida.Visible = false;
            btn_enviar_duvida.Visible = false;


            btn_aula.BackColor = Color.Transparent;

            btn_aula.FlatAppearance.MouseDownBackColor = Color.Transparent;
            btn_aula.FlatAppearance.MouseOverBackColor = Color.Transparent;

            btn_aula.FlatStyle = FlatStyle.Flat;
            btn_aula.FlatAppearance.BorderSize = 0;

        }

        private void Form1_Load(object sender, EventArgs e)
        {

            Bitmap bitmap = new Bitmap
                ("C:\\Users\\rapos\\OneDrive\\Área de Trabalho\\facul\\FUNDOS\\tank.png");


            Icon icon = Icon.FromHandle(bitmap.GetHicon());


            this.Icon = icon;

        }

        private void abr_exe_Click(object sender, EventArgs e)

        {


            Process process = new Process();
            process.StartInfo.FileName = "cmd.exe";
            process.StartInfo.Arguments = "/c start chrome https://docs.google.com/forms/d/e/1FAIpQLScFU4xtnrrhjW97KQjyatDatvFITjiA6Dq7IdVZ_7qXcDBy1w/viewform?hr_submission=ChkInPXWy9MNEhAI746giY4QEgcImoemsbYREAE";
            process.Start();



            abr_exe.BackColor = Color.Transparent;

            abr_exe.FlatAppearance.MouseDownBackColor = Color.Transparent;
            abr_exe.FlatAppearance.MouseOverBackColor = Color.Transparent;

            abr_exe.FlatStyle = FlatStyle.Flat;
            abr_exe.FlatAppearance.BorderSize = 0;

        }



        private void lbl_selecione_Click(object sender, EventArgs e)

        { }

        private void tela_aula_Click(object sender, EventArgs e)
        {  }



        private void btn_duvida_Click(object sender, EventArgs e)
        {
            cbm_duvida.Visible = true;
            txt_duvida.Visible = true;
            cbm_aula.Visible = false;
            btn_enviar_duvida.Visible = true;

            btn_duvida.BackColor = Color.Transparent;

            btn_duvida.FlatAppearance.MouseDownBackColor = Color.Transparent;
            btn_duvida.FlatAppearance.MouseOverBackColor = Color.Transparent;

            btn_duvida.FlatStyle = FlatStyle.Flat;
            btn_duvida.FlatAppearance.BorderSize = 0;


        }

        private void btn_enviar_duvida_Click(object sender, EventArgs e)
        {
            if (cbm_duvida.SelectedIndex == -1 || string.IsNullOrEmpty(txt_duvida.Text))
            {
                MessageBox.Show("Por favor, preencha todos os campos antes de enviar a dúvida.");
                if (SpeechEnabled)
                {
                    synth.SpeakAsync("Por favor, preencha todos os campos antes de enviar a dúvida.");
                }
                return;
            }


            string remetente = "2210340@fortec.edu.br";
            string destinatario = "mikaeljl824@gmail.com";
            string senha = "98814fox";


            MailMessage mensagem = new MailMessage(remetente, destinatario, cbm_duvida.SelectedItem.ToString(), txt_duvida.Text);


            SmtpClient clienteSmtp = new SmtpClient("smtp.gmail.com", 587);
            
            clienteSmtp.EnableSsl = true;
            clienteSmtp.UseDefaultCredentials = false;
            clienteSmtp.Credentials = new System.Net.NetworkCredential(remetente, senha);

            try
            {

                clienteSmtp.Send(mensagem);
                MessageBox.Show("Dúvida enviada com sucesso!");
                if (SpeechEnabled)
                {
                    synth.SpeakAsync("duvida enviada com sucesso");
                }

            }
           catch (Exception ex)
            {
               if (SpeechEnabled)
                {
                    synth.SpeakAsync("ocorreu um erro a enviar a duvida");
                }
                MessageBox.Show("Ocorreu um erro ao enviar a dúvida: " + ex.Message);
            }

            txt_duvida.Clear();
            btn_duvida.Visible = false;
            txt_duvida.Visible = false;
            btn_enviar_duvida.Visible = false;
            cbm_duvida.Visible = false;
            cbm_aula.SelectedIndex = 0;
            cbm_duvida.SelectedIndex = 0;


        }

        private void txt_duvida_TextChanged(object sender, EventArgs e)
        {


        }



        private void button3_Click(object sender, EventArgs e)
        {


            Form_login form_Login = new Form_login();
            form_Login.Show();
            this.Hide();

        }

        private void lbl_selecione_Paint(object sender, PaintEventArgs e)
        {
            System.Drawing.Drawing2D.GraphicsPath path = new System.Drawing.Drawing2D.GraphicsPath();
            int radius = 20;
            Rectangle rect = new Rectangle(0, 0, lbl_selecione.Width, lbl_selecione.Height);

            path.StartFigure();
            path.AddArc(rect.X, rect.Y, radius, radius, 180, 90);
            path.AddLine(rect.X + radius, rect.Y, rect.Width - radius, rect.Y);
            path.AddArc(rect.X + rect.Width - radius, rect.Y, radius, radius, 270, 90);
            path.AddLine(rect.Width, rect.Y + radius, rect.Width, rect.Height - radius);
            path.AddArc(rect.X + rect.Width - radius, rect.Y + rect.Height - radius, radius, radius, 0, 90);
            path.AddLine(rect.Width - radius, rect.Height, rect.X + radius, rect.Height);
            path.AddArc(rect.X, rect.Y + rect.Height - radius, radius, radius, 90, 90);
            path.CloseFigure();

            lbl_selecione.Region = new System.Drawing.Region(path);
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {


        }

        private void llbl_exercicio_Paint(object sender, PaintEventArgs e)
        {

        }

        private void lbl_redefinir_senha_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {

            if (e.KeyCode == Keys.Right || e.KeyCode == Keys.Down)
            {
                this.SelectNextControl(this.ActiveControl, true, true, true, true);
            }
            else if (e.KeyCode == Keys.Left || e.KeyCode == Keys.Up)
            {
                this.SelectNextControl(this.ActiveControl, false, true, true, true);
            }

            if (e.KeyCode == Keys.Enter && cbm_aula.Focused)
            {
                btn_duvida.Focus();
                e.Handled = true; 
            }



        }

        private void cbm_duvida_KeyPress(object sender, KeyPressEventArgs e)
        {

        }



        private void cbm_duvida_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {
            if (e.KeyCode == Keys.Up || e.KeyCode == Keys.Down)
            {
                if (cbm_duvida.DroppedDown)
                {
                    e.IsInputKey = true;
                }
                else
                {
                    SelectNextControl((Control)sender, true, true, true, true);
                }
            }
            else if (e.KeyCode == Keys.Escape)
            {
                this.SelectNextControl((Control)sender, true, true, true, true);

            }

        }

        private void Form1_Load_1(object sender, EventArgs e)
        {

            Bitmap bitmap = new Bitmap
                ("C:\\Users\\rapos\\OneDrive\\Área de Trabalho\\facul\\FUNDOS\\tank.png");


            Icon icon = Icon.FromHandle(bitmap.GetHicon());


            this.Icon = icon;

            
        }

        private void cbm_duvida_KeyDown(object sender, KeyEventArgs e)
        {

        }



        private void button3_Click_1(object sender, EventArgs e)
        {

        }

        private void txt_duvida_Enter(object sender, EventArgs e)
        {

        }




        private void cbm_aula_SelectedIndexChanged(object sender, EventArgs e)
        {
          

            switch (cbm_aula.SelectedItem.ToString())
            {
                case "<selecione>":
                    if (SpeechEnabled)
                    {
                        synth.SpeakAsync("selecione");
                       
                    }
                    break;

                case "Aula:1":
                    tela_aula.Image = Resources.a1;
                    btn_duvida.Visible = true;
                    if (SpeechEnabled)
                    {
                        synth.SpeakAsync("aula:1");
                        ptb_acess.Image = Resources.al1;
                        ptb_acess.Visible = true;
                    }
                    break;
                case "Aula:2":
                    tela_aula.Image = Resources.a2;
                    btn_duvida.Visible = true;
                    if (SpeechEnabled)
                    {
                        synth.SpeakAsync("aula:2");
                        ptb_acess.Image = Resources.al2;
                        ptb_acess.Visible = true;

                    }
                    break;
                case "Aula:3":
                    tela_aula.Image = Resources.a3;
                    btn_duvida.Visible = true;
                    if (SpeechEnabled)
                    {
                        synth.SpeakAsync("aula:3");
                        ptb_acess.Image = Resources.al3;
                        ptb_acess.Visible = true;
                    }
                    break;
                case "Aula:4":
                    tela_aula.Image = Resources.a4;
                    btn_duvida.Visible = true;
                    if (SpeechEnabled)
                    {
                        synth.SpeakAsync("aula:4");
                        ptb_acess.Image = Resources.al4;
                        ptb_acess.Visible = true;
                    }
                    break;
                case "Aula:5":
                    tela_aula.Image = Resources.a5;
                    btn_duvida.Visible = true;
                    if (SpeechEnabled)
                    {
                        synth.SpeakAsync("aula:5");
                        ptb_acess.Image = Resources.al1;
                        ptb_acess.Visible = true;
                    }
                    break;
                default:
                    cbm_aula.SelectedIndex = 0;
                    break;
            }

        }

        private void cbm_aula_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {

        }

        private void cbm_duvida_SelectedIndexChanged_1(object sender, EventArgs e)
        {

           
            switch (cbm_duvida.SelectedItem.ToString())
            {
                case "<<selecione>>":


                    break;


                case "Duvida:1":
                    tela_aula.Image = Properties.Resources.d1;
                    if (SpeechEnabled)
                    {
                        synth.SpeakAsync("duvida:1");
                        ptb_acess.Image = Resources.ad1;
                        ptb_acess.Visible = true;
                       
                    }

                    break;

                case "Duvida:2":
                    tela_aula.Image = Properties.Resources.d2;
                    if (SpeechEnabled)
                    {
                        synth.SpeakAsync("duvida:2");
                        ptb_acess.Image = Resources.ad2;
                        ptb_acess.Visible = true;
                    }
                    break;
                case "Duvida:3":
                    tela_aula.Image = Properties.Resources.d3;
                    if (SpeechEnabled)
                    {
                        synth.SpeakAsync("duvida:3");
                        ptb_acess.Image = Resources.ad3;
                        ptb_acess.Visible = true;
                    }
                    break;
                case "Duvida:4":
                    tela_aula.Image = Properties.Resources.d4;
                    if (SpeechEnabled)
                    {
                        synth.SpeakAsync("duvida:4");
                        ptb_acess.Image = Resources.ad4;
                        ptb_acess.Visible = true;
                    }
                    break;
                case "Duvida:5":
                    tela_aula.Image = Properties.Resources.d5;
                    if (SpeechEnabled)
                    {
                        synth.SpeakAsync("duvida:5");
                        ptb_acess.Image = Resources.ad5;
                        ptb_acess.Visible = true;
                    }
                    break;
            }
        }


        public void ToggleSpeechEnabled()
        {
            SpeechEnabled = !SpeechEnabled;

            if (SpeechEnabled)
            {
              
                if (synth == null)
                {
                    synth = new SpeechSynthesizer();
                    synth.SetOutputToDefaultAudioDevice();
                }
            }
            else
            {
               
                if (synth != null)
                {
                    synth.Dispose();
                    synth = null;
                }
            }
        }

       
        public void SetSpeechEnabled(bool enabled)
        {
            SpeechEnabled = enabled;
        }



        public void btn_aula_Enter(object sender, EventArgs e)
        {
            if (SpeechEnabled)
            {
                synth.SpeakAsync("Pressione Enter para abrir o seletor de aula.");
            }


        }

        private void btn_duvida_Enter(object sender, EventArgs e)
        {
            if (SpeechEnabled)
            {
                synth.SpeakAsync("Pressione Enter para abrir o seletor de duvida.");
            }
        }

        private void btn_enviar_duvida_Enter(object sender, EventArgs e)
        {
            if (SpeechEnabled)
            {
                synth.SpeakAsync("Pressione Enter para enviar a duvida.");
            }
        }

        private void abr_exe_Enter(object sender, EventArgs e)
        {
            if (SpeechEnabled)
            {
                synth.SpeakAsync("Pressione Enter para abrir os exercicios");
            }
        }

        private void btn_sair_Enter(object sender, EventArgs e)
        {
            if (SpeechEnabled)
            {
                synth.SpeakAsync("Pressione Enter para sair.");
            }
        }

        private void txt_duvida_TextChanged_1(object sender, EventArgs e)
        {
            if (SpeechEnabled)
            {
           
                string textoParaLer = txt_duvida.Text;
                synth.SpeakAsync(textoParaLer);
            }
        }

        private void txt_duvida_Enter_1(object sender, EventArgs e)
        {
            if (SpeechEnabled)
            {
                synth.SpeakAsync("Digite aqui suas duvidas");
            }
        }

        private void cbm_aula_KeyPress(object sender, KeyPressEventArgs e)
        {
           
        }

        private void btn_duvida_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void cbm_aula_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter && cbm_aula.Focused)
            {
                btn_duvida.Focus();
            }
        }

        private void txt_duvida_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btn_enviar_duvida.PerformClick();
                e.Handled = true;
            }
        }

        private void cbm_duvida_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter && cbm_duvida.Focused)
            {
                txt_duvida.Focus();
            }
        }

        private void ptb_acess_Click(object sender, EventArgs e)
        {

        }
    }
}
