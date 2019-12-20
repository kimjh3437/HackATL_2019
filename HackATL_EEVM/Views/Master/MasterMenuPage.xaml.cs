using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using Xamarin.Forms.PlatformConfiguration.iOSSpecific;
using HackATL_EEVM.Views.Master.MaserMenuNav;
using HackATL_EEVM.Helpers_token;
using Application = Xamarin.Forms.Application;

namespace HackATL_EEVM.Views.Master
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class MasterMenuPage : ContentPage
    {
        public MasterMenuPage()
        {
            InitializeComponent();
            On<Xamarin.Forms.PlatformConfiguration.iOS>().SetUseSafeArea(true);
        }
        private void ImgExit_Tapped(object sender, EventArgs e)
        {
            Utilities.Common.MasterPage.IsPresented = false;
        }

        
        private void viewProfileTapped(object sender, EventArgs e)
        {          
           
                //var page = new Xamarin.Forms.NavigationPage(new ProfileView());
                //Utilities.Common.MasterPage.Detail = page;
                //Xamarin.Forms.NavigationPage.SetHasNavigationBar(page,false);
                //Utilities.Common.MasterPage.IsPresented = false;

            var temp = (Application.Current.MainPage as MasterDetailPage);
            var temp2 = temp.Detail as Xamarin.Forms.NavigationPage;
            temp.IsPresented = false;
            temp2.PushAsync(new ProfileView());
                 

        }

        private void Logout_Tapped(object sender, EventArgs e)
        {
            Settings.AccessToken = "";
            var page = new Xamarin.Forms.NavigationPage(new OptionPage());
            Utilities.Common.MasterPage.Detail = page;
            Xamarin.Forms.NavigationPage.SetHasNavigationBar(page, false);
            Utilities.Common.MasterPage.IsPresented = false;

        }

        private void ChatFeat_Tapped(object sender, EventArgs e)
        {
            DisplayAlert("Maintenance", "Chat feature is currently disabled", "Ok");

        }
    }
}