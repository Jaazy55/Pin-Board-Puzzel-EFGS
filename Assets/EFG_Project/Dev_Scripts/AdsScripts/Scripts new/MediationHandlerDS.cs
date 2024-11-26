//using System.Collections;
//using System.Collections.Generic;
//using UnityEngine;
//using GoogleMobileAds.Api;
//using UnityEngine.SceneManagement;

//public enum AdLoadingStatus
//{
//    NotLoaded,
//    Loading,
//    Loaded,
//    NoInventory
//}
//public enum AdType
//{
//    NOAds,
//    Ads
//}
//public abstract class MediationHandlerDS : MonoBehaviour
//{

//    public delegate void RewardUserDelegate();

//    public static AdLoadingStatus iAdStatus = AdLoadingStatus.NotLoaded;

//    public static AdLoadingStatus smallBannerStatus = AdLoadingStatus.NotLoaded;

//    public static AdLoadingStatus smallAdaptiveBannerStatus = AdLoadingStatus.NotLoaded;

//    public static AdLoadingStatus smallSmartBannerStatus = AdLoadingStatus.NotLoaded;

//    public static AdLoadingStatus mediumBannerStatus = AdLoadingStatus.NotLoaded;

//    public static AdLoadingStatus vAdStatus = AdLoadingStatus.NotLoaded;

//    public static AdLoadingStatus rAdStatus = AdLoadingStatus.NotLoaded;

//    public static AdLoadingStatus riAdStatus = AdLoadingStatus.NotLoaded;
//    public static AdType adsStatus;


//    public abstract bool IsRewardedAdReady();
//    public abstract bool IsRewardedInterstitialAdReady();
//    public abstract bool IsMediumBannerReady();
//    public abstract bool IsLeftSmallBannerReady();
//    public abstract bool IsRightSmallBannerReady();

//    public abstract bool IsSmallAdaptiveBannerReady();
//    public abstract bool IsSmallSmartBannerReady();
//    public abstract bool IsVideoAdReady();
//    public abstract bool IsInterstitialAdReady();
//    public abstract void LeftLoadSmallBanner();
//    public abstract void RightLoadSmallBanner();

//    public abstract void LoadMediumBanner();
//    public abstract void LoadSmallAdaptiveBanner();
//    public abstract void LoadInterstitial();
//    public abstract void LoadVideo();
//    public abstract void LoadRewardedVideo();
//    public abstract void LoadRewardedInterstitial();
//    public abstract void ShowInterstitial();
//    public abstract void ShowVideo();
//    public abstract void ShowLeftSmallBanner(AdPosition pos);

//    public abstract void ShowRightSmallBanner(AdPosition pos);

//    public abstract void ShowSmallAdaptiveBanner(AdPosition pos);
//    public abstract void ShowSmallSmartBanner(AdPosition pos);
//    public abstract void ShowMediumBanner(AdPosition pos);
//    public abstract void ShowAppOpenAd();
//    public abstract void HideLeftSmallBannerEvent();
//    public abstract void HideRightSmallBannerEvent();

//    public abstract void HideSmallAdaptiveBannerEvent();
//    public abstract void HideSmallSmartBannerEvent();
//    public abstract void HideMediumBannerEvent();
//    public abstract void ShowRewardedVideo(RewardUserDelegate _delegate);
//    public abstract void ShowRewardedInterstitialAd(RewardUserDelegate _delegate);
//    public abstract bool IsMediumBannerBeingDisplayed();
//    // public abstract bool IsSmallBannerBeingDisplayed();




//    //public void showRewardedVideoAd(RewardUserDelegate _delegate)
//    //{
//    //    if (IsRewardedAdReady())
//    //    {
//    //        ShowRewardedVideo(_delegate);
//    //    }
//    //    else if (IsRewardedInterstitialAdReady())
//    //    {
//    //        LoadRewardedVideo();
//    //        ShowRewardedInterstitialAd(_delegate);
//    //    }
//    //    else
//    //    {
//    //        LoadRewardedVideo();
//    //        LoadRewardedInterstitial();
//    //        if (PlayerPrefs.GetInt("Showing2XRewarded") == 1)
//    //        {
//    //            //Toolbox.GameManager.Instantiate_Message("Rewarded Ad is not available at the moment", "Message");
//    //            PlayerPrefs.SetInt("Showing2XRewarded", 0);
//    //        }
//    //    }
//    //}

//    public void ShowSbanner(AdPosition pos)
//    {
//        ShowLeftSmallBanner(pos);
//    }

//    public void ShowMbanner(AdPosition pos)
//    {
//        ShowMediumBanner(pos);
//    }

//    public void hideLeftSmallBanner()
//    {
//        HideLeftSmallBannerEvent();
//    }
//    public void hideRightSmallBanner()
//    {
//        HideRightSmallBannerEvent();
//    }
//    public void HideSmallAdaptiveBanner()
//    {
//        HideSmallAdaptiveBannerEvent();
//    }

//    public void hideMediumBanner()
//    {
//        HideMediumBannerEvent();
//    }
//}
