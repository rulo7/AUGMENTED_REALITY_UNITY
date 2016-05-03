using UnityEngine;
using System;
using System.Collections;
using UnityEngine.UI;

static class Constants
{
    public const float timeGame = 6.0f*25.0f;
    public const float timeCube = 6.0f;
    public const float timeToStart = 6.0f;
}

public class TimeController : MonoBehaviour {
    

    private float timeLeftGame = Constants.timeGame;
    private float timeLeftCube = Constants.timeCube;
    private float timeLeftToStart = Constants.timeToStart;


    void Update()
    {
        timeLeftToStart -= Time.deltaTime;
        timeLeftGame -= Time.deltaTime;
        timeLeftCube -= Time.deltaTime;
    }

    public float getTimeLeftCube()
    {
        return timeLeftCube;
    }
    public float getTimeLeftToStart()
    {
        return timeLeftToStart;
    }

    public float getTimeLeftGame()
    {
        return timeLeftGame;
    }

    public void resetTimeCube()
    {
        timeLeftCube = Constants.timeCube;
    }
}
