using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace HackATL_EEVM.Views.AdminPages
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class AdminMain : ContentPage
    {
        public AdminMain()
        {
            InitializeComponent();
        }

        private void Button_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new MainTab());

        }

        async void Admin_clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new AdminNavigation());
        }
         
    }
}