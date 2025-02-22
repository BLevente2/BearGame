namespace BearGame;

public partial class PlayerSettings : Form
{
    public PlayerSettings(Strategy strategy, Color playerColor)
    {
        InitializeComponent();

        this.ForeColor = playerColor;

        GoWithRandomBox.Checked = strategy.GoWithRandom;
        GoWithRandomBox.Enabled = !strategy.GoWithRandom;
        GoWithClosestBox.Checked = strategy.GoWithClosest;
        GoWithClosestBox.Enabled = !strategy.GoWithClosest;
        GoWithTheFurthestBox.Checked = strategy.GoWithFurthest;
        GoWithTheFurthestBox.Enabled = !strategy.GoWithFurthest;
        GoForKOsBox.Checked = strategy.PrioritizeKO;
        SetNewCharActiveBox.Checked = strategy.PrioritizeNewCharacter;
        GoOutOfStartBox.Checked = strategy.PrioritizeOutOfStart;

        PlayerStrategy = strategy;

        SettingOkButton.MouseEnter += Button_MouseEnter;
        SettingOkButton.MouseLeave += Button_MouseLeave;
        SettingCancelButton.MouseEnter += Button_MouseEnter;
        SettingCancelButton.MouseLeave += Button_MouseLeave;
    }

    private void Button_MouseEnter(object? sender, EventArgs e)
    {
        if (sender != null)
        {
            Button button = (Button)sender;
            button.BackColor = SystemColors.Highlight;
        }
    }

    private void Button_MouseLeave(object? sender, EventArgs e)
    {
        if (sender != null)
        {
            Button button = (Button)sender;
            button.BackColor = SystemColors.Control;
        }
    }

    public Strategy PlayerStrategy { get; private set; }

    private void GoWithRandomBox_CheckedChanged(object sender, EventArgs e)
    {
        if (GoWithRandomBox.Checked)
        {
            GoWithClosestBox.Checked = false;
            GoWithClosestBox.Enabled = true;
            GoWithTheFurthestBox.Checked = false;
            GoWithTheFurthestBox.Enabled = true;
            GoWithRandomBox.Enabled = false;
        }
    }

    private void GoWithClosestBox_CheckedChanged(object sender, EventArgs e)
    {
        if (GoWithClosestBox.Checked)
        {
            GoWithRandomBox.Checked = false;
            GoWithRandomBox.Enabled = true;
            GoWithTheFurthestBox.Checked = false;
            GoWithTheFurthestBox.Enabled = true;
            GoWithClosestBox.Enabled = false;
        }
    }

    private void GoWithTheFurthestBox_CheckedChanged(object sender, EventArgs e)
    {
        if (GoWithTheFurthestBox.Checked)
        {
            GoWithRandomBox.Checked = false;
            GoWithRandomBox.Enabled = true;
            GoWithClosestBox.Checked = false;
            GoWithClosestBox.Enabled = true;
            GoWithTheFurthestBox.Enabled = false;
        }
    }

    private void SettingCancelButton_Click(object sender, EventArgs e)
    {
        DialogResult = DialogResult.Cancel;
        Close();
    }

    private void SettingOkButton_Click(object sender, EventArgs e)
    {
        PlayerStrategy = new Strategy(
            GoWithRandomBox.Checked,
            GoWithClosestBox.Checked,
            GoWithTheFurthestBox.Checked,
            GoForKOsBox.Checked,
            SetNewCharActiveBox.Checked,
            GoOutOfStartBox.Checked
        );
        DialogResult = DialogResult.OK;
        Close();
    }
}