using System;
using Xamarin.Forms;

namespace SimpleLogInSample
{
	public class HomeMenuView : SecureBaseView
	{
		public HomeMenuView ()
		{
			this.Content = new Label () 
			{
				Text = "Home",
				VerticalOptions = LayoutOptions.Center,
				HorizontalOptions = LayoutOptions.Center,
			};
		}
	}
}