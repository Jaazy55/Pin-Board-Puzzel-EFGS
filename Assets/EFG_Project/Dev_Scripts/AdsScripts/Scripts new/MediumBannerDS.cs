//using System;
//using UnityEngine;

//public class MediumBannerDS : MonoBehaviour
//{
//    public MaxSdk.AdViewPosition pos = MaxSdkBase.AdViewPosition.Centered;
//    public bool hidesmallbanner = false;
//    public bool ShowMbanner = false;

//    public bool ShowIAD = false;
//    // Start is called before the first frame update
//    private void OnEnable()
//    {
//        try
//        {

//            if (hidesmallbanner)
//            {
//                AdsManager.HideBannerAd();
//            }
//            if (ShowIAD)
//                AdsManager.ShowInterstitialAd();
//            if (ShowMbanner)
//                AdsManager.ShowMrecAd(pos);
//        }
//        catch (Exception e)
//        {
//        }
//    }

//    private void OnDisable()
//    {
//        try
//        {
//            AdsManager.HideMrecAd();
//        }
//        catch (Exception e)
//        {
//        }
//    }
//}
