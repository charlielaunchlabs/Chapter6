using System;

using Xamarin.Forms;

namespace ChapterSix
{
	public class FirstContent : ContentPage
	{
		//MyPage xx =new MyPage();
		public FirstContent()
		{
			Content = new StackLayout
			{
				
				Children = {
					new Label { Text = "Hello ContentPage" },
				}
			};
			this.BackgroundColor = Color.Accent;
		}
	}
}


