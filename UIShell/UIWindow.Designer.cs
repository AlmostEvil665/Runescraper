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
            this.FlipGetterForm = new UIShell.FlipGetter();
            this.label1 = new System.Windows.Forms.Label();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.BackColor = System.Drawing.SystemColors.ControlDark;
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
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 13);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(914, 45);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // FlipGetterButton
            // 
            this.FlipGetterButton.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.FlipGetterButton.AutoSize = true;
            this.FlipGetterButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.FlipGetterButton.Location = new System.Drawing.Point(3, 3);
            this.FlipGetterButton.Name = "FlipGetterButton";
            this.FlipGetterButton.Size = new System.Drawing.Size(94, 39);
            this.FlipGetterButton.TabIndex = 0;
            this.FlipGetterButton.Text = "Look for Flips";
            this.FlipGetterButton.UseVisualStyleBackColor = true;
            this.FlipGetterButton.Click += new System.EventHandler(this.FlipGetterButton_Click);
            // 
            // GESearchButton
            // 
            this.GESearchButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.GESearchButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.GESearchButton.Location = new System.Drawing.Point(103, 3);
            this.GESearchButton.Name = "GESearchButton";
            this.GESearchButton.Size = new System.Drawing.Size(94, 39);
            this.GESearchButton.TabIndex = 1;
            this.GESearchButton.Text = "GE Search";
            this.GESearchButton.UseVisualStyleBackColor = true;
            this.GESearchButton.Click += new System.EventHandler(this.GESearchButton_Click);
            // 
            // HallofFlipsButton
            // 
            this.HallofFlipsButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.HallofFlipsButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.HallofFlipsButton.Location = new System.Drawing.Point(203, 3);
            this.HallofFlipsButton.Name = "HallofFlipsButton";
            this.HallofFlipsButton.Size = new System.Drawing.Size(94, 39);
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
            this.AlchFinderButton.Size = new System.Drawing.Size(94, 39);
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
            this.FlipTrackerButton.Size = new System.Drawing.Size(94, 39);
            this.FlipTrackerButton.TabIndex = 5;
            this.FlipTrackerButton.Text = "Track Flips";
            this.FlipTrackerButton.UseVisualStyleBackColor = true;
            // 
            // SettingsButton
            // 
            this.SettingsButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.SettingsButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.SettingsButton.Location = new System.Drawing.Point(617, 3);
            this.SettingsButton.Name = "SettingsButton";
            this.SettingsButton.Size = new System.Drawing.Size(94, 39);
            this.SettingsButton.TabIndex = 4;
            this.SettingsButton.Text = "Settings";
            this.SettingsButton.UseVisualStyleBackColor = true;
            // 
            // FullScreenWindowButton
            // 
            this.FullScreenWindowButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.FullScreenWindowButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.FullScreenWindowButton.Location = new System.Drawing.Point(717, 3);
            this.FullScreenWindowButton.Name = "FullScreenWindowButton";
            this.FullScreenWindowButton.Size = new System.Drawing.Size(94, 39);
            this.FullScreenWindowButton.TabIndex = 6;
            this.FullScreenWindowButton.Text = "Resize Window";
            this.FullScreenWindowButton.UseVisualStyleBackColor = true;
            // 
            // ExitButton
            // 
            this.ExitButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ExitButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.ExitButton.Location = new System.Drawing.Point(817, 3);
            this.ExitButton.Name = "ExitButton";
            this.ExitButton.Size = new System.Drawing.Size(94, 39);
            this.ExitButton.TabIndex = 7;
            this.ExitButton.Text = "Exit";
            this.ExitButton.UseVisualStyleBackColor = true;
            // 
            // FlipGetterForm
            // 
            this.FlipGetterForm.AutoSize = true;
            this.FlipGetterForm.BackColor = System.Drawing.SystemColors.ControlDark;
            this.FlipGetterForm.Dock = System.Windows.Forms.DockStyle.Fill;
            this.FlipGetterForm.Font = new System.Drawing.Font("OCR A Extended", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.FlipGetterForm.Location = new System.Drawing.Point(0, 58);
            this.FlipGetterForm.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.FlipGetterForm.Name = "FlipGetterForm";
            this.FlipGetterForm.Size = new System.Drawing.Size(914, 332);
            this.FlipGetterForm.TabIndex = 1;
            this.FlipGetterForm.Visible = false;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.SystemColors.ControlDark;
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Font = new System.Drawing.Font("OCR A Extended", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(914, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Flipscraper - The Ultimate OSRS Moneymaking Tool";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // UIWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.BackgroundImage = global::UIShell.Properties.Resources.runescape;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(914, 390);
            this.Controls.Add(this.FlipGetterForm);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.label1);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("OCR A Extended", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Name = "UIWindow";
            this.Text = "Flipscape";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Resize += new System.EventHandler(this.Form1_Resize);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TableLayoutPanel tableLayoutPanel1;
        private FlipGetter FlipGetterForm;
        private Button FlipGetterButton;
        private Button GESearchButton;
        private Button HallofFlipsButton;
        private Button AlchFinderButton;
        private Button FlipTrackerButton;
        private Button SettingsButton;
        private Button FullScreenWindowButton;
        private Button ExitButton;
        private Label label1;
    }
}