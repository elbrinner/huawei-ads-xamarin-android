# HP_HMSCore-Plugin-Xamarin_Ads-Library

## Contents
- Introduction
- Installation Guide
- Xamarin Ads SDK Method Definition
- Configuration Description
- Licensing and Terms

## 1. Introduction

The Xamarin SDK wraps the Android SDK with Managed Callable Wrappers through the usage of Android Bindings Library projects. It provides the same APIs as the native SDK.

The Xamarin SDK libraries are described as follows:

- Library .DLL files: These are the files enable the usage of the native Android SDK interfaces. Once generated, these files can be referenced & used directly in a Xamarin.Android project.

## 2. Installation Guide
Before using the Xamarin SDK code, ensure that Visual Studio 2019 is installed with "Mobile development with .NET" support.

### 2.1 Download native Android SDK packages
The ads SDK and its dependencies must be downloaded from the Huawei repository.

Use the following URLs to download the packages for XAdsLite-13.4.29.301(Publisher Service)
- [ads-banner-13.4.29.301.aar](https://developer.huawei.com/repo/com/huawei/hms/ads-banner/13.4.29.301/ads-banner-13.4.29.301.aar)
- [ads-base-13.4.29.301.aar](https://developer.huawei.com/repo/com/huawei/hms/ads-base/13.4.29.301/ads-base-13.4.29.301.aar)
- [ads-consent-3.4.29.301.aar](https://developer.huawei.com/repo/com/huawei/hms/ads-consent/3.4.29.301/ads-consent-3.4.29.301.aar)
- [ads-interstitial-13.4.29.301.aar](https://developer.huawei.com/repo/com/huawei/hms/ads-interstitial/13.4.29.301/ads-interstitial-13.4.29.301.aar)
- [ads-lang-13.4.29.301.aar](https://developer.huawei.com/repo/com/huawei/hms/ads-lang/13.4.29.301/ads-lang-13.4.29.301.aar)
- [ads-lite-13.4.29.301.aar](https://developer.huawei.com/repo/com/huawei/hms/ads-lite/13.4.29.301/ads-lite-13.4.29.301.aar)
- [ads-native-13.4.29.301.aar](https://developer.huawei.com/repo/com/huawei/hms/ads-native/13.4.29.301/ads-native-13.4.29.301.aar)
- [ads-reward-13.4.29.301.aar](https://developer.huawei.com/repo/com/huawei/hms/ads-reward/13.4.29.301/ads-reward-13.4.29.301.aar)
- [ads-splash-13.4.29.301.aar](https://developer.huawei.com/repo/com/huawei/hms/ads-splash/13.4.29.301/ads-splash-13.4.29.301.aar)
- [ads-template-13.4.29.301.aar](https://developer.huawei.com/repo/com/huawei/hms/ads-template/13.4.29.301/ads-template-13.4.29.301.aar)


Use the following URLs to download the packages for XAdsIdentifier-3.4.28.313(Identifier Service)
- [ads-identifier-3.4.28.313.aar](https://developer.huawei.com/repo/com/huawei/hms/ads-identifier/3.4.28.313/ads-identifier-3.4.28.313.aar)
- [ads-installreferrer-3.4.28.313.aar](https://developer.huawei.com/repo/com/huawei/hms/ads-installreferrer/3.4.28.313/ads-installreferrer-3.4.28.313.aar)

### 2.2 Open the library project
An Android Bindings Library project for Xamarin allows the usage of only one .aar file. For this reason the library repository comes with multiple library projects. 
Open up Visual Studio 2019. Then from the menu;

- Click "Open a project or a solution"
- Navigate to the directory where you cloned the repository and open "XAdsLite-13.4.29.301.csproj".

### 2.3 Import the downloaded packages
Once you open the library project for the ads SDK, each package you downloaded in the first step must placed under its related library project.

Inside the "Solution Explorer", expand each project and repeat the steps below:
- Right click "Jars" -> "Add" -> "Existing Item" (Shift + Alt + A)
- Navigate to the folder where you downloaded the packages and select the related .aar or .jar file.

	Example: For XAdsBanner-13.4.29.301 project, import "tasks-1.3.3.300.aar"
- Click on the package file you just imported. 
		In the **properties** window, 
		
	- set the Build Action as "LibraryProjectZip" if the file type is .aar
	- set the Build Action as "EmbeddedJar" if the file type is .jar

### 2. Build the library.
From the Visual Studio's toolbar, click "Build" -> "Build Solution" (Ctrl + Shift + B).
Once the build process is complete, generated classes should be visible in the object browser.

(View -> Object Browser) (Ctrl + Alt + J)

### 2.5 Using the library
There are two ways to use the Ads SDK after the .dll files are generated.	

#### 2.5.1 Reference the generated library files
You can add the generated .dll files as references to your project directly.
- Expand the solution of your Xamarin.Android app, then right click "References" -> "Add"
- In the Reference Manager window that just opened, click the "Browse" button at the bottom.
- Navigate to the directory of the XAdsLite-13.4.29.301 library project. Based on your choice of build type (Debug or Release), the generated .dll files will inside on of the following directories:
	- XAdsLite-13.4.29.301\bin\\**Debug**
    - XAdsLite-13.4.29.301\bin\\**Release**
- Select all of the generated .dll files. Click "OK", then you should be able to use the classes from the libraries you just imported.	


#### 2.5.2 Reference the projects
You can add the library projects to the solution of your Xamarin.Android application, then add the projects as a reference.

- From the Visual Studio's toolbar, click "File" -> "Add" -> "Existing Project"
- Navigate to the directory where the library projects reside, then select the **.csproj** file of one of the library projects.

	 Example: For XAdsBanner-13.4.29.301 project, select "XAdsBanner-13.4.29.301.csproj"
- Expand the solution of your Xamarin.Android app, then right click "References" -> "Add"
- In the Reference Manager window that just opened, click "Projects" then select the project you just added to your solution. Click "OK", then you should be able to use the classes from the library you just imported.
- Repeat the above steps **for each of the library projects.**

## 3. HUAWEI Ads Kit SDK for Xamarin

### 3.1 For Publisher Service (XAdsLite-13.4.29.301)

| **BannerView** |**Description**|
| ------ | ------ |
|BannerView(Context context)|Banner ad view constructor.|
|Destroy()|Destroys an ad view.| 
|AdId|Sets and obtains an ad slot ID.|
|AdListener|Sets and obtains an ad listener.|
|BannerAdSize|Sets and obtains the size of a banner ad.|
|IsLoading|Checks whether ads are being loaded.|
|LoadAd(AdParam adparam)|Loads an ad.|
|Pause()|Pauses any additional processing related to an ad view.|
|Resume()|Resumes an ad view after the pause() method is called last time.|

| **NativeAd** |**Description**|
| ------ | ------ |
|Destroy()|Destroys an ad object.|
|DislikeAd(IDislikeAdReason dislikeAdReason)|Content suitable for teenagers and older audiences.| 
|GetChoicesInfo()|Does not display the current ad. After this method is called, the current ad is closed.|
|SetAllowCustomClick()|Enables custom tap gestures.|
|Description|Obtains the description of an ad.|
|AdSource|Obtains an ad source.|
|CallToAction|Obtains the text to be displayed on a button, for example, View Details or Install.|
|DislikeAdReasons|Obtains the choice of not displaying the current ad.|
|Title|Obtains the title of an ad.|
|Icon|Obtains the icon of an ad.|
|Images|Obtains multi-image materials of an ad.
|VideoOperator|Obtains the video controller of an ad.|
|IsCustomClickAllowed|Checks whether custom tap gestures are enabled.|
|IsCustomDislikeThisAdEnabled|Checks whether custom ad closing is enabled.|
|TriggerClick(Bundle p0)|Reports a tap.|
|RecordClickEvent()|Reports a custom tap gesture.|
|RecordImpressionEvent(Bundle p0)|Reports an ad impression.|
|SetDislikeAdListener(IDislikeAdListener p0)|Sets an ad closing listener.|

| **RewardAd** |**Description**|
| ------ | ------ |
|Reward|Obtains reward item information.|
|CreateRewardAdInstance(Context p0)|Obtains a rewarded ad object.|
|Data|Sets and obtains custom data.|
|UserId|Sets and obtains a user ID.|
|RewardAdListener|Sets and obtains a rewarded ad loading listener.|
|Pause(Context context)|Pauses a rewarded ad.|
|Pause()|Pauses a rewarded ad.|
|Resume(Context p0)|Resumes a rewarded ad.|
|Resume()|Resumes a rewarded ad.|
|IsLoaded|Checks whether a rewarded ad is successfully loaded.|
|LoadAd(string p0, AdParam p1)|Requests a rewarded ad.|
|LoadAd(AdParam p0, RewardAdLoadListener p1)|Requests a rewarded ad.|
|SetRewardVerifyConfig(RewardVerifyConfig p0)|Sets server-side verification parameters.|
|Show()|Displays a rewarded ad.|
|Show(Activity p0, RewardAdStatusListener p1)|Displays a rewarded ad.|

| **InterstitialAd** |**Description**|
| ------ | ------ |
|InterstitialAd(Context p0)|Banner ad view constructor.|
|AdId|Sets and obtains an ad slot ID.|
|AdListener|Sets and gets an ad listener.|
|IsLoaded|Checks whether ad loading is complete.|
|IsLoading|Checks whether ads are being loaded.|
|LoadAd(AdParam p0)|Initiates a request to load an ad.|
|SetRewardAdListener(IRewardAdListener p0)|Sets a rewarded ad listener.|
|Show()|Displays an interstitial ad.|

| **SplashView** |**Description**|
| ------ | ------ |
|SplashView(Context p0)|Banner ad view constructor.|
|Load(string adId, int orientation, AdParam adParam, SplashAdLoadListener listener)|Loads and displays a splash ad. This method must be called in the UI thread.|
|SetLogo(View logo)|Hides an app logo area.|
|SetLogo(View logo, int defaultVisibility)|Sets the visibility of an app logo area.|
|SetLogoResId(int resId)|Sets an app logo resource ID.|
|SetMediaNameResId(int p0)|Sets an app text resource ID.|
|SetSloganResId(int p0)|Sets a default app launch image in portrait mode, which is displayed before a splash ad is displayed.|
|SetWideSloganResId(int p0)|Sets a default app launch image in landscape mode, which is displayed before a splash ad is displayed.|
|IsLoading|Checks whether a splash ad is being loaded.|
|IsLoaded|Checks whether a splash ad has been loaded.|
|SetAdDisplayListener(SplashAdDisplayListener adDisplayListener)|Sets a listener for the splash ad display or click event.|
|SetAudioFocusType(int audioFocusType)|Sets the audio focus preemption policy for a video splash ad.|
|ResumeView()|Resumes a view.|
|PauseView()|Suspends a view.|
|DestroyView()|Destroys a view.|


### 3.2 For Identifier Service (XAdsIdentifier-3.4.28.313)

| **AdvertisingIdClient** |**Description**|
| ------ | ------ |
|GetAdvertisingIdInfo(Context context)|Obtains the OAID and setting of Disable personalized ads.|
|VerifyAdId(Context context, string adId, bool isLimitAdTracking)|Verifies the OAID and setting of Disable personalized ads.|

| **AdvertisingIdClient.Info** |**Description**|
| ------ | ------ |
|Id|Obtains the current OAID.|
|IsLimitAdTrackingEnabled|Obtains the current setting of Disable personalized ads.|

| **InstallReferrerClient** |**Description**|
| ------ | ------ |
|NewBuilder(Context context)|Creates an InstallReferrerClient.Builder instance.|
|StartConnection(IInstallReferrerStateListener p0)|Starts to connect to the install referrer service.|
|EndConnection()|Ends the service connection and releases all occupied resources.|
|IsReady|Indicates whether the service connection is ready.|
|InstallReferrer|Obtains install referrer information.|

| **InstallReferrerClient.Builder** |**Description**|
| ------ | ------ |
|SetTest(bool isTest)|Sets the test mode.|
|Build()|Creates an InstallReferrerClient instance.|

| **IPPSChannelInfoService** |**Description**|
| ------ | ------ |
|GetChannelInfo()|Obtains install referrer information.|


You can read more and get detailed information about the interfaces described above from [developer.huawei.com](https://developer.huawei.com/consumer/en/)
## 4. Configure parameters.
No.

## 5. Licensing and Terms
Huawei Xamarin SDK uses the Apache 2.0 license.