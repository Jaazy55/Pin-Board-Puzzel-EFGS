using System;
using UnityEngine;
using UnityEngine.UI;

public class TimeManager : MonoBehaviour
{
    public Text timeCounterText; // Reference to the UI Text element
    private float startTime; // Time when the level started
    private float currentTime;
    public float[] LevelTime;
    public static bool Timeover = true;

    // Add More Time on watch video 
    private bool loadvideo = false;
   
    // Start is called before the first frame update
    void Start()
    {
        //Timeover = false;
        startTime = Time.time;
        currentTime = LevelTime[PlayerPrefs.GetInt("levelnumber", 1)];
        loadvideo = false;
        InitializeLevelTimeCounter();
    }

    // Update is called once per frame
    void Update()
    {
        UpdateTimeCounterUI();
    }
    void UpdateTimeCounterUI()
    {
        if (Timeover)
            return;

        startTime = Time.deltaTime;

        currentTime = currentTime - startTime;
        int minutes = Mathf.FloorToInt(currentTime / 60);
        int seconds = Mathf.FloorToInt(currentTime % 60);
        string timeString = string.Format("{0:00}:{1:00}", minutes, seconds);
        //timeString = currentTime - timeString;
        // Update the UI Text element
        timeCounterText.text = /*"Time: " +*/ timeString;
        if ( minutes <=0 &&  seconds <= 0)
        {
            Timeover = true;
            Dev_UIManager.INSTANCE.Failpanel();
        }
        if (seconds <= 6 && !loadvideo)
        {
            loadvideo = true;
            //try
            //{
            //    if (!FindObjectOfType<MediationHandlerDS>().IsRewardedAdReady())
            //        FindObjectOfType<MediationHandlerDS>().LoadRewardedVideo();

            //}
            //catch (Exception e)
            //{

            //}
        }
    }
    public void InitializeLevelTimeCounter()
    {
        startTime = Time.time;
        Timeover = false;
    }

    public void GetMoreTime(GameObject Panel)
    {
        try
        {
            //if (!FindObjectOfType<MediationHandlerDS>().IsRewardedAdReady())
            //{
            //    FindObjectOfType<MediationHandlerDS>().LoadRewardedVideo();
            //}
            //else
            //{
            //    FindObjectOfType<MediationHandlerDS>().ShowRewardedVideo(Addtime);
            //    Panel.SetActive(false);
            //}
            //if (AdsManager.IsrewardedAdLoaded())
            //{
            //    AdsManager.ShowRewardedAd(Addtime);
            //    Panel.SetActive(false);
            //}
            //else
            //{
            //    AdsManager.InitializeRewardedAd();
            //    Addtime();
            //}
        }
        catch (Exception e)
        {

        }
    }
    private void Addtime()
    {
        Dev_UIManager.INSTANCE.failpanel.SetActive(false);
        startTime = Time.time;
        currentTime = 15f;
        Timeover = false;
    }
}
