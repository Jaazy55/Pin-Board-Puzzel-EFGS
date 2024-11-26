// /*
// Created by Darsan
// */

using System;
using System.Collections;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Splash : MonoBehaviour
{
    public GameObject Policy;
    public GameObject Loading;
    public GameObject MainMenu;
    private void Start()
    {
        
        if (PlayerPrefs.GetInt("HaveSetupConsent") == 0)
        {
            Policy.SetActive(true);
            Loading.SetActive(false);
        }
        else
        {
            Policy.SetActive(false);
            Loading.SetActive(true);
            Invoke(nameof(Mbanner),5f);
            Invoke(nameof(Loadscene), 12f);
            Invoke(nameof(Appopen), 9f);
        }

       
    }

    public void OnClickYes()
    {
        PlayerPrefs.SetInt("HaveSetupConsent", 1);
        Policy.SetActive(false);
        Loading.SetActive(true);
        Invoke(nameof(Loadscene), 12f);
        Invoke(nameof(Appopen), 9f);
        Mbanner();
    }
    public void OnClickNo()
    {
        Policy.SetActive(false);
        Loading.SetActive(true);
        Invoke(nameof(Loadscene), 12f);
        Invoke(nameof(Appopen), 9f);
    }

    private void Loadscene()
    {
        Policy.SetActive(false);
        Loading.SetActive(false);
        MainMenu.SetActive(true);
      //  SceneManager.LoadScene("Dev_Main Menu");
    }
    private void Mbanner()
    {
        //try
        //{
        //    if (FindObjectOfType<MediationHandlerDS>())
        //        FindObjectOfType<MediationHandlerDS>().ShowMediumBanner(GoogleMobileAds.Api.AdPosition.Center);
        //}
        //catch (Exception e)
        //{

        //}
    }
    private void Appopen()
    {
        //try
        //{
        //    if (FindObjectOfType<MediationHandlerDS>())
        //        FindObjectOfType<MediationHandlerDS>().ShowAppOpenAd();
        //}
        //catch (Exception e)
        //{
        //}
    }
    public void OnClickPrivacy()
    {
        Application.OpenURL("https://devpulseprivacypolicy.blogspot.com/2023/08/privacy-policy-dev-pulse-us-we-or-our.html");
    }
}