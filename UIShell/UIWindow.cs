

using RunescraperObjects;
using System.IO;
using System.Reflection;
using UIShell.Properties;
using System.Runtime.InteropServices;


namespace UIShell
{
    public partial class UIWindow : Form
    {

        //constants related to dragging the form (label1_mousedown)
        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;


        //constants related to resizing the form (WndProc)
        private const int cGrip = 16;      // Grip size
        private const int cCaption = 32;   // Caption bar height;


        [System.Runtime.InteropServices.DllImport("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [System.Runtime.InteropServices.DllImport("user32.dll")]
        public static extern bool ReleaseCapture();

        int PaddingValue = 30;

        Controller controller = new Controller();
        SettingsForm sf;

        public UIWindow()
        {
            //default code
            InitializeComponent();
            Assembly assembly = Assembly.GetExecutingAssembly();
            this.FormBorderStyle = FormBorderStyle.None;
            
            //faster paint time settings
            this.SetStyle(ControlStyles.AllPaintingInWmPaint, true);
            this.SetStyle(ControlStyles.OptimizedDoubleBuffer, true);
            this.SetStyle(ControlStyles.UserPaint, true);

            this.DoubleBuffered = true;
            this.SetStyle(ControlStyles.ResizeRedraw, true); // this is to avoid visual artifacts

            FlipGetterSetup();
            GEScraperSetup();
            ControllerSetup();

           
            
        }


        protected override void WndProc(ref Message m)
        {
            if (m.Msg == 0x84)
            {  // Trap WM_NCHITTEST
                Point pos = new Point(m.LParam.ToInt32());
                pos = this.PointToClient(pos);
                if (pos.Y < cCaption)
                {
                    m.Result = (IntPtr)2;  // HTCAPTION
                    return;
                }
                if (pos.X >= this.ClientSize.Width - cGrip && pos.Y >= this.ClientSize.Height - cGrip)
                {
                    m.Result = (IntPtr)17; // HTBOTTOMRIGHT
                    return;
                }
            }
            base.WndProc(ref m);
        }



        private void ControllerSetup()
        {
            controller.suggestFinished += flipGetterForm.updateWithSuggestions;
            controller.flipperscrapeFinished += flipGetterForm.finishUpdatingPrices;

            controller.scrapeFinished += UpdateGEList;
            controller.UpdateCashStack += flipGetterForm.updateCashStackBox;
            
            
            
        }

        private void SettingsFormSetup()
        {
            Control[] control = sf.Controls.Find("MinBuyTextbox", true);
            TextBox MinBuyBox = (TextBox)control[0];

            control = sf.Controls.Find("MinSellTextbox", true);
            TextBox MinSellBox = (TextBox)control[0];

            control = sf.Controls.Find("MaxBuyTextbox", true);
            TextBox MaxBuyBox = (TextBox)control[0];

            control = sf.Controls.Find("MaxSellTextbox", true);
            TextBox MaxSellBox = (TextBox)control[0];

            control = sf.Controls.Find("MinVolTextbox", true);
            TextBox MinVolBox = (TextBox)control[0];

            control = sf.Controls.Find("MinMarginTextbox", true);
            TextBox MinMarginBox = (TextBox)control[0];

            control = sf.Controls.Find("MinProfitTextbox", true);
            TextBox MinProfitBox = (TextBox)control[0];

            MinBuyBox.TextChanged += MinBuyBoxChanged;
            MinSellBox.TextChanged += MinSellBoxChanged;
            MaxBuyBox.TextChanged += MaxBuyBoxChanged;
            MaxSellBox.TextChanged += MaxSellBoxChanged;
            MinVolBox.TextChanged += MinVolBoxChanged;
            MinMarginBox.TextChanged += MinMarginBoxChanged;
            MinProfitBox.TextChanged += MinProfitBoxChanged;

            controller.UpdateMinBuy += sf.updateMinBuyBox;
            controller.UpdateMaxBuy += sf.updateMaxBuyBox;
            controller.UpdateMinSell += sf.updateMinSellBox;
            controller.UpdateMaxSell += sf.updateMaxSellBox;
            controller.UpdateMinVol += sf.updateMinVolBox;
            controller.UpdateMinMargin += sf.updateMinMarginBox;
            controller.UpdateMinProfit += sf.updateMinProfitBox;

            controller.SendSettings();
        }

       
        private void UpdateGEList(List<Item> items)
        {
            geScraperForm.addItems(items);
        }

        private void FlipGetterSetup()
        {

            Control[] controlArray = flipGetterForm.Controls.Find("SuggestFlipsButton", true);
            Button suggestFlipsButton = (Button)controlArray[0];
            suggestFlipsButton.Click += SuggestFlip_Click;

            controlArray = flipGetterForm.Controls.Find("UpdatePricesButton", true);
            Button updatePricesButton = (Button)controlArray[0];
            updatePricesButton.Click += UpdatePrices_Click;


            controlArray = flipGetterForm.Controls.Find("CashStackTextbox", true);
            TextBox CashStackBox = (TextBox)controlArray[0];
            CashStackBox.TextChanged += CashStackBoxChanged;

                       

        }

        private void GEScraperSetup()
        {
            Control[] controlArray = geScraperForm.Controls.Find("UpdatePricesButton", true);
            Button updatePricesButton = (Button)controlArray[0];
            updatePricesButton.Click += UpdatePrices_Click;
        }


        /// <summary>
        /// Signal receiver function to start suggestions
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void SuggestFlip_Click(object sender, EventArgs e)
        {
            controller.StartSuggesting();
        }

        private void UpdatePrices_Click(object sender, EventArgs e)
        {
            controller.scrapeDB();
        }


        private void FlipGetterButton_Click(object sender, EventArgs e)
        {
            movePanelAndRecolor(sender as Button);

            RemoveShownForm();
            
            flipGetterForm.Visible = true;
            flipGetterForm.Focus();
        }


        

        private void GESearchButton_Click(object sender, EventArgs e)
        {

            movePanelAndRecolor(sender as Button);

            RemoveShownForm();

            //add form to layout
            geScraperForm.Visible = true;
            geScraperForm.Focus();

        }

       


        private void SettingsButton_Click(object sender, EventArgs e)
        {
            sf = new SettingsForm();
            SettingsFormSetup();
            sf.Show();
        }

        private void movePanelAndRecolor(Button sender)
        {
            //move the navigation indicator and reset all button colors
            moveNavPanel(sender as Button);
            resetButtonColors();

            //set button to show highlight
            sender.BackColor = Color.Yellow;
            sender.ForeColor = Color.FromArgb(24, 24, 24);
        }

        /// <summary>
        /// Moves the navigation panel to above the provided button
        /// </summary>
        /// <param name="sender">Button to "highlight"</param>
        private void moveNavPanel(Button sender)
        {
            pnlNav.Visible = true;
            pnlNav.Width = sender.Width;
            pnlNav.Top = sender.Top;
            pnlNav.Left = sender.Left;
        }

        private void RemoveShownForm()
        {
            flipGetterForm.Visible = false;
            geScraperForm.Visible = false;
        }

        /// <summary>
        /// Resets the menu button colors to their defaults
        /// </summary>
        private void resetButtonColors()
        {
            GESearchButton.ForeColor = Color.Yellow;
            GESearchButton.BackColor = Color.FromArgb(24, 24, 24);

            FlipGetterButton.ForeColor = Color.Yellow;
            FlipGetterButton.BackColor = Color.FromArgb(24, 24, 24);

            HallofFlipsButton.ForeColor = Color.Yellow;
            HallofFlipsButton.BackColor = Color.FromArgb(24, 24, 24);

            AlchFinderButton.ForeColor = Color.Yellow;
            AlchFinderButton.BackColor = Color.FromArgb(24, 24, 24);

            FlipTrackerButton.ForeColor = Color.Yellow;
            FlipTrackerButton.BackColor = Color.FromArgb(24, 24, 24);
        }

        private void SaveSettings()
        {
            List<string> settings = new List<string>();

            foreach (string s in controller.getStg().toString().Split('\n'))
                settings.Add(s);

            /*            foreach (DataGridViewRow row in itemGridView.Rows)
                        {
                            if (row.Cells[0].Value is null)
                                break;

                            string s = ""; 
                            for (int i = 0; i < row.Cells.Count; i++)
                            {
                                s = s + row.Cells[i].Value.ToString() + ",";
                            }
                            settings.Add(s);
                        }
                        settings.Add("flips");
                        foreach (DataGridViewRow row in flipsGridView.Rows)
                        {
                            if (row.Cells[0].Value is null)
                                break;

                            string s = "";
                            for (int i = 0; i < row.Cells.Count; i++)
                            {
                                s = s + row.Cells[i].Value.ToString() + ",";
                            }
                            settings.Add(s);
                        }*/

            File.WriteAllLines("settings.stg", settings.ToArray());
        }

        private void MinBuyBoxChanged(object sender, EventArgs e)
        {
            controller.getStg().setMinBuy((sender as TextBox).Text);
        }

        private void MaxBuyBoxChanged(object sender, EventArgs e)
        {
            controller.getStg().setMaxBuy((sender as TextBox).Text);

        }

        private void MinSellBoxChanged(object sender, EventArgs e)
        {
            controller.getStg().setMinSell((sender as TextBox).Text);

        }

        private void MaxSellBoxChanged(object sender, EventArgs e)
        {
            controller.getStg().setMaxSell((sender as TextBox).Text);
        }

        private void MinVolBoxChanged(object sender, EventArgs e)
        {
            controller.getStg().setMinVol((sender as TextBox).Text);
        }

        private void MinMarginBoxChanged(object sender, EventArgs e)
        {
            controller.getStg().setMinMargin((sender as TextBox).Text);
        }

        private void MinProfitBoxChanged(object sender, EventArgs e)
        {
            controller.getStg().setMinProfit((sender as TextBox).Text);
        }

        private void CashStackBoxChanged(object sender, EventArgs e)
        {
            controller.getStg().setCashStack((sender as TextBox).Text);
        }

        private void UIWindow_FormClosed(object sender, FormClosedEventArgs e)
        {
            SaveSettings();
        }

        private void ExitButton_Click(object sender, EventArgs e)
        {
            Application.Exit(); 
        }

        private void label1_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }

        private void UIWindow_Load(object sender, EventArgs e)
        {

        }
    }
}