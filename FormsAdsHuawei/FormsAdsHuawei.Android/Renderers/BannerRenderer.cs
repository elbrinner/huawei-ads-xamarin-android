using System;
using FormsAdsHuawei.Controls;
using FormsAdsHuawei.Droid.Renderers;
using Xamarin.Forms;
using Xamarin.Forms.Platform.Android;
using Com.Huawei.Hms.Ads;
using Com.Huawei.Hms.Ads.Banner;
using Android.Content;
using Android.Widget;

[assembly: ExportRenderer(typeof(AdBanner), typeof(BannerRenderer))]
namespace FormsAdsHuawei.Droid.Renderers
{
    public class BannerRenderer : ViewRenderer<AdBanner, BannerView>
    {
        string _adUnitId = "testw6vs28auh3";

        BannerView _adView;

        private BannerView defaultBannerView;

        private const int REFRESH_TIME = 30;

        public BannerRenderer(Context context) : base(context)
        {

        }


        protected override void OnElementChanged(ElementChangedEventArgs<AdBanner> e)

        {

            base.OnElementChanged(e);

            if (Control == null)

            {

                CreateNativeControl(e.NewElement, e.NewElement.AdsId, e.NewElement.PersonalizedAds);

                SetNativeControl(_adView);

            }

        }



        private void CreateNativeControl(AdBanner myMtAdView, string adsId, bool? personalizedAds)

        {

            if (_adView != null)

                return;



            _adUnitId = !string.IsNullOrEmpty(adsId) ? adsId : "testw6vs28auh3";



            if (string.IsNullOrEmpty(_adUnitId))

            {

                Console.WriteLine("You must set the adsID before using it");

            }



            _adView = new BannerView(Context)

            {

                BannerAdSize = BannerAdSize.BannerSize46860,

                AdId = _adUnitId,

                LayoutParameters = new LinearLayout.LayoutParams(LayoutParams.WrapContent, LayoutParams.WrapContent)

            };



            _adView.AdListener = new AdsListener(Context);





            AdParam adParam = new AdParam.Builder().Build();

            _adView.LoadAd(adParam);



            _adView.SetBannerRefresh(REFRESH_TIME);





        }



        private class AdsListener : AdListener

        {



            public AdsListener(Context activity)

            {



            }

            public override void OnAdClicked()

            {

                // Called when a user taps an ad.

                var a = 1;



            }

            public override void OnAdClosed()

            {

                // Called when an ad is closed.

                var a = 1;



            }

            public override void OnAdFailed(int errorCode)

            {

                // Called when an ad fails to be loaded.

                var a = 1;



            }



            public override void OnAdLeave()

            {

                // Called when a user has left the app.

                var a = 1;



            }

            public override void OnAdOpened()

            {

                // Called when an ad is opened.

                var a = 1;



            }

            public override void OnAdLoaded()

            {

                // Called when an ad is loaded successfully.

                var a = 1;
            }
        }
    }
}
