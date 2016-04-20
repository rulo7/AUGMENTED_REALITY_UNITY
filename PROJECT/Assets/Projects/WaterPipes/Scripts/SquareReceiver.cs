using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public abstract class SquareReceiver : MonoBehaviour {

    protected Dictionary<int, int> _direc;
    protected int _square;
    protected int _output;
    protected int _input;

    public void setSquare(int square)
    {
        _square = square;
    }

    public int getSquare()
    {
        return _square;
    }

    public void setInput(int input)
    {
        _input = input;
    }
    public int getInput()
    {
        return _input;
    }

    public int getNextSquare(int input)
    {
        return _square + _direc[input];
    }

    public int getOutput(int input)
    {
        return _direc[input];
    }

    public abstract bool isCorrect(int input);

}
