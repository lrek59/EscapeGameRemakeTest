using System.Windows.Forms;
using EscapeGameRemake.src;

namespace EscapeGameRemake
{
    public partial class StartingMenu : Form
    {
        public StartingMenu()
        {
            InitializeComponent();
        }

        private void StartingMenu_Load(object sender, System.EventArgs e)
        {
            SoundController.PlayMenuMusic();
        }

        private void play_button_Click(object sender, System.EventArgs e)
        {
            SoundController.PlayMainMusic();
            Utility.OpenForm(this, new forms.Office());
        }

        private void credits_button_Click(object sender, System.EventArgs e)
        {
            // Utility.OpenForm(this, new forms.Credits());
        }

        private void nose_honk_button_Click(object sender, System.EventArgs e)
        {
            SoundController.Play(SoundType.NOSE_HONK);
        }

        private void play_button_MouseHover(object sender, System.EventArgs e)
        {
            SoundController.Play(SoundType.CLICK);
        }

        private void credits_button_MouseHover(object sender, System.EventArgs e)
        {
            SoundController.Play(SoundType.CLICK);
        }
    }
}
