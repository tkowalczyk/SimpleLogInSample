using System;
using Xamarin.Forms;

namespace SimpleLogInSample
{
	public class AboutMenuView : SecureBaseView
	{
		public AboutMenuView ()
		{
			this.Content = new Label () 
			{
				Text = "About",
				VerticalOptions = LayoutOptions.Center,
				HorizontalOptions = LayoutOptions.Center,
			};
		}
	}
}