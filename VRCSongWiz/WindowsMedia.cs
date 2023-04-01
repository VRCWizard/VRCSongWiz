using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windows.Media.Control;
using WindowsMediaController;
using static WindowsMediaController.MediaManager;

namespace TTSVoiceWizard3._0
{
    public class WindowsMedia
    {
        static MediaManager mediaManager;
        public static string previousTitle = "-|-]][54h]nh734ngeg==--=";
        public static string mediaTitle = "";
        public static string mediaSource = "";
        public static string mediaArtist = "";
        public static string mediaStatus = "Paused";
        public static string mediaSourceNew = "";
        public static bool pauseMedia = false;
        private static MediaSession getSession = null;
       

        public static async Task getWindowsMedia()
        {
            

                mediaManager = new MediaManager();

                mediaManager.OnAnySessionOpened += MediaManager_OnAnySessionOpened;
                mediaManager.OnAnySessionClosed += MediaManager_OnAnySessionClosed;
                mediaManager.OnAnyPlaybackStateChanged += MediaManager_OnAnyPlaybackStateChanged;
                mediaManager.OnAnyMediaPropertyChanged += MediaManager_OnAnyMediaPropertyChanged;
                mediaManager.Start();

               
     

            //  mediaManager.Dispose(); // should dispose manually if nessicary, for instance if I want to stop media completely

        }
        //if time "" then there is no session
        // if time 00:00/00:00 could not get time
        //if time -/- then there was an error
        public static string getMediaProgress()
        {
            try
            {
                var time = "";
                if (getSession != null)
                {
                    if (getSession.ControlSession != null)
                    {

                        time = getSession.ControlSession.GetTimelineProperties().Position.ToString(@"mm\:ss").ToString();

                    }
                }
                return time;
            }
            catch (Exception ex)
            {
               // OutputText.outputLog("Progress Exception: " + ex.Message, Color.Red);
            }
            return "-:-";
        }
        public static string getMediaDuration()
        {
            try
            {

                var time = "";
                if (getSession != null)
                {
                    if (getSession.ControlSession != null)
                    {

                        time = getSession.ControlSession.GetTimelineProperties().EndTime.ToString(@"mm\:ss").ToString();

                    }
                }
                return time;
            }
            catch (Exception ex)
            {
               // OutputText.outputLog("Duration Exception: " + ex.Message, Color.Red);
            }
            return "-:-";
        }
      
       
        public static void MediaManager_OnAnySessionOpened(MediaManager.MediaSession session)
        {
           
                getSession = session;
                string info = "[Windows Media New Source: " + session.Id + "]";
                //   var ot = new OutputText();

                mediaSourceNew = session.Id;


            }
        private static void MediaManager_OnAnySessionClosed(MediaManager.MediaSession session)
            {
            VRCSongWiz.MainFormGlobal.Invoke((MethodInvoker)delegate ()
            {
                VRCSongWiz.MainFormGlobal.label1.ForeColor = Color.Red;
                VRCSongWiz.MainFormGlobal.label1.Text = "- Spotify Not Connected -";

            });


        }

            private static void MediaManager_OnAnyPlaybackStateChanged(MediaManager.MediaSession sender, GlobalSystemMediaTransportControlsSessionPlaybackInfo args)
            {
                if (sender.Id.ToString() == "Spotify.exe")
                {
                VRCSongWiz.MainFormGlobal.Invoke((MethodInvoker)delegate ()
                {
                    VRCSongWiz.MainFormGlobal.label1.ForeColor = Color.Green;
                    VRCSongWiz.MainFormGlobal.label1.Text = "- Spotify Connected -";

                });



                mediaStatus = args.PlaybackStatus.ToString();

                }

            }

            private static void MediaManager_OnAnyMediaPropertyChanged(MediaManager.MediaSession sender, GlobalSystemMediaTransportControlsSessionMediaProperties args)
            {

                if (sender.Id.ToString() == "Spotify.exe")
                {




                    mediaTitle = args.Title;
                    mediaArtist = args.Artist;
                    mediaSource = sender.Id;

                    

                }
                if(VRCSongWiz.MainFormGlobal.materialSwitchDisplaySong.Checked == true && VRCSongWiz.MainFormGlobal.materialSwitchChangeOnly.Checked == true)
                {
                if(mediaTitle != previousTitle)//prevent message from bugging and appearing twice
                {
                    previousTitle = args.Title;
                    VRCSongWiz.MainFormGlobal.windowsMediaGetSongInfo();
                }
               
                }


            }

      

       

    }
}
