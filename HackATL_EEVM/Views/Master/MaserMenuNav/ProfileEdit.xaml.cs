using HackATL_EEVM.Helpers_token;
using HackATL_EEVM.Models.BindingModels;
using HackATL_EEVM.Services.User_related;
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
    public partial class ProfileEdit : ContentPage
    {
        FirebaseUser firebase = new FirebaseUser();
        public ProfileEdit()
        {
            InitializeComponent();
            
            
        }
        

        public async void Editor_Tapped(object sender, EventArgs e)
        {
            await Navigation.PopAsync();


        }

        async void finalsignup2_Tabbed(object sender, EventArgs e)
        {
            var role = "member";
            var user = new firebaseUser
            {
                Firstname = Settings.Firstname,
                Lastname = Settings.Lastname,
                University = Settings.University,
                Facebook = Settings.Facebook,
                LinkedIn = Settings.LinkedIn,
                Twitter = Settings.Twitter,
                Instagram = Settings.Instagram,
                Role = role
            };

            
            if (Settings.Role != "member" )
            {
                role = "admin";
            }
            if(!string.IsNullOrEmpty(txtFirstname.Text))
            {
                Settings.Firstname = txtFirstname.Text;
                user.Firstname = txtFirstname.Text;
            }
            if(!string.IsNullOrEmpty(txtLastname.Text))
            {
                Settings.Lastname = txtLastname.Text;
                user.Lastname = txtLastname.Text;
            }
            if(!string.IsNullOrEmpty(txtUniversity.Text))
            {
                Settings.University = txtUniversity.Text;
                user.University = txtUniversity.Text;
            }
            if(!string.IsNullOrEmpty(txtFacebook.Text))
            {
                Settings.Facebook = txtFacebook.Text;
                user.Facebook = txtFacebook.Text;
            }
            if(!string.IsNullOrEmpty(txtLinkedIn.Text))
            {
                Settings.LinkedIn = txtLinkedIn.Text;
                user.LinkedIn = txtLinkedIn.Text;
            }
            if(!string.IsNullOrEmpty(txtTwitter.Text))
            {
                Settings.Twitter = txtTwitter.Text;
                user.Twitter = txtTwitter.Text;
            }
            if(!string.IsNullOrEmpty(txtInstagram.Text))
            {
                Settings.Instagram = txtInstagram.Text;
                user.Instagram = txtInstagram.Text;
            }
            string currentUser = Settings.Username;
            //if (Settings.Firstname != txtFirstname.Text && !string.IsNullOrEmpty(txtFirstname.Text))
            //{
            //    Settings.Firstname = txtFirstname.Text;
            //}
            //if (Settings.Lastname != txtLastname.Text && !string.IsNullOrEmpty(txtLastname.Text))
            //{
            //    Settings.Lastname = txtLastname.Text;
            //}
            //if (Settings.University != txtUniversity.Text && !string.IsNullOrEmpty(txtUniversity.Text))
            //{
            //    Settings.University = txtUniversity.Text;
            //}
            //if (Settings.Facebook != txtFacebook.Text && !string.IsNullOrEmpty(txtFacebook.Text))
            //{
            //    Settings.Facebook = txtFacebook.Text;
            //}
            //if (Settings.LinkedIn != txtLinkedIn.Text && !string.IsNullOrEmpty(txtLinkedIn.Text))
            //{
            //    Settings.LinkedIn = txtLinkedIn.Text;
            //}
            //if (Settings.Twitter != txtTwitter.Text && !string.IsNullOrEmpty(txtTwitter.Text))
            //{
            //    Settings.Twitter = txtTwitter.Text;
            //}
            //if (Settings.Instagram != txtInstagram.Text && !string.IsNullOrEmpty(txtInstagram.Text))
            //{
            //    Settings.Instagram = txtInstagram.Text;
            //}
            //var user = new firebaseUser
            //{
            //    Firstname = Settings.Firstname,
            //    Lastname = Settings.Lastname,
            //    University = Settings.University,
            //    Facebook = Settings.Facebook,
            //    LinkedIn = Settings.LinkedIn,
            //    Twitter = Settings.Twitter,
            //    Instagram = Settings.Instagram,
            //    Role = role 
            //};
            //Settings.Firstname = txtFirstname.Text;
            //Settings.Lastname = txtLastname.Text;
            //Settings.University = txtUniversity.Text;
            //Settings.Facebook = txtFacebook.Text;
            //Settings.LinkedIn = txtLinkedIn.Text;
            //Settings.Instagram = txtInstagram.Text;

            try
            {
                await firebase.UpdateUser(currentUser, user);

            }
            catch (Exception ex)
            {
                await DisplayAlert("Error", "Update failed", "ok");
            }
            Navigation.InsertPageBefore(new MainTab(), this);
            await Navigation.PopAsync();

            //await Navigation.PushModalAsync(new MainTab());

        }
    }
}