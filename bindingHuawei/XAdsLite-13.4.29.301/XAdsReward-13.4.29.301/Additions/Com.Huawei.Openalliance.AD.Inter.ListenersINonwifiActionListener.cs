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
using Java.Interop;

namespace Com.Huawei.Openalliance.AD.Inter.Listeners
{
	// Metadata.xml XPath interface reference: path="/api/package[@name='com.huawei.openalliance.ad.inter.listeners']/interface[@name='INonwifiActionListener']"
	[Register("com/huawei/openalliance/ad/inter/listeners/INonwifiActionListener", "", "Com.Huawei.Openalliance.AD.Inter.Listeners.INonwifiActionListenerInvoker")]
	public partial interface INonwifiActionListener : IJavaObject, IJavaPeerable
	{

		// Metadata.xml XPath method reference: path="/api/package[@name='com.huawei.openalliance.ad.inter.listeners']/interface[@name='INonwifiActionListener']/method[@name='Code' and count(parameter)=2 and parameter[1][@type='com.huawei.openalliance.ad.inter.data.AppInfo'] and parameter[2][@type='long']]"
		[Register("Code", "(Lcom/huawei/openalliance/ad/inter/data/AppInfo;J)Z", "GetCode_Lcom_huawei_openalliance_ad_inter_data_AppInfo_JHandler:Com.Huawei.Openalliance.AD.Inter.Listeners.INonwifiActionListenerInvoker, XAdsReward-13.4.29.301")]
		bool Code(global::Com.Huawei.Openalliance.AD.Inter.Data.AppInfo param0, long param1);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.huawei.openalliance.ad.inter.listeners']/interface[@name='INonwifiActionListener']/method[@name='Code' and count(parameter)=1 and parameter[1][@type='long']]"
		[Register("Code", "(J)Z", "GetCode_JHandler:Com.Huawei.Openalliance.AD.Inter.Listeners.INonwifiActionListenerInvoker, XAdsReward-13.4.29.301")]
		bool Code(long mParam0);

	}

	[global::Android.Runtime.Register("com/huawei/openalliance/ad/inter/listeners/INonwifiActionListener", DoNotGenerateAcw = true)]
	internal partial class INonwifiActionListenerInvoker : global::Java.Lang.Object, INonwifiActionListener
	{

		static readonly JniPeerMembers _members = new XAPeerMembers("com/huawei/openalliance/ad/inter/listeners/INonwifiActionListener", typeof(INonwifiActionListenerInvoker));

		static IntPtr java_class_ref
		{
			get { return _members.JniPeerType.PeerReference.Handle; }
		}

		public override global::Java.Interop.JniPeerMembers JniPeerMembers
		{
			get { return _members; }
		}

		protected override IntPtr ThresholdClass
		{
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType
		{
			get { return _members.ManagedPeerType; }
		}

		IntPtr class_ref;

		public static INonwifiActionListener GetObject(IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<INonwifiActionListener>(handle, transfer);
		}

		static IntPtr Validate(IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf(handle, java_class_ref))
				throw new InvalidCastException(string.Format("Unable to convert instance of type '{0}' to type '{1}'.",
							JNIEnv.GetClassNameFromInstance(handle), "com.huawei.openalliance.ad.inter.listeners.INonwifiActionListener"));
			return handle;
		}

		protected override void Dispose(bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef(this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose(disposing);
		}

		public INonwifiActionListenerInvoker(IntPtr handle, JniHandleOwnership transfer) : base(Validate(handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass(((global::Java.Lang.Object)this).Handle);
			this.class_ref = JNIEnv.NewGlobalRef(local_ref);
			JNIEnv.DeleteLocalRef(local_ref);
		}

		static Delegate cb_Code_Lcom_huawei_openalliance_ad_inter_data_AppInfo_J;
#pragma warning disable 0169
		static Delegate GetCode_Lcom_huawei_openalliance_ad_inter_data_AppInfo_JHandler()
		{
			if (cb_Code_Lcom_huawei_openalliance_ad_inter_data_AppInfo_J == null)
				cb_Code_Lcom_huawei_openalliance_ad_inter_data_AppInfo_J = JNINativeWrapper.CreateDelegate((Func<IntPtr, IntPtr, IntPtr, long, bool>)n_Code_Lcom_huawei_openalliance_ad_inter_data_AppInfo_J);
			return cb_Code_Lcom_huawei_openalliance_ad_inter_data_AppInfo_J;
		}

		static bool n_Code_Lcom_huawei_openalliance_ad_inter_data_AppInfo_J(IntPtr jnienv, IntPtr native__this, IntPtr native_param0, long param1)
		{
			global::Com.Huawei.Openalliance.AD.Inter.Listeners.INonwifiActionListener __this = global::Java.Lang.Object.GetObject<global::Com.Huawei.Openalliance.AD.Inter.Listeners.INonwifiActionListener>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Huawei.Openalliance.AD.Inter.Data.AppInfo param0 = global::Java.Lang.Object.GetObject<global::Com.Huawei.Openalliance.AD.Inter.Data.AppInfo>(native_param0, JniHandleOwnership.DoNotTransfer);
			bool __ret = __this.Code(param0, param1);
			return __ret;
		}
#pragma warning restore 0169

		IntPtr id_Code_Lcom_huawei_openalliance_ad_inter_data_AppInfo_J;
		public unsafe bool Code(global::Com.Huawei.Openalliance.AD.Inter.Data.AppInfo param0, long param1)
		{
			if (id_Code_Lcom_huawei_openalliance_ad_inter_data_AppInfo_J == IntPtr.Zero)
				id_Code_Lcom_huawei_openalliance_ad_inter_data_AppInfo_J = JNIEnv.GetMethodID(class_ref, "Code", "(Lcom/huawei/openalliance/ad/inter/data/AppInfo;J)Z");
			JValue* __args = stackalloc JValue[2];
			__args[0] = new JValue((param0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object)param0).Handle);
			__args[1] = new JValue(param1);
			bool __ret = JNIEnv.CallBooleanMethod(((global::Java.Lang.Object)this).Handle, id_Code_Lcom_huawei_openalliance_ad_inter_data_AppInfo_J, __args);
			return __ret;
		}

		static Delegate cb_Code_J;
#pragma warning disable 0169
		static Delegate GetCode_JHandler()
		{
			if (cb_Code_J == null)
				cb_Code_J = JNINativeWrapper.CreateDelegate((Func<IntPtr, IntPtr, long, bool>)n_Code_J);
			return cb_Code_J;
		}

		static bool n_Code_J(IntPtr jnienv, IntPtr native__this, long mParam0)
		{
			global::Com.Huawei.Openalliance.AD.Inter.Listeners.INonwifiActionListener __this = global::Java.Lang.Object.GetObject<global::Com.Huawei.Openalliance.AD.Inter.Listeners.INonwifiActionListener>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.Code(mParam0);
		}
#pragma warning restore 0169

		IntPtr id_Code_J;
		public unsafe bool Code(long mParam0)
		{
			if (id_Code_J == IntPtr.Zero)
				id_Code_J = JNIEnv.GetMethodID(class_ref, "Code", "(J)Z");
			JValue* __args = stackalloc JValue[1];
			__args[0] = new JValue(mParam0);
			return JNIEnv.CallBooleanMethod(((global::Java.Lang.Object)this).Handle, id_Code_J, __args);
		}

	}

	// event args for com.huawei.openalliance.ad.inter.listeners.INonwifiActionListener.Code
	public partial class CodeEventArgs : global::System.EventArgs
	{

		public CodeEventArgs(bool mhandled, global::Com.Huawei.Openalliance.AD.Inter.Data.AppInfo param0, long param1)
		{
			this.mhandled = mhandled;
			this.param0 = param0;
			this.param1 = param1;
		}

		bool mhandled;
		public bool Handled
		{
			get { return handled; }
			set { handled = value; }
		}

		global::Com.Huawei.Openalliance.AD.Inter.Data.AppInfo param0;
		public global::Com.Huawei.Openalliance.AD.Inter.Data.AppInfo Param0
		{
			get { return param0; }
		}

		long param1;
		public long Param1
		{
			get { return param1; }
		}
	}

	// event args for com.huawei.openalliance.ad.inter.listeners.INonwifiActionListener.Code
	public partial class CodeEventArgs : global::System.EventArgs
	{

		public CodeEventArgs(bool handled, long mParam0)
		{
			this.handled = handled;
			this.mParam0 = mParam0;
		}

		bool handled;
		public bool mHandled
		{
			get { return handled; }
			set { handled = value; }
		}

		long mParam0;
		public long MParam0
		{
			get { return mParam0; }
		}
	}

	[global::Android.Runtime.Register("mono/com/huawei/openalliance/ad/inter/listeners/INonwifiActionListenerImplementor")]
	internal sealed partial class INonwifiActionListenerImplementor : global::Java.Lang.Object, INonwifiActionListener
	{

		object sender;

		public INonwifiActionListenerImplementor(object sender)
			: base(
				global::Android.Runtime.JNIEnv.StartCreateInstance("mono/com/huawei/openalliance/ad/inter/listeners/INonwifiActionListenerImplementor", "()V"),
				JniHandleOwnership.TransferLocalRef)
		{
			global::Android.Runtime.JNIEnv.FinishCreateInstance(((global::Java.Lang.Object)this).Handle, "()V");
			this.sender = sender;
		}

#pragma warning disable 0649
		public EventHandler<CodeEventArgs> CodeHandler;
#pragma warning restore 0649

		public bool Code(global::Com.Huawei.Openalliance.AD.Inter.Data.AppInfo param0, long param1)
		{
			var __h = CodeHandler;
			if (__h == null)
				return false;
			var __e = new CodeEventArgs(true, param0, param1);
			__h(sender, __e);
			return __e.Handled;
		}
#pragma warning disable 0649
		public EventHandler<CodeEventArgs> mCodeHandler;
#pragma warning restore 0649

		public bool Code(long mParam0)
		{
			var __h = CodeHandler;
			if (__h == null)
				return false;
			var __e = new CodeEventArgs(true, mParam0);
			__h(sender, __e);
			return __e.Handled;
		}

		internal static bool __IsEmpty(INonwifiActionListenerImplementor value)
		{
			return value.CodeHandler == null && value.CodeHandler == null;
		}
	}
}