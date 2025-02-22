namespace BearGame;

partial class PlayerSettings
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
        SettingOkButton = new Button();
        SettingCancelButton = new Button();
        GoWithRandomBox = new CheckBox();
        GoWithClosestBox = new CheckBox();
        GoWithTheFurthestBox = new CheckBox();
        GoForKOsBox = new CheckBox();
        SetNewCharActiveBox = new CheckBox();
        GoOutOfStartBox = new CheckBox();
        SuspendLayout();
        // 
        // SettingOkButton
        // 
        SettingOkButton.DialogResult = DialogResult.OK;
        SettingOkButton.FlatStyle = FlatStyle.Flat;
        SettingOkButton.Font = new Font("Segoe UI", 13F, FontStyle.Bold, GraphicsUnit.Point, 238);
        SettingOkButton.Location = new Point(666, 381);
        SettingOkButton.Name = "SettingOkButton";
        SettingOkButton.Size = new Size(107, 57);
        SettingOkButton.TabIndex = 0;
        SettingOkButton.Text = "Ok";
        SettingOkButton.UseVisualStyleBackColor = true;
        SettingOkButton.Click += SettingOkButton_Click;
        // 
        // SettingCancelButton
        // 
        SettingCancelButton.DialogResult = DialogResult.Cancel;
        SettingCancelButton.FlatStyle = FlatStyle.Flat;
        SettingCancelButton.Font = new Font("Segoe UI", 13F, FontStyle.Bold, GraphicsUnit.Point, 238);
        SettingCancelButton.Location = new Point(21, 383);
        SettingCancelButton.Name = "SettingCancelButton";
        SettingCancelButton.Size = new Size(107, 57);
        SettingCancelButton.TabIndex = 1;
        SettingCancelButton.Text = "Cancel";
        SettingCancelButton.UseVisualStyleBackColor = true;
        SettingCancelButton.Click += SettingCancelButton_Click;
        // 
        // GoWithRandomBox
        // 
        GoWithRandomBox.AutoSize = true;
        GoWithRandomBox.Checked = true;
        GoWithRandomBox.CheckState = CheckState.Checked;
        GoWithRandomBox.FlatStyle = FlatStyle.Flat;
        GoWithRandomBox.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point, 238);
        GoWithRandomBox.ForeColor = SystemColors.WindowText;
        GoWithRandomBox.Location = new Point(27, 35);
        GoWithRandomBox.Name = "GoWithRandomBox";
        GoWithRandomBox.Size = new Size(409, 34);
        GoWithRandomBox.TabIndex = 2;
        GoWithRandomBox.Text = "If possible, go with a random character";
        GoWithRandomBox.UseVisualStyleBackColor = true;
        GoWithRandomBox.CheckedChanged += GoWithRandomBox_CheckedChanged;
        // 
        // GoWithClosestBox
        // 
        GoWithClosestBox.AutoSize = true;
        GoWithClosestBox.FlatStyle = FlatStyle.Flat;
        GoWithClosestBox.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point, 238);
        GoWithClosestBox.ForeColor = SystemColors.WindowText;
        GoWithClosestBox.Location = new Point(27, 75);
        GoWithClosestBox.Name = "GoWithClosestBox";
        GoWithClosestBox.Size = new Size(615, 34);
        GoWithClosestBox.TabIndex = 3;
        GoWithClosestBox.Text = "If possible, go with the closest character to the starting point";
        GoWithClosestBox.UseVisualStyleBackColor = true;
        GoWithClosestBox.CheckedChanged += GoWithClosestBox_CheckedChanged;
        // 
        // GoWithTheFurthestBox
        // 
        GoWithTheFurthestBox.AutoSize = true;
        GoWithTheFurthestBox.FlatStyle = FlatStyle.Flat;
        GoWithTheFurthestBox.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point, 238);
        GoWithTheFurthestBox.ForeColor = SystemColors.WindowText;
        GoWithTheFurthestBox.Location = new Point(27, 115);
        GoWithTheFurthestBox.Name = "GoWithTheFurthestBox";
        GoWithTheFurthestBox.Size = new Size(651, 34);
        GoWithTheFurthestBox.TabIndex = 4;
        GoWithTheFurthestBox.Text = "If possible, go with the furthest cahracter from the starting point";
        GoWithTheFurthestBox.UseVisualStyleBackColor = true;
        GoWithTheFurthestBox.CheckedChanged += GoWithTheFurthestBox_CheckedChanged;
        // 
        // GoForKOsBox
        // 
        GoForKOsBox.AutoSize = true;
        GoForKOsBox.Checked = true;
        GoForKOsBox.CheckState = CheckState.Checked;
        GoForKOsBox.FlatStyle = FlatStyle.Flat;
        GoForKOsBox.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point, 238);
        GoForKOsBox.ForeColor = SystemColors.WindowText;
        GoForKOsBox.Location = new Point(27, 232);
        GoForKOsBox.Name = "GoForKOsBox";
        GoForKOsBox.Size = new Size(377, 34);
        GoForKOsBox.TabIndex = 5;
        GoForKOsBox.Text = "When possible, prioritize knockouts";
        GoForKOsBox.UseVisualStyleBackColor = true;
        // 
        // SetNewCharActiveBox
        // 
        SetNewCharActiveBox.AutoSize = true;
        SetNewCharActiveBox.Checked = true;
        SetNewCharActiveBox.CheckState = CheckState.Checked;
        SetNewCharActiveBox.FlatStyle = FlatStyle.Flat;
        SetNewCharActiveBox.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point, 238);
        SetNewCharActiveBox.ForeColor = SystemColors.WindowText;
        SetNewCharActiveBox.Location = new Point(27, 281);
        SetNewCharActiveBox.Name = "SetNewCharActiveBox";
        SetNewCharActiveBox.Size = new Size(668, 34);
        SetNewCharActiveBox.TabIndex = 6;
        SetNewCharActiveBox.Text = "If possilbe, when rolling 6, prioritize setting a new character active";
        SetNewCharActiveBox.UseVisualStyleBackColor = true;
        // 
        // GoOutOfStartBox
        // 
        GoOutOfStartBox.AutoSize = true;
        GoOutOfStartBox.Checked = true;
        GoOutOfStartBox.CheckState = CheckState.Checked;
        GoOutOfStartBox.FlatStyle = FlatStyle.Flat;
        GoOutOfStartBox.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point, 238);
        GoOutOfStartBox.ForeColor = SystemColors.WindowText;
        GoOutOfStartBox.Location = new Point(27, 325);
        GoOutOfStartBox.Name = "GoOutOfStartBox";
        GoOutOfStartBox.Size = new Size(506, 34);
        GoOutOfStartBox.TabIndex = 7;
        GoOutOfStartBox.Text = "If possible, prioritize moving out of starting point";
        GoOutOfStartBox.UseVisualStyleBackColor = true;
        // 
        // PlayerSettings
        // 
        AutoScaleDimensions = new SizeF(10F, 25F);
        AutoScaleMode = AutoScaleMode.Font;
        ClientSize = new Size(780, 448);
        ControlBox = false;
        Controls.Add(GoOutOfStartBox);
        Controls.Add(SetNewCharActiveBox);
        Controls.Add(GoForKOsBox);
        Controls.Add(GoWithTheFurthestBox);
        Controls.Add(GoWithClosestBox);
        Controls.Add(GoWithRandomBox);
        Controls.Add(SettingCancelButton);
        Controls.Add(SettingOkButton);
        FormBorderStyle = FormBorderStyle.FixedSingle;
        Name = "PlayerSettings";
        ShowIcon = false;
        ShowInTaskbar = false;
        StartPosition = FormStartPosition.CenterScreen;
        Text = "PlayerSettings";
        TopMost = true;
        ResumeLayout(false);
        PerformLayout();
    }

    #endregion

    private Button SettingOkButton;
    private Button SettingCancelButton;
    private CheckBox GoWithRandomBox;
    private CheckBox GoWithClosestBox;
    private CheckBox GoWithTheFurthestBox;
    private CheckBox GoForKOsBox;
    private CheckBox SetNewCharActiveBox;
    private CheckBox GoOutOfStartBox;
}