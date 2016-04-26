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
       /* Debug.Log(" square: " + _square.transform.name);
        Debug.Log(" input " + _input);
        Debug.Log(" output " + _square.getOutput(_input));
        */
        bool is_correct = false;
        if (_square.isCorrect(_input))
        {
            is_correct = true;
           
        } 
        return is_correct;
    }

}
