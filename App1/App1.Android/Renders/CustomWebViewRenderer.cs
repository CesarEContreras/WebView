using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Android.Webkit;
using Xamarin.Forms;
using Xamarin.Forms.Platform.Android;
using App1;
using App1.Droid.Renders;


[assembly: ExportRenderer(typeof(LocalHtml), typeof(CustomWebViewRenderer))]
namespace App1.Droid.Renders
{
class CustomWebViewRenderer : Xamarin.Forms.Platform.Android.WebViewRenderer
        {
            protected override void OnElementChanged(ElementChangedEventArgs<Xamarin.Forms.WebView> e)
		{
			base.OnElementChanged (e);
			if (e.OldElement == null) {
				var webView = (Android.Webkit.WebView)Control;
				webView.Settings.JavaScriptEnabled = true;

				webView.LoadUrl ("file:///android_asset/Content/Chat.html");
				webView.Layout (10, 10, 10, 10);

				User user = new User ();
				webView.AddJavascriptInterface (user, "userCredential");

				webView.Settings.DatabaseEnabled = true;
				webView.Settings.DomStorageEnabled = true;
				string dbPath = Android.App.Application.Context.GetDir("EathisaDB.db3", FileCreationMode.Private).Path;
				webView.Settings.DatabasePath = dbPath;

				webView.Settings.LoadWithOverviewMode = true;
				webView.Settings.UseWideViewPort = true;

			}
		}
	}
}