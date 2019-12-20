using HackATL_EEVM.Models;
using HackATL_EEVM.Services.Item_realted;
using HackATL_EEVM.Utilities;
using HackATL_EEVM.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace HackATL_EEVM.Views.Pages.DaysContentPage
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class FridayView : ContentView
    {
        FirebaseItem firebase = new FirebaseItem();
        List<TypesModel> typesModelsFRI = new List<TypesModel>();
        List<TypesModel> mytypesModelsFRI = new List<TypesModel>();
        List<Item> agendaList = new List<Item>();
        bool _isAgenda = false;
        public FridayView()
        {
            InitializeComponent();
            _isAgenda = false;
            BindData();
        }

        public FridayView(bool isAgenda)
        {
            InitializeComponent();
            _isAgenda = isAgenda;
            BindAgendaData();
        }

        public void BindData()
        {
            typesModelsFRI.Clear();
            typesModelsFRI.Add(new TypesModel() { id = 1, Time = "5:00 PM", status = "Check-In", Desc = "Goizuetafri Business School Arches", Description="Check in to the event", day="FRI", });
            typesModelsFRI.Add(new TypesModel() { id = 2, Time = "6:00 PM", status = "Dinner", Desc = "Coke Commons", Description = "Aladdin’s Mediterranean Grill", day = "FRI", category="Food" });
            typesModelsFRI.Add(new TypesModel() { id = 3, Time = "8:00 PM", status = "Ideation Workshop", Desc = "Goizueta GBS 204", Description = "This workshop is intended to help you identify problems and solutions to those problems when you’re developing your HackATL idea. Whether you’re a seasoned hackathoner or a newcomer, we highly recommend going to this workshop.", day = "FRI", category = "Workshop" });
            typesModelsFRI.Add(new TypesModel() { id = 4, Time = "9:00 PM", status = "Category Breakout", Desc = "TBD", Description = "Break ups into different categories", day = "FRI", category = "Workshop" });
            typesModelsFRI.Add(new TypesModel() { id = 5, Time = "11:30 PM", status = "Midnight Snack", Desc = "Coke Commons", Description = "Auntie Anne’s Pretzels", day = "FRI", category = "Food" });
 
            flvTypes.FlowItemsSource = typesModelsFRI.ToList();
        }

        public void BindAgendaData()
        {
            typesModelsFRI.Clear();
         typesModelsFRI = Common.mytypesModelFRI.ToList();
            flvTypes.FlowItemsSource = typesModelsFRI.ToList();
        }

        private void BtnAdd_Tapped(object sender, EventArgs e)
        {
            if (!_isAgenda)
            {
                var rs = (Image)sender;
                var mImages = rs.BindingContext as TypesModel;
                foreach (var item in typesModelsFRI)
                {
                    if (item.id == mImages.id)
                    {
                        if (mImages.IsAddImage == "AddSelected.png")
                        {
                            item.IsAddImage = "Add.png";
                        }
                        else
                        {
                            item.IsAddImage = "AddSelected.png";

                        }
                    }
                    else
                    {
                        item.IsAddImage = "Add.png";
                    }
                }
                
                Common.mytypesModelFRI.Add(mImages);
            }
        }

        private void BtnNotification_Tapped(object sender, EventArgs e)
        {
            if (!_isAgenda)
            {
                var rs = (Image)sender;
                var mImages = rs.BindingContext as TypesModel;
                foreach (var item in typesModelsFRI)
                {
                    if (item.id == mImages.id)
                    {
                        if (mImages.IsNotificationImage == "BellSelected.png")
                        {
                            item.IsNotificationImage = "Bell.png";
                        }
                        else
                        {
                            item.IsNotificationImage = "BellSelected.png";
                        }
                    }
                    else
                    {
                        item.IsNotificationImage = "Bell.png";
                    }
                }
            }
        }
        async void OnItemSelected(object sender, SelectedItemChangedEventArgs args)
        {
            var item = args.SelectedItem as Item;
            if (item == null)
                return;

            await Navigation.PushAsync(new ItemDetailPage(new ItemDetailViewModel(item)));
            flvTypes.SelectedItem = null;

        }

        private void FlvTypes_FlowItemTapped(object sender, ItemTappedEventArgs e)
        {
            var Type = e.Item;
        }
    }
}