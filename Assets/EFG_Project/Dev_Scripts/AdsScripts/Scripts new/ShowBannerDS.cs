//using System;
//using UnityEngine;

//public class ShowBannerDS : MonoBehaviour
//{
//    public MaxSdk.BannerPosition pos = MaxSdkBase.BannerPosition.TopCenter;
//    public bool Hidemedium = true;
//    // Start is called before the first frame update
//    private void OnEnable()
//    {
//        Smallbanner();
//    }


//    private void Smallbanner()
//    {
//        try
//        {

//            AdsManager.HideBannerAd();
//            AdsManager.ShowBannerAd(pos);
//                if (Hidemedium)
//                AdsManager.HideMrecAd();
        
//        }
//        catch (Exception e)
//        {
//        }
//    }
//}
