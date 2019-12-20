﻿using System;
using System.ComponentModel;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

using HackATL_EEVM.Models;
using HackATL_EEVM.ViewModels;

namespace HackATL_EEVM.Views
{
    // Learn more about making custom code visible in the Xamarin.Forms previewer
    // by visiting https://aka.ms/xamarinforms-previewer
    [DesignTimeVisible(false)]
    public partial class ItemDetailPage : ContentPage
    {
        ItemDetailViewModel viewModel;

        public ItemDetailPage(ItemDetailViewModel viewModel)
        {
            InitializeComponent();

            BindingContext = this.viewModel = viewModel;
        }

        public ItemDetailPage()
        {
            InitializeComponent();

            var item = new Item
            {
                Text = "Item Sample",
                Description = "This is an item description.",
                Time = "10:00 PM",
                Location = "GBS101",
                Type = "Food",
                Day = "FRI"


            };

            viewModel = new ItemDetailViewModel(item);
            BindingContext = viewModel;
        }
    }
}