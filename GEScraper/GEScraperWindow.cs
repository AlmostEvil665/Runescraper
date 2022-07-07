namespace GEScraper
{
    public partial class GEScraperWindow : Form
    {
        int SpacingValue = 10;
        TableLayoutPanel layout;
        public GEScraperWindow()
        {
            InitializeComponent();
            layout = new TableLayoutPanel();
            layout.RowCount = 1;
            layout.ColumnCount = 2;
            layout.Dock = DockStyle.Fill;
            this.Controls.Add(layout);
            DataGridView GrandExchangeTable = new DataGridView();
          

           
            
            GrandExchangeTable.Anchor = (AnchorStyles.Top | AnchorStyles.Left|AnchorStyles.Right);
            GrandExchangeTable.AutoSize = true;
            GrandExchangeTable.Dock = DockStyle.Fill;
            GrandExchangeTable.Columns.Add("ItemName", "Item Name");
            GrandExchangeTable.Columns.Add("BuyPrice", "Buy Price");
            GrandExchangeTable.Columns.Add("SellPrice", "Sell Price");
            GrandExchangeTable.Columns.Add("BuyLimit", "Buy Limit");
            GrandExchangeTable.Columns.Add("DailyVolume", "Daily Volume");
            GrandExchangeTable.Columns.Add("Margin", "Current Margin");
            GrandExchangeTable.Columns.Add("Profit", "Potential Profit");

            
            TableLayoutPanel searchPanel = new TableLayoutPanel(); 
            searchPanel.AutoSize = true;
            searchPanel.Dock = DockStyle.Fill;
            searchPanel.RowCount = 2;
            searchPanel.ColumnCount = 1;

            TextBox SearchBar = new TextBox();
            SearchBar.Width = 100;
            SearchBar.Anchor = (AnchorStyles.Top | AnchorStyles.Right);

            

            layout.Controls.Add(GrandExchangeTable,0,0);
            layout.Controls.Add(SearchBar, 1, 0);

            
            GrandExchangeTable.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            GrandExchangeTable.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;



            


        }

       
    }
}