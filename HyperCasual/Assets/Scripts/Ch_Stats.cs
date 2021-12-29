using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ch_Stats : MonoBehaviour
{
    public float movementSpeed = 7f;
    public float jumpSpeed = 35f;
    public string Ch_Name { get; set; }
    public int movementBuffLevel { get; set; }
    public int jumpBuffLevel { get; set; }
    public int coinBuffLevel { get; set; }

    private void Start()
    {
        PlayerPrefs.SetString("Ch_Name",Ch_Name);
        PlayerPrefs.SetInt("movementBuffLevel",movementBuffLevel);
        PlayerPrefs.SetInt("jumpBuffLevel",jumpBuffLevel);
        PlayerPrefs.SetInt("coinBuffLevel",coinBuffLevel);
    }
}
