
using Runescraper;
using GEScraper;
using RunescraperObjects;
using System.IO;
using System.Reflection;
using UIShell.Properties;
using UIControllerSpace;

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
            //I am a dummy function that is hooked up to scrapeFinished signal from controller
            //reassign the scrapeFinished to the GE Searcher window, make it update that window with flips
        }

        private void FlipGetterSetup()
        {

            Control[] controlArray = FlipGetterForm.Controls.Find("SuggestFlipsButton", true);
            Button suggestFlipsButton = (Button)controlArray[0];
            suggestFlipsButton.Click += SuggestFlip_Click;

            controlArray = FlipGetterForm.Controls.Find("UpdatePricesButton", true);
            Button updatePricesButton = (Button)controlArray[0];
            updatePricesButton.Click += UpdatePricesFromFlipper_Click;
           
        }

        private void FlipGetterButton_Click(object sender, EventArgs e)
        {
            RemoveShownForm();
            FlipGetterForm.Visible = true;
        }
        private void SuggestFlip_Click(object sender, EventArgs e)
        {
            controller.StartSuggesting();
        }

        private void UpdatePricesFromFlipper_Click(object sender, EventArgs e)
        {
            controller.scrapeDB();
        }

        private void RemoveShownForm()
        {
           FlipGetterForm.Visible = false;
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

        private void toolStripContainer1_TopToolStripPanel_Click(object sender, EventArgs e)
        {

        }

       
    }
}