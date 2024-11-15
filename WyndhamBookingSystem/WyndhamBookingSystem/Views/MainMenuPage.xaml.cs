namespace WyndhamBookingSystem.Views
{
    public partial class MainMenuPage : ContentPage
    {

        public MainMenuPage()
        {
            InitializeComponent();
        }

        private async void OnGoToSearchClicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new ReservarPage());
        }

    }

}
