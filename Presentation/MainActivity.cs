using Android.App;
using Android.OS;
using Android.Views;
using Android.Webkit;

namespace Freshaus
{
    [Activity(Label = "Freshaus", MainLauncher = true)]
    public class MainActivity : Activity
    {
        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);
            RequestWindowFeature(WindowFeatures.NoTitle);
            SetContentView(Resource.Layout.Main);
            WebView webView = FindViewById<WebView>(Resource.Id.webView);
            webView.Settings.JavaScriptEnabled = true;
            webView.SetWebViewClient(new WebViewClient());
            webView.LoadUrl("https://www.freshaus.co.uk");

        }
    }
}

