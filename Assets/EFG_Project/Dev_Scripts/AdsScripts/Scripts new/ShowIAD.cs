//using System;
//using UnityEngine;

//public class ShowIAD : MonoBehaviour
//{
//    //public GoogleMobileAds.Api.AdPosition pos = GoogleMobileAds.Api.AdPosition.Top;
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
//            if (FindObjectOfType<MediationHandlerDS>())
//            {
//                //FindObjectOfType<MediationHandlerDS>().hideLeftSmallBanner();
//                //FindObjectOfType<MediationHandlerDS>().hideRightSmallBanner();

//                //FindObjectOfType<MediationHandlerDS>().ShowLeftSmallBanner(GoogleMobileAds.Api.AdPosition.Top);
//                //FindObjectOfType<MediationHandlerDS>().ShowRightSmallBanner(GoogleMobileAds.Api.AdPosition.Bottom);

//                //if (pos == GoogleMobileAds.Api.AdPosition.TopRight)
//                //{
//                //    FindObjectOfType<MediationHandlerDS>().ShowLeftSmallBanner(GoogleMobileAds.Api.AdPosition.TopRight);
//                //}
//                //if (pos == GoogleMobileAds.Api.AdPosition.Top)
//                //{
//                //    FindObjectOfType<MediationHandlerDS>().ShowLeftSmallBanner(GoogleMobileAds.Api.AdPosition.Top);
//                //}
//                if (Hidemedium)
//                    FindObjectOfType<MediationHandlerDS>().hideMediumBanner();

//                FindAnyObjectByType<MediationHandlerDS>().ShowInterstitial();
//            }
//        }
//        catch (Exception e)
//        {
//        }
//    }
//}
