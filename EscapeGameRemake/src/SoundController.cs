using System.Media;
using System.Windows.Forms;

namespace EscapeGameRemake.src
{
    public enum SoundType
    {
        NOSE_HONK, ROBOTVOICE, YAY_SOUND, JUMPSCARE, CLICK, DOOR, PAPER
    }

    public class SoundController
    {
        private static AxWMPLib.AxWindowsMediaPlayer WMPlayer = new AxWMPLib.AxWindowsMediaPlayer();
        private static SoundPlayer Player = new SoundPlayer();
        private static readonly string SoundsPath = System.Windows.Forms.Application.StartupPath + "\\sounds\\";
        private static readonly string Extension = ".wav";

        public static void PlayMainMusic()
        {
            WMPlayer.CreateControl();
            WMPlayer.settings.autoStart = true;
            WMPlayer.settings.setMode("loop", true);
            WMPlayer.URL = Application.StartupPath + "\\sounds\\ambiance.wav";
        }

        public static void PlayMenuMusic()
        {
            WMPlayer.CreateControl();
            WMPlayer.settings.autoStart = true;
            WMPlayer.settings.setMode("loop", true);
            WMPlayer.URL = Application.StartupPath + "\\sounds\\menu_music.wav";
        }

        public static void Play(SoundType Type)
        {
            switch (Type)
            {
                case SoundType.NOSE_HONK:
                    Player.SoundLocation = SoundsPath + "nose_honk" + Extension;
                    break;
                case SoundType.ROBOTVOICE:
                    Player.SoundLocation = SoundsPath + "robotvoice" + Extension;
                    break;
                case SoundType.YAY_SOUND:
                    Player.SoundLocation = SoundsPath + "yay_sound" + Extension;
                    break;
                case SoundType.JUMPSCARE:
                    Player.SoundLocation = SoundsPath + "jumpscare" + Extension;
                    break;
                case SoundType.CLICK:
                    Player.SoundLocation = SoundsPath + "click" + Extension;
                    break;
                case SoundType.DOOR:
                    Player.SoundLocation = SoundsPath + "door" + Extension;
                    break;
                case SoundType.PAPER:
                    Player.SoundLocation = SoundsPath + "paper" + Extension;
                    break;
            }

            if (System.IO.File.Exists(Player.SoundLocation))
                Player.Play();
        }
    }
}
