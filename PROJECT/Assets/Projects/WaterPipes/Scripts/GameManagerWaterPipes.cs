using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using System.Collections.Generic;


public class GameManagerWaterPipes : MonoBehaviour {

    public SquareReceiver _horizontal;
    public SquareReceiver _bottom_left;
    public SquareReceiver _bottom_right;
    public SquareReceiver _top_left;
    public SquareReceiver _top_right;
    public SquareReceiver _vertical;
    public SquareReceiver _end;
    public SquareReceiver _start;

    public GameObject _imageTarget;
    private List<SquareReceiver> _squarePrefabs = new List<SquareReceiver>();
    public Text timeText;
	public Text scoreText;
    public GameObject activateOnFinish;
    public SquareReceiver[] last_square = new SquareReceiver[25];



    void Awake()
    {
        _squarePrefabs.Add(_horizontal);
        _squarePrefabs.Add(_bottom_left);
        _squarePrefabs.Add(_bottom_right);
        _squarePrefabs.Add(_top_left);
        _squarePrefabs.Add(_top_right);
        _squarePrefabs.Add(_vertical);

        

        createObject(_start, new Vector3(-0.4f, -0.09f, -0.4f));
        createObject(_end, new Vector3(0.4f, -0.09f, 0.4f));

        makeGameBoard();


        
    }

    void makeGameBoard()
    {
        float _x, _z, x, z = 0.0f;
        Vector3 posSquare;

        for (z = -2.0f; z <= 2.0f; z++)
        {
            _z = z * 0.2f;

            for (x = -2.0f; x <= 2.0f; x++)
            {
                _x = x * 0.2f;
                posSquare = new Vector3(_x, -0.09f, _z);
                if (GameObject.Find("start0").transform.localPosition != posSquare && GameObject.Find("end24").transform.localPosition != posSquare)
                {
                    SquareReceiver a = _squarePrefabs[Random.Range(0, _squarePrefabs.Count)];
                    createObject(a, posSquare);
                }
            }
        }
    }

    void createObject(SquareReceiver _object, Vector3 local_position)
    {
        
        int axis_object_push_x = (int)(5.0f * local_position.x) + 2;
        int axis_object_push_z = (int)(5.0f * local_position.z) + 2;
        int nume_square = (int)(5.0f * axis_object_push_z) + axis_object_push_x;

        switch (_object.transform.name)
        {
            case "start":
                
                last_square[nume_square] = Instantiate(_object) as StartSquare;
                break;
            case "horizontal":
                 
                last_square[nume_square] = Instantiate(_object) as HorizontalSquare;
                last_square[nume_square].transform.localRotation = Quaternion.Euler(0.0f, 0.0f, 0.0f);

                break;
            case "vertical":
                 
                last_square[nume_square] = Instantiate(_object) as VerticalSquare;
                last_square[nume_square].transform.localRotation = Quaternion.Euler(0.0f, 0.0f, 0.0f);

                break;
            case "bottom_left":
               
                last_square[nume_square] = Instantiate(_object) as BottomLeftSquare;
                last_square[nume_square].transform.localRotation = Quaternion.Euler(0.0f, 0.0f, 0.0f);

                break;
            case "top_left":
                 
                last_square[nume_square] = Instantiate(_object) as UpLeftSquare;
                last_square[nume_square].transform.localRotation = Quaternion.Euler(0.0f, 0.0f, 0.0f);

                break;
            case "bottom_right":
                 
                last_square[nume_square] = Instantiate(_object) as BottomRightSquare;
                last_square[nume_square].transform.localRotation = Quaternion.Euler(0.0f, 0.0f, 0.0f);

                break;
            case "top_right":
               
                last_square[nume_square] = Instantiate(_object) as UpRightSquare;
                last_square[nume_square].transform.localRotation = Quaternion.Euler(0.0f, 0.0f, 0.0f);

                break;
            case "end":
                
                last_square[nume_square] = Instantiate(_object) as EndSquare;
                last_square[nume_square].transform.localRotation = Quaternion.Euler(0.0f, 0.0f, 0.0f);

                break;
        }



        last_square[nume_square].transform.name = _object.transform.name + nume_square;
        last_square[nume_square].transform.parent = _imageTarget.transform;
        last_square[nume_square].transform.localPosition = local_position;
        last_square[nume_square].transform.localScale = new Vector3(0.2f, 0.2f, 0.2f);
        last_square[nume_square].setFull(false);

       
    }

    // Use this for initialization
    void Start () {
        Debug.Log("starting gamemanager waterpipes");
       GameObject.Find("InfoPanel").SetActive(false);
    }

	private int lastSeconds;
	// Update is called once per frame
	void Update () {
	    TimeController time = GetComponent<TimeController>();
        
        int min_time_game = (int)time.getTimeLeftGame() / 60;
        int sec_time_game = (int)time.getTimeLeftGame() % 60;

		if(lastSeconds != sec_time_game)
			scoreText.text = "Score: " + ScoreManager.getInstance().decr(1);

		lastSeconds = sec_time_game;

        timeText.text = "Time: " + min_time_game.ToString() + ":" + sec_time_game.ToString();

        if (min_time_game == 0 && sec_time_game == 0)
        {
            activateOnFinish.SetActive(true);
        }

        
    }
}
