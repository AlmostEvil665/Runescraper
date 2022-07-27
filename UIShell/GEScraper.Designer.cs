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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
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
            this.tableLayoutPanel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(24)))), ((int)(((byte)(24)))));
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
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1029, 640);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // rightLayout
            // 
            this.rightLayout.BackColor = System.Drawing.Color.Black;
            this.rightLayout.ColumnCount = 1;
            this.rightLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.rightLayout.Controls.Add(this.SuggestFlipsButton, 0, 2);
            this.rightLayout.Controls.Add(this.textBox1, 0, 1);
            this.rightLayout.Controls.Add(this.ItemSearchLabel, 0, 0);
            this.rightLayout.Controls.Add(this.UpdatePricesButton, 0, 5);
            this.rightLayout.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rightLayout.ForeColor = System.Drawing.Color.Yellow;
            this.rightLayout.Location = new System.Drawing.Point(931, 3);
            this.rightLayout.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.rightLayout.Name = "rightLayout";
            this.rightLayout.RowCount = 6;
            this.rightLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 51F));
            this.rightLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 28F));
            this.rightLayout.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.rightLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 93F));
            this.rightLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 18F));
            this.rightLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.rightLayout.Size = new System.Drawing.Size(93, 634);
            this.rightLayout.TabIndex = 2;
            // 
            // SuggestFlipsButton
            // 
            this.SuggestFlipsButton.AutoSize = true;
            this.SuggestFlipsButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(18)))), ((int)(((byte)(18)))));
            this.SuggestFlipsButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.SuggestFlipsButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SuggestFlipsButton.Location = new System.Drawing.Point(5, 82);
            this.SuggestFlipsButton.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.SuggestFlipsButton.Name = "SuggestFlipsButton";
            this.SuggestFlipsButton.Size = new System.Drawing.Size(83, 63);
            this.SuggestFlipsButton.TabIndex = 1;
            this.SuggestFlipsButton.Text = "Add Item to Watch List";
            this.SuggestFlipsButton.UseVisualStyleBackColor = false;
            // 
            // textBox1
            // 
            this.textBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBox1.Location = new System.Drawing.Point(5, 54);
            this.textBox1.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(83, 26);
            this.textBox1.TabIndex = 0;
            // 
            // ItemSearchLabel
            // 
            this.ItemSearchLabel.AutoSize = true;
            this.ItemSearchLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ItemSearchLabel.Location = new System.Drawing.Point(5, 0);
            this.ItemSearchLabel.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.ItemSearchLabel.Name = "ItemSearchLabel";
            this.ItemSearchLabel.Size = new System.Drawing.Size(83, 51);
            this.ItemSearchLabel.TabIndex = 2;
            this.ItemSearchLabel.Text = "Item Search:";
            this.ItemSearchLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // UpdatePricesButton
            // 
            this.UpdatePricesButton.BackColor = System.Drawing.Color.SeaGreen;
            this.UpdatePricesButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.UpdatePricesButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.UpdatePricesButton.Font = new System.Drawing.Font("Lucida Sans Unicode", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.UpdatePricesButton.Location = new System.Drawing.Point(5, 262);
            this.UpdatePricesButton.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.UpdatePricesButton.Name = "UpdatePricesButton";
            this.UpdatePricesButton.Size = new System.Drawing.Size(83, 369);
            this.UpdatePricesButton.TabIndex = 3;
            this.UpdatePricesButton.Text = "UPDATE PRICES";
            this.UpdatePricesButton.UseVisualStyleBackColor = false;
            this.UpdatePricesButton.Click += new System.EventHandler(this.UpdatePricesButton_Click);
            // 
            // itemGridView
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(18)))), ((int)(((byte)(18)))));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Yellow;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Yellow;
            this.itemGridView.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.itemGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.itemGridView.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.itemGridView.BackgroundColor = System.Drawing.Color.Black;
            this.itemGridView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.itemGridView.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.itemGridView.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Lucida Console", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Yellow;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.itemGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.itemGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.itemGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ItemName,
            this.BuyPrice,
            this.SellPrice,
            this.BuyLimit,
            this.DailyVolume,
            this.MarginColumn,
            this.Profit});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Lucida Console", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Yellow;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.itemGridView.DefaultCellStyle = dataGridViewCellStyle3;
            this.itemGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.itemGridView.EnableHeadersVisualStyles = false;
            this.itemGridView.Location = new System.Drawing.Point(3, 3);
            this.itemGridView.Name = "itemGridView";
            this.itemGridView.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.Gold;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.itemGridView.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.itemGridView.RowTemplate.Height = 25;
            this.itemGridView.Size = new System.Drawing.Size(920, 634);
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
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.Controls.Add(this.tableLayoutPanel1);
            this.Font = new System.Drawing.Font("Lucida Sans Unicode", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Name = "GEScraper";
            this.Size = new System.Drawing.Size(1029, 640);
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
