
namespace Runescraper_v5._13
{
    partial class Form1
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.scrape_btn = new System.Windows.Forms.Button();
            this.itemGridView = new System.Windows.Forms.DataGridView();
            this.name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.low = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.high = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.volume = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.limit = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cost = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.margin = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.roi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.profit = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.apply_btn = new System.Windows.Forms.Button();
            this.min_buy_lbl = new System.Windows.Forms.Label();
            this.min_buy_tbox = new System.Windows.Forms.TextBox();
            this.max_buy_lbl = new System.Windows.Forms.Label();
            this.max_buy_tbox = new System.Windows.Forms.TextBox();
            this.min_sell_lbl = new System.Windows.Forms.Label();
            this.min_sell_tbox = new System.Windows.Forms.TextBox();
            this.max_sell_tbox = new System.Windows.Forms.TextBox();
            this.max_sell_lbl = new System.Windows.Forms.Label();
            this.min_volume_tbox = new System.Windows.Forms.TextBox();
            this.min_volume_lbl = new System.Windows.Forms.Label();
            this.cash_stk_tbox = new System.Windows.Forms.TextBox();
            this.cash_stk_lbl = new System.Windows.Forms.Label();
            this.min_margin_tbox = new System.Windows.Forms.TextBox();
            this.min_margin_lbl = new System.Windows.Forms.Label();
            this.min_profit_tbox = new System.Windows.Forms.TextBox();
            this.min_profit_lbl = new System.Windows.Forms.Label();
            this.suggest_item_btn = new System.Windows.Forms.Button();
            this.delete_items_btn = new System.Windows.Forms.Button();
            this.update_btn = new System.Windows.Forms.Button();
            this.cleanse_btn = new System.Windows.Forms.Button();
            this.add_btn = new System.Windows.Forms.Button();
            this.add_tbox = new System.Windows.Forms.TextBox();
            this.add_lbl = new System.Windows.Forms.Label();
            this.splitter1 = new System.Windows.Forms.Splitter();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.itemGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // scrape_btn
            // 
            this.scrape_btn.Location = new System.Drawing.Point(1162, 551);
            this.scrape_btn.Name = "scrape_btn";
            this.scrape_btn.Size = new System.Drawing.Size(87, 23);
            this.scrape_btn.TabIndex = 0;
            this.scrape_btn.Text = "Scrape";
            this.scrape_btn.UseVisualStyleBackColor = true;
            this.scrape_btn.Click += new System.EventHandler(this.scrape_btn_Click_1);
            // 
            // itemGridView
            // 
            this.itemGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.itemGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.name,
            this.low,
            this.high,
            this.volume,
            this.limit,
            this.cost,
            this.margin,
            this.roi,
            this.profit});
            this.itemGridView.Location = new System.Drawing.Point(12, 23);
            this.itemGridView.Name = "itemGridView";
            this.itemGridView.Size = new System.Drawing.Size(1050, 551);
            this.itemGridView.TabIndex = 1;
            this.itemGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // name
            // 
            this.name.HeaderText = "Name";
            this.name.Name = "name";
            // 
            // low
            // 
            this.low.HeaderText = "Buy Price";
            this.low.Name = "low";
            // 
            // high
            // 
            this.high.HeaderText = "Sell Price";
            this.high.Name = "high";
            // 
            // volume
            // 
            this.volume.HeaderText = "Volume";
            this.volume.Name = "volume";
            // 
            // limit
            // 
            this.limit.HeaderText = "Buy Limit";
            this.limit.Name = "limit";
            // 
            // cost
            // 
            this.cost.HeaderText = "Cost";
            this.cost.Name = "cost";
            // 
            // margin
            // 
            this.margin.HeaderText = "Margin";
            this.margin.Name = "margin";
            // 
            // roi
            // 
            this.roi.HeaderText = "ROI";
            this.roi.Name = "roi";
            // 
            // profit
            // 
            this.profit.HeaderText = "Profit";
            this.profit.Name = "profit";
            // 
            // apply_btn
            // 
            this.apply_btn.Location = new System.Drawing.Point(1072, 551);
            this.apply_btn.Name = "apply_btn";
            this.apply_btn.Size = new System.Drawing.Size(84, 23);
            this.apply_btn.TabIndex = 2;
            this.apply_btn.Text = "Apply";
            this.apply_btn.UseVisualStyleBackColor = true;
            this.apply_btn.Click += new System.EventHandler(this.apply_Click);
            // 
            // min_buy_lbl
            // 
            this.min_buy_lbl.AutoSize = true;
            this.min_buy_lbl.Location = new System.Drawing.Point(1069, 23);
            this.min_buy_lbl.Name = "min_buy_lbl";
            this.min_buy_lbl.Size = new System.Drawing.Size(72, 13);
            this.min_buy_lbl.TabIndex = 3;
            this.min_buy_lbl.Text = "Min Buy Price";
            // 
            // min_buy_tbox
            // 
            this.min_buy_tbox.Location = new System.Drawing.Point(1069, 40);
            this.min_buy_tbox.Name = "min_buy_tbox";
            this.min_buy_tbox.Size = new System.Drawing.Size(180, 20);
            this.min_buy_tbox.TabIndex = 4;
            // 
            // max_buy_lbl
            // 
            this.max_buy_lbl.AutoSize = true;
            this.max_buy_lbl.Location = new System.Drawing.Point(1069, 67);
            this.max_buy_lbl.Name = "max_buy_lbl";
            this.max_buy_lbl.Size = new System.Drawing.Size(75, 13);
            this.max_buy_lbl.TabIndex = 5;
            this.max_buy_lbl.Text = "Max Buy Price";
            // 
            // max_buy_tbox
            // 
            this.max_buy_tbox.Location = new System.Drawing.Point(1069, 84);
            this.max_buy_tbox.Name = "max_buy_tbox";
            this.max_buy_tbox.Size = new System.Drawing.Size(180, 20);
            this.max_buy_tbox.TabIndex = 6;
            // 
            // min_sell_lbl
            // 
            this.min_sell_lbl.AutoSize = true;
            this.min_sell_lbl.Location = new System.Drawing.Point(1069, 111);
            this.min_sell_lbl.Name = "min_sell_lbl";
            this.min_sell_lbl.Size = new System.Drawing.Size(71, 13);
            this.min_sell_lbl.TabIndex = 7;
            this.min_sell_lbl.Text = "Min Sell Price";
            // 
            // min_sell_tbox
            // 
            this.min_sell_tbox.Location = new System.Drawing.Point(1069, 128);
            this.min_sell_tbox.Name = "min_sell_tbox";
            this.min_sell_tbox.Size = new System.Drawing.Size(180, 20);
            this.min_sell_tbox.TabIndex = 8;
            // 
            // max_sell_tbox
            // 
            this.max_sell_tbox.Location = new System.Drawing.Point(1069, 167);
            this.max_sell_tbox.Name = "max_sell_tbox";
            this.max_sell_tbox.Size = new System.Drawing.Size(180, 20);
            this.max_sell_tbox.TabIndex = 10;
            // 
            // max_sell_lbl
            // 
            this.max_sell_lbl.AutoSize = true;
            this.max_sell_lbl.Location = new System.Drawing.Point(1068, 151);
            this.max_sell_lbl.Name = "max_sell_lbl";
            this.max_sell_lbl.Size = new System.Drawing.Size(74, 13);
            this.max_sell_lbl.TabIndex = 9;
            this.max_sell_lbl.Text = "Max Sell Price";
            // 
            // min_volume_tbox
            // 
            this.min_volume_tbox.Location = new System.Drawing.Point(1071, 206);
            this.min_volume_tbox.Name = "min_volume_tbox";
            this.min_volume_tbox.Size = new System.Drawing.Size(180, 20);
            this.min_volume_tbox.TabIndex = 12;
            // 
            // min_volume_lbl
            // 
            this.min_volume_lbl.AutoSize = true;
            this.min_volume_lbl.Location = new System.Drawing.Point(1068, 190);
            this.min_volume_lbl.Name = "min_volume_lbl";
            this.min_volume_lbl.Size = new System.Drawing.Size(62, 13);
            this.min_volume_lbl.TabIndex = 11;
            this.min_volume_lbl.Text = "Min Volume";
            // 
            // cash_stk_tbox
            // 
            this.cash_stk_tbox.Location = new System.Drawing.Point(1068, 401);
            this.cash_stk_tbox.Name = "cash_stk_tbox";
            this.cash_stk_tbox.Size = new System.Drawing.Size(180, 20);
            this.cash_stk_tbox.TabIndex = 14;
            // 
            // cash_stk_lbl
            // 
            this.cash_stk_lbl.AutoSize = true;
            this.cash_stk_lbl.Location = new System.Drawing.Point(1068, 384);
            this.cash_stk_lbl.Name = "cash_stk_lbl";
            this.cash_stk_lbl.Size = new System.Drawing.Size(62, 13);
            this.cash_stk_lbl.TabIndex = 13;
            this.cash_stk_lbl.Text = "Cash Stack";
            // 
            // min_margin_tbox
            // 
            this.min_margin_tbox.Location = new System.Drawing.Point(1069, 245);
            this.min_margin_tbox.Name = "min_margin_tbox";
            this.min_margin_tbox.Size = new System.Drawing.Size(180, 20);
            this.min_margin_tbox.TabIndex = 17;
            // 
            // min_margin_lbl
            // 
            this.min_margin_lbl.AutoSize = true;
            this.min_margin_lbl.Location = new System.Drawing.Point(1068, 229);
            this.min_margin_lbl.Name = "min_margin_lbl";
            this.min_margin_lbl.Size = new System.Drawing.Size(59, 13);
            this.min_margin_lbl.TabIndex = 16;
            this.min_margin_lbl.Text = "Min Margin";
            // 
            // min_profit_tbox
            // 
            this.min_profit_tbox.Location = new System.Drawing.Point(1068, 284);
            this.min_profit_tbox.Name = "min_profit_tbox";
            this.min_profit_tbox.Size = new System.Drawing.Size(180, 20);
            this.min_profit_tbox.TabIndex = 19;
            // 
            // min_profit_lbl
            // 
            this.min_profit_lbl.AutoSize = true;
            this.min_profit_lbl.Location = new System.Drawing.Point(1068, 268);
            this.min_profit_lbl.Name = "min_profit_lbl";
            this.min_profit_lbl.Size = new System.Drawing.Size(51, 13);
            this.min_profit_lbl.TabIndex = 18;
            this.min_profit_lbl.Text = "Min Profit";
            // 
            // suggest_item_btn
            // 
            this.suggest_item_btn.Location = new System.Drawing.Point(1068, 427);
            this.suggest_item_btn.Name = "suggest_item_btn";
            this.suggest_item_btn.Size = new System.Drawing.Size(177, 23);
            this.suggest_item_btn.TabIndex = 15;
            this.suggest_item_btn.Text = "Suggest Items";
            this.suggest_item_btn.UseVisualStyleBackColor = true;
            this.suggest_item_btn.Click += new System.EventHandler(this.suggest_items_btn_Click);
            // 
            // delete_items_btn
            // 
            this.delete_items_btn.Location = new System.Drawing.Point(1070, 524);
            this.delete_items_btn.Name = "delete_items_btn";
            this.delete_items_btn.Size = new System.Drawing.Size(177, 23);
            this.delete_items_btn.TabIndex = 20;
            this.delete_items_btn.Text = "Delete Items";
            this.delete_items_btn.UseVisualStyleBackColor = true;
            this.delete_items_btn.Click += new System.EventHandler(this.delete_items_btn_Click);
            // 
            // update_btn
            // 
            this.update_btn.Location = new System.Drawing.Point(1072, 495);
            this.update_btn.Name = "update_btn";
            this.update_btn.Size = new System.Drawing.Size(177, 23);
            this.update_btn.TabIndex = 21;
            this.update_btn.Text = "Update Prices";
            this.update_btn.UseVisualStyleBackColor = true;
            this.update_btn.Click += new System.EventHandler(this.update_btn_Click);
            // 
            // cleanse_btn
            // 
            this.cleanse_btn.Location = new System.Drawing.Point(1072, 457);
            this.cleanse_btn.Name = "cleanse_btn";
            this.cleanse_btn.Size = new System.Drawing.Size(173, 23);
            this.cleanse_btn.TabIndex = 22;
            this.cleanse_btn.Text = "Cleanse Unsafe Items";
            this.cleanse_btn.UseVisualStyleBackColor = true;
            this.cleanse_btn.Click += new System.EventHandler(this.cleanse_btn_Click);
            // 
            // add_btn
            // 
            this.add_btn.Location = new System.Drawing.Point(1070, 358);
            this.add_btn.Name = "add_btn";
            this.add_btn.Size = new System.Drawing.Size(175, 23);
            this.add_btn.TabIndex = 23;
            this.add_btn.Text = "Add Item";
            this.add_btn.UseVisualStyleBackColor = true;
            this.add_btn.Click += new System.EventHandler(this.add_btn_Click);
            // 
            // add_tbox
            // 
            this.add_tbox.Location = new System.Drawing.Point(1068, 332);
            this.add_tbox.Name = "add_tbox";
            this.add_tbox.Size = new System.Drawing.Size(180, 20);
            this.add_tbox.TabIndex = 24;
            // 
            // add_lbl
            // 
            this.add_lbl.AutoSize = true;
            this.add_lbl.Location = new System.Drawing.Point(1069, 311);
            this.add_lbl.Name = "add_lbl";
            this.add_lbl.Size = new System.Drawing.Size(58, 13);
            this.add_lbl.TabIndex = 25;
            this.add_lbl.Text = "Item Name";
            // 
            // splitter1
            // 
            this.splitter1.Location = new System.Drawing.Point(0, 0);
            this.splitter1.Name = "splitter1";
            this.splitter1.Size = new System.Drawing.Size(3, 586);
            this.splitter1.TabIndex = 26;
            this.splitter1.TabStop = false;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.Info;
            this.groupBox1.Location = new System.Drawing.Point(1058, 303);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(208, 92);
            this.groupBox1.TabIndex = 27;
            this.groupBox1.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1261, 586);
            this.Controls.Add(this.splitter1);
            this.Controls.Add(this.add_lbl);
            this.Controls.Add(this.add_tbox);
            this.Controls.Add(this.add_btn);
            this.Controls.Add(this.cleanse_btn);
            this.Controls.Add(this.update_btn);
            this.Controls.Add(this.delete_items_btn);
            this.Controls.Add(this.min_profit_tbox);
            this.Controls.Add(this.min_profit_lbl);
            this.Controls.Add(this.min_margin_tbox);
            this.Controls.Add(this.min_margin_lbl);
            this.Controls.Add(this.suggest_item_btn);
            this.Controls.Add(this.cash_stk_tbox);
            this.Controls.Add(this.cash_stk_lbl);
            this.Controls.Add(this.min_volume_tbox);
            this.Controls.Add(this.min_volume_lbl);
            this.Controls.Add(this.max_sell_tbox);
            this.Controls.Add(this.max_sell_lbl);
            this.Controls.Add(this.min_sell_tbox);
            this.Controls.Add(this.min_sell_lbl);
            this.Controls.Add(this.max_buy_tbox);
            this.Controls.Add(this.max_buy_lbl);
            this.Controls.Add(this.min_buy_tbox);
            this.Controls.Add(this.min_buy_lbl);
            this.Controls.Add(this.apply_btn);
            this.Controls.Add(this.itemGridView);
            this.Controls.Add(this.scrape_btn);
            this.Controls.Add(this.groupBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Runescraper";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.itemGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button scrape_btn;
        private System.Windows.Forms.DataGridView itemGridView;
        private System.Windows.Forms.Button apply_btn;
        private System.Windows.Forms.Label min_buy_lbl;
        private System.Windows.Forms.TextBox min_buy_tbox;
        private System.Windows.Forms.Label max_buy_lbl;
        private System.Windows.Forms.TextBox max_buy_tbox;
        private System.Windows.Forms.Label min_sell_lbl;
        private System.Windows.Forms.TextBox min_sell_tbox;
        private System.Windows.Forms.TextBox max_sell_tbox;
        private System.Windows.Forms.Label max_sell_lbl;
        private System.Windows.Forms.TextBox min_volume_tbox;
        private System.Windows.Forms.Label min_volume_lbl;
        private System.Windows.Forms.TextBox cash_stk_tbox;
        private System.Windows.Forms.Label cash_stk_lbl;
        private System.Windows.Forms.TextBox min_margin_tbox;
        private System.Windows.Forms.Label min_margin_lbl;
        private System.Windows.Forms.TextBox min_profit_tbox;
        private System.Windows.Forms.Label min_profit_lbl;
        private System.Windows.Forms.DataGridViewTextBoxColumn name;
        private System.Windows.Forms.DataGridViewTextBoxColumn low;
        private System.Windows.Forms.DataGridViewTextBoxColumn high;
        private System.Windows.Forms.DataGridViewTextBoxColumn volume;
        private System.Windows.Forms.DataGridViewTextBoxColumn limit;
        private System.Windows.Forms.DataGridViewTextBoxColumn cost;
        private System.Windows.Forms.DataGridViewTextBoxColumn margin;
        private System.Windows.Forms.DataGridViewTextBoxColumn roi;
        private System.Windows.Forms.DataGridViewTextBoxColumn profit;
        private System.Windows.Forms.Button suggest_item_btn;
        private System.Windows.Forms.Button delete_items_btn;
        private System.Windows.Forms.Button update_btn;
        private System.Windows.Forms.Button cleanse_btn;
        private System.Windows.Forms.Button add_btn;
        private System.Windows.Forms.TextBox add_tbox;
        private System.Windows.Forms.Label add_lbl;
        private System.Windows.Forms.Splitter splitter1;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}

