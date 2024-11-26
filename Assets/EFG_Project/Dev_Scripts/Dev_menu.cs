using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Dev_menu : MonoBehaviour
{
    public GameObject Laodingpanel;

    private void Start()
    {
        //Vibration.Init();
        //SceneManager.LoadScene(PlayerPrefs.GetInt("levelnumber", 1) > SceneManager.sceneCountInBuildSettings - 1
        //    ? Random.Range(1, SceneManager.sceneCountInBuildSettings
        //    - 1)
        //    : PlayerPrefs.GetInt("levelnumber", 1));
      //  SceneManager.LoadScene("Dev_Level "+PlayerPrefs.GetInt("levelnumber", 1));
    }
    public void OnClickRate()
    {
        Application.OpenURL("https://play.google.com/store/apps/developer?id="+Application.identifier);
    }
    public void OnClickMore()
    {
        Application.OpenURL("https://play.google.com/store/apps/developer?id=Dev+Pulse&hl=en&gl=US");
    }
    public void OnClickSetting()
    {
       
    }
    public void OnClickPlay()
    {
        Laodingpanel.SetActive(true);
        Invoke(nameof(Loadscene), 3f);
    }
    
    private void Loadscene()
    {
        // SceneManager.LoadScene("Dev_Level " + PlayerPrefs.GetInt("levelnumber", 1));
        SceneManager.LoadScene(PlayerPrefs.GetInt("levelnumber", 1) > SceneManager.sceneCountInBuildSettings - 1
            ? Random.Range(1, SceneManager.sceneCountInBuildSettings
            - 1)
            : PlayerPrefs.GetInt("levelnumber", 1));
    }
}
