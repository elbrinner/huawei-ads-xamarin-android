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
using System.IO;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Util;
using Android.Views;
using Android.Widget;
using Com.Huawei.Hms.Ads.Installreferrer.Api;

namespace XamarinAdsInstallReferrerDemo.InstallReferrer
{
    public class InstallReferrerSdkUtil
    {
        private static readonly string TAG = "InstallReferrerSdkUtil";
        private Context mContext;
        private InstallReferrerClient mReferrerClient;
        private InstallReferrerCallback mCallback;

        public InstallReferrerSdkUtil(Context context) { mContext = context; }

        /// <summary>
        /// connect huawei ads service.
        /// </summary>
        /// <returns></returns>
        private bool Connect()
        {
            Log.Info(TAG, "connect...");
            if (null == mContext)
            {
                Log.Error(TAG, "connect context is null");
                return false;
            }

            // Create InstallReferrerClient
            mReferrerClient = InstallReferrerClient.NewBuilder(mContext).SetTest(true).Build();
            Log.Info(TAG, "InstallReferrerClient.NewBuilder called successfully.");
            Log.Info(TAG, "InstallReferrerClient.Builder.SetTest called successfully.");
            Log.Info(TAG, "InstallReferrerClient.Builder.Build called successfully.");
            // Start connecting service.
            mReferrerClient.StartConnection(new InstallReferrerListener(this));
            Log.Info(TAG, "InstallReferrerClient.StartConnection called successfully.");
            return true;

        }
        /// <summary>
        /// diconnect from huawei ads service.
        /// </summary>
        private void Disconnect()
        {
            Log.Info(TAG, "disconnect");
            if(null != mReferrerClient)
            {
                mReferrerClient.EndConnection();
                Log.Info(TAG, "InstallReferrerClient.EndConnection called successfully.");
                mReferrerClient = null;
                mContext = null;
            }
        }

        public void GetInstallReferrer(InstallReferrerCallback installReferrerCallback)
        {
            if(null == installReferrerCallback)
            {
                Log.Error(TAG, "getInstallReferrer callback is null");
                return;
            }
            mCallback = installReferrerCallback;
            Connect();
        }

        /// <summary>
        /// Obtain install referrer.
        /// </summary>
        private void Get()
        {
            if(null != mReferrerClient)
            {
                try
                {
                    // install referrer id information. Do not call this method in the main thread.
                    ReferrerDetails referrerDetails = mReferrerClient.InstallReferrer;
                    Log.Info(TAG, "InstallReferrerClient.IsReady: " + mReferrerClient.IsReady);
                    Log.Info(TAG, "InstallReferrerClient.InstallReferrer: "+mReferrerClient.InstallReferrer);
                    if (null != referrerDetails && null != mCallback)
                    {
                        // Update install referer details.
                        mCallback.OnSuccess(referrerDetails.InstallReferrer, referrerDetails.ReferrerClickTimestampMillisecond, referrerDetails.InstallBeginTimestampMillisecond);
                        Log.Info(TAG, "ReferrerDetails.InstallReferrer: " + referrerDetails.InstallReferrer);
                        Log.Info(TAG, "ReferrerDetails.ReferrerClickTimestampMillisecond: " + referrerDetails.ReferrerClickTimestampMillisecond);
                        Log.Info(TAG, "ReferrerDetails.InstallBeginTimestampMillisecond: " + referrerDetails.InstallBeginTimestampMillisecond);

                    }
                }
                catch (RemoteException remoteEx)
                {
                    Log.Info(TAG, "getInstallReferrer RemoteException: " + remoteEx.Message);
                }catch(IOException e)
                {
                    Log.Info(TAG, "getInstallReferrer IOException: " + e.Message);
                }catch(Java.IO.IOException ioEx)
                {
                    Toast.MakeText(mContext, ioEx.Message.ToString(), ToastLength.Short).Show();
                }
                finally
                {
                    Disconnect();
                }
            }
        }

        /// <summary>
        /// create new connect listener.
        /// </summary>
        private class InstallReferrerListener : Java.Lang.Object, IInstallReferrerStateListener
        {
            InstallReferrerSdkUtil installReferrerSdkUtil;
            const string TAG = "IInstallReferrerStateListener";
            public InstallReferrerListener(InstallReferrerSdkUtil installReferrerSdkUtil)
            {
                this.installReferrerSdkUtil = installReferrerSdkUtil;
            }
            public void OnInstallReferrerServiceDisconnected()
            {
                Log.Info(TAG, "onInstallReferrerServiceDisconnected");
            }

            public void OnInstallReferrerSetupFinished(int responseCode)
            {
                Log.Info(TAG, "OnInstallReferrerSetupFinished");
                switch (responseCode)
                {
                    case InstallReferrerClient.InstallReferrerResponse.Ok:
                        Log.Info(TAG, "connect ads kit ok");
                        installReferrerSdkUtil.Get();
                        break;

                    case InstallReferrerClient.InstallReferrerResponse.FeatureNotSupported:
                        // Service not supported. Please download and install the latest version of Huawei Mobile Services(APK).
                        Log.Info(TAG, "FEATURE_NOT_SUPPORTED");
                        break;
                    case InstallReferrerClient.InstallReferrerResponse.ServiceUnavailable:
                        // Service unavailable. Please update the version of Huawei Mobile Services(APK) to 2.6.5 or later.
                        Log.Info(TAG, "SERVICE_UNAVAILABLE");
                        break;
                    default:
                        Log.Info(TAG, "responseCode: " + responseCode);
                        break;
                }
            }
        }
    }
}