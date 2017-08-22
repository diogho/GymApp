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
    public partial class EditClientPage : ContentPage
    {
        MClient _client;

        public EditClientPage(MClient client)
        {
            InitializeComponent();

            _client = client;
            actualizarButton.Clicked += actualizarButton_Clicked;
            borrarButton.Clicked += borrarButton_Clicked;

            documentoEntry.Text = _client.Document.ToString();
            nombresEntry.Text = _client.FirstName;
            apellidosEntry.Text = _client.LastName;
            nacimiento.Date = _client.Birthdate;
            grupoPicker.SelectedIndex = _client.Group-1;
        }


        private async void actualizarButton_Clicked(object sender, EventArgs e)
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

            _client.Document = int.Parse(documentoEntry.Text, System.Globalization.NumberStyles.Integer);
            _client.FirstName = nombresEntry.Text;
            _client.LastName = apellidosEntry.Text;
            _client.Birthdate = nacimiento.Date;
            _client.Group = int.Parse(grupoPicker.SelectedItem.ToString(), System.Globalization.NumberStyles.Integer);

            using(var datos = new DataAcces())
            {
                datos.UpdateClient(_client);
            }

            await DisplayAlert("Confirmación", "Cliente Actualizado Exitosamente", "Aceptar");
            await Navigation.PushAsync(new ClientPage());
        }

        private async void borrarButton_Clicked(object sender, EventArgs e)
        {
            var rta = await DisplayAlert("Confirmar", "¿Desea BORRAR el Cliente?", "Aceptar","Cancelar");
            if (!rta)
                return;

            using(var datos = new DataAcces())
            {
                datos.DeleteClient(_client);
            }

            await DisplayAlert("Confirmación", "Cliente Borrado Exitosamente", "Aceptar");
            await Navigation.PushAsync(new ClientPage());
        }
    }
}