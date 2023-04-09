using CoreOSC;
using MaterialSkin;
using MaterialSkin.Controls;

namespace TTSVoiceWizard3._0
{
    public partial class VRCSongWiz : MaterialForm
    {
        public static CoreOSC.UDPSender OSCSender = new CoreOSC.UDPSender("127.0.0.1", 9000);
        public static System.Threading.Timer spotifyTimer;
        public static VRCSongWiz MainFormGlobal;
        public VRCSongWiz()
        {
            InitializeComponent();
            MainFormGlobal = this;

            var materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.DARK;
            //  materialSkinManager.ColorScheme = new ColorScheme(Primary.DeepPurple800, Primary.DeepPurple900, Primary.DeepPurple800, Accent.DeepPurple700, TextShade.WHITE);
            materialSkinManager.ColorScheme = new ColorScheme(Primary.Green800, Primary.Green900, Primary.Green800, Accent.Green700, TextShade.WHITE);




        }

        // MaterialSkinManager TManager = MaterialSkinManager.Instance;
        public void spotifytimertick(object sender)
        {

            Thread t = new Thread(doSpotifyTimerTick);
            t.Start();
        }
        private void doSpotifyTimerTick()
        {



            if (materialSwitchDisplaySong.Checked==true&& materialSwitchChangeOnly.Checked==false)
            {
                windowsMediaGetSongInfo();
            }

            spotifyTimer.Change(5000, 0);


        }

        public  async Task windowsMediaGetSongInfo()
        {
            var theString = "";
            this.Invoke((MethodInvoker)delegate ()
            {
               theString = materialTextBox1.Text.ToString();


                    theString = theString.Replace("{title}", WindowsMedia.mediaTitle);
                    theString = theString.Replace("{artist}", WindowsMedia.mediaArtist);
                    theString = theString.Replace("{progressMinutes}", WindowsMedia.getMediaProgress());
                    theString = theString.Replace("{durationMinutes}", WindowsMedia.getMediaDuration());
            });


            var messageSpeechBubble = new OscMessage("/chatbox/input", theString, true, false);
            OSCSender.Send(messageSpeechBubble);
       
            
        }

        private void VRCSongWiz_Load(object sender, EventArgs e)
        {
            label1.ForeColor = Color.Red;
            materialSwitchDisplaySong.Checked = Settings1.Default.DisplaySong;
            materialSwitchChangeOnly.Checked = Settings1.Default.SongChangeOnly;
            materialTextBox1.Text = Settings1.Default.SongText;
            WindowsMedia.getWindowsMedia();
            spotifyTimer = new System.Threading.Timer(spotifytimertick);
            spotifyTimer.Change(5000, 0);
          
        }

        private void materialSwitchDisplaySong_CheckedChanged(object sender, EventArgs e)
        {
            Settings1.Default.DisplaySong = materialSwitchDisplaySong.Checked;
            Settings1.Default.Save();
          
        }

        private void materialSwitchChangeOnly_CheckedChanged(object sender, EventArgs e)
        {
            Settings1.Default.SongChangeOnly = materialSwitchChangeOnly.Checked;
            Settings1.Default.Save();
        }

        private void VRCSongWiz_FormClosing(object sender, FormClosingEventArgs e)
        {
            Settings1.Default.SongText = materialTextBox1.Text.ToString();
            Settings1.Default.Save();
            var messageSpeechBubble = new OscMessage("/chatbox/input", "", true, false);
            OSCSender.Send(messageSpeechBubble);
        }

        private void materialButton1_Click(object sender, EventArgs e)
        {
            materialTextBox1.Text = "▶ {title} - {artist} ";
        }
    }
}