﻿using HackATL_EEVM.Models;
using Plugin.Settings;
using Plugin.Settings.Abstractions;
using System;
using System.Collections.Generic;
using System.Text;

namespace HackATL_EEVM.Helpers_token
{
    
    public static class Settings
    {

        private static ISettings AppSettings
        {
            get
            {
                return CrossSettings.Current;
            }
        }

        public static string myAgendaList
        {
            get => AppSettings.GetValueOrDefault(nameof(myAgendaList), string.Empty);
            set => AppSettings.AddOrUpdateValue(nameof(myAgendaList), value);
        }
        



        public static string Username
        {
            get => AppSettings.GetValueOrDefault(nameof(Username), string.Empty);
            set => AppSettings.AddOrUpdateValue(nameof(Username), value);
        }

        

        public static string Password
        {
            get => AppSettings.GetValueOrDefault(nameof(Password), string.Empty);
            set => AppSettings.AddOrUpdateValue(nameof(Password), value);
        }

        public static string Firstname
        {
            get => AppSettings.GetValueOrDefault(nameof(Firstname), string.Empty);
            set => AppSettings.AddOrUpdateValue(nameof(Firstname), value);
        }

        public static string Lastname
        {
            get => AppSettings.GetValueOrDefault(nameof(Lastname), string.Empty);
            set => AppSettings.AddOrUpdateValue(nameof(Lastname), value);
        }

        public static string Role
        {
            get => AppSettings.GetValueOrDefault(nameof(Role), string.Empty);
            set => AppSettings.AddOrUpdateValue(nameof(Role), value);
        }

        public static string AccessToken
        {
            get => AppSettings.GetValueOrDefault(nameof(AccessToken), string.Empty);
            set => AppSettings.AddOrUpdateValue(nameof(AccessToken), value);
        }

        public static string AccessTokenExpirationDate
        {
            get => AppSettings.GetValueOrDefault(nameof(AccessTokenExpirationDate), string.Empty);
            set => AppSettings.AddOrUpdateValue(nameof(AccessTokenExpirationDate), value);
        }

        public static string University
        {
            get => AppSettings.GetValueOrDefault(nameof(University), string.Empty);
            set => AppSettings.AddOrUpdateValue(nameof(University), value);
        }

        public static string Facebook
        {
            get => AppSettings.GetValueOrDefault(nameof(Facebook), string.Empty);
            set => AppSettings.AddOrUpdateValue(nameof(Facebook), value);
        }

        public static string Instagram
        {
            get => AppSettings.GetValueOrDefault(nameof(Instagram), string.Empty);
            set => AppSettings.AddOrUpdateValue(nameof(Instagram), value);
        }

        public static string Twitter
        {
            get => AppSettings.GetValueOrDefault(nameof(Twitter), string.Empty);
            set => AppSettings.AddOrUpdateValue(nameof(Twitter), value);
        }
        public static string LinkedIn
        {
            get => AppSettings.GetValueOrDefault(nameof(LinkedIn), string.Empty);
            set => AppSettings.AddOrUpdateValue(nameof(LinkedIn), value);
        }

        public static string additInfo
        {
            get => AppSettings.GetValueOrDefault(nameof(additInfo), string.Empty);
            set => AppSettings.AddOrUpdateValue(nameof(additInfo), value);

        }
        //public static string Firstname
        //{
        //    get
        //    {
        //        return AppSettings.GetValueOrDefault(nameof(Firstname), string.Empty);
        //    }
        //    set
        //    {
        //        AppSettings.AddOrUpdateValue("Firstname", value); ;

        //    }
        //}

        //public static string Lastname
        //{
        //    get
        //    {
        //        return AppSettings.GetValueOrDefault("Lastname", "");
        //    }

        //    set
        //    {
        //        AppSettings.AddOrUpdateValue("Lastname", value);
        //    }
        //}

        //public static string Username
        //{
        //    get
        //    {
        //        return AppSettings.GetValueOrDefault("Username", "");
        //    }
        //    set
        //    {
        //        AppSettings.AddOrUpdateValue("Username", value);
        //    }
        //}
        //public static string Password
        //{
        //    get
        //    {
        //        return AppSettings.GetValueOrDefault("Password", "");
        //    }
        //    set
        //    {
        //        AppSettings.AddOrUpdateValue("Password", value);
        //    }
        //}

        //public static string Role
        //{
        //    get
        //    {
        //        return AppSettings.GetValueOrDefault("Role", "");
        //    }
        //    set
        //    {
        //        AppSettings.AddOrUpdateValue("Role", value);
        //    }
        //}


        //public static string AccessToken
        //{
        //    get
        //    {
        //        return AppSettings.GetValueOrDefault("AccessToken", "");
        //    }
        //    set
        //    {
        //        AppSettings.AddOrUpdateValue("AccessToken", value);
        //    }
        //}

        //public static DateTime AccessTokenExpirationDate
        //{
        //    get
        //    {
        //        return AppSettings.GetValueOrDefault("AccessTokenExpirationDate", DateTime.UtcNow);
        //    }
        //    set
        //    {
        //        AppSettings.AddOrUpdateValue("AccessTokenExpirationDate", value);
        //    }
        //}


    }
}

