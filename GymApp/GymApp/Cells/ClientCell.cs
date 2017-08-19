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
                HorizontalTextAlignment = TextAlignment.End
            };
            idClientLabel.SetBinding(Label.TextProperty, new Binding("IDClient"));

            var documentLabel = new Label
            {
                HorizontalOptions = LayoutOptions.Start
            };
            documentLabel.SetBinding(Label.TextProperty, new Binding("Document"));

            var firstNameLabel = new Label
            {
                FontSize = Device.GetNamedSize(NamedSize.Small, typeof(Label)),
                TextColor = Color.DarkBlue,
                HorizontalOptions = LayoutOptions.Start
            };
            firstNameLabel.SetBinding(Label.TextProperty, new Binding("FirstName"));

            var lastNameLabel = new Label
            {
                FontSize = Device.GetNamedSize(NamedSize.Small, typeof(Label)),
                TextColor = Color.DarkBlue,
                HorizontalOptions = LayoutOptions.Start
            };
            lastNameLabel.SetBinding(Label.TextProperty, new Binding("LastName"));

            var birthDayLabel = new Label
            {
                HorizontalOptions = LayoutOptions.StartAndExpand
            };
            birthDayLabel.SetBinding(Label.TextProperty, new Binding("BirthdateEdit"));

            var ageLabel = new Label
            {
                HorizontalOptions = LayoutOptions.StartAndExpand,
            };
            ageLabel.SetBinding(Label.TextProperty, new Binding("Age"));

            var groupLabel = new Label
            {
                HorizontalOptions = LayoutOptions.CenterAndExpand,
                HorizontalTextAlignment = TextAlignment.End
            };
            groupLabel.SetBinding(Label.TextProperty, new Binding("Group"));

            var line1 = new StackLayout
            {
                Children = { idClientLabel, documentLabel, firstNameLabel, lastNameLabel },
                Orientation = StackOrientation.Horizontal
            };

            var line2 = new StackLayout
            {
                Children = { birthDayLabel,ageLabel, groupLabel },
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
