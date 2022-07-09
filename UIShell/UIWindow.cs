

using RunescraperObjects;
using System.IO;
using System.Reflection;
using UIShell.Properties;


namespace UIShell
{
    public partial class UIWindow : Form
    {
        
        int PaddingValue = 30;

        Controller controller = new Controller();
        
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

            controller.scrapeFinished += DummyFunction;
            
        }

       private void DummyFunction(List<Item> items)
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

        private void button4_Click(object sender, EventArgs e)
        {
            SettingsForm sf = new SettingsForm();
            sf.Show();
        }

        private void GESearchButton_Click(object sender, EventArgs e)
        {
            RemoveShownForm();
            geScraperForm.Visible = true;
            geScraperForm.Focus();
            //add form to layout
        }

        private void toolStripContainer1_TopToolStripPanel_Click(object sender, EventArgs e)
        {

        }

       
    }
}