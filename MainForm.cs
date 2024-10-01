using System.Speech.Synthesis;

namespace TextToSpeech
{
    public partial class MainForm : Form
    {
        private SpeechSynthesizer speakSynthetizer;
        private string speakerName;
        private string[] systemVoiceNames;
        public MainForm()
        {
            InitializeComponent();
            InitForm();
        }

        private void InitForm()
        {
            this.speakSynthetizer = new SpeechSynthesizer();
            systemVoiceNames = this.speakSynthetizer.GetInstalledVoices()
                .Select(v => v.VoiceInfo.Name)
                .ToArray();
            this.speakerName = systemVoiceNames.First();
            this.speakSynthetizer.SelectVoice(this.speakerName);
            ddlVoiceNames.Items.AddRange(systemVoiceNames);
            ddlVoiceNames.SelectedItem = this.speakerName;
        }

        private void btnSpeech_Click(object sender, EventArgs e)
        {
            this.speakSynthetizer.SelectVoice(this.speakerName);
            this.speakSynthetizer.Speak(txtText.Text);
        }

        private void ddlVoiceNames_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.speakerName = ((string?)ddlVoiceNames.SelectedItem)
                ?? systemVoiceNames.First();
        }
    }
}
