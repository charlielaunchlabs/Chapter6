using System;

using Xamarin.Forms;

namespace ChapterSix
{
	public class MyPage : CarouselPage
	{
		public MyPage()
		{

			Button press = new Button { Text = "Press" };

			ContentPage xx = new ContentPage
			{
				Content = new StackLayout
				{
					Orientation = StackOrientation.Vertical,
					VerticalOptions = LayoutOptions.CenterAndExpand,
					Children = { press}
				}
			};
			ContentPage xy = new ContentPage
			{
				Content = new BoxView { BackgroundColor = Color.Blue }
			};


			Children.Add(xx);
			Children.Add(xy);


			ToolbarItems.Clear();
			ToolbarItems.Add(new ToolbarItem
			{
				Text = "Home",
				Order = ToolbarItemOrder.Secondary,
				Command = new Command(() =>
				Navigation.PushAsync(new FirstContent()))
			});
			ToolbarItems.Add(new ToolbarItem
			{
				Text = "Second",
				Order = ToolbarItemOrder.Secondary,
				Command = new Command(() =>
				Navigation.PushAsync(new SecondPage()))
			});

				press.Clicked += async (sender, args) =>
				await Navigation.PushAsync(new FirstContent());

		}


	}
}

