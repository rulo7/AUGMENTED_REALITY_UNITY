using UnityEngine;
using System;
using System.Collections;
using UnityEngine.UI;

static class Constants
{
    public const float timeGame = 120.0f;
    public const float timeCube = 12.0f;
}

public class TimeController : MonoBehaviour {
    

    private float timeLeftGame = Constants.timeGame;
    private float timeLeftCube = Constants.timeCube;


    void Update()
    {
        timeLeftGame -= Time.deltaTime;
        timeLeftCube -= Time.deltaTime;
    }

    public float getTimeLeftCube()
    {
        return timeLeftCube;
    }

    public float getTimeLeftGame()
    {
        return timeLeftGame;
    }

    public void resetTimeGame()
    {
        timeLeftCube = Constants.timeCube;
    }
}
