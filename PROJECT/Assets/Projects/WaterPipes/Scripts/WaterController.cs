using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using System.Collections.Generic;

public class WaterController : MonoBehaviour {

    private int _nume_square;
    private GameManagerWaterPipes _gm;
    private TimeController _time;
    public GameObject activateOnFinish;
    
    private bool _game_over;

    private bool _start = false;
    
    private bool _you_win = false;
    
    private int min_time_cube;
    private int sec_time_cube;

    private int min_time_start;
    private int sec_time_start;

    // Use this for initialization
    void Start () {
        _nume_square = 0;
        _game_over = false;
        _time = GetComponent<TimeController>();
        _gm = GetComponent<GameManagerWaterPipes>();
        _gm.last_square[_nume_square].setSquare(0);
        _gm.last_square[_nume_square].setInput(1);
        _gm.last_square[_nume_square].setFull(true);
        
    }

    // Update is called once per frame
    void Update () {

        updateTime("start");
        

        if(_nume_square == 0 && min_time_start == 0 && sec_time_start == 0)
        {
            _gm.last_square[0].GetComponent<Animator>().SetBool("start", true);
            updateTime("cube");
            
        }

        if (min_time_cube == 0 && sec_time_cube == 0)
        {
            _time.resetTimeCube();
            _start = true;
        }
           

        if (!_game_over && _start) {
            updateTime("cube");

            if ( min_time_cube == 0 && sec_time_cube == 0)
            {

                if (checkWater())
                {
                    _time.resetTimeCube();
                }
                else
                {
                    if (!_you_win)
                    {
                        _game_over = true;
                    }
                    activateOnFinish.SetActive(true);
                }
            }
        }
    }

    bool checkWater()
    {
        bool is_correct = false;

        int input_ant = _gm.last_square[_nume_square].getInput();
        int square_next = _gm.last_square[_nume_square].getNextSquare(input_ant);

        if (square_next == 24)
        { 
            _you_win = true;
        }

        if (square_next >= 0 && square_next <= 24 && !_you_win)
        {
            ICommand check_next = new CheckSquare(_gm.last_square[square_next], _gm.last_square[_nume_square].getOutput(input_ant));


            // Creamos un nuevo Invoker (el objeto que será desacoplado de las luces)
            Invoker invoker = new SquareController();

            // Le asociamos los objetos Command y los ejecutamos
            // El objeto invoker invoca el método 'Execute()' sin saber en ningún momento
            // qué es lo que se está ejecutando realmente.

            invoker.SetCommand(check_next);      // Asociamos el ICommand

            if (invoker.Invoke())                          // Hacemos que se ejecute ICommand.Execute()
            {
                
                is_correct = true;
                
                _gm.last_square[square_next].setInput(_gm.last_square[_nume_square].getOutput(input_ant));

                _gm.last_square[square_next].setSquare(square_next);

                _nume_square = square_next;

                int input = _gm.last_square[_nume_square].getInput();
                
                _gm.last_square[_nume_square].setFull(true);
                _gm.last_square[_nume_square].GetComponentInChildren<Animator>().SetBool("water", true);
                _gm.last_square[_nume_square].GetComponentInChildren<Animator>().SetInteger("direction", input);
                
            }
        }
        return is_correct;
    }

    void updateTime(string type_time)
    {
        switch (type_time)
        {
            case "start":
                min_time_start = (int)_time.getTimeLeftToStart() / 60;
                sec_time_start = (int)_time.getTimeLeftToStart() % 60;
            break;
            case "cube":
                min_time_cube = (int)_time.getTimeLeftCube() / 60;
                sec_time_cube = (int)_time.getTimeLeftCube() % 60;
            break;
        }
            
    }

    
}
