using System;
using Xamarin.Forms;

namespace SimpleLogInSample
{
	public class MasterView : SecureBaseView
	{
		#region Fields
		private Page pageSelection;
		private MenuType menuType = MenuType.About;

		public Action<MenuType> PageSelectionChanged;
		public Page PageSelection
		{
			get { return pageSelection; }
			set
			{
				pageSelection = value;
				if (PageSelectionChanged != null)
					PageSelectionChanged(menuType);
			}
		}
		#endregion

		#region Menu
		private HomeMenuView home;
		private ContactMenuView contact;
		private AboutMenuView about;
		#endregion

		#region Ctor
		public MasterView(MenuViewModel viewModel)
		{
			this.BindingContext = viewModel;

			var layout = new StackLayout { Spacing = 0 };

			var listView = new ListView();

			var cell = new DataTemplate(typeof(ImageCell));

			cell.SetBinding(TextCell.TextProperty, MenuViewModel.TitlePropertyName);
			cell.SetBinding(ImageCell.ImageSourceProperty, "Icon");

			listView.ItemTemplate = cell;

			listView.ItemsSource = viewModel.MenuItems;
			if (about == null)
				about = new AboutMenuView();

			PageSelection = about;

			listView.ItemSelected += (sender, args) =>
			{
				var menuItem = listView.SelectedItem as MenuItem;
				menuType = menuItem.MenuType;
				switch (menuItem.MenuType)
				{
				case MenuType.Home:
					if (home == null)
						home = new HomeMenuView();

					PageSelection = home;
					break;
				case MenuType.Contact:
					if (contact == null)
						contact = new ContactMenuView();

					PageSelection = contact;
					break;
				case MenuType.About:
					if (about == null)
						about = new AboutMenuView();

					PageSelection = about;
					break;
				}
			};

			listView.SelectedItem = viewModel.MenuItems[0];
			layout.Children.Add(listView);

			this.Content = layout;
		}
		#endregion
	}
}