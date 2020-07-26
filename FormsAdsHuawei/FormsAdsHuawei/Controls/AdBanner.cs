using System;
using Xamarin.Forms;

namespace FormsAdsHuawei.Controls
{
    public class AdBanner : View
    {
        public event EventHandler AdsClicked;
        public event EventHandler AdsClosed;
        public event EventHandler AdsImpression;
        public event EventHandler AdsOpened;

        public static readonly BindableProperty AdsIdProperty = BindableProperty.Create("AdsId", typeof(string), typeof(AdBanner));

        public string AdsId
        {
            get => (string)GetValue(AdsIdProperty);
            set => SetValue(AdsIdProperty, value);
        }

        public static readonly BindableProperty PersonalizedAdsProperty = BindableProperty.Create("PersonalizedAds", typeof(bool), typeof(AdBanner));

        public bool? PersonalizedAds
        {
            get => (bool?)GetValue(PersonalizedAdsProperty);
            set => SetValue(PersonalizedAdsProperty, value);
        }

        public void AdClicked(object sender, EventArgs e)
        {
            AdsClicked?.Invoke(sender, e);
        }

        public void AdClosed(object sender, EventArgs e)
        {
            AdsClosed?.Invoke(sender, e);
        }

        public void AdImpression(object sender, EventArgs e)
        {
            AdsImpression?.Invoke(sender, e);
        }

        public void AdOpened(object sender, EventArgs e)
        {
            AdsOpened?.Invoke(sender, e);
        }
    }
}
