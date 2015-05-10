using System;
using Xamarin.Forms;

namespace App1
{
    class HomePage : ContentPage
    {
        public HomePage()
        {
            //var stack = new StackLayout(); //{ VerticalOptions = LayoutOptions.FillAndExpand, HorizontalOptions = LayoutOptions.FillAndExpand };
            //LocalHtml browser = new LocalHtml();
            //browser.Source = "wwww.google.com";
            //stack.Children.Add(browser);
            //this.Content = browser;

//			var web = new WebView {
//				WidthRequest = 5,
//				HeightRequest = 400,
//				Source = "file:///android_asset/Content/Chat.html"
//			}; // want this to just always go full-screen...
//					

			// test PopToRootAsync bugfix in 1.2.2-pre2

//			Content = new StackLayout {
//				VerticalOptions = LayoutOptions.StartAndExpand,
//				Children = {web}
//			};


			var browser = new LocalHtml {
				Source = "file:///android_asset/Content/Chat.html",
				WidthRequest = 140,
				HeightRequest = 200,
			}; // want this to just always go full-screen...();
			Content = new AbsoluteLayout {
				WidthRequest = 200,
				HeightRequest = 400,
				Children = { browser }
			};

        }

    }
}
