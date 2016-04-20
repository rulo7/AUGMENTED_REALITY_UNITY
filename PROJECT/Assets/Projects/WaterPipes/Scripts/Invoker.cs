using UnityEngine;
using System.Collections;

public interface Invoker {

    // Inyecta un ICommand, permitiendo cambiar la operación encapsulada en
    // tiempo de ejecución
    void SetCommand(ICommand command);

    // Ejecuta el método encapsulado
    bool Invoke();
}
