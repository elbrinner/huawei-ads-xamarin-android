# HP_HMSCore-Plugin-Xamarin_Ads-Demo

## Contents
- Introduction
- Installation Guide
- Xamarin Example Method Definition
- Configuration Description
- Licensing and Terms

## 1. Introduction

There are three demos in the project named XamarinAdsInstallReferrerDemo, XamarinAdsKitDemo, XamarinAdsOAIDDemo.

The project is an example that aims to demonstrate how the HUAWEI Ads Kit SDK for Xamarin can be used.

The Xamarin SDK libraries are described as follows:

- Library .DLL files: These are the files enable the usage of the native Android SDK interfaces. Once generated, these files can be referenced & used directly in a Xamarin.Android project.

## 2. Installation Guide

Before using the Xamarin SDK code, ensure that Visual Studio 2019 is installed with "Mobile development with .NET" support.

### 2.1 HMS Xamarin Ads SDK Library
You can retrieve the library from [developer.huawei.com](https://developer.huawei.com)

### 2.2 Download native Android SDK packages
The Ads SDK and its dependencies must be downloaded from the Huawei repository.

Use the following URLs to download the packages for XamarinAdsKitDemo(Publisher Service)
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


Use the following URLs to download the packages for XamarinAdsOAIDDemo,XamarinAdsInstallReferrerDemo(Identifier Service)
- [ads-identifier-3.4.28.313.aar](https://developer.huawei.com/repo/com/huawei/hms/ads-identifier/3.4.28.313/ads-identifier-3.4.28.313.aar)
- [ads-installreferrer-3.4.28.313.aar](https://developer.huawei.com/repo/com/huawei/hms/ads-installreferrer/3.4.28.313/ads-installreferrer-3.4.28.313.aar)

### 2.3 Open the library project
An Android Bindings Library project for Xamarin allows the usage of only one .aar file. For this reason the library repository comes with multiple library projects. 

Open up Visual Studio 2019. Then from the menu;
	
- Click "Open a project or a solution"
- Navigate to the directory where you cloned the repository and open "XAdsLite-13.4.29.301.csproj".

### 2.4 Import the downloaded packages
Once you open the library project for the ads SDK, each package you downloaded in the first step must placed under its related library project.

Inside the "Solution Explorer", expand each project and repeat the steps below:
- Right click "Jars" -> "Add" -> "Existing Item" (Shift + Alt + A)
- Navigate to the folder where you downloaded the packages and select the related .aar or .jar file.	
    
         Example: For  XAdsBanner-13.4.29.301 project, import "ads-banner-13.4.29.301.aar"
- Click on the package file you just imported. 
		In the **properties** window, 
			
    - set the Build Action as "LibraryProjectZip" if the file type is .aar
	- set the Build Action as "EmbeddedJar" if the file type is .jar
	
### 2.5 Build the library.
From the Visual Studio's toolbar, click "Build" -> "Build Solution" (Ctrl + Shift + B).
Once the build process is complete, generated classes should be visible in the object browser and ready to use.

(View -> Object Browser) (Ctrl + Alt + J)

### 2.6 Copy the libary .dll files
Once you build the ads SDK library project, the generated .dll files should be copied inside the demo project.
- Copy the .dll files from "...\XAdsLite-13.4.29.301\bin\Debug\" or "...\XAdsLite-13.4.29.301\bin\Release\" depending on your build type selection.
- To the "_LibDlls" folder of the demo project. 

### 2.7 Run the application
You can now run your application and it should automatically start up on your mobile device.

## 3. Xamarin Example method definition
No. Developer can flexibly develop projects based on the example code. 

## 4. Configure parameters.    
No.

## 5. Licensing and Terms  
Huawei Xamarin SDK uses the Apache 2.0 license.