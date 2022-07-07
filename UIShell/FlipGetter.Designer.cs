namespace UIShell
{
    partial class FlipGetter
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.suggestionTable = new System.Windows.Forms.DataGridView();
            this.ItemName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DBBuyPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.WikiBuyPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DBSellPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.WikiSellPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BuyLimit = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Volume = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MarginColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Profit = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mainLayout = new System.Windows.Forms.TableLayoutPanel();
            this.rightLayout = new System.Windows.Forms.TableLayoutPanel();
            this.SuggestFlipsButton = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.CashStackLabel = new System.Windows.Forms.Label();
            this.UpdatePricesButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.suggestionTable)).BeginInit();
            this.mainLayout.SuspendLayout();
            this.rightLayout.SuspendLayout();
            this.SuspendLayout();
            // 
            // suggestionTable
            // 
            this.suggestionTable.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.suggestionTable.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.suggestionTable.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.suggestionTable.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.suggestionTable.ColumnHeadersHeight = 53;
            this.suggestionTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.suggestionTable.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ItemName,
            this.DBBuyPrice,
            this.WikiBuyPrice,
            this.DBSellPrice,
            this.WikiSellPrice,
            this.BuyLimit,
            this.Volume,
            this.MarginColumn,
            this.Profit});
            this.suggestionTable.Location = new System.Drawing.Point(4, 3);
            this.suggestionTable.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.suggestionTable.Name = "suggestionTable";
            this.suggestionTable.RowTemplate.Height = 25;
            this.suggestionTable.Size = new System.Drawing.Size(918, 514);
            this.suggestionTable.TabIndex = 2;
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
            // MarginColumn
            // 
            this.MarginColumn.HeaderText = "Current Margin";
            this.MarginColumn.Name = "MarginColumn";
            // 
            // Profit
            // 
            this.Profit.HeaderText = "Possible Profit";
            this.Profit.Name = "Profit";
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
            this.mainLayout.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.mainLayout.Name = "mainLayout";
            this.mainLayout.RowCount = 1;
            this.mainLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.mainLayout.Size = new System.Drawing.Size(1029, 520);
            this.mainLayout.TabIndex = 3;
            // 
            // rightLayout
            // 
            this.rightLayout.ColumnCount = 1;
            this.rightLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.rightLayout.Controls.Add(this.SuggestFlipsButton, 0, 2);
            this.rightLayout.Controls.Add(this.textBox1, 0, 1);
            this.rightLayout.Controls.Add(this.CashStackLabel, 0, 0);
            this.rightLayout.Controls.Add(this.UpdatePricesButton, 0, 5);
            this.rightLayout.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rightLayout.Location = new System.Drawing.Point(930, 3);
            this.rightLayout.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.rightLayout.Name = "rightLayout";
            this.rightLayout.RowCount = 6;
            this.rightLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 48F));
            this.rightLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 26F));
            this.rightLayout.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.rightLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 87F));
            this.rightLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 17F));
            this.rightLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.rightLayout.Size = new System.Drawing.Size(95, 514);
            this.rightLayout.TabIndex = 0;
            // 
            // SuggestFlipsButton
            // 
            this.SuggestFlipsButton.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.SuggestFlipsButton.FlatAppearance.BorderSize = 0;
            this.SuggestFlipsButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.SuggestFlipsButton.Location = new System.Drawing.Point(4, 77);
            this.SuggestFlipsButton.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.SuggestFlipsButton.Name = "SuggestFlipsButton";
            this.SuggestFlipsButton.Size = new System.Drawing.Size(87, 35);
            this.SuggestFlipsButton.TabIndex = 1;
            this.SuggestFlipsButton.Text = "Suggest Flips";
            this.SuggestFlipsButton.UseVisualStyleBackColor = true;
            this.SuggestFlipsButton.Click += new System.EventHandler(this.SuggestFlipsButton_Click);
            // 
            // textBox1
            // 
            this.textBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBox1.Location = new System.Drawing.Point(4, 51);
            this.textBox1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(87, 21);
            this.textBox1.TabIndex = 0;
            // 
            // CashStackLabel
            // 
            this.CashStackLabel.AutoSize = true;
            this.CashStackLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.CashStackLabel.Location = new System.Drawing.Point(4, 0);
            this.CashStackLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.CashStackLabel.Name = "CashStackLabel";
            this.CashStackLabel.Size = new System.Drawing.Size(87, 48);
            this.CashStackLabel.TabIndex = 2;
            this.CashStackLabel.Text = "Enter Cash Stack";
            this.CashStackLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // UpdatePricesButton
            // 
            this.UpdatePricesButton.BackColor = System.Drawing.Color.SeaGreen;
            this.UpdatePricesButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.UpdatePricesButton.Font = new System.Drawing.Font("OCR A Extended", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.UpdatePricesButton.Location = new System.Drawing.Point(4, 222);
            this.UpdatePricesButton.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.UpdatePricesButton.Name = "UpdatePricesButton";
            this.UpdatePricesButton.Size = new System.Drawing.Size(87, 289);
            this.UpdatePricesButton.TabIndex = 3;
            this.UpdatePricesButton.Text = "UPDATE PRICES";
            this.UpdatePricesButton.UseVisualStyleBackColor = false;
            this.UpdatePricesButton.Click += new System.EventHandler(this.UpdatePricesButton_Click);
            // 
            // FlipGetter
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.Controls.Add(this.mainLayout);
            this.Font = new System.Drawing.Font("OCR A Extended", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "FlipGetter";
            this.Size = new System.Drawing.Size(1029, 520);
            ((System.ComponentModel.ISupportInitialize)(this.suggestionTable)).EndInit();
            this.mainLayout.ResumeLayout(false);
            this.rightLayout.ResumeLayout(false);
            this.rightLayout.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DataGridView suggestionTable;
        private TableLayoutPanel mainLayout;
        private TableLayoutPanel rightLayout;
        private Button SuggestFlipsButton;
        private TextBox textBox1;
        private Label CashStackLabel;
        private Button UpdatePricesButton;
        private DataGridViewTextBoxColumn ItemName;
        private DataGridViewTextBoxColumn DBBuyPrice;
        private DataGridViewTextBoxColumn WikiBuyPrice;
        private DataGridViewTextBoxColumn DBSellPrice;
        private DataGridViewTextBoxColumn WikiSellPrice;
        private DataGridViewTextBoxColumn BuyLimit;
        private DataGridViewTextBoxColumn Volume;
        private DataGridViewTextBoxColumn MarginColumn;
        private DataGridViewTextBoxColumn Profit;
    }
}
