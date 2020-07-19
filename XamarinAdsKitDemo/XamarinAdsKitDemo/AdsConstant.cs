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
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;

namespace XamarinAdsKitDemo
{
    public class AdsConstant
    {
        //SharedPrefences name.
        public const string SP_NAME = "HuaweiAdsSdkSharedPreferences";

        //The SP key of protocol.
        public const string SP_PROTOCOL_KEY = "protocol";

        //The SP key of consent.
        public const string SP_CONSENT_KEY = "consent";

        //The SP default value of protocol.
        public const int DEFAULT_SP_PROTOCOL_VALUE = 0;

        //The SP default value of consent.
        public const int DEFAULT_SP_CONSENT_VALUE = -1;


    }
}