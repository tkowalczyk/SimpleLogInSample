using System;
using Xamarin.Forms;

namespace SimpleLogInSample
{
	public class SignInView : BaseView
	{
		public SignInView ()
		{
			Button signInButton = new Button () 
			{
				Text = "Sign In",
				VerticalOptions = LayoutOptions.Center,
				HorizontalOptions = LayoutOptions.Center,
			};

			signInButton.Clicked += async (s, e) => 
			{
				await Navigation.PushAsync(new MainView());
			};

			this.Content = signInButton;
		}
	}
}