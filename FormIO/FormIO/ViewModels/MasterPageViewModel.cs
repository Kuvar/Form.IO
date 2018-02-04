using FormIO.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using Xamarin.Forms;

namespace FormIO.ViewModels
{
    public class MasterPageViewModel : BaseViewModel
    {
        public ObservableCollection<MasterPageItem> MenuList { get; set; }

        private MasterPageItem _ItemSelected;
        public MasterPageItem OnRowItemSelected
        {
            get
            {
                return _ItemSelected;
            }
            set
            {
                if (value != null)
                {
                    _ItemSelected = null;
                    OnRowSelection(value);
                }
            }
        }

        
        public MasterPageViewModel(INavigation navigation)
        {
            Navigation = navigation;
            GetMenu();
        }

        private void GetMenu()
        {
            List<MasterPageItem> menuList = new List<MasterPageItem>();
            menuList.Add(new MasterPageItem {Title = "Simple Form", TargetType = typeof(DetailPage) });
            menuList.Add(new MasterPageItem { Title = "Complex Form", TargetType = typeof(ComplexPage) });

            MenuList = new ObservableCollection<MasterPageItem>(menuList);
            OnPropertyChanged("MenuList");
        }

        private void OnRowSelection(MasterPageItem value)
        {
            ((MainPage)Application.Current.MainPage).NavigateToPage((Page)Activator.CreateInstance(value.TargetType));
        }
    }
}
