using HackATL_EEVM.Helpers_token;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace HackATL_EEVM.Views.Master.MaserMenuNav
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ProfileView : ContentPage
    {
        public ProfileView()
        {
            InitializeComponent();
            bindMaterials();
            
        }
       private void bindMaterials()
       {
            firstname.Text = Settings.Firstname;
            lastname.Text = Settings.Lastname;
            txtEmail.Text = Settings.Username;
            txtUniversity.Text = Settings.University;
            txtLinkedIn.Text = Settings.LinkedIn;
            txtInstagram.Text = Settings.Instagram;
            txtTwitter.Text = Settings.Twitter;
            txtFacebook.Text = Settings.Facebook;
            additinfo.Text = Settings.additInfo;
            

       }
        private void ImgExit_Tapped(object sender, EventArgs e)
        {
            
            var page = new Xamarin.Forms.NavigationPage(new MainTab());
            Utilities.Common.MasterPage.Detail = page;
            Xamarin.Forms.NavigationPage.SetHasNavigationBar(page, false);
            Utilities.Common.MasterPage.IsPresented = true;

        }

        public async void Editor_Tapped(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new PersonalInfo());


        }
    }
}