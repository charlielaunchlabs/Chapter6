using System;

using Xamarin.Forms;

namespace ChapterSix
{
	public class Tabbed : TabbedPage
	{
		public Tabbed()
		{
			this.Title = "Page";
			this.Children.Add(new MyPage() { Title ="First"});
			this.Children.Add(new FirstContent(){ Title = "Second" });
			this.Children.Add(new SecondPage(){ Title = "Third" });
		}
	}
}


