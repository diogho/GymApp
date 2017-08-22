using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace GymApp.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class HomePage : TabbedPage
    {
        public HomePage()
        {
            InitializeComponent();
            NavigationPage.SetTitleIcon(this, "app_Icon.png");
            //clientButton.Clicked += ClientButton_Clicked;
            //seguimientoButton.Clicked += SeguimientoButton_Clicked;
            //salirButton.Clicked += SalirButton_Clicked;

            var clientPage = new NavigationPage(new ClientPage());
            var screeningPage = new NavigationPage(new TracingPage());
            var graphPage = new NavigationPage(new ScreeningSheetPage());
            var settingsPage = new NavigationPage(new ScreeningSheetPage());

            clientPage.Icon = "ic_client";
            screeningPage.Icon = "ic_Screening";
            graphPage.Icon = "ic_graph";
            settingsPage.Icon = "ic_settings";

            Children.Add(clientPage);
            Children.Add(screeningPage);
            Children.Add(graphPage);
            Children.Add(settingsPage);
        }



        //private async void ClientButton_Clicked(object sender, EventArgs e)
        //{
        //    await Navigation.PushAsync(new ClientPage());
        //}

        //private async void SeguimientoButton_Clicked(object sender, EventArgs e)
        //{
        //    await Navigation.PushAsync(new TracingPage() as Page);
            
        //}

        //private async void SalirButton_Clicked(object sender, EventArgs e)
        //{
        //    await Navigation.PushAsync(new TracingPage());
        //}
    }
}