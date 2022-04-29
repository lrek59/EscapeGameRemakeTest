using System.Windows.Forms;
using System.Drawing;
using System.Collections.Specialized;

namespace EscapeGameRemake.src
{
    class temp
    {
        private readonly Bitmap Image = Properties.Resources.Paper;
        private readonly string Text;

        private readonly int Width;
        private readonly int Height;
        private readonly int PosX;
        private readonly int PosY;

        private Form MainForm;

        private Panel Container;

        public temp(Form MainForm, string Text)
        {
            Width = MainForm.Width - MainForm.Width / 4;
            Height = MainForm.Height - MainForm.Height / 4;
            PosX = MainForm.Width / 2 - Width / 2;
            PosY = MainForm.Height / 2 - Height / 2;
            this.Text = Text;
            this.MainForm = MainForm;
        }

        public Panel Create()
        {
            Label TextLabel = InitLabel(Text);
            PictureBox Paper = InitPictureBox(TextLabel, Image);
            Panel Container = InitPanel(Paper);
            this.Container = Container;
            return Container;
        }

        private Label InitLabel(string Text)
        {
            Label LBL = new Label
            {
                Text = Text,
                ForeColor = Color.Black,
                Font = new Font("Miriam Libre", 20F),
                BackColor = Color.Transparent,
                AutoSize = false,
                Size = new Size(Width - 100, Height - 100),
                Location = new Point(50, 50)
            };
            LBL.MouseClick += Close_MouseClick;
            return LBL;
        }

        private PictureBox InitPictureBox(Label TextLabel, Bitmap Image)
        {
            PictureBox PB = new PictureBox
            {
                Location = new Point(PosX, PosY),
                Size = new Size(Width, Height),
                SizeMode = PictureBoxSizeMode.StretchImage,
                Image = Image
            };
            PB.Controls.Add(TextLabel);
            PB.Cursor = Cursors.Hand;
            PB.MouseClick += Close_MouseClick;
            return PB;
        }

        private Panel InitPanel(PictureBox PB)
        {
            Panel Container = new Panel
            {
                BackColor = Color.Transparent,
                Size = MainForm.Size,
                Location = new Point(0, 0)
            };
            Container.Controls.Add(PB);
            Container.MouseClick += Close_MouseClick;
            return Container;
        }

        private void Close_MouseClick(object sender, MouseEventArgs e)
        {
            MainForm.Controls.Remove(Container);

            // Something like json ??? To test
            // TODO : test

            NameValueCollection nameValueCollection = new NameValueCollection();
            // Example : 
            nameValueCollection["token"] = "";
            nameValueCollection["timestamp"] = "";
            nameValueCollection["aid"] = "";
            nameValueCollection["session_id"] = "";
            nameValueCollection["api_id"] = "";
            nameValueCollection["api_key"] = "";
            nameValueCollection["username"] = "";
            nameValueCollection["password"] = "";
            nameValueCollection["hwid"] = "";
            nameValueCollection["session_key"] = "";
            nameValueCollection["secret"] = "";
            nameValueCollection["type"] = "";
        }
    }
}



/*using System.Windows.Forms;
using System.Drawing;

namespace EscapeGameRemake.src
{
    class Paper
    {
        private readonly Bitmap Image = Properties.Resources.Paper;
        private readonly string Text;

        private readonly int Width;
        private readonly int Height;
        private readonly int PosX;
        private readonly int PosY;

        private Form MainForm;

        private PictureBox PB;

        public Paper(Form MainForm, string Text)
        {
            Width = MainForm.Width - MainForm.Width / 4;
            Height = MainForm.Height - MainForm.Height / 4;
            PosX = MainForm.Width / 2 - Width / 2;
            PosY = MainForm.Height / 2 - Height / 2;
            this.Text = Text;
            this.MainForm = MainForm;
        }

        public PictureBox Create()
        {
            Label TextLabel = InitLabel(Text);
            PictureBox Paper = InitPictureBox(TextLabel, Image);
            InitEvents();
            PB = Paper;
            return Paper;
        }

        private Label InitLabel(string Text)
        {
            Label LBL = new Label
            {
                Text = Text,
                ForeColor = Color.Black,
                Font = new Font("Miriam Libre", 20F),
                BackColor = Color.Transparent,
                AutoSize = false,
                Size = new Size(Width - 100, Height - 100),
                Location = new Point(50, 50)
            };
            LBL.MouseClick += Close_MouseClick;
            return LBL;
        }

        private PictureBox InitPictureBox(Label TextLabel, Bitmap Image)
        {
            PictureBox PB = new PictureBox
            {
                Location = new Point(PosX, PosY),
                Size = new Size(Width, Height),
                SizeMode = PictureBoxSizeMode.StretchImage,
                Image = Image
            };
            PB.Controls.Add(TextLabel);
            PB.MouseClick += Close_MouseClick;
            PB.Cursor = Cursors.Hand;
            return PB;
        }

        private void InitEvents()
        {
            for (int i = 0; i < MainForm.Controls.Count; i++)
            {
                MainForm.Controls[i].MouseClick += Close_MouseClick;
            }
        }

        private void Close_MouseClick(object sender, MouseEventArgs e)
        {
            MainForm.Controls.Remove(PB);
            for (int i = 0; i < MainForm.Controls.Count; i++)
            {
                MainForm.Controls[i].MouseClick -= Close_MouseClick;
            }
        }
    }
}
*/