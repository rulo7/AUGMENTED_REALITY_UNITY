using UnityEngine;
using System.Collections;
using System;
/**
* Calcula si el la entrada de la casilla siguiente coincide con la salida de la actual.
**/
public class CheckSquare : ICommand {
    private SquareReceiver _square;
    private int _input;
   
    // Use this for initialization
   public CheckSquare(SquareReceiver square, int input)
    {
        _square = square;
        _input = input;
    }
	 public bool Execute()
    {
        bool is_correct = false;
        if (_square.isCorrect(_input))
        {
            is_correct = true;
           
        } 
        return is_correct;
    }

}
