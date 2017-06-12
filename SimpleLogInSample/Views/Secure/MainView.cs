﻿using System;
using Xamarin.Forms;
using System.Collections.Generic;

namespace SimpleLogInSample
{
	public class MainView : MasterDetailPage
	{
		#region Fields
		private MenuViewModel ViewModel
		{
			get { return BindingContext as MenuViewModel; }
		}

		private MasterView master;

		private Dictionary<MenuType, NavigationPage> pages;
		#endregion

		public MainView ()
		{
			pages = new Dictionary<MenuType, NavigationPage>();

			this.BindingContext = new MenuViewModel();

			this.Master = master = new MasterView(ViewModel);

			var homeNav = new NavigationPage(master.PageSelection)
			{

			};

			this.Detail = homeNav;

			pages.Add(MenuType.Home, homeNav);

			master.PageSelectionChanged = (menuType) =>
			{
				NavigationPage newPage;

				if (pages.ContainsKey(menuType))
				{
					newPage = pages[menuType];
				}
				else
				{
					newPage = new NavigationPage(master.PageSelection)
					{

					};
					pages.Add(menuType, newPage);
				}
				Detail = newPage;
				Detail.Title = master.PageSelection.Title;
				IsPresented = false;
			};
		}
	}
}