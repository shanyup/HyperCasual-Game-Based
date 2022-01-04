using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ch_Stats : MonoBehaviour
{
    public float movementSpeed = 7f;
    public float jumpSpeed = 16f;

    public int goldInt { get; set; }
    private int highScore;
    private int speedBoostLevel;
    private int goldBoostLevel;
    private int deathlessBoostLevel;
    void Start()
    {
        PlayerPrefs.SetInt("GoldInt",goldInt);
        PlayerPrefs.SetInt("HighScore",highScore);
        PlayerPrefs.SetInt("SpeedBoostLevel",speedBoostLevel);
        PlayerPrefs.SetInt("GoldBoostLevel",goldBoostLevel);
        PlayerPrefs.SetInt("DeathlessBoostLevel",deathlessBoostLevel);
    }
    void Update()
    {
        
    }
}
