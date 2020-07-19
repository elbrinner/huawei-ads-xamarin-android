/*
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
using Android.App;
using Android.OS;
using Android.Support.V7.App;
using Android.Runtime;
using Android.Widget;
using Android.Views;
using System;
using Android.Content;
using Android.Util;
using XamarinAdsOAIDDemo.Oaid;

namespace XamarinAdsOAIDDemo
{
    [Activity(Label = "@string/app_name", Theme = "@style/AppTheme", MainLauncher = true)]
    public class MainActivity : AppCompatActivity,View.IOnClickListener
    {
        private static readonly string TAG = "MainActivity";
        private RelativeLayout mAdIdRl;
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            
            // Set our view from the "main" layout resource
            SetContentView(Resource.Layout.activity_main);
            InitView();
        }
       
        private void InitView()
        {
            //Create the "ad_id" view, which tries to enter "OAID" show page.
            mAdIdRl = FindViewById<RelativeLayout>(Resource.Id.enter_ad_id_rl);
            mAdIdRl.SetOnClickListener(this);
        }
        public void OnClick(View v)
        {
            if(v.Id == Resource.Id.enter_ad_id_rl)
            {
                StartActivity(typeof(OaidActivity));
            }
        }

        private void StartActivity(Type activity)
        {
            try
            {
                Intent intent = new Intent(this, activity);
                StartActivity(intent);
            }
            catch (Exception ex)
            {
                Log.Error(TAG, "startActivity Exception: " + ex.ToString());
            }
        }
    }
}