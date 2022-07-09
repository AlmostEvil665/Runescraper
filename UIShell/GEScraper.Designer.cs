namespace UIShell
{
    partial class GEScraper
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.rightLayout = new System.Windows.Forms.TableLayoutPanel();
            this.SuggestFlipsButton = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.ItemSearchLabel = new System.Windows.Forms.Label();
            this.UpdatePricesButton = new System.Windows.Forms.Button();
            this.itemGridView = new System.Windows.Forms.DataGridView();
            this.ItemName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BuyPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SellPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BuyLimit = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DailyVolume = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MarginColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Profit = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tableLayoutPanel1.SuspendLayout();
            this.rightLayout.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.itemGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 90F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel1.Controls.Add(this.rightLayout, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.itemGridView, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(900, 600);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // rightLayout
            // 
            this.rightLayout.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.rightLayout.ColumnCount = 1;
            this.rightLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.rightLayout.Controls.Add(this.SuggestFlipsButton, 0, 2);
            this.rightLayout.Controls.Add(this.textBox1, 0, 1);
            this.rightLayout.Controls.Add(this.ItemSearchLabel, 0, 0);
            this.rightLayout.Controls.Add(this.UpdatePricesButton, 0, 5);
            this.rightLayout.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rightLayout.Location = new System.Drawing.Point(814, 3);
            this.rightLayout.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.rightLayout.Name = "rightLayout";
            this.rightLayout.RowCount = 6;
            this.rightLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 48F));
            this.rightLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 26F));
            this.rightLayout.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.rightLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 87F));
            this.rightLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 17F));
            this.rightLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.rightLayout.Size = new System.Drawing.Size(82, 594);
            this.rightLayout.TabIndex = 2;
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
            this.SuggestFlipsButton.Size = new System.Drawing.Size(74, 59);
            this.SuggestFlipsButton.TabIndex = 1;
            this.SuggestFlipsButton.Text = "Add Item to Watch List";
            this.SuggestFlipsButton.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            this.textBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBox1.Location = new System.Drawing.Point(4, 51);
            this.textBox1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(74, 23);
            this.textBox1.TabIndex = 0;
            // 
            // ItemSearchLabel
            // 
            this.ItemSearchLabel.AutoSize = true;
            this.ItemSearchLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ItemSearchLabel.Location = new System.Drawing.Point(4, 0);
            this.ItemSearchLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.ItemSearchLabel.Name = "ItemSearchLabel";
            this.ItemSearchLabel.Size = new System.Drawing.Size(74, 48);
            this.ItemSearchLabel.TabIndex = 2;
            this.ItemSearchLabel.Text = "Item Search:";
            this.ItemSearchLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // UpdatePricesButton
            // 
            this.UpdatePricesButton.BackColor = System.Drawing.Color.SeaGreen;
            this.UpdatePricesButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.UpdatePricesButton.Font = new System.Drawing.Font("OCR A Extended", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.UpdatePricesButton.Location = new System.Drawing.Point(4, 246);
            this.UpdatePricesButton.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.UpdatePricesButton.Name = "UpdatePricesButton";
            this.UpdatePricesButton.Size = new System.Drawing.Size(74, 345);
            this.UpdatePricesButton.TabIndex = 3;
            this.UpdatePricesButton.Text = "UPDATE PRICES";
            this.UpdatePricesButton.UseVisualStyleBackColor = false;
            this.UpdatePricesButton.Click += new System.EventHandler(this.UpdatePricesButton_Click);
            // 
            // itemGridView
            // 
            this.itemGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.itemGridView.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Sunken;
            this.itemGridView.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.itemGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.itemGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.itemGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ItemName,
            this.BuyPrice,
            this.SellPrice,
            this.BuyLimit,
            this.DailyVolume,
            this.MarginColumn,
            this.Profit});
            this.itemGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.itemGridView.EnableHeadersVisualStyles = false;
            this.itemGridView.Location = new System.Drawing.Point(3, 3);
            this.itemGridView.Name = "itemGridView";
            this.itemGridView.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.itemGridView.RowTemplate.Height = 25;
            this.itemGridView.Size = new System.Drawing.Size(804, 594);
            this.itemGridView.TabIndex = 1;
            // 
            // ItemName
            // 
            this.ItemName.HeaderText = "Item Name";
            this.ItemName.Name = "ItemName";
            // 
            // BuyPrice
            // 
            this.BuyPrice.HeaderText = "Buy Price";
            this.BuyPrice.Name = "BuyPrice";
            // 
            // SellPrice
            // 
            this.SellPrice.HeaderText = "Sell Price";
            this.SellPrice.Name = "SellPrice";
            // 
            // BuyLimit
            // 
            this.BuyLimit.HeaderText = "Buy Limit";
            this.BuyLimit.Name = "BuyLimit";
            // 
            // DailyVolume
            // 
            this.DailyVolume.HeaderText = "Daily Volume";
            this.DailyVolume.Name = "DailyVolume";
            // 
            // MarginColumn
            // 
            this.MarginColumn.HeaderText = "Margin";
            this.MarginColumn.Name = "MarginColumn";
            // 
            // Profit
            // 
            this.Profit.HeaderText = "Profit";
            this.Profit.Name = "Profit";
            // 
            // GEScraper
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "GEScraper";
            this.Size = new System.Drawing.Size(900, 600);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.rightLayout.ResumeLayout(false);
            this.rightLayout.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.itemGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private TableLayoutPanel tableLayoutPanel1;
        private DataGridView itemGridView;
        private DataGridViewTextBoxColumn ItemName;
        private DataGridViewTextBoxColumn BuyPrice;
        private DataGridViewTextBoxColumn SellPrice;
        private DataGridViewTextBoxColumn BuyLimit;
        private DataGridViewTextBoxColumn DailyVolume;
        private DataGridViewTextBoxColumn MarginColumn;
        private DataGridViewTextBoxColumn Profit;
        private TableLayoutPanel rightLayout;
        private Button SuggestFlipsButton;
        private TextBox textBox1;
        private Label ItemSearchLabel;
        private Button UpdatePricesButton;
    }
}
