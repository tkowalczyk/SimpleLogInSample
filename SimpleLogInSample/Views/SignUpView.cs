using System;
using Xamarin.Forms;

namespace SimpleLogInSample
{
	public class SignUpView : BaseView
	{
		public SignUpView ()
		{
			this.Content = new Button () 
			{
				Text = "Sign Up",
				VerticalOptions = LayoutOptions.Center,
				HorizontalOptions = LayoutOptions.Center,
			};
		}
	}
}