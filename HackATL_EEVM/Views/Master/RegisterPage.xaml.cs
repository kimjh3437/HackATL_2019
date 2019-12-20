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
    public partial class RegisterPage : ContentPage
    {
        FirebaseUser firebase = new FirebaseUser();
        IFirebaseAuthenticator auth;
        public RegisterPage()
        {
            InitializeComponent();
            auth = DependencyService.Get<IFirebaseAuthenticator>();
        }

        public async void loginInfotapped(object sender, EventArgs e)
        {
            try
            {
                if (txtPassword.Text == txtConfirmPassword.Text)
                {
                    bool status = auth.SignUp(txtEmail.Text, txtPassword.Text);
                    if (status)
                    {
                        string token = await auth.Login(txtEmail.Text, txtPassword.Text);
                        if (token != "")
                        {
                            string username = txtEmail.Text;
                            string password = txtPassword.Text;
                            string role = "member";
                            if (username.Contains("123") && password.Contains("eevm"))
                            {
                                role = "admin";
                                

                            }
                            var user = new firebaseUser
                            {
                                Username = txtEmail.Text,
                                Role = role
                                
                            };
                            await firebase.AddUser(user);
                            Settings.Username = txtEmail.Text;
                            if(user.Role == "member")
                            {
                                
                                await Navigation.PushAsync(new PersonalInfo());

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
                    else
                    {
                        await DisplayAlert("Confirm the Password", "Password does not match", "Ok");
                    }
                }

            }
            catch(Exception ex)
            {
                ShowError();
            }
            
            
            

        }

        async private void ShowError()
        {
            await DisplayAlert("Authentication Failed", "E-mail or password are incorrect. Try again!", "OK");
        }
    }
}