using UnityEngine;
using System.Collections.Generic;
using System.Collections;

public class EndSquare : SquareReceiver {

	// Use this for initialization
	void Start () {
        this._direc = new Dictionary<int, int>();
        this._direc.Add(-1, -1);
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
