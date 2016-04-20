using UnityEngine;
using System.Collections.Generic;
using System.Collections;
using System;

public class BottomLeftSquare : SquareReceiver {

  
    public void Start()
    {
        this._direc = new Dictionary<int, int>();
        this._direc.Add(1, -5);
        this._direc.Add(5, -1);
    }


    public override bool isCorrect(int input)
    {
        bool is_correct = false;

        if (_direc.ContainsKey(input))
        {
            is_correct = true;
        }

        return is_correct;
    }
}
