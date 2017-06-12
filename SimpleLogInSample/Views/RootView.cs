using System;
using Xamarin.Forms;

namespace SimpleLogInSample
{
	public class RootView : CarouselPage
	{
		ContentPage signIn, signUp;

		public RootView ()
		{
			signIn = new SignInView();
			signUp = new SignUpView ();

			this.Children.Add (signIn);
			this.Children.Add (signUp);

			MessagingCenter.Subscribe<ContentPage> (this, "Login", (sender) => {
				this.SelectedItem = signIn;
			});
			MessagingCenter.Subscribe<ContentPage> (this, "Create", (sender) => {
				this.SelectedItem = signUp;
			});
		}
	}
}