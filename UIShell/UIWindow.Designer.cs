namespace UIShell
{
    partial class UIWindow
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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.FlipGetterButton = new System.Windows.Forms.Button();
            this.GESearchButton = new System.Windows.Forms.Button();
            this.HallofFlipsButton = new System.Windows.Forms.Button();
            this.AlchFinderButton = new System.Windows.Forms.Button();
            this.FlipTrackerButton = new System.Windows.Forms.Button();
            this.SettingsButton = new System.Windows.Forms.Button();
            this.FullScreenWindowButton = new System.Windows.Forms.Button();
            this.ExitButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pnlNav = new System.Windows.Forms.Panel();
            this.flipGetterForm = new UIShell.FlipGetter();
            this.geScraperForm = new UIShell.GEScraper();
            this.tableLayoutPanel1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.AutoSize = true;
            this.tableLayoutPanel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(24)))), ((int)(((byte)(24)))));
            this.tableLayoutPanel1.ColumnCount = 9;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 100F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 100F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 100F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 100F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 100F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 100F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 100F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 100F));
            this.tableLayoutPanel1.Controls.Add(this.FlipGetterButton, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.GESearchButton, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.HallofFlipsButton, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.AlchFinderButton, 3, 0);
            this.tableLayoutPanel1.Controls.Add(this.FlipTrackerButton, 4, 0);
            this.tableLayoutPanel1.Controls.Add(this.SettingsButton, 6, 0);
            this.tableLayoutPanel1.Controls.Add(this.FullScreenWindowButton, 7, 0);
            this.tableLayoutPanel1.Controls.Add(this.ExitButton, 8, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.tableLayoutPanel1.ForeColor = System.Drawing.Color.Yellow;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(3, 48);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(951, 42);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // FlipGetterButton
            // 
            this.FlipGetterButton.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.FlipGetterButton.AutoSize = true;
            this.FlipGetterButton.FlatAppearance.BorderSize = 0;
            this.FlipGetterButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.FlipGetterButton.Location = new System.Drawing.Point(3, 3);
            this.FlipGetterButton.Name = "FlipGetterButton";
            this.FlipGetterButton.Size = new System.Drawing.Size(94, 36);
            this.FlipGetterButton.TabIndex = 0;
            this.FlipGetterButton.Text = "Look for Flips";
            this.FlipGetterButton.UseVisualStyleBackColor = true;
            this.FlipGetterButton.Click += new System.EventHandler(this.FlipGetterButton_Click);
            // 
            // GESearchButton
            // 
            this.GESearchButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.GESearchButton.FlatAppearance.BorderSize = 0;
            this.GESearchButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.GESearchButton.Location = new System.Drawing.Point(103, 3);
            this.GESearchButton.Name = "GESearchButton";
            this.GESearchButton.Size = new System.Drawing.Size(94, 36);
            this.GESearchButton.TabIndex = 1;
            this.GESearchButton.Text = "GE Search";
            this.GESearchButton.UseVisualStyleBackColor = true;
            this.GESearchButton.Click += new System.EventHandler(this.GESearchButton_Click);
            // 
            // HallofFlipsButton
            // 
            this.HallofFlipsButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.HallofFlipsButton.FlatAppearance.BorderSize = 0;
            this.HallofFlipsButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.HallofFlipsButton.Location = new System.Drawing.Point(203, 3);
            this.HallofFlipsButton.Name = "HallofFlipsButton";
            this.HallofFlipsButton.Size = new System.Drawing.Size(94, 36);
            this.HallofFlipsButton.TabIndex = 2;
            this.HallofFlipsButton.Text = "Hall of Flips";
            this.HallofFlipsButton.UseVisualStyleBackColor = true;
            // 
            // AlchFinderButton
            // 
            this.AlchFinderButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.AlchFinderButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.AlchFinderButton.Location = new System.Drawing.Point(303, 3);
            this.AlchFinderButton.Name = "AlchFinderButton";
            this.AlchFinderButton.Size = new System.Drawing.Size(94, 36);
            this.AlchFinderButton.TabIndex = 3;
            this.AlchFinderButton.Text = "Find High Alchs";
            this.AlchFinderButton.UseVisualStyleBackColor = true;
            // 
            // FlipTrackerButton
            // 
            this.FlipTrackerButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.FlipTrackerButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.FlipTrackerButton.Location = new System.Drawing.Point(403, 3);
            this.FlipTrackerButton.Name = "FlipTrackerButton";
            this.FlipTrackerButton.Size = new System.Drawing.Size(94, 36);
            this.FlipTrackerButton.TabIndex = 5;
            this.FlipTrackerButton.Text = "Track Flips";
            this.FlipTrackerButton.UseVisualStyleBackColor = true;
            // 
            // SettingsButton
            // 
            this.SettingsButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.SettingsButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.SettingsButton.Location = new System.Drawing.Point(654, 3);
            this.SettingsButton.Name = "SettingsButton";
            this.SettingsButton.Size = new System.Drawing.Size(94, 36);
            this.SettingsButton.TabIndex = 4;
            this.SettingsButton.Text = "Settings";
            this.SettingsButton.UseVisualStyleBackColor = true;
            this.SettingsButton.Click += new System.EventHandler(this.SettingsButton_Click);
            // 
            // FullScreenWindowButton
            // 
            this.FullScreenWindowButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.FullScreenWindowButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.FullScreenWindowButton.Location = new System.Drawing.Point(754, 3);
            this.FullScreenWindowButton.Name = "FullScreenWindowButton";
            this.FullScreenWindowButton.Size = new System.Drawing.Size(94, 36);
            this.FullScreenWindowButton.TabIndex = 6;
            this.FullScreenWindowButton.Text = "Resize Window";
            this.FullScreenWindowButton.UseVisualStyleBackColor = true;
            // 
            // ExitButton
            // 
            this.ExitButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ExitButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.ExitButton.Location = new System.Drawing.Point(854, 3);
            this.ExitButton.Name = "ExitButton";
            this.ExitButton.Size = new System.Drawing.Size(94, 36);
            this.ExitButton.TabIndex = 7;
            this.ExitButton.Text = "Exit";
            this.ExitButton.UseVisualStyleBackColor = true;
            this.ExitButton.Click += new System.EventHandler(this.ExitButton_Click);
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(24)))), ((int)(((byte)(24)))));
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Font = new System.Drawing.Font("Lucida Console", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.Yellow;
            this.label1.Location = new System.Drawing.Point(3, 3);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(951, 35);
            this.label1.TabIndex = 2;
            this.label1.Text = "Flipscraper - The Ultimate OSRS Moneymaking Tool";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.label1_MouseDown);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(24)))), ((int)(((byte)(24)))));
            this.panel1.Controls.Add(this.pnlNav);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(3, 38);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(951, 10);
            this.panel1.TabIndex = 4;
            // 
            // pnlNav
            // 
            this.pnlNav.BackColor = System.Drawing.Color.Yellow;
            this.pnlNav.Location = new System.Drawing.Point(103, 5);
            this.pnlNav.Name = "pnlNav";
            this.pnlNav.Size = new System.Drawing.Size(94, 5);
            this.pnlNav.TabIndex = 0;
            this.pnlNav.Visible = false;
            // 
            // flipGetterForm
            // 
            this.flipGetterForm.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(24)))), ((int)(((byte)(24)))));
            this.flipGetterForm.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flipGetterForm.Font = new System.Drawing.Font("Lucida Sans Unicode", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.flipGetterForm.Location = new System.Drawing.Point(3, 90);
            this.flipGetterForm.Margin = new System.Windows.Forms.Padding(4);
            this.flipGetterForm.Name = "flipGetterForm";
            this.flipGetterForm.Size = new System.Drawing.Size(951, 385);
            this.flipGetterForm.TabIndex = 5;
            this.flipGetterForm.Visible = false;
            // 
            // geScraperForm
            // 
            this.geScraperForm.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.geScraperForm.Dock = System.Windows.Forms.DockStyle.Fill;
            this.geScraperForm.Font = new System.Drawing.Font("Lucida Sans Unicode", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.geScraperForm.Location = new System.Drawing.Point(3, 90);
            this.geScraperForm.Name = "geScraperForm";
            this.geScraperForm.Size = new System.Drawing.Size(951, 385);
            this.geScraperForm.TabIndex = 6;
            this.geScraperForm.Visible = false;
            // 
            // UIWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(24)))), ((int)(((byte)(24)))));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(957, 478);
            this.Controls.Add(this.geScraperForm);
            this.Controls.Add(this.flipGetterForm);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label1);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Lucida Console", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Name = "UIWindow";
            this.Padding = new System.Windows.Forms.Padding(3);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Flipscape";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.UIWindow_FormClosed);
            this.Load += new System.EventHandler(this.UIWindow_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TableLayoutPanel tableLayoutPanel1;
        private Button FlipGetterButton;
        private Button GESearchButton;
        private Button HallofFlipsButton;
        private Button AlchFinderButton;
        private Button FlipTrackerButton;
        private Button SettingsButton;
        private Button FullScreenWindowButton;
        private Button ExitButton;
        private Label label1;
        private Panel panel1;
        private Panel pnlNav;
        private FlipGetter flipGetterForm;
        private GEScraper geScraperForm;
    }
}