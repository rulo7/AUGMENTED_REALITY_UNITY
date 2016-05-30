    using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using System.Collections.Generic;

public class SquareController : Invoker {

    ICommand command;

    public void SetCommand(ICommand command)
    {
        this.command = command;
    }

    public bool Invoke()
    {
        return command.Execute();
    }

}