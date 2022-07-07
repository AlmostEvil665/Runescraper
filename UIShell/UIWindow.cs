
using Runescraper;
using GEScraper;
using FlipGetter;
using System.IO;
using System.Reflection;
using UIShell.Properties;
using UIControllerSpace;

namespace UIShell
{
    public partial class UIWindow : Form
    {
        
        int PaddingValue = 30;

        UIController controller = new UIController();
        FlipGetterWindow fg = new FlipGetterWindow();
        public UIWindow()
        {
            InitializeComponent();
            Assembly assembly = Assembly.GetExecutingAssembly();
            tableLayoutPanel1.BackgroundImage = Resources.runescape;
            this.IsMdiContainer = true;

           // rw = new RunescraperWindow();
           // ge = new GEScraperWindow();
            fg = new FlipGetterWindow();

            FlipGetterSetup();
           // controller.UISetup(this);
            

            /*
            ge.TopLevel = false;
            ge.FormBorderStyle = FormBorderStyle.None;
            ge.AutoSize = true;
            ge.AutoSizeMode = AutoSizeMode.GrowOnly;
          //  ge.Dock = DockStyle.Fill;
            
            ge.StartPosition = FormStartPosition.Manual;
            ge.MdiParent = this;

            ge.Location = new Point(button1.Location.X,button1.Location.Y + button1.Height + 5);
            ge.Anchor = (AnchorStyles.Left | AnchorStyles.Top | AnchorStyles.Right | AnchorStyles.Bottom);
            
            //   ge.Size = new Size(this.Width - 10, this.Height - ge.Location.Y);
            ge.Visible = true;
            
            rw.TopLevel = false;
            rw.FormBorderStyle = FormBorderStyle.None;
            
            rw.Dock = DockStyle.Fill;
            rw.MdiParent = this;
           // rw.BackColor = Color.Transparent;
            rw.Hide();
            */
            
        }

        private void FlipGetterSetup()
        {
            fg = new FlipGetterWindow();
            fg.TopLevel = false;
            fg.FormBorderStyle = FormBorderStyle.None;
            fg.AutoSize = true;
            // fg.Dock = DockStyle.Fill;
            fg.Anchor = (AnchorStyles.Left | AnchorStyles.Top | AnchorStyles.Right | AnchorStyles.Bottom);
            fg.Visible = true;
            fg.MdiParent = this;
        }

        private void FlipGetterButton_Click(object sender, EventArgs e)
        {
            RemoveShownForm();
            tableLayoutPanel1.Controls.Add(fg);
            tableLayoutPanel1.SetColumn(fg, 0);
            tableLayoutPanel1.SetRow(fg, 1);
        }

        private void RemoveShownForm()
        {
            if (tableLayoutPanel1.Controls.Count > 1)
            {
                tableLayoutPanel1.Controls.RemoveAt(1);
            }
        }

        private void Form1_Resize(object sender, EventArgs e)
        {
         //  ge.Size = new Size(this.Width - PaddingValue, this.Height - ge.Location.Y - PaddingValue );

        }

        private void button4_Click(object sender, EventArgs e)
        {
            SettingsForm sf = new SettingsForm();
            sf.Show();
        }

        private void GESearchButton_Click(object sender, EventArgs e)
        {
            RemoveShownForm();
            //add form to layout
        }
    }
}