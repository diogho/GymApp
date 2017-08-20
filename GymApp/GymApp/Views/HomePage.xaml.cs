using GymApp.Cells;
using GymApp.Models;
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
    public partial class HomePage : ContentPage
    {
        public HomePage()
        {
            InitializeComponent();
            
            switch (Device.RuntimePlatform)
            {
                case Device.iOS:
                    Padding = new Thickness(3, 20, 3, 3);
                    break;
                case Device.Android:
                    Padding = new Thickness(3, 10, 3, 3);
                    break;
                case Device.Windows:
                    Padding = new Thickness(3, 10, 3, 3);
                    break;
            }

            listaListView.ItemTemplate = new DataTemplate(typeof(ClientCell));
            listaListView.ItemTapped += ListaListView_ItemTapped;
            agregarButton.Clicked += agregarButton_Clicked;

            using(var datos = new Models.DataAcces())
            {
                listaListView.ItemsSource = datos.GetClients();
            }
        }



        private async void ListaListView_ItemTapped(object sender, ItemTappedEventArgs e)
        {
            await Navigation.PushAsync(new EditPage(e.Item as MClient));
        }

        private async void agregarButton_Clicked(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(documentoEntry.Text))
            {
                await DisplayAlert("Error", "Debe ingresar el numero de documento", "Aceptar");
                documentoEntry.Focus();
                return;
            }
            if (string.IsNullOrEmpty(nombresEntry.Text))
            {
                await DisplayAlert("Error", "Debe ingresar nombres", "Aceptar");
                nombresEntry.Focus();
                return;
            }

            if (string.IsNullOrEmpty(apellidosEntry.Text))
            {
                await DisplayAlert("Error", "Debe ingresar apellidos", "Aceptar");
                apellidosEntry.Focus();
                return;
            }

            MClient client = new MClient
            {
                Document = int.Parse(documentoEntry.Text, System.Globalization.NumberStyles.Integer),
                FirstName = nombresEntry.Text,
                LastName = apellidosEntry.Text,
                Birthdate = nacimiento.Date,
                Group = int.Parse(grupoPicker.SelectedItem.ToString(), System.Globalization.NumberStyles.Integer)

            };

            using (var datos = new Models.DataAcces())
            {
                datos.InsertClient(client);
                listaListView.ItemsSource = datos.GetClients();
            }

            documentoEntry.Text = string.Empty;
            nombresEntry.Text = string.Empty;
            apellidosEntry.Text = string.Empty;
            nacimiento.Date = DateTime.Now;
            grupoPicker.SelectedItem = 1;
            await DisplayAlert("Confirmación", "Cliente Agregado", "Aceptar");
        }
    }
}