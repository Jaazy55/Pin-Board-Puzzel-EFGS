using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class Dev_Key : MonoBehaviour
{
    public static Dev_Key instance;

    public GameObject locking;

    public Dev_GameManager gamemanager;
    private void Awake()
    {
        instance = this;
    }

    void Start()
    {
        gamemanager= Dev_GameManager.instance;
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("CUBE"))
        {
            gameObject.GetComponent<Collider>().enabled = false;
            gameObject.transform.GetComponentInChildren<DOTweenAnimation>().DOComplete();
            if (Dev_AudioManager.instance)
            {
                gamemanager.vibration();
                Dev_AudioManager.instance.Play("Key");
                gamemanager.keycollect = true;
            }
            gameObject.transform.DOMove(locking.gameObject.transform.position, 0.5f).OnComplete(() =>
            {
                transform.GetComponentInChildren<MeshRenderer>().enabled = false;
                if (Dev_AudioManager.instance)
                {
                    Dev_AudioManager.instance.Play("Lock");
                    gamemanager.vibration();
                }
                locking.GetComponentInChildren<DOTweenAnimation>().DOPlay();
                if (!locking.transform.GetComponentInChildren<ParticleSystem>().isPlaying)
                {
                    locking.transform.GetComponentInChildren<ParticleSystem>().Play();
                }
            
            });
        }
       
    }

    public void Locked()
    {
        locking.transform.parent.GetChild(1).tag = "BOLT";
        transform.gameObject.SetActive(false);
        locking.transform.SetParent(null);
        locking.GetComponent<Rigidbody>().isKinematic = false;
    }
    
}
