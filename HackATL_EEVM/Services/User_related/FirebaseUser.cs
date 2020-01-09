using Firebase.Database;
using Firebase.Database.Query;
using HackATL_EEVM.Models.BindingModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HackATL_EEVM.Services.User_related
{
    public class FirebaseUser
    {
        FirebaseClient firebase = new FirebaseClient("https://eevmhackatl.firebaseio.com/");
        public async Task<List<firebaseUser>> GetAllUser()
        {
            var result = (await firebase
                .Child("eevmhackatl")
                .Child("UserInfo")
                .OnceAsync<firebaseUser>()).Select(user => new firebaseUser{
                Username = user.Object.Username,
                Firstname = user.Object.Firstname,
                Lastname = user.Object.Lastname,
                University = user.Object.University, 
                Facebook = user.Object.Facebook,
                LinkedIn = user.Object.LinkedIn,
                Twitter = user.Object.Twitter, 
                Instagram = user.Object.Instagram,
                additionalInfo = user.Object.additionalInfo
            } ).ToList();
            return result;

        }
        public async Task AddUser(firebaseUser user) 
        {
            var newUser = user;
            await firebase
                .Child("eevmhackatl")
                .Child("UserInfo")
                .PostAsync(newUser);
        }

        public async Task<firebaseUser> getUser(string username)
        {
            var user = await GetAllUser();
            await firebase
                .Child("eevmhackatl")
                .Child("UserInfo")
                .OnceAsync<firebaseUser>();
            return user.Where(x => x.Username == username).FirstOrDefault();
        }

        public async Task UpdateUser(string username, firebaseUser user)
        {
            var toUpdateUser = (await firebase
                .Child("eevmhackatl")
                .Child("UserInfo")
                .OnceAsync<firebaseUser>()).Where(x => x.Object.Username == username).FirstOrDefault();
            var newUser = user;
            await firebase
                .Child("eevmhackatl")
                .Child("UserInfo")
                .Child(toUpdateUser.Key)
                .PutAsync(new firebaseUser() {
                    Role = user.Role,
                    Username = user.Username,
                    Firstname = user.Firstname,
                    Lastname = user.Lastname,
                    University = user.University,
                    Facebook = user.Facebook,
                    LinkedIn = user.LinkedIn,
                    Twitter = user.Twitter,
                    Instagram = user.Instagram
                });
        }
        public async Task DeleteAgenda(string username)
        {
            var toDeleteUser = (await firebase
                .Child("eevmhackatl")
                .Child("UserInfo")
                .OnceAsync<firebaseUser>()).Where(x => x.Object.Username == username).FirstOrDefault();
            await firebase.Child("UserInfo").Child(toDeleteUser.Key).DeleteAsync();
        }
    }
}
