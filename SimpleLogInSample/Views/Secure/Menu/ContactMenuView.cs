using System;
using Xamarin.Forms;

namespace SimpleLogInSample
{
	public class ContactMenuView : SecureBaseView
	{
		public ContactMenuView ()
		{
			this.Content = new Label () 
			{
				Text = "Contact",
				VerticalOptions = LayoutOptions.Center,
				HorizontalOptions = LayoutOptions.Center,
			};
		}
	}
}