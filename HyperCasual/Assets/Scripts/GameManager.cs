using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    public GameObject TapToStartPanel;
    public Animator anim;
    public bool isGameStart;
    private void Update()
    {
        if (Input.touchCount > 0)
        {
            isGameStart = true;
            TapToStartPanel.SetActive(false);
            anim.SetBool("isGameStart",true);   
        }
        //silinecek
        /*if (Input.GetKeyDown(KeyCode.W))
        {
            isGameStart = true;
            TapToStartPanel.SetActive(false);
            anim.SetBool("isGameStart",true);
        }*/
    }
}
