using System;
using Xamarin.Forms;

namespace App1
{
    public class WebPage : ContentPage
    {
        public WebPage()
        {
            var browser = new WebView();

            browser.Source = "http://xamarin.com";

            Content = browser;
        }
    }
}

