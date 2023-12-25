using System.Speech.Synthesis;



namespace AVI
{

    public partial class form_sair : Form
    {

        public static bool SpeechEnabled { get; set; }
        public SpeechSynthesizer synth;
        public form_sair()
        {
            InitializeComponent();

            synth = new SpeechSynthesizer();
            synth.SetOutputToDefaultAudioDevice();
        }

        private void btn_sair_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

     

        private void btn_cancelar_Click_1(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void btn_cancelar_Enter(object sender, EventArgs e)
        {
            if (SpeechEnabled)
            {
                synth.SpeakAsync("Pressione Enter para voltar");
            }
        }

        private void btn_sair_Enter(object sender, EventArgs e)
        {
            if (SpeechEnabled)
            {
                string mensagem = "precione enter para sair";
                synth.SpeakAsync(mensagem);

            }
        }

        private void form_sair_Load(object sender, EventArgs e)
        {
           
        }

        private void btn_cancelar_DragEnter(object sender, DragEventArgs e)
        {
            
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





    }

}


