using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Experimental.Video;

public class GameManager : MonoBehaviour
{
    public Player player;
    public static GameManager instance;
    
    void Awake()
    {
        instance = this;
    }
}
