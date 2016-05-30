using UnityEngine;
using System.Collections;
public class TouchObject : MonoBehaviour
{
 
    //private Renderer _rend;
    private GameObject[] objects_push;
    private GameObject _object_push;
    private GameObject _object_hit;
    private Vector3 _initial_position_cube;
    private SquareReceiver _inital_square_cube;
    private Renderer _rend;
    private GameManagerWaterPipes _gm;
  

    void Start()
    {
        _gm = GameObject.Find("GameManager").GetComponent<GameManagerWaterPipes>();
        

    }

    void Update()
    {
        objects_push = GameObject.FindGameObjectsWithTag("ButtonPush");

        foreach (Touch touch in Input.touches)
        {
            switch (touch.phase)
            {
                case TouchPhase.Began:
                    getObjectHit();
                    break;
          }
        }

    }

    private void getObjectHit()
    {
        _object_hit = getNearestHitGameObject();
       
        if (!_gm.last_square[getSquareReceiver(_object_hit)].getFull() && _object_hit.name != "start" && _object_hit.name != "end")
        {
            changeCube();
        }
        
    }

   private GameObject getNearestHitGameObject()
    {
        Ray ray = Camera.main.ScreenPointToRay(Input.touches[0].position);
      
        RaycastHit[] hitInfos = Physics.RaycastAll(transform.position, ray.direction);
       
        if (hitInfos.Length == 0)
        {
            return null;
        }
       
        RaycastHit nearestHit = new RaycastHit();
       

        
        float minDist = float.MaxValue;
        foreach (RaycastHit hit in hitInfos)
        {
            
            if (hit.distance < minDist)
            {
                minDist = hit.distance;
                nearestHit = hit;
            }
        }

        return nearestHit.collider.gameObject;

    }


    private void changeCube()
    {
        if (objects_push.Length == 0)
        {
            _object_hit.transform.gameObject.tag = "ButtonPush";
            _rend = _object_hit.GetComponent<Renderer>();
            _rend.material.shader = Shader.Find("Mobile/Particles/Additive");
        }
        else
        {
            foreach (GameObject object_push in objects_push)
            {
                _object_push = object_push;
            }

            changeSquarePositions();

            _rend.material.shader = Shader.Find("Mobile/Particles/Multiply");
            _object_hit.transform.gameObject.tag = "Button";
            _object_push.transform.tag = "Button";

        }
    }

    int getSquareReceiver(GameObject object_square)
    {

        int axis_x = (int)(5.0f * object_square.transform.localPosition.x) + 2;
        int axis_z = (int)(5.0f * object_square.transform.localPosition.z) + 2;
        return (int)(5.0f * axis_z) + axis_x;
    }

    void changeSquarePositions()
    {

        //Get number axis of hit object
        int square_hit = getSquareReceiver(_object_hit);
        int square_push = getSquareReceiver(_object_push);


        //Save positions in auxiliar var
        _inital_square_cube = _gm.last_square[square_push];
        _initial_position_cube = _object_push.transform.localPosition;


        //Change position object push
        _gm.last_square[square_push] = _gm.last_square[square_hit];
        _object_push.transform.localPosition = _object_hit.transform.localPosition;


        //Change position object hit
        _gm.last_square[square_hit] = _inital_square_cube;
        _object_hit.transform.localPosition = _initial_position_cube;
    }

}