using HackATL_EEVM.FirebaseAuth;
using HackATL_EEVM.Helpers_token;
using HackATL_EEVM.Models.BindingModels;
using HackATL_EEVM.Services.User_related;
using HackATL_EEVM.Views.AdminPages;
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
    public partial class SignUpPage : ContentPage
    {
        IFirebaseAuthenticator auth;
        FirebaseUser firebase = new FirebaseUser();
        firebaseUser user;
        public SignUpPage()
        {
            InitializeComponent();
            auth = DependencyService.Get<IFirebaseAuthenticator>();

        }
        async void ImgSignUp_Tapped(object sender, EventArgs e)
        {

            try
            {

                string token = await auth.Login(txtEmail.Text, txtPassword.Text);
                if (token != "")
                {
                    var user = await firebase.getUser(txtEmail.Text);
                    //user = new firebaseUser
                    //{
                    //    Firstname = temp.Firstname,
                    //    Lastname = temp.Lastname,
                    //    University = temp.University,
                    //    Facebook = temp.Facebook,
                    //    LinkedIn = temp.LinkedIn,
                    //    Twitter = temp.LinkedIn,
                    //    Instagram = temp.Instagram
                    //};
                    //string FN = "";
                    //string LN = "";
                    //string UserName = "";
                    //string role = "";
                    //string univ = "";
                    //string FB = "";
                    //string Insta = "";
                    //string Twit = "";
                    //string Link = "";

                    //this is the issue 

                    //if(user == null)
                    //{
                    //    ShowError();
                    //}
                    //Settings.Firstname = user.Firstname;

                    Settings.AccessToken = token;
                    Settings.Username = user.Username;
                    Settings.Password = user.Password;
                    Settings.Role = user.Role;
                    Settings.University = user.University;
                    Settings.Facebook = user.Facebook;
                    Settings.Instagram = user.Instagram;
                    Settings.Twitter = user.Twitter;
                    Settings.LinkedIn = user.LinkedIn;

                    if (Settings.Role == "member")
                    {
                        await Navigation.PushAsync(new Views.MainTab());

                    }
                    else
                    {
                        await Navigation.PushAsync(new AdminMain());
                    }
                }
                else
                {
                    ShowError();
                }

            }
            catch (Exception ex)
            {
                ShowError2();
            }

        }

        async private void ShowError()
        {
            await DisplayAlert("Authentication Failed", "E-mail or password is incorrect. Try again!", "OK");
        }

        async private void ShowError2()
        {
            await DisplayAlert("Invalid Info entered", "E-mail or password is incorrect. Try again!", "OK");
        }
    }
}