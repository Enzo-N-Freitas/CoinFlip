namespace CoinFlip
{
    public partial class MainPage : ContentPage
    {
        int count = 0;

        public MainPage()
        {
            InitializeComponent();
        }
        private void FlipButton_Clicked(object sender, EventArgs e)
        {
            int escolha = SelectedSide.SelectedIndex;
            Moeda moeda = new Moeda(escolha);
            ResultLabel.Text = moeda.Jogar();
        }
        // 0 = cara; 1 = coroa;
    }

}
