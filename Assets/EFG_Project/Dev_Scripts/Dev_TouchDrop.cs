using System;
using System.Collections;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using UnityEngine;
using DG.Tweening;
using UnityEngine.UI;

public class Dev_TouchDrop : MonoBehaviour
{
    public static Dev_TouchDrop instance;

    [SerializeField] public bool start;
    
    private RaycastHit _hit;
    [Header("Scripts")]
    public Dev_GameManager gameManager;

    public float boltremoveheight;
    
    private Vector3 offset;
   
    //public int touchcount;

    public bool blocking;
    public GameObject Block1;
    public GameObject Block2;
    
    public Dev_AudioManager Dev_AudioManager;
    private void Awake()
    {
        instance = this;
        boltremoveheight = 2f;
    }

    void Start()
    {
        gameManager= Dev_GameManager.instance;
        
        if (Dev_AudioManager.instance)
        {
            Dev_AudioManager = Dev_AudioManager.instance;
        }

        if (gameManager.gamemodes == Dev_GameManager.Modes.Null)
        {
            start = true;
        }
    }

    
    void Update()
    {
        /*if (blocking && Block1.GetComponent<Rigidbody2D>())
        {
            Block1.GetComponent<Rigidbody2D>().simulated = true;
        }

        /*if (!blocking)
        {
            Block1.GetComponent<Rigidbody2D>().simulated = false;
        }#1#*/
        if (Input.GetMouseButtonDown(0))
        {
            if (!Dev_UIManager.INSTANCE.win && start)
            {
                var ray = Camera.main.ScreenPointToRay(Input.mousePosition);
                if (Physics.Raycast(ray, out _hit))
                {
                    if (_hit.collider.gameObject.CompareTag("BOLT"))
                    {
                        if (gameManager.gamestate == Dev_GameManager.State.Done)
                        {
                            var selectObject = _hit.collider.gameObject;
                            Boltshifting(selectObject);
                        }
                        
                    }

                    if (_hit.collider.gameObject.CompareTag("Fill"))
                    {
                        if (gameManager.gamestate == Dev_GameManager.State.Done)
                        {
                            var fillingplace = _hit.collider.gameObject;
                            Filling(fillingplace);
                           // print(" "+_hit.collider.gameObject.name);
                        }
                    }
                }
            }
            
        }
    }

    // ReSharper disable Unity.PerformanceAnalysis
    public void Filling(GameObject fillingreferance)
    {
        /*if (gameManager.selectedBolt.Count == 1)
        {
            if (UIManager.INSTANCE.fill)
            {
                UIManager.INSTANCE.fill = false;
            }

            var position1 = fillingreferance.transform.position;
            var gameobj = gameManager.selectedBolt[0].GetComponentInChildren<CapsuleCollider>().gameObject;
            gameManager.vibration();
            gameManager.selectedBolt[0].GetComponentInParent<NewBolt>().enabled = false;
            //print(gameManager.selectedBolt[0].transform.parent.name);
            var position = position1;
            /////make lists equal
            if (gameManager != null && gameManager.selectedBolt[0].GetComponent<NewBolt>().previousbodies.Count != null)
            {
                gameManager.selectedBolt[0].GetComponent<NewBolt>().previousbodies.Clear();
                
                /*if (gameManager.selectedBolt[0].GetComponent<NewBolt>().connectedBodylist.Count != null)
                {
                    for (int i = 0; i < gameManager.selectedBolt[0].GetComponent<NewBolt>().connectedBodylist.Count; i++)
                    {
                        gameManager.selectedBolt[0].GetComponent<NewBolt>().previousbodies.Add(gameManager.selectedBolt[0].GetComponent<NewBolt>().connectedBodylist[i]);
                    }
                }#1#
            }
            if (gameManager != null && gameManager.selectedBolt[0].GetComponent<NewBolt>().connectedBodylist.Count != null)
            {
                for (int i = 0; i < gameManager.selectedBolt[0].GetComponent<NewBolt>().connectedBodylist.Count; i++)
                {
                    gameManager.selectedBolt[0].GetComponent<NewBolt>().connectedBodylist[i].GetComponentInParent<Rigidbody2D>().simulated = false;
                }
                
                gameobj.GetComponent<Collider>().enabled = false;
                /*Instantiate(gameManager.fillPartical, new Vector3(position1.x,position1.y,position1.z - 1.5f),
                    new Quaternion(0f,0f,0f,0f));#1#
               
                
                for (int i = 0; i < gameManager.selectedBolt[0].GetComponent<NewBolt>().connectedBodylist.Count; i++)
                {
                    gameManager.selectedBolt[0].GetComponent<NewBolt>().previousbodies.Add(gameManager.selectedBolt[0].GetComponent<NewBolt>().connectedBodylist[i]);
                }
            }
            gameManager.selectedBolt[0].GetComponent<NewBolt>().connectedBodylist.Clear();
            gameManager.selectedBolt[0].transform.parent.DOMoveX(position.x, 0.25f);
            gameManager.selectedBolt[0].transform.parent.DOMoveY(position.y, 0.25f).SetEase(Ease.Linear).OnComplete(() =>
            {
                
                Dev_AudioManager.Play("Fill");
                //gameManager.selectedBolt[0].GetComponentInParent<CircleCollider2D>().enabled = true;
                Instantiate(gameManager.fillPartical, new Vector3(position1.x,position1.y,position1.z - 1.5f),
                    new Quaternion(0f,0f,0f,0f));
                
                gameManager.selectedBolt[0].transform.parent.transform.DOLocalMoveZ(
                        gameManager.selectedBolt[0].transform.parent.transform.localPosition.z + boltremoveheight, 0.3f)
                    .SetEase(Ease.Linear)/*.OnComplete(() =>
                    {
                        gameManager.selectedBolt[0].GetComponentInParent<CircleCollider2D>().enabled = true;
                    })#1#;
                if (gameManager.selectedBolt[0].GetComponent<NewBolt>().previousbodies != null)
                {
                    
                    for (int i = 0; i < gameManager.selectedBolt[0].GetComponent<NewBolt>().previousbodies.Count; i++)
                    {
                        gameManager.selectedBolt[0].GetComponent<NewBolt>().previousbodies[i]
                            .GetComponentInParent<Rigidbody2D>().simulated = true;

                    }
                    gameobj.GetComponent<Collider>().enabled = true;
                    gameManager.selectedBolt.Clear();
                }
                else
                {
                    gameManager.selectedBolt.Clear();
                }

            });
        }*/
        if (gameManager.dupPlug!=null)
        {
            if (Dev_UIManager.INSTANCE.fill)
            {
                Dev_UIManager.INSTANCE.fill = false;
            } 
             gameManager.vibration();
            var parent = gameManager.dupPlug.transform.parent;
            var position1 = fillingreferance.transform.position;
            
            gameManager.dupcolider.transform.localPosition = parent.transform.localPosition;
            gameManager.dupcolider.GetComponent<CircleCollider2D>().enabled = true;
            parent.GetComponent<CircleCollider2D>().enabled = false;
            
            //gameManager.dupPlug.GetComponentInParent<NewBolt>().enabled = false;
            //gameManager.dupPlug.GetComponent<NewBolt>().connectedBodylist.Clear();
            parent.DOMoveX(position1.x, 0.25f);
            parent.DOMoveY(position1.y, 0.25f).SetEase(Ease.Linear).OnComplete(() =>
            {
                
                Dev_AudioManager.Play("Fill");
                Instantiate(gameManager.fillPartical, new Vector3(position1.x,position1.y,position1.z - 1.5f),
                    new Quaternion(0f,0f,0f,0f));
                
                parent.transform.DOLocalMoveZ(
                        parent.transform.localPosition.z + boltremoveheight, 0.3f)
                    .SetEase(Ease.Linear).OnComplete(() =>
                    {
                        gameManager.dupcolider.GetComponent<CircleCollider2D>().enabled = false;
                        parent.GetComponent<CircleCollider2D>().enabled = true;
                        gameManager.gamestate = Dev_GameManager.State.Done;
                    });
            });
            gameManager.dupPlug = null;
        }
    }
    // ReSharper disable Unity.PerformanceAnalysis
    public void Boltshifting(GameObject boltreferance)
    {
        if (gameManager.dupPlug!=null)
        {
            gameManager.vibration();
            Dev_AudioManager.Play("Bolt");
            if (Dev_UIManager.INSTANCE.pin)
            {
                Dev_UIManager.INSTANCE.pin = false;
                Dev_UIManager.INSTANCE.fill = true;
            }
            if (gameManager.dupPlug == (boltreferance))
            {
            
                gameManager.gamestate = Dev_GameManager.State.Select;
                gameManager.dupPlug = null;
                var parent = boltreferance.transform.parent;
                parent.DOLocalMoveZ(parent.localPosition.z + boltremoveheight, 0.3f).SetEase(Ease.Linear).OnComplete(
                    () =>
                    {
                        gameManager.gamestate = Dev_GameManager.State.Done;
                    });
                //gameManager.gamestate = GameManager.State.Select;
                
            }
            else if (gameManager.dupPlug!=(boltreferance))
            {
                gameManager.gamestate = Dev_GameManager.State.Select;
                var parent = gameManager.dupPlug.transform.parent;
                parent.DOLocalMoveZ(parent.localPosition.z + boltremoveheight, 0.3f).SetEase(Ease.Linear);
                gameManager.dupPlug = null;
                gameManager.dupPlug=boltreferance;
                var parent1 = boltreferance.transform.parent;
                //boltreferance.transform.GetComponent<Collider>().enabled = false;
                parent1.DOLocalMoveZ(parent1.localPosition.z - boltremoveheight, 0.3f).SetEase(Ease.Linear).OnComplete(
                    () =>
                    {
                        gameManager.gamestate = Dev_GameManager.State.Done;
                    });
            }
        }
        
        else if (gameManager.dupPlug == null)
        {
            gameManager.gamestate = Dev_GameManager.State.Select;
            if (Dev_UIManager.INSTANCE.pin)
            {
                Dev_UIManager.INSTANCE.pin = false;
                Dev_UIManager.INSTANCE.fill = true;
            }
            gameManager.vibration();
            Dev_AudioManager.Play("Bolt");
            var parent = boltreferance.transform.parent;
            parent.DOLocalMoveZ(parent.localPosition.z - boltremoveheight, 0.3f).SetEase(Ease.Linear).OnComplete(() =>
            {
                gameManager.gamestate = Dev_GameManager.State.Done;
            });
            gameManager.dupPlug = boltreferance;
        }
    }
    // ReSharper disable Unity.PerformanceAnalysis
    /*public void Boltshifting(GameObject boltreferance)
    {
        if (gameManager.selectedBolt.Count == 1)
        {
            gameManager.vibration();
            Dev_AudioManager.Play("Bolt");
            if (UIManager.INSTANCE.pin)
            {
                UIManager.INSTANCE.pin = false;
                UIManager.INSTANCE.fill = true;
            }
            if (gameManager.selectedBolt.Contains(boltreferance))
            {
            
                if (boltreferance.GetComponent<NewBolt>().connectedBodylist != null)
                {
                    for (int i = 0; i < boltreferance.GetComponent<NewBolt>().connectedBodylist.Count; i++)
                    {
                        boltreferance.GetComponent<NewBolt>().connectedBodylist[i].GetComponentInParent<Rigidbody2D>().simulated = true;
                    }
                }
                gameManager.selectedBolt.RemoveAt(0);
                var parent = boltreferance.transform.parent;
                boltreferance.transform.GetComponent<Collider>().enabled = false;
                parent.DOLocalMoveZ(parent.localPosition.z + boltremoveheight, 0.3f).OnComplete(() =>
                {
                    boltreferance.transform.GetComponent<Collider>().enabled = true;
                });
                //gameManager.gamestate = GameManager.State.Select;
                
            }
            else if (!gameManager.selectedBolt.Contains(boltreferance))
            {
               
                gameManager.selectedBolt[0].transform.parent.DOLocalMoveZ(gameManager.selectedBolt[0].transform.parent.localPosition.z + boltremoveheight, 0.3f).SetEase(Ease.Linear);
                gameManager.selectedBolt.RemoveAt(0);
                /*if (boltreferance.GetComponent<NewBolt>().connectedBodylist != null)
                {
                    for (int i = 0; i < boltreferance.GetComponent<NewBolt>().connectedBodylist.Count; i++)
                    {
                        boltreferance.GetComponent<NewBolt>().connectedBodylist[i].GetComponentInParent<Rigidbody2D>().simulated = true;
                    }
                }#1#
                gameManager.selectedBolt.Add(boltreferance);
                var parent1 = boltreferance.transform.parent;
                boltreferance.transform.GetComponent<Collider>().enabled = false;
                parent1.DOLocalMoveZ(parent1.localPosition.z - boltremoveheight, 0.3f).SetEase(Ease.Linear).OnComplete(
                    () =>
                    {
                        boltreferance.transform.GetComponent<Collider>().enabled = true;
                    });
            }
        }
        
        else if (gameManager.selectedBolt.Count==0)
        {
            /*if (boltreferance.GetComponent<NewBolt>().connectedBodylist != null)
            {
                for (int i = 0; i < boltreferance.GetComponent<NewBolt>().connectedBodylist.Count; i++)
                {
                    boltreferance.GetComponent<NewBolt>().connectedBodylist[i].GetComponentInParent<Rigidbody2D>()
                        .simulated = false;
                }
            }#1#
            if (UIManager.INSTANCE.pin)
            {
                UIManager.INSTANCE.pin = false;
                UIManager.INSTANCE.fill = true;
            }
            gameManager.vibration();
            Dev_AudioManager.Play("Bolt");
            boltreferance.transform.GetComponent<Collider>().enabled = false;
            var parent = boltreferance.transform.parent;
            Dev_AudioManager.Play("Bolt");
            parent.DOLocalMoveZ(parent.localPosition.z - boltremoveheight, 0.3f).OnComplete(() =>
            {
                boltreferance.transform.GetComponent<Collider>().enabled = true;
                gameManager.gamestate = GameManager.State.Select;
            });
            gameManager.selectedBolt.Add((boltreferance));
            //gameManager.dupPlug = boltreferance;
        }
    }*/ 
   
}