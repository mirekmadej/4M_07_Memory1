namespace _4M_07_Memory1
{
    public partial class MainPage : ContentPage
    {
        int[] elementy = { 0, 1, 0, 2, 2, 1 };
        string[] karty = { "kolo.png", "kwadrat.png", "trojkat.png" };
        private bool czyPierwsza = true;
        private int nrPierwszej;
        private ImageButton btnPierwszy;
        public MainPage()
        {
            InitializeComponent();
        }
        private void btnZacznijClicked(object sender, EventArgs e)
        {
            czyPierwsza = true;
            p00.Source = "tlo.png";
            p01.Source = "tlo.png";
            p02.Source = "tlo.png";
            p00.IsEnabled = true;
            p01.IsEnabled = true;
            p02.IsEnabled = true;
        }
        private async void btnP00Clicked(object sender, EventArgs e)
        {
            p00.Source = karty[elementy[0]];
            if(czyPierwsza)
            {
                czyPierwsza = false;
                nrPierwszej = 0;
                btnPierwszy = p00;
            }
            else
            {
                int x = elementy[0];
                int y = elementy[nrPierwszej];
                if(x == y)
                {
                    p00.IsEnabled = false;
                    btnPierwszy.IsEnabled = false;
                    czyPierwsza = true;
                }
                else
                {
                    await Task.Delay(1000);
                    p00.Source = "tlo.png";
                    btnPierwszy.Source = "tlo.png";
                    czyPierwsza = true;
                }

            }
        }
        private async void btnP01Clicked(object sender, EventArgs e)
        {
            p01.Source = karty[elementy[1]];
            if (czyPierwsza)
            {
                czyPierwsza = false;
                nrPierwszej = 1;
                btnPierwszy = p01;
            }
            else
            {
                int x = elementy[1];
                int y = elementy[nrPierwszej];
                if (x == y)
                {
                    p01.IsEnabled = false;
                    btnPierwszy.IsEnabled = false;
                    czyPierwsza = true;
                }
                else
                {
                    await Task.Delay(1000); 
                    p01.Source = "tlo.png";
                    btnPierwszy.Source = "tlo.png";
                    czyPierwsza = true;
                }

            }
        }
        private async void btnP02Clicked(object sender, EventArgs e)
        {
            p02.Source = karty[elementy[2]];
            if (czyPierwsza)
            {
                czyPierwsza = false;
                nrPierwszej = 2;
                btnPierwszy = p02;
            }
            else
            {
                int x = elementy[2];
                int y = elementy[nrPierwszej];
                if (x == y)
                {
                    p02.IsEnabled = false;
                    btnPierwszy.IsEnabled = false;
                    czyPierwsza = true;
                }
                else
                {
                    await Task.Delay(1000); 
                    p02.Source = "tlo.png";
                    btnPierwszy.Source = "tlo.png";
                    czyPierwsza = true;
                }

            }
        }

    }
}