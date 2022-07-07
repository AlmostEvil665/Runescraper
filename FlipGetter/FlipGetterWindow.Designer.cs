namespace FlipGetter
{
    partial class FlipGetterWindow
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.mainLayout = new System.Windows.Forms.TableLayoutPanel();
            this.rightLayout = new System.Windows.Forms.TableLayoutPanel();
            this.button1 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.CashStackLabel = new System.Windows.Forms.Label();
            this.suggestionTable = new System.Windows.Forms.DataGridView();
            this.ItemName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DBBuyPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.WikiBuyPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DBSellPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.WikiSellPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BuyLimit = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Volume = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Margin = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Profit = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mainLayout.SuspendLayout();
            this.rightLayout.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.suggestionTable)).BeginInit();
            this.SuspendLayout();
            // 
            // mainLayout
            // 
            this.mainLayout.AutoSize = true;
            this.mainLayout.ColumnCount = 2;
            this.mainLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 90F));
            this.mainLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.mainLayout.Controls.Add(this.rightLayout, 1, 0);
            this.mainLayout.Controls.Add(this.suggestionTable, 0, 0);
            this.mainLayout.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mainLayout.Location = new System.Drawing.Point(0, 0);
            this.mainLayout.Name = "mainLayout";
            this.mainLayout.RowCount = 1;
            this.mainLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.mainLayout.Size = new System.Drawing.Size(800, 450);
            this.mainLayout.TabIndex = 0;
            // 
            // rightLayout
            // 
            this.rightLayout.ColumnCount = 1;
            this.rightLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.rightLayout.Controls.Add(this.button1, 0, 2);
            this.rightLayout.Controls.Add(this.textBox1, 0, 1);
            this.rightLayout.Controls.Add(this.CashStackLabel, 0, 0);
            this.rightLayout.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rightLayout.Location = new System.Drawing.Point(723, 3);
            this.rightLayout.Name = "rightLayout";
            this.rightLayout.RowCount = 4;
            this.rightLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 55F));
            this.rightLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.rightLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.rightLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.rightLayout.Size = new System.Drawing.Size(74, 444);
            this.rightLayout.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.AutoSize = true;
            this.button1.Location = new System.Drawing.Point(3, 155);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(68, 39);
            this.button1.TabIndex = 1;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            this.textBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBox1.Location = new System.Drawing.Point(3, 58);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(68, 23);
            this.textBox1.TabIndex = 0;
            // 
            // CashStackLabel
            // 
            this.CashStackLabel.AutoSize = true;
            this.CashStackLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.CashStackLabel.Location = new System.Drawing.Point(3, 0);
            this.CashStackLabel.Name = "CashStackLabel";
            this.CashStackLabel.Size = new System.Drawing.Size(68, 55);
            this.CashStackLabel.TabIndex = 2;
            this.CashStackLabel.Text = "Enter Cash Stack";
            this.CashStackLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // suggestionTable
            // 
            this.suggestionTable.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.suggestionTable.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.suggestionTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.suggestionTable.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ItemName,
            this.DBBuyPrice,
            this.WikiBuyPrice,
            this.DBSellPrice,
            this.WikiSellPrice,
            this.BuyLimit,
            this.Volume,
            this.Margin,
            this.Profit});
            this.suggestionTable.Location = new System.Drawing.Point(3, 3);
            this.suggestionTable.Name = "suggestionTable";
            this.suggestionTable.RowTemplate.Height = 25;
            this.suggestionTable.Size = new System.Drawing.Size(714, 444);
            this.suggestionTable.TabIndex = 1;
            // 
            // ItemName
            // 
            this.ItemName.HeaderText = "Item Name";
            this.ItemName.Name = "ItemName";
            // 
            // DBBuyPrice
            // 
            this.DBBuyPrice.HeaderText = "Database Buy Price";
            this.DBBuyPrice.Name = "DBBuyPrice";
            // 
            // WikiBuyPrice
            // 
            this.WikiBuyPrice.HeaderText = "Wiki Buy Price";
            this.WikiBuyPrice.Name = "WikiBuyPrice";
            // 
            // DBSellPrice
            // 
            this.DBSellPrice.HeaderText = "Database Sell Price";
            this.DBSellPrice.Name = "DBSellPrice";
            // 
            // WikiSellPrice
            // 
            this.WikiSellPrice.HeaderText = "Wiki Sell Price";
            this.WikiSellPrice.Name = "WikiSellPrice";
            // 
            // BuyLimit
            // 
            this.BuyLimit.HeaderText = "Buy Limit";
            this.BuyLimit.Name = "BuyLimit";
            // 
            // Volume
            // 
            this.Volume.HeaderText = "Daily Volume";
            this.Volume.Name = "Volume";
            // 
            // Margin
            // 
            this.Margin.HeaderText = "Current Margin";
            this.Margin.Name = "Margin";
            // 
            // Profit
            // 
            this.Profit.HeaderText = "Possible Profit";
            this.Profit.Name = "Profit";
            // 
            // FlipGetterWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.mainLayout);
            this.Name = "FlipGetterWindow";
            this.Text = "Form1";
            this.mainLayout.ResumeLayout(false);
            this.rightLayout.ResumeLayout(false);
            this.rightLayout.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.suggestionTable)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TableLayoutPanel mainLayout;
        private TableLayoutPanel rightLayout;
        private Button button1;
        private TextBox textBox1;
        private Label CashStackLabel;
        private DataGridView suggestionTable;
        private DataGridViewTextBoxColumn ItemName;
        private DataGridViewTextBoxColumn DBBuyPrice;
        private DataGridViewTextBoxColumn WikiBuyPrice;
        private DataGridViewTextBoxColumn DBSellPrice;
        private DataGridViewTextBoxColumn WikiSellPrice;
        private DataGridViewTextBoxColumn BuyLimit;
        private DataGridViewTextBoxColumn Volume;
        private DataGridViewTextBoxColumn Margin;
        private DataGridViewTextBoxColumn Profit;
    }
}