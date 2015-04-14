using System;

using Xamarin.Forms;

namespace PasswordlessLogin
{
	public class PhoneNumberPage : ContentPage
	{
		public PhoneNumberPage ()
		{
			Content = new StackLayout { 
				Children = {
					new Label { Text = "Hello ContentPage" }
				}
			};
		}
	}
}


