using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace GymApp.Cells
{
    public class ClientCell:ViewCell
    {
        public ClientCell()
        {
            var idClientLabel = new Label
            {
                HorizontalOptions = LayoutOptions.End,
                VerticalTextAlignment = TextAlignment.Center,
                HorizontalTextAlignment = TextAlignment.End          
            };
            idClientLabel.SetBinding(Label.TextProperty, new Binding("IDClient"));

            var documentLabel = new Label
            {
                HorizontalOptions = LayoutOptions.Start,
                VerticalTextAlignment = TextAlignment.Center
            };
            documentLabel.SetBinding(Label.TextProperty, new Binding("Document", stringFormat:"DI: {0}"));

            var firstNameLabel = new Label
            {
                FontSize = Device.GetNamedSize(NamedSize.Small, typeof(Label)),
                TextColor = Color.DarkBlue,
                HorizontalOptions = LayoutOptions.Start,
                VerticalTextAlignment = TextAlignment.Center
            };
            firstNameLabel.SetBinding(Label.TextProperty, new Binding("FirstName"));

            var lastNameLabel = new Label
            {
                FontSize = Device.GetNamedSize(NamedSize.Small, typeof(Label)),
                TextColor = Color.DarkBlue,
                HorizontalOptions = LayoutOptions.Start,
                VerticalTextAlignment = TextAlignment.Center,
            };
            lastNameLabel.SetBinding(Label.TextProperty, new Binding("LastName"));

            var birthDayLabel = new Label
            {
                HorizontalOptions = LayoutOptions.StartAndExpand,
                VerticalTextAlignment = TextAlignment.Center
            };
            birthDayLabel.SetBinding(Label.TextProperty, new Binding("BirthdateEdit"));

            var ageLabel = new Label
            {
                HorizontalOptions = LayoutOptions.StartAndExpand,
                VerticalTextAlignment = TextAlignment.Center
            };
            ageLabel.SetBinding(Label.TextProperty, new Binding("Age", stringFormat: "Edad: {0}"));

            var groupLabel = new Label
            {
                HorizontalOptions = LayoutOptions.CenterAndExpand,
                VerticalTextAlignment = TextAlignment.Center,
                HorizontalTextAlignment = TextAlignment.End
            };
            groupLabel.SetBinding(Label.TextProperty, new Binding("Group",stringFormat: "G: #{0}"));

            var imgLabel = new Image
            {
                HorizontalOptions = LayoutOptions.Start,
                Source = "ic_account_circle"
            };

            var line1 = new StackLayout
            {
                Children = { idClientLabel, imgLabel, firstNameLabel, lastNameLabel },
                Orientation = StackOrientation.Horizontal
            };

            var line2 = new StackLayout
            {
                Children = { documentLabel, birthDayLabel, ageLabel, groupLabel },
                Orientation = StackOrientation.Horizontal
            };
            View = new StackLayout
            {
                Children = { line1,line2 },
                Orientation = StackOrientation.Vertical
            };
        }
    }
}
