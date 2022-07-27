

using RunescraperObjects;
using System.IO;
using System.Reflection;
using UIShell.Properties;
using System.Runtime.InteropServices;


namespace UIShell
{
    public partial class UIWindow : Form
    {

        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;

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
            
            //faster paint time settings
            this.SetStyle(ControlStyles.AllPaintingInWmPaint, true);
            this.SetStyle(ControlStyles.OptimizedDoubleBuffer, true);
            this.SetStyle(ControlStyles.UserPaint, true);

            
            FlipGetterSetup();
            GEScraperSetup();
            ControllerSetup();

           
            
        }

        private void ControllerSetup()
        {
            controller.suggestFinished += FlipGetterForm.updateWithSuggestions;
            controller.flipperscrapeFinished += FlipGetterForm.finishUpdatingPrices;

            controller.scrapeFinished += UpdateGEList;
            controller.UpdateCashStack += FlipGetterForm.updateCashStackBox;
            
            
            
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

        private void MinBuyBox_TextChanged(object? sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void UpdateGEList(List<Item> items)
        {
            geScraperForm.addItems(items);
        }

        private void FlipGetterSetup()
        {

            Control[] controlArray = FlipGetterForm.Controls.Find("SuggestFlipsButton", true);
            Button suggestFlipsButton = (Button)controlArray[0];
            suggestFlipsButton.Click += SuggestFlip_Click;

            controlArray = FlipGetterForm.Controls.Find("UpdatePricesButton", true);
            Button updatePricesButton = (Button)controlArray[0];
            updatePricesButton.Click += UpdatePrices_Click;


            controlArray = FlipGetterForm.Controls.Find("CashStackTextbox", true);
            TextBox CashStackBox = (TextBox)controlArray[0];
            CashStackBox.TextChanged += CashStackBoxChanged;

                       

        }

        private void GEScraperSetup()
        {
            Control[] controlArray = geScraperForm.Controls.Find("UpdatePricesButton", true);
            Button updatePricesButton = (Button)controlArray[0];
            updatePricesButton.Click += UpdatePrices_Click;
        }

        private void FlipGetterButton_Click(object sender, EventArgs e)
        {
            RemoveShownForm();
            FlipGetterForm.Visible = true;
            FlipGetterForm.Focus();
        }
        private void SuggestFlip_Click(object sender, EventArgs e)
        {
            controller.StartSuggesting();
        }

        private void UpdatePrices_Click(object sender, EventArgs e)
        {
            controller.scrapeDB();
        }

        

        private void RemoveShownForm()
        {
           FlipGetterForm.Visible = false;
           geScraperForm.Visible = false;
        }

        private void Form1_Resize(object sender, EventArgs e)
        {
         //  ge.Size = new Size(this.Width - PaddingValue, this.Height - ge.Location.Y - PaddingValue );

        }

        private void SettingsButton_Click(object sender, EventArgs e)
        {
            sf = new SettingsForm();
            SettingsFormSetup();
            sf.Show();
        }

        private void GESearchButton_Click(object sender, EventArgs e)
        {
            RemoveShownForm();
            geScraperForm.Visible = true;
            geScraperForm.Focus();
            //add form to layout
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
    }
}