namespace BearGame
{
    partial class BearGameProject
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
            ViewControlPanel = new Panel();
            StatisticsViewButton = new Button();
            GameViewButton = new Button();
            GameView = new Panel();
            GameTablePanel = new Panel();
            RC4 = new TextBox();
            RC3 = new TextBox();
            RC2 = new TextBox();
            RC1 = new TextBox();
            YC4 = new TextBox();
            YC3 = new TextBox();
            YC2 = new TextBox();
            YC1 = new TextBox();
            GameConfigPanel = new Panel();
            GameConfigLabel = new Label();
            ViewControlPanel.SuspendLayout();
            GameView.SuspendLayout();
            GameTablePanel.SuspendLayout();
            GameConfigPanel.SuspendLayout();
            SuspendLayout();
            // 
            // ViewControlPanel
            // 
            ViewControlPanel.BackColor = SystemColors.Control;
            ViewControlPanel.BorderStyle = BorderStyle.FixedSingle;
            ViewControlPanel.Controls.Add(StatisticsViewButton);
            ViewControlPanel.Controls.Add(GameViewButton);
            ViewControlPanel.Dock = DockStyle.Top;
            ViewControlPanel.Location = new Point(0, 0);
            ViewControlPanel.Name = "ViewControlPanel";
            ViewControlPanel.Size = new Size(1295, 33);
            ViewControlPanel.TabIndex = 0;
            // 
            // StatisticsViewButton
            // 
            StatisticsViewButton.Dock = DockStyle.Left;
            StatisticsViewButton.FlatStyle = FlatStyle.Flat;
            StatisticsViewButton.Location = new Point(168, 0);
            StatisticsViewButton.Name = "StatisticsViewButton";
            StatisticsViewButton.Size = new Size(168, 31);
            StatisticsViewButton.TabIndex = 2;
            StatisticsViewButton.Text = "StatisticsView";
            StatisticsViewButton.UseVisualStyleBackColor = true;
            // 
            // GameViewButton
            // 
            GameViewButton.Dock = DockStyle.Left;
            GameViewButton.FlatStyle = FlatStyle.Flat;
            GameViewButton.Location = new Point(0, 0);
            GameViewButton.Name = "GameViewButton";
            GameViewButton.Size = new Size(168, 31);
            GameViewButton.TabIndex = 1;
            GameViewButton.Text = "GameView";
            GameViewButton.UseVisualStyleBackColor = true;
            GameViewButton.Click += GameViewButton_Click;
            // 
            // GameView
            // 
            GameView.Controls.Add(GameTablePanel);
            GameView.Controls.Add(GameConfigPanel);
            GameView.Dock = DockStyle.Fill;
            GameView.Location = new Point(0, 33);
            GameView.Name = "GameView";
            GameView.Size = new Size(1295, 492);
            GameView.TabIndex = 1;
            // 
            // GameTablePanel
            // 
            GameTablePanel.BorderStyle = BorderStyle.FixedSingle;
            GameTablePanel.Controls.Add(RC4);
            GameTablePanel.Controls.Add(RC3);
            GameTablePanel.Controls.Add(RC2);
            GameTablePanel.Controls.Add(RC1);
            GameTablePanel.Controls.Add(YC4);
            GameTablePanel.Controls.Add(YC3);
            GameTablePanel.Controls.Add(YC2);
            GameTablePanel.Controls.Add(YC1);
            GameTablePanel.Dock = DockStyle.Fill;
            GameTablePanel.Location = new Point(0, 0);
            GameTablePanel.Name = "GameTablePanel";
            GameTablePanel.Size = new Size(1096, 492);
            GameTablePanel.TabIndex = 1;
            // 
            // RC4
            // 
            RC4.BackColor = Color.Red;
            RC4.ForeColor = Color.Yellow;
            RC4.Location = new Point(1020, 85);
            RC4.Name = "RC4";
            RC4.ReadOnly = true;
            RC4.Size = new Size(27, 27);
            RC4.TabIndex = 7;
            RC4.Tag = "";
            RC4.Text = "C";
            RC4.TextAlign = HorizontalAlignment.Center;
            // 
            // RC3
            // 
            RC3.BackColor = Color.Red;
            RC3.ForeColor = Color.Yellow;
            RC3.Location = new Point(968, 85);
            RC3.Name = "RC3";
            RC3.ReadOnly = true;
            RC3.Size = new Size(27, 27);
            RC3.TabIndex = 6;
            RC3.Tag = "";
            RC3.Text = "C";
            RC3.TextAlign = HorizontalAlignment.Center;
            // 
            // RC2
            // 
            RC2.BackColor = Color.Red;
            RC2.ForeColor = Color.Yellow;
            RC2.Location = new Point(1020, 38);
            RC2.Name = "RC2";
            RC2.ReadOnly = true;
            RC2.Size = new Size(27, 27);
            RC2.TabIndex = 5;
            RC2.Tag = "";
            RC2.Text = "C";
            RC2.TextAlign = HorizontalAlignment.Center;
            // 
            // RC1
            // 
            RC1.BackColor = Color.Red;
            RC1.ForeColor = Color.Yellow;
            RC1.Location = new Point(968, 38);
            RC1.Name = "RC1";
            RC1.ReadOnly = true;
            RC1.Size = new Size(27, 27);
            RC1.TabIndex = 4;
            RC1.Tag = "";
            RC1.Text = "C";
            RC1.TextAlign = HorizontalAlignment.Center;
            // 
            // YC4
            // 
            YC4.BackColor = Color.Yellow;
            YC4.ForeColor = Color.Blue;
            YC4.Location = new Point(112, 85);
            YC4.Name = "YC4";
            YC4.ReadOnly = true;
            YC4.Size = new Size(27, 27);
            YC4.TabIndex = 3;
            YC4.Tag = "";
            YC4.Text = "C";
            YC4.TextAlign = HorizontalAlignment.Center;
            // 
            // YC3
            // 
            YC3.BackColor = Color.Yellow;
            YC3.ForeColor = Color.Blue;
            YC3.Location = new Point(60, 85);
            YC3.Name = "YC3";
            YC3.ReadOnly = true;
            YC3.Size = new Size(27, 27);
            YC3.TabIndex = 2;
            YC3.Tag = "";
            YC3.Text = "C";
            YC3.TextAlign = HorizontalAlignment.Center;
            // 
            // YC2
            // 
            YC2.BackColor = Color.Yellow;
            YC2.ForeColor = Color.Blue;
            YC2.Location = new Point(112, 38);
            YC2.Name = "YC2";
            YC2.ReadOnly = true;
            YC2.Size = new Size(27, 27);
            YC2.TabIndex = 1;
            YC2.Tag = "";
            YC2.Text = "C";
            YC2.TextAlign = HorizontalAlignment.Center;
            // 
            // YC1
            // 
            YC1.BackColor = Color.Yellow;
            YC1.ForeColor = Color.Blue;
            YC1.Location = new Point(60, 38);
            YC1.Name = "YC1";
            YC1.ReadOnly = true;
            YC1.Size = new Size(27, 27);
            YC1.TabIndex = 0;
            YC1.Tag = "";
            YC1.Text = "C";
            YC1.TextAlign = HorizontalAlignment.Center;
            // 
            // GameConfigPanel
            // 
            GameConfigPanel.BorderStyle = BorderStyle.FixedSingle;
            GameConfigPanel.Controls.Add(GameConfigLabel);
            GameConfigPanel.Dock = DockStyle.Right;
            GameConfigPanel.Location = new Point(1096, 0);
            GameConfigPanel.Name = "GameConfigPanel";
            GameConfigPanel.Size = new Size(199, 492);
            GameConfigPanel.TabIndex = 0;
            // 
            // GameConfigLabel
            // 
            GameConfigLabel.AutoSize = true;
            GameConfigLabel.Dock = DockStyle.Top;
            GameConfigLabel.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 238);
            GameConfigLabel.Location = new Point(0, 0);
            GameConfigLabel.Name = "GameConfigLabel";
            GameConfigLabel.Size = new Size(128, 28);
            GameConfigLabel.TabIndex = 0;
            GameConfigLabel.Text = "GameConfig";
            GameConfigLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // BearGameProject
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1295, 525);
            Controls.Add(GameView);
            Controls.Add(ViewControlPanel);
            DoubleBuffered = true;
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Name = "BearGameProject";
            Text = "BearGameProject";
            WindowState = FormWindowState.Maximized;
            ViewControlPanel.ResumeLayout(false);
            GameView.ResumeLayout(false);
            GameTablePanel.ResumeLayout(false);
            GameTablePanel.PerformLayout();
            GameConfigPanel.ResumeLayout(false);
            GameConfigPanel.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel ViewControlPanel;
        private Button GameViewButton;
        private Button StatisticsViewButton;
        private Panel GameView;
        private Panel GameTablePanel;
        private Panel GameConfigPanel;
        private Label GameConfigLabel;
        private TextBox YC1;
        private TextBox YC4;
        private TextBox YC3;
        private TextBox YC2;
        private TextBox RC4;
        private TextBox RC3;
        private TextBox RC2;
        private TextBox RC1;
    }
}
