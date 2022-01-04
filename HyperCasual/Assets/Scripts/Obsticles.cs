using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Obsticles : MonoBehaviour
{
    public bool barrier,trafficCone,concreteBarrier;
    private GameManager _GameManager;
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            _GameManager.isGameOver = true;
            Time.timeScale = 0;
        }
    }
}
