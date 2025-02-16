namespace BearGame
{
    public partial class BearGameProject : Form
    {
        public BearGameProject()
        {
            InitializeComponent();

            GameViewButton.FlatAppearance.BorderSize = 0;
            GameViewButton.MouseEnter += Buttons_MouseEnter;
            GameViewButton.MouseLeave += Buttons_MouseLeave;
            StatisticsViewButton.FlatAppearance.BorderSize = 0;
            StatisticsViewButton.MouseEnter += Buttons_MouseEnter;
            StatisticsViewButton.MouseLeave += Buttons_MouseLeave;

            GameView.Visible = false;

        }

        private void GameViewButton_Click(object sender, EventArgs e)
        {
            GameView.Visible = true;
        }

        private void Buttons_MouseEnter(object? sender, EventArgs e)
        {
            if (sender != null)
            {
                Button button = (Button)sender;
                button.FlatAppearance.BorderSize = 1;
            }
        }

        private void Buttons_MouseLeave(object? sender, EventArgs e)
        {
            if (sender != null)
            {
                Button button = (Button)sender;
                button.FlatAppearance.BorderSize = 0;
            }
        }

    }
}
