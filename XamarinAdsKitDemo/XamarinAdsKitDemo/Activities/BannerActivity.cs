﻿/*
Copyright (c) Huawei Technologies Co., Ltd. 2012-2020. All rights reserved.

    Licensed under the Apache License, Version 2.0 (the "License");
    you may not use this file except in compliance with the License.
    You may obtain a copy of the License at

    http://www.apache.org/licenses/LICENSE-2.0

    Unless required by applicable law or agreed to in writing, software
    distributed under the License is distributed on an "AS IS" BASIS,
    WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
    See the License for the specific language governing permissions and
    limitations under the License.
*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.Graphics;
using Android.Nfc;
using Android.OS;
using Android.Runtime;
using Android.Util;
using Android.Views;
using Android.Widget;
using Com.Huawei.Hms.Ads;
using Com.Huawei.Hms.Ads.Banner;

namespace XamarinAdsKitDemo.Activities
{
    [Activity(Label = "BannerActivity")]
    public class BannerActivity : BaseActivity,View.IOnClickListener
    {
        private const string TAG = "BannerActivity";
        private const int REFRESH_TIME = 30;

        private BannerView bannerView;

        private BannerView defaultBannerView;
        
        private FrameLayout adFrameLayout;

        private RadioGroup sizeRadioGroup;

        private RadioGroup colorRadioGroup;

        public void OnClick(View v)
        {
            defaultBannerView.Visibility = ViewStates.Invisible;
            if(bannerView != null)
            {
                adFrameLayout.RemoveView(bannerView);
                bannerView.Destroy();
            }

            //Call new BannerView(Context context) to create a BannerView class.
            bannerView = new BannerView(v.Context);

            //Set an ad Slot ID.
            bannerView.AdId = GetString(Resource.String.banner_ad_id);
            Log.Info(TAG, "AdId has been successfully set.");
            Log.Info(TAG, "AdId has been successfully get. AdId: " + bannerView.AdId);
            // Set the background color and size based on user selection.
            BannerAdSize adSize = GetBannerAdSize(sizeRadioGroup.CheckedRadioButtonId);

            bannerView.BannerAdSize = adSize;
            Log.Info(TAG, "BannerAdSize has been successfully set.");



            Color color = GetBannerViewBackground(colorRadioGroup.CheckedRadioButtonId);
            bannerView.SetBackgroundColor(color);

            adFrameLayout.AddView(bannerView);
            bannerView.AdListener = new AdsListener(this);
            Log.Info(TAG, "AdListener has been successfully set.");
            Log.Info(TAG, "AdListener has been successfully get. AdId: " + bannerView.AdListener);
            bannerView.LoadAd(new AdParam.Builder().Build());
            Log.Info(TAG, "LoadAd function has been successfully set.");
            Log.Info(TAG, "BannerView.IsLoading: " + bannerView.IsLoading);

            bannerView.Pause();
            Log.Info(TAG, "Pause called successfully.");
            bannerView.Resume();
            Log.Info(TAG, "Resume called successfully.");

            bannerView.SetBannerRefresh(30000);
            Log.Info(TAG, "SetBannerRefresh called successfully.");

        }

       

        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            Title = GetString(Resource.String.banner_ad);
            SetContentView(Resource.Layout.activity_banner);
            // Create your application here

            TextView bannertitle = FindViewById<TextView>(Resource.Id.text_banner);
            bannertitle.Text = GetString(Resource.String.banner_title);

            sizeRadioGroup = FindViewById<RadioGroup>(Resource.Id.size_radioGroup);
            colorRadioGroup = FindViewById<RadioGroup>(Resource.Id.color_radioGroup);

            // Load the default banner ad
            LoadDefaultBanner();

            // Set the button for loading an ad.
            Button loadButton = FindViewById<Button>(Resource.Id.refreshButton);
            loadButton.SetOnClickListener(this);

            adFrameLayout = FindViewById<FrameLayout>(Resource.Id.ad_frame);
        }
        /// <summary>
        /// Load the default banner ad.
        /// </summary>
        private void LoadDefaultBanner()
        {
            // Obtain BannerView based on the configuration in layout/activity_main.xml.
            defaultBannerView = FindViewById<BannerView>(Resource.Id.hw_banner_view);
            defaultBannerView.AdListener = new AdsListener(this);
            defaultBannerView.SetBannerRefresh(REFRESH_TIME);

            AdParam adParam = new AdParam.Builder().Build();
            defaultBannerView.LoadAd(adParam);
        }
        private void ShowToast(string message)
        {
            Toast.MakeText(this, message, ToastLength.Short).Show();
        }
        private Color GetBannerViewBackground(int checkedRadioButtonId)
        {
            Color color = Color.Transparent;
            switch (checkedRadioButtonId)
            {
                case Resource.Id.color_white:
                    color = Color.White;
                    break;
                case Resource.Id.color_black:
                    color = Color.Black;
                    break;
                case Resource.Id.color_red:
                    color = Color.Red;
                    break;
                case Resource.Id.color_transparent:
                    color = Color.Transparent;
                    break;
                
            }
            return color;
        }

        private BannerAdSize GetBannerAdSize(int checkedRadioButtonId)
        {
            BannerAdSize adSize = null;
            switch (checkedRadioButtonId)
            {
                case Resource.Id.size_320_50:
                    adSize = BannerAdSize.BannerSize32050;
                    break;
                case Resource.Id.size_320_100:
                    adSize = BannerAdSize.BannerSize320100;
                    break;
                case Resource.Id.size_300_250:
                    adSize = BannerAdSize.BannerSize300250;
                    break;
                case Resource.Id.size_smart:
                    adSize = BannerAdSize.BannerSizeSmart;
                    break;
                case Resource.Id.size_360_57:
                    adSize = BannerAdSize.BannerSize36057;
                    break;
                case Resource.Id.size_360_144:
                    adSize = BannerAdSize.BannerSize360144;
                    break;
               
            }
            return adSize;
        }
        private class AdsListener : AdListener
        {
            BannerActivity activity;
            public AdsListener(BannerActivity activity)
            {
                this.activity = activity;
            }
            public override void OnAdClicked()
            {
                // Called when a user taps an ad.
                activity.ShowToast("Ad clicked.");
            }
            public override void OnAdClosed()
            {
                // Called when an ad is closed.
                activity.ShowToast("Ad closed.");
            }
            public override void OnAdFailed(int errorCode)
            {
                // Called when an ad fails to be loaded.
                activity.ShowToast("Ad failed. ERROR CODE: " +errorCode);
            }
           
            public override void OnAdLeave()
            {
                // Called when a user has left the app.
                activity.ShowToast("Ad Leave.");
            }
            public override void OnAdOpened()
            {
                // Called when an ad is opened.
                activity.ShowToast("Ad opened.");
            }
            public override void OnAdLoaded()
            {
                // Called when an ad is loaded successfully.
                activity.ShowToast("Ad loaded.");

            }
        }
    }
}