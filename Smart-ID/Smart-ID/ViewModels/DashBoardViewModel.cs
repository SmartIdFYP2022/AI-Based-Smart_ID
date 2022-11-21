using Smart_ID.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace Smart_ID.ViewModels
{
    public class DashBoardViewModel
    {
        ObservableCollection<DashBoardListViewModel> dataList = new ObservableCollection<DashBoardListViewModel>();
        public ObservableCollection<DashBoardListViewModel> DashBoardLists { get { return dataList; } }

        public DashBoardViewModel()
        {
            FlayoutButton = new Command(CanExecuteFlayoutAsync);
            dataList.Add(new DashBoardListViewModel { ImgUrl = "menu_icon.svg", Name = "File skripshit", MemorySpace = 50, Items = 32, IconUrl = "three_dots_icon.png" });
            dataList.Add(new DashBoardListViewModel { ImgUrl = "menu_icon.svg", Name = "Exploration.png", MemorySpace = 4, IconUrl = "three_dots_icon.png" });
            dataList.Add(new DashBoardListViewModel { ImgUrl = "menu_icon.svg", Name = "Brief website.pdf ", MemorySpace = 2, Items = 32, IconUrl = "three_dots_icon.png" });
            dataList.Add(new DashBoardListViewModel { ImgUrl = "menu_icon.svg", Name = "File skripshit", MemorySpace = 50, Items = 32, IconUrl = "three_dots_icon.png" });
            dataList.Add(new DashBoardListViewModel { ImgUrl = "menu_icon.svg", Name = "Exploration.png", MemorySpace = 4, IconUrl = "three_dots_icon.png" });
            dataList.Add(new DashBoardListViewModel { ImgUrl = "menu_icon.svg", Name = "Brief website.pdf ", MemorySpace = 2, Items = 32, IconUrl = "three_dots_icon.png" });
            dataList.Add(new DashBoardListViewModel { ImgUrl = "menu_icon.svg", Name = "File skripshit", MemorySpace = 50, Items = 32, IconUrl = "three_dots_icon.png" });
            dataList.Add(new DashBoardListViewModel { ImgUrl = "menu_icon.svg", Name = "Exploration.png", MemorySpace = 4, IconUrl = "three_dots_icon.png" });
            dataList.Add(new DashBoardListViewModel { ImgUrl = "menu_icon.svg", Name = "Brief website.pdf ", MemorySpace = 2, Items = 32, IconUrl = "three_dots_icon.png" });
            dataList.Add(new DashBoardListViewModel { ImgUrl = "menu_icon.svg", Name = "File skripshit", MemorySpace = 50, Items = 32, IconUrl = "three_dots_icon.png" });
            dataList.Add(new DashBoardListViewModel { ImgUrl = "menu_icon.svg", Name = "Exploration.png", MemorySpace = 4, IconUrl = "three_dots_icon.png" });
            dataList.Add(new DashBoardListViewModel { ImgUrl = "menu_icon.svg", Name = "Brief website.pdf ", MemorySpace = 2, Items = 32, IconUrl = "three_dots_icon.png" });
        }
        public ICommand FlayoutButton { get; set; }
        public async void CanExecuteFlayoutAsync(object obj)
        {
            //await Application.Current.MainPage.Navigation.PushAsync(new FlyoutMenuPage());

        }
    }
}
