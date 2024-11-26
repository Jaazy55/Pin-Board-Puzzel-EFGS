using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Loading : MonoBehaviour
{
    public Image LoadingBar;
    public Text Value;
    public float val = 0.08f;
    // Start is called before the first frame update
    void Start()
    {
        LoadingBar.fillAmount = 0f;
        Value.text = "";
    }

    // Update is called once per frame
    void Update()
    {
        LoadingBar.fillAmount = LoadingBar.fillAmount + (val * Time.deltaTime);
        Value.text = Mathf.Round(LoadingBar.fillAmount*100).ToString()+"%";
    }
}
