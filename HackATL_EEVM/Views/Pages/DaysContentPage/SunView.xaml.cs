using HackATL_EEVM.Models;
using HackATL_EEVM.Utilities;
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
    public partial class SunView : ContentView
    {
        List<TypesModel> typesModelsSUN = new List<TypesModel>();
        List<TypesModel> mytypesModelsSun = new List<TypesModel>();
        bool _isAgenda = false;
        public SunView()
        {
            InitializeComponent();
            _isAgenda = false;
            BindData();
        }

        public SunView(bool isAgenda)
        {
            InitializeComponent();
            _isAgenda = isAgenda;
            BindAgendaData();
        }

        public void BindData()
        {
            typesModelsSUN.Clear();
            typesModelsSUN.Add(new TypesModel() { id = 1, Time = "8:00 AM", status = "Breakfast", Desc = "ESC Multipurpose", Description="", day="Sun", category="Food" });
            typesModelsSUN.Add(new TypesModel() { id = 2, Time = "9:00 AM", status = "Preliminary Pitch", Desc = "ESC Multipurpose Rooms", Description = "Preliminary pitch", day = "Sun", category = "Food" });
            typesModelsSUN.Add(new TypesModel() { id = 3, Time = "1:00 PM", status = "Lunch", Desc = "ESC Multipurpose Room 5", Description = "", day = "Sun", category = "Food" });
            typesModelsSUN.Add(new TypesModel() { id = 4, Time = "2:00 PM", status = "Finalround Pitch", Desc = "ESC Multipurpose Rooms 4,5 & 6", Description = "", day = "Sun", category = "Pitch" });
            typesModelsSUN.Add(new TypesModel() { id = 5, Time = "4:30 PM", status = "Closing Ceremony", Desc = "ESC Multipurpose Rooms 4,5 & 6", Description = "", day = "Sun", category = "Pitch" });
            flvTypes.FlowItemsSource = typesModelsSUN.ToList();
        }

        public void BindAgendaData()
        {
            typesModelsSUN.Clear();
            typesModelsSUN = Common.mytypesModelSUN.ToList();
            flvTypes.FlowItemsSource = typesModelsSUN.ToList();
        }

        private void BtnAdd_Tapped(object sender, EventArgs e)
        {
            if (!_isAgenda)
            {
                var rs = (Image)sender;
                var mImages = rs.BindingContext as TypesModel;
                foreach (var item in typesModelsSUN)
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

                Common.mytypesModelSUN.Add(mImages);
            }
        }

        private void BtnNotification_Tapped(object sender, EventArgs e)
        {
            if (!_isAgenda)
            {
                var rs = (Image)sender;
                var mImages = rs.BindingContext as TypesModel;
                foreach (var item in typesModelsSUN)
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



        }

        private void FlvTypes_FlowItemTapped(object sender, ItemTappedEventArgs e)
        {
            var Type = e.Item;
        }

        private void FlvTypes_ItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            var item = e.SelectedItem as TypesModel;
            if (item == null)
                return;



        }
    }
}