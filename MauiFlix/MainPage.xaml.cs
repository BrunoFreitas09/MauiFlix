namespace MauiFlix
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private void Button_Clicked(System.Object sender, System.EventArgs e)
        {
            try
            {
                Navigation.PushAsync(new Categorias.Aventura());
            }
            catch (Exception ex)
            {
                DisplayAlert("OPS!!", ex.Message, "OK");
            }
        }

        private void Button_Clicked_1(object sender, EventArgs e)
        {
            try
            {
                Navigation.PushAsync(new Categorias.comedia());
            }
            catch (Exception ex) 
            {
                DisplayAlert("OPS!!", ex.Message, "Ok");
            }
        }

        private void Button_Clicked_2(object sender, EventArgs e)
        {
            try
            {
                Navigation.PushAsync(new Categorias.drama());
            }
            catch (Exception ex)
            {
                DisplayAlert("OPS!!", ex.Message, "Ok");
            }
        }

        private void Button_Clicked_3(object sender, EventArgs e)
        {
            try
            {
                Navigation.PushAsync(new Categorias.terror());
            }
            catch (Exception ex)
            {
                DisplayAlert("OPS!!", ex.Message, "Ok");
            }
        }

        private void Button_Clicked_4(object sender, EventArgs e)
        {
            try
            {
                Navigation.PushAsync(new Categorias.ficcao());
            }
            catch (Exception ex)
            {
                DisplayAlert("OPS!!", ex.Message, "Ok");
            }
        }

        private void Button_Clicked_5(object sender, EventArgs e)
        {
            try
            {
                Navigation.PushAsync(new Categorias.Sus());
            }
            catch (Exception ex)
            {
                DisplayAlert("OPS!!", ex.Message, "Ok");
            }
        }

        private void Button_Clicked_6(object sender, EventArgs e)
        {
            try
            {
                Navigation.PushAsync(new Categorias.infantil());
            }
            catch (Exception ex)
            {
                DisplayAlert("OPS!!", ex.Message, "Ok");
            }
        }

        private void Button_Clicked_7(object sender, EventArgs e)
        {
            try
            {
                Navigation.PushAsync(new Categorias.animacao());
            }
            catch (Exception ex)
            {
                DisplayAlert("OPS!!", ex.Message, "Ok");
            }
        }

        private void Button_Clicked_8(object sender, EventArgs e)
        {
            try
            {
                Navigation.PushAsync(new Categorias.nacional());
            }
            catch (Exception ex)
            {
                DisplayAlert("OPS!!", ex.Message, "Ok");
            }
        }

        private void Button_Clicked_9(object sender, EventArgs e)
        {
            try
            {
                Navigation.PushAsync(new Categorias.romance());
            }
            catch (Exception ex)
            {
                DisplayAlert("OPS!!", ex.Message, "Ok");
            }
        }

        private void Button_Clicked_10(object sender, EventArgs e)
        {
            try
            {
                Navigation.PushAsync(new Categorias.Sus());
            }
            catch (Exception ex)
            {
                DisplayAlert("OPS!!", ex.Message, "Ok");
            }
        }

        private void Button_Clicked_11(object sender, EventArgs e)
        {
            try
            {
                Navigation.PushAsync(new Categorias.Sus());
            }
            catch (Exception ex)
            {
                DisplayAlert("OPS!!", ex.Message, "Ok");
            }
        }
    }
}
