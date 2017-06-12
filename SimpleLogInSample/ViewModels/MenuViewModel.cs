using System;
using System.Collections.ObjectModel;

namespace SimpleLogInSample
{
	public class MenuViewModel : BaseViewModel
	{
		#region Properties
		public ObservableCollection<MenuItem> MenuItems { get; set; }
		#endregion

		#region Ctor
		public MenuViewModel()
		{
			CanLoadMore = true;
			Title = "SimpleLoginForm";
			MenuItems = new ObservableCollection<MenuItem>();

			MenuItems.Add(new MenuItem
				{
					Id = 0,
					Title = "Home",
					MenuType = MenuType.Home,
					Icon = "home.png"
				});

			MenuItems.Add(new MenuItem
				{
					Id = 5,
					Title = "Contact",
					MenuType = MenuType.Contact,
					Icon = "contact.png"
				});

			MenuItems.Add(new MenuItem
				{
					Id = 6,
					Title = "About",
					MenuType = MenuType.About,
					Icon = "About.png"
				});
		}
		#endregion
	}
}