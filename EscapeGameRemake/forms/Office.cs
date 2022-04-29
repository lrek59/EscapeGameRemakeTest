using System;
using System.Drawing;
using System.Windows.Forms;
using EscapeGameRemake.src;

namespace EscapeGameRemake.forms
{
    public partial class Office : Form
    {
        private static bool DoorOpened = false;
        private static readonly int DOORCODE = 8453;

        public Office()
        {
            InitializeComponent();
        }

        private void Office_Load(object sender, EventArgs e)
        {
            CheckDoor();
        }

        private void CheckDoor()
        {
            if (DoorOpened)
            {
                BackgroundImage = Properties.Resources.Office_ON_background;
                door_button.Visible = true;
                digicode_button.Visible = false;
            }
        }

        private void desk_button_Click(object sender, EventArgs e)
        {
            Utility.OpenForm(this, new OfficeDesk());
        }

        private void return_button_Click(object sender, EventArgs e)
        {
            Utility.OpenForm(this, new StartingMenu());
        }

        private void digicode_button_Click(object sender, EventArgs e)
        {
            Digicode digicode = new Digicode(this, DOORCODE);
            digicode.ShowDialog();
            if (digicode.check_code())
            {
                SoundController.Play(SoundType.DOOR);
                DoorOpened = true;
                CheckDoor();
            } else
            {

                //var screamer = new AxWMPLib.AxWindowsMediaPlayer();
                //screamer.Location = new Point(0, 0);
                //screamer.CreateControl();
                //screamer.Width = this.Width;
                //screamer.Height = this.Height;
                //screamer.Dock = DockStyle.Fill;
                //screamer.Size = new Size(this.ClientSize.Width, this.ClientSize.Height);
                //screamer.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right | AnchorStyles.Bottom;
                //screamer.fullScreen = true;
                //screamer.stretchToFit = false;
                //screamer.uiMode = "none";
                //this.Controls.Add(screamer);

                //screamer.Size = screamer.Parent.Size;

                //screamer.URL = Application.StartupPath + "\\Resources\\Video.mp4";
                var screamer = this.axWindowsMediaPlayer1;
                screamer.Width = this.Width;
                screamer.Height = this.Height;
                screamer.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right | AnchorStyles.Bottom;
                this.axWindowsMediaPlayer1.Visible = true;
                 screamer.URL = Application.StartupPath + "\\Resources\\Video.mp4";
            }
        }

        private void axWindowsMediaPlayer1_Enter(object sender, EventArgs e)
        {

        }
    }
}
