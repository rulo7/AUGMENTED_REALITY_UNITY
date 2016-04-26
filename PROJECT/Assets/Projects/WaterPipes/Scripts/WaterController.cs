using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using System.Collections.Generic;

public class WaterController : MonoBehaviour {

    private int _nume_square;
    private GameManagerWaterPipes _gm;

    public GameObject activateOnFinish;
    
   
    private bool _game_over;
    
    private bool _you_win = false;
    
    private int min_time_cube;
    private int sec_time_cube;

    // Use this for initialization
    void Start () {
        _nume_square = 0;
        _game_over = false;
        _gm = GetComponent<GameManagerWaterPipes>();
        _gm.last_square[_nume_square].setSquare(0);
        _gm.last_square[_nume_square].setInput(1);
        
    }
	
	// Update is called once per frame
	void Update () {
        TimeController time = GetComponent<TimeController>();
        min_time_cube = (int)time.getTimeLeftCube() / 60;
        sec_time_cube = (int)time.getTimeLeftCube() % 60;
        


        if (!_game_over) {
            _gm.timeCubeText.text = "Time: " + min_time_cube.ToString() + ":" + sec_time_cube.ToString();
            if ( min_time_cube == 0 && sec_time_cube == 0)
            {

                if (checkWater())
                {
                    time.resetTimeGame();
                }
                else
                {
                    _gm.timeCubeText.text = "Time: - : - ";
                    if(_you_win)
                    {
                        _gm.gameOverText.color = Color.green;
                        _gm.gameOverText.text = "YOU WIN";
  
                        //Application.LoadLevel("winner");
                    }
                    else {
                        _game_over = true;
                        _gm.gameOverText.text = "GAME OVER";
                        //Application.LoadLevel("gameover");
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
        //Debug.Log("name: " + _gm.last_square[_nume_square].transform.name + " input : " + input_ant);
        int square_next = _gm.last_square[_nume_square].getNextSquare(input_ant);
        Debug.Log("square_next: " + square_next);
        if (square_next == 24)
        { 
            _you_win = true;
        }
        //Debug.Log("square_next: " + square_next);
        if(square_next >= 0 && square_next <= 24 && !_you_win)
        {
            //Debug.Log("antes icommad");
            ICommand check_next = new CheckSquare(_gm.last_square[square_next], _gm.last_square[_nume_square].getOutput(input_ant));

            //Debug.Log("antes invoker");

            // Creamos un nuevo Invoker (el objeto que será desacoplado de las luces)
            Invoker invoker = new SquareController();

            // Le asociamos los objetos Command y los ejecutamos
            // El objeto invoker invoca el método 'Execute()' sin saber en ningún momento
            // qué es lo que se está ejecutando realmente.
            //Debug.Log("antes setcommand");

            invoker.SetCommand(check_next);      // Asociamos el ICommand

            //Debug.Log("antes if");
            if (invoker.Invoke())                          // Hacemos que se ejecute ICommand.Execute()
            {
                
                is_correct = true;


               

                _gm.last_square[square_next].setInput(_gm.last_square[_nume_square].getOutput(input_ant));

          

                _gm.last_square[square_next].setSquare(square_next);

           

                _gm.last_square[_nume_square].enabled = false;

       

                _nume_square = square_next;

                int input = _gm.last_square[_nume_square].getInput();
                //Debug.Log("input: " + input);
                //Debug.Log("inputAnt: " + input_ant + " input: " + input + " --> next: " + _nume_square);
                //Debug.Log("name: " + _gm.last_square[_nume_square].transform.name);

             

                _gm.last_square[_nume_square].GetComponentInChildren<Animator>().SetBool("water", true);
                _gm.last_square[_nume_square].GetComponentInChildren<Animator>().SetInteger("direction", input);

            }
           
        }

        


        return is_correct;
    }

     public int getSecTimeCube()
    {
        return sec_time_cube;
    }
}
