using System;

using Xamarin.Forms;

namespace ChapterSix
{
	public class SecondPage : ContentPage
	{
		public SecondPage()
		{
			Label label = new Label();
			Button button = new Button { Text = "Show ActionSheet" };
			button.Clicked += async (sender, e) =>
			{
				String action = await DisplayActionSheet("Options",
			 	"Cancel", null, "Here", "There", "Everywhere");
				label.Text = "Action is :" + action;

				if (action == "Here")
				{
					await this.DisplayAlert(action, "Locale", "Cancel");

				}
				else if (action == "There")
				{
					await Navigation.PushAsync(new FirstContent());
				}
				else if (action == "Everywhere")
				{
					await Navigation.PushAsync(new Tabbed());
				}
			};
			Content = new StackLayout
			{
				Children = {
					new Label { Text = "Hello ContentPage" },button,label
				}
			};
		}
	}
}


