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
using XamarinAdsInstallReferrerDemo.InstallReferrer;

namespace XamarinAdsInstallReferrerDemo
{
    [Activity(Label = "@string/app_name", Theme = "@style/AppTheme", MainLauncher = true)]
    public class MainActivity : AppCompatActivity,View.IOnClickListener,RadioGroup.IOnCheckedChangeListener
    {
        private static readonly string TAG = "MainActivity";
    private RelativeLayout mInstallReferrerRl;
        private RelativeLayout mWriteInstallReferrerRl;
        private RadioGroup mModeGroup;
        private int mCallMode = CallMode.SDK;
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            
            // Set our view from the "main" layout resource
            SetContentView(Resource.Layout.activity_main);
            InitView();
        }

        private void InitView()
        {
            // Create the "install_referrer" TextView, which tries to show the obtained install referrer.
            mInstallReferrerRl = FindViewById<RelativeLayout>(Resource.Id.enter_install_referrer_rl);
            mInstallReferrerRl.SetOnClickListener(this);
            // Create the "write_install_referrer" view, which tries to enter the page where user can set service package name and install referer.
            mWriteInstallReferrerRl = FindViewById<RelativeLayout>(Resource.Id.write_install_referrer_rl);
            mWriteInstallReferrerRl.SetOnClickListener(this);

            mModeGroup = FindViewById<RadioGroup>(Resource.Id.call_mode_rg);
            mModeGroup.SetOnCheckedChangeListener(this);
        }

        public void OnClick(View v)
        {
            int id = v.Id;
            if (id == Resource.Id.enter_install_referrer_rl)
            {
                StartActivityIntent(typeof(InstallReferrerActivity));
            }else if(id == Resource.Id.write_install_referrer_rl)
            {
                StartActivityIntent(typeof(InstallReferrerWriteActivity));
            }
        }

        public void OnCheckedChanged(RadioGroup group, int checkedId)
        {
            GetCallMode(checkedId);
        }

        private void GetCallMode(int checkedId)
        {
            if (Resource.Id.mode_sdk_rb == checkedId)
            {
                mCallMode = CallMode.SDK;
            }else if(Resource.Id.mode_aidl_rb == checkedId)
            {
                mCallMode = CallMode.AIDL;
            }
        }


        private void StartActivityIntent(Type activity)
        {
            try
            {
                Intent intent = new Intent(this, activity);
                intent.PutExtra("mode", mCallMode);
                StartActivity(intent);
            }
            catch (Exception ex)
            {
                Log.Error(TAG, "startActivity Exception: " + ex.ToString());
                
            }
        }
    }
}