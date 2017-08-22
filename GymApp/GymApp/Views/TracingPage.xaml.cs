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
    public partial class TracingPage : TabbedPage
    {
        public TracingPage()
        {
            InitializeComponent();

            var clientTracingPage = new NavigationPage(new ClientTracingPage());
            var screenignSheetPage = new NavigationPage(new ScreeningSheetPage());
            var maximalPage = new NavigationPage(new MaximalsPage());

            clientTracingPage.Title = "Usuario";
            screenignSheetPage.Title = "Tamizaje";
            maximalPage.Title = "Maximales";

            Children.Add(clientTracingPage);
            Children.Add(screenignSheetPage);
            Children.Add(maximalPage);
        }
    }
}