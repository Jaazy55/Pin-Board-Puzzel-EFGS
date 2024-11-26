//using System;
//using System.Collections;
//using System.Collections.Generic;
//using UnityEngine;

//public class AdsManager : MonoBehaviour
//{

//    private static string sdkKey = "F95CDGF_nTJwX79tZZTc06uqiu8TrndGhkAtPhSG1lKZOKi9ueCQKcTXDPUGyLcUhT_M3TR_Hg2qS42irOyqQn";

//    private static string appopenId = "";
//    private static string bannerId  = "9bcb13335f2f99a2";
//    private static string mrecId    = "62a241676e1094cb";
//    private static string interstitialId = "84f4654b20f88f38";
//    private static string rewardedId = "070ec746ce61d025";

//    private static int interstitialRetry;
//    private static int rewardedRetry;

//    //public delegate void AdReward();
//    //public static event AdReward RewardedAdReward;

//    private static AdsManager selfReference = null;

//    public delegate void RewardUserDelegate();
//    private static RewardUserDelegate NotifyReward;

//    private void OnEnable()
//    {
//        InitSelfReference();
//        DontDestroyOnLoad(this.gameObject);
//    }

//    private void Start()
//    {
//        InitializeSDK();
//    }
//    private static void InitSelfReference()
//    {
//        if (selfReference == null)
//        {
//            selfReference = FindObjectOfType<AdsManager>();
//        }
//    }

//    public static void InitializeSDK()
//    {
//        MaxSdkCallbacks.OnSdkInitializedEvent += (MaxSdkBase.SdkConfiguration sdkConfiguration) =>
//        {
//            InitializeBannerAd();
//            InitializeMrecAd();
//        //    InitializeAppOpenAd();
//            InitializeInterstitialAd();
//            InitializeRewardedAd();
//        };
//        MaxSdk.SetSdkKey(sdkKey);
//        MaxSdk.SetUserId("");
//        MaxSdk.InitializeSdk();
        
//    }

//    private static void InitializeAppOpenAd()
//    {
//        MaxSdkCallbacks.AppOpen.OnAdHiddenEvent += OnAppOpenDismissedEvent;
//        LoadAppOpenAd();
//    }

//    private static void OnAppOpenDismissedEvent(string adUnitId, MaxSdkBase.AdInfo adInfo)
//    {
//        LoadAppOpenAd();
//    }

//    private static void LoadAppOpenAd()
//    {
//        MaxSdk.LoadAppOpenAd(appopenId);
//        Debug.Log("Load AppOpen");
//    }

//    public static void ShowAppOpenAd()
//    {
//        if (MaxSdk.IsAppOpenAdReady(appopenId))
//        {
//            MaxSdk.ShowAppOpenAd(appopenId);
//        }
//        else
//        {
//            LoadAppOpenAd();
//        }
//    }

//    private static void InitializeBannerAd()
//    {
//        Debug.Log("Load Banner");
//        MaxSdk.CreateBanner(bannerId, MaxSdkBase.BannerPosition.BottomCenter);
//        MaxSdk.SetBannerBackgroundColor(bannerId, Color.black);
//        ShowBannerAd(MaxSdkBase.BannerPosition.TopCenter);
//    }

//    public static void ShowBannerAd(MaxSdk.BannerPosition pos)
//    {
//        Debug.Log("ShowBannerAd");
//        MaxSdk.CreateBanner(bannerId, pos);
//        MaxSdk.ShowBanner(bannerId);
//    }

//    public static void HideBannerAd()
//    {
//        Debug.Log("HideBannerAd");
//        MaxSdk.HideBanner(bannerId);
//    }

//    private static void InitializeMrecAd()
//    {
//        Debug.Log("InitializeMrecAd");
//        MaxSdk.CreateMRec(mrecId, MaxSdkBase.AdViewPosition.Centered);
//       // ShowMrecAd();
//    }

//    public static void ShowMrecAd(MaxSdk.AdViewPosition pos)
//    {
//        Debug.Log("ShowMrecAd");
//        MaxSdk.CreateMRec(mrecId, pos);
//        MaxSdk.ShowMRec(mrecId);
//    }

//    public static void HideMrecAd()
//    {
//        Debug.Log("HideMrecAd");
//        MaxSdk.HideMRec(mrecId);
//    }

//    public static void InitializeInterstitialAd()
//    {
//        MaxSdkCallbacks.Interstitial.OnAdLoadedEvent += OnInterstitialLoadedEvent;
//        MaxSdkCallbacks.Interstitial.OnAdLoadFailedEvent += OnInterstitialLoadFailedEvent;
//        MaxSdkCallbacks.Interstitial.OnAdHiddenEvent += OnInterstitialHiddenEvent;
//        MaxSdkCallbacks.Interstitial.OnAdDisplayFailedEvent += OnInterstitialAdFailedToDisplayEvent;
//        LoadInterstitialAd();
//    }

//    private static void OnInterstitialLoadedEvent(string adUnitId, MaxSdkBase.AdInfo adInfo)
//    {
//        interstitialRetry = 0;
//    }

//    private static void OnInterstitialLoadFailedEvent(string adUnitId, MaxSdkBase.ErrorInfo errorInfo)
//    {
//        interstitialRetry++;
//        double retryDelay = Math.Pow(2, Math.Min(6, interstitialRetry));
//        selfReference.Invoke("LoadInterstitial", (float)retryDelay);
//    }

//    private static void OnInterstitialHiddenEvent(string adUnitId, MaxSdkBase.AdInfo adInfo)
//    {
//        LoadInterstitialAd();
//    }

//    private static void OnInterstitialAdFailedToDisplayEvent(string adUnitId, MaxSdkBase.ErrorInfo errorInfo, MaxSdkBase.AdInfo adInfo)
//    {
//        LoadInterstitialAd();
//    }

//    private static void LoadInterstitialAd()
//    {
//        MaxSdk.LoadInterstitial(interstitialId);
//        Debug.Log("LoadInterstitialAd");
//    }

//    public static void ShowInterstitialAd()
//    {
//        if (MaxSdk.IsInterstitialReady(interstitialId))
//        {
//            MaxSdk.ShowInterstitial(interstitialId);
//            Debug.Log("ShowInterstitialAd");
//        }
//    }

//    public static void InitializeRewardedAd()
//    {
//        MaxSdkCallbacks.Rewarded.OnAdLoadedEvent += OnRewardedAdLoadedEvent;
//        MaxSdkCallbacks.Rewarded.OnAdLoadFailedEvent += OnRewardedAdLoadFailedEvent;
//        MaxSdkCallbacks.Rewarded.OnAdHiddenEvent += OnRewardedAdHiddenEvent;
//        MaxSdkCallbacks.Rewarded.OnAdDisplayFailedEvent += OnRewardedAdFailedToDisplayEvent;
//        MaxSdkCallbacks.Rewarded.OnAdReceivedRewardEvent += OnRewardedAdReceivedRewardEvent;
//        LoadRewardedAd();
//    }

//    private static void OnRewardedAdLoadedEvent(string adUnitId, MaxSdkBase.AdInfo adInfo)
//    {
//        rewardedRetry = 0;
//    }

//    private static void OnRewardedAdLoadFailedEvent(string adUnitId, MaxSdkBase.ErrorInfo errorInfo)
//    {
//        rewardedRetry++;
//        double retryDelay = Math.Pow(2, Math.Min(6, rewardedRetry));
//        selfReference.Invoke("LoadRewardedAd", (float)retryDelay);
//    }

//    private static void OnRewardedAdHiddenEvent(string adUnitId, MaxSdkBase.AdInfo adInfo)
//    {
//        LoadRewardedAd();
//    }

//    private static void OnRewardedAdFailedToDisplayEvent(string adUnitId, MaxSdkBase.ErrorInfo errorInfo, MaxSdkBase.AdInfo adInfo)
//    {
//        LoadRewardedAd();
//    }

//    private static void OnRewardedAdReceivedRewardEvent(string adUnitId, MaxSdk.Reward reward, MaxSdkBase.AdInfo adInfo)
//    {
//        //if (RewardedAdReward != null)
//        //{
//        //    RewardedAdReward();
//        //}
//        if (NotifyReward != null)
//        {
//            NotifyReward();
//        }
//    }

//    private static void LoadRewardedAd()
//    {
//        MaxSdk.LoadRewardedAd(rewardedId);
//        Debug.Log("LoadRewardedAd");
//    }

//    public static void ShowRewardedAd(RewardUserDelegate _delegate)
//    {
//        if (MaxSdk.IsRewardedAdReady(rewardedId))
//        {
//            NotifyReward = _delegate;
//            MaxSdk.ShowRewardedAd(rewardedId);
//            Debug.Log("ShowRewardedAd");
//        }
//        else
//        {
//            InitializeRewardedAd();
//        }
//    }
//}