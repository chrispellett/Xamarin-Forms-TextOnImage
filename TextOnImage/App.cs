using System;
using Xamarin.Forms;

namespace TextOnImage
{
	public class App
	{
		public static Page GetMainPage ()
		{
			return new SamplePage ();
//			return new ContentPage { 
//				Content = new Label {
//					Text = "Hello, Forms!",
//					VerticalOptions = LayoutOptions.CenterAndExpand,
//					HorizontalOptions = LayoutOptions.CenterAndExpand,
//				},
//			};
		}
	}
}