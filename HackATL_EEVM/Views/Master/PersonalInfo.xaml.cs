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

namespace HackATL_EEVM.Views.Master
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class PersonalInfo : ContentPage
    {
        FirebaseUser firebase = new FirebaseUser();
        public PersonalInfo()
        {
            InitializeComponent();
        }
        public async void loginInfotapped(object sender, EventArgs e)
        {
            await Navigation.PopAsync();
        }

        async void finalsignup2_Tabbed(object sender, EventArgs e)
        {
            string currentUser = Settings.Username;
            var user = new firebaseUser
            {
                Firstname = txtFirstname.Text,
                Lastname = txtLastname.Text,
                University = txtUniversity.Text,
                Facebook = txtFacebook.Text,
                LinkedIn = txtLinkedIn.Text,
                Twitter = txtTwitter.Text,
                Instagram = txtInstagram.Text
            };
            Settings.Firstname = txtFirstname.Text;
            Settings.Lastname = txtLastname.Text;
            Settings.University = txtUniversity.Text;
            Settings.Facebook = txtFacebook.Text;
            Settings.LinkedIn = txtLinkedIn.Text;
            Settings.Instagram = txtInstagram.Text;
            
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