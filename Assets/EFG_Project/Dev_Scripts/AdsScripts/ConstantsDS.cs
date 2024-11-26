//using Firebase.Analytics;
using System;
using UnityEngine;
 
public static class ConstantsDS
{

    public const string link_StoreInitial = "https://play.google.com/store/apps/details?id=";
    public const string link_MoreGames = "https://play.google.com/store/apps/developer?id=Dev+Pulse";
    public const string link_Facebook = "";
    public const string link_PrivacyPolicy = "https://devpulseprivacypolicy.blogspot.com/";

 
    #region Prefs Data 
    public const string UserConsent = "UserConsent";
    //public const string Headshot = "Headshot";
    //public const string Bodyshot = "Bodyshot";
    //public const string Levelreward = "Levelreward";
    public const string Lowenddevice = "Lowenddevice";
    public const string Mode2Unlock = "Mode2Unlock";
    public const string Mode3Unlock = "Mode3Unlock";
    public const string Mode4Unlock = "Mode4Unlock";
    public const string Mode5Unlock = "Mode5Unlock";
    public const string Totalreward = "TotalLevelreward";
    public const string lastselectedMode = "lastselectedMode";
    public const string lastselectedEnv = "lastselectedEnv";
    public const string lastselectedLevel = "lastselectedLevel";
    public const string lastUnlockedLevel = "lastUnlockedLevel";
    public const string LastSelectedGun = "LastSelectedGun";
    public const string Totalvideoswatched = "Totalvideoswatched";
    public const string removeAds = "RemoveAds";
    public const string TyrweaponNo = "TyrweaponNo";
    public const string DailyRewardDay = "DailyRewardDay";
    public const string NextDailyRewardTime = "NextDailyRewardTime";
    public const string DailyRewardTime = "DailyRewardTime";
    public const string Dailyrewardclaimed = "Dailyrewardclaimed";

    public static void SetPref(string KeyName, int Value)
    {
        PlayerPrefs.SetInt(KeyName, Value);
    }

    public static int Getprefs(string KeyName)
    {
        return PlayerPrefs.GetInt(KeyName);
    }
    public static void SetPrefstring(string KeyName, string _val)
    {
        PlayerPrefs.SetString(KeyName, _val);
    }

    public static string Getprefstring(string KeyName)
    {
        return PlayerPrefs.GetString(KeyName);
    }
    public static bool SetBoolpref(String name, bool value)
    {
        try
        {
            PlayerPrefs.SetInt(name, value ? 1 : 0);
        }
        catch
        {
            return false;
        }
        return true;
    }

    public static bool GetBoolpref(String name)
    {
        return PlayerPrefs.GetInt(name) == 1;
    }
    public static void DeletePref(string pref)
    {
        PlayerPrefs.DeleteKey(pref);
    }
    #endregion

    #region Firebase-Analytics
    public static bool FirebaseInitilized = false;
    public static void FBAnalytic_EventLevel_Started(string Mode, int level)
    {
        if (!FirebaseInitilized)
            return;

        Mode = Mode.Replace(" ", "_");

        try
        {
            //FirebaseAnalytics.LogEvent("lvl_start_" + Mode + "_Lvl" + level);
            if (!Application.isMobilePlatform)
                Debug.Log("Level_started_" + "Mode_" + Mode + "_" + "Lvl_" + level);
        }
        catch (Exception e)
        {
            Debug.Log("Error in Analytics:" + e.ToString());
        }
    }
    public static void FBAnalytic_EventLevel_pause(string Mode, int level)
    {
        if (!FirebaseInitilized)
            return;
        Mode = Mode.Replace(" ", "_");

        try
        {
           // FirebaseAnalytics.LogEvent("lvl_pause_" + Mode + "_Lvl" + level);
            if (!Application.isMobilePlatform)
                Debug.Log("Level_pause_" + "Mode_" + Mode + "_" + "Lvl_" + level);
        }
        catch (Exception e)
        {
            Debug.Log("Error in Analytics:" + e.ToString());
        }
    }
    public static void FBAnalytic_EventLevel_Complete(string Mode, int level)
    {
        if (!FirebaseInitilized)
            return;
        Mode = Mode.Replace(" ", "_");
        //lvl_complete_Survival_Lvl0
        try
        {
           // FirebaseAnalytics.LogEvent("lvl_complete_" + Mode + "_Lvl" + level);
            if (!Application.isMobilePlatform)
                Debug.Log("Lvl_complete_" + "Mode_" + Mode + "_" + "Level_" + level);
        }
        catch (Exception e)
        {
            Debug.Log("Error in Analytics: " + e.ToString());
        }
    }

    public static void FBAnalytic_EventLevel_Fail(string Mode, int level)
    {
        if (!FirebaseInitilized)
            return;
        Mode = Mode.Replace(" ", "_");
        try
        {
           // FirebaseAnalytics.LogEvent("lvl_fail_" + Mode + "_Lvl" + level);
            if (!Application.isMobilePlatform)
                Debug.Log("Lvl_Fail_" + "Mode_" + Mode + "_" + "Level_" + level);
        }
        catch (Exception e)
        {
            Debug.Log("Error in Analytics: " + e.ToString());
        }
    }

    public static void FBAnalytic_EventDesign(string eventName)
    {
        if (!FirebaseInitilized)
            return;
        eventName = eventName.Replace(" ", "_");
        try
        {
           //FirebaseAnalytics.LogEvent(eventName);
            if (!Application.isMobilePlatform)
                Debug.Log(eventName);
        }
        catch (Exception e)
        {
            Debug.Log("Error in Analytics: " + e.ToString());
        }
    }

    public static void NotificationsOpen(string eventname)
    {
        if (!FirebaseInitilized)
            return;
        try
        {
           //  FirebaseAnalytics.LogEvent("Open_" + eventname);
            if (!Application.isMobilePlatform)
                Debug.Log("AnalyticsNotification: " + eventname);
        }
        catch (Exception e)
        {
            Debug.Log("Analytics_Design: Error in Analytics: " + e.ToString());
        }
    }
    #endregion
  
    #region Rewards of Watch-Videos
    public static void Freecoins_Onwatchvieo()
    {
        // Toolbox.UIManager.UpdateTxts();
    }

    #endregion

    #region Inapp reward Function 
    public static void RemoveAds()
    {
        SetPref(removeAds, 1);
    }
    #endregion

    #region Ads Data
    public static string adsRemoteConfigStatus = "1";
    public static bool isGamePaused = false;

    public static bool isAdPlaying = false;

    public static bool showInterstitial = true;
    public static int Adsofframbasefilter = 2000;
    #endregion

}




