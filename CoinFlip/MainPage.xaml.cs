namespace CoinFlip
{
    public partial class MainPage : ContentPage
    {

        public MainPage()
        {
            InitializeComponent();
            SelectedSide.SelectedIndex = 0;
        }
        private async void FlipButton_Clicked(object sender, EventArgs e)
        {
            CoinImage.Source = "giro.gif";
            CoinImage.IsAnimationPlaying = true;
            ResultLabel.Text = "Girando a moeda";
            await Task.Delay(1500);
            string escolha;
            CoinImage.IsAnimationPlaying = false;
            if (SelectedSide.SelectedIndex == 0)
            {
                escolha = "Cara";
            }
            else
            {
                escolha = "Coroa";
            }
            Moeda moeda = new Moeda(escolha);
            ResultLabel.Text = moeda.Jogar();

            if (ResultLabel.Text == "Parabéns! Você escolheu Cara e a moeda deu Cara!" || ResultLabel.Text == "Que pena! Você escolheu Coroa, mas a moeda deu Cara!")
            {
                CoinImage.Source = "cara.png";
            }
            else if (ResultLabel.Text == "Parabéns! Você escolheu Coroa e a moeda deu Coroa!" || ResultLabel.Text == "Que pena! Você escolheu Cara, mas a moeda deu Coroa")
            {
                CoinImage.Source = "coroa.png";
            }
        }
        // 0 = cara; 1 = coroa;
    }

}
