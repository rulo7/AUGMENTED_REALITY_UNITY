using UnityEngine;
using System.Collections;
public class DraggableObjectTouch2D : MonoBehaviour
{
 
    //private Renderer _rend;
    private GameObject[] objects_push;
    private GameObject _object_push;
    private Vector3 _initial_position_cube;
    private SquareReceiver _inital_square_cube;

    private Renderer _rend;

    private string _initial_name;
   
    private GameManagerWaterPipes _gm;
  




    void Awake()
    {
        

    }
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
                    TriggerInputEvent(new Vector3(touch.position.x, touch.position.y, 0), "OnTouchDown");
                    break;
          }
        }

    }

    private void TriggerInputEvent(Vector3 pos, string eventStr)
    {
        GameObject hitObj = GetNearestHitGameObject(pos);

        
        if(hitObj.name != "start" && hitObj.name != "end")
        {
            changeCube(hitObj);
        }
        
    }

   private GameObject GetNearestHitGameObject(Vector3 pos)
    {
        Ray ray = Camera.main.ScreenPointToRay(Input.touches[0].position);
      
        RaycastHit[] hitInfos = Physics.RaycastAll(transform.position, ray.direction);

        Debug.DrawRay(transform.position, ray.direction * 100, Color.red, 5f);
       
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


    private void changeCube(GameObject hit_object)
    {
        if (objects_push.Length == 0)
        {
            //_rend.material.shader = Shader.Find("Specular");
            //_rend.material.SetColor("_SpecColor", Color.black);
            //hit_object.GetComponent<MeshCollider>().isTrigger = true;
            
            //hit_object.transform.position = new Vector3(hit_object.transform.position.x, hit_object.transform.position.y, hit_object.transform.position.z + 1.0f);
            hit_object.transform.gameObject.tag = "ButtonPush";
            
        }
        else
        {
            foreach (GameObject object_push in objects_push)
            {
                _object_push = object_push;
            }

         
            //Get number axis of hit object
            int axis_object_hit_x = (int)(5.0f * hit_object.transform.localPosition.x) + 2;
            int axis_object_hit_z = (int)(5.0f * hit_object.transform.localPosition.z) + 2;
            int nume_square_hit_object = (int)(5.0f * axis_object_hit_z) + axis_object_hit_x;
            //Debug.Log("nume_square_hit_object: " + nume_square_hit_object);

            //Get number axis of push object
            int axis_object_push_x = (int)(5.0f * _object_push.transform.localPosition.x) + 2;
            int axis_object_push_z = (int)(5.0f * _object_push.transform.localPosition.z) + 2;
            int nume_square_object_push = (int)(5.0f * axis_object_push_z) + axis_object_push_x;
            //Debug.Log("nume_square_object_push: " + nume_square_object_push);


            //Save positions in auxiliar var
            _inital_square_cube = _gm.last_square[nume_square_object_push];
            _initial_position_cube = _object_push.transform.position;
      
            
            //Change position object push
            _gm.last_square[nume_square_object_push] = _gm.last_square[nume_square_hit_object];
            _object_push.transform.position = hit_object.transform.position;
           

            //Change position object hit
            _gm.last_square[nume_square_hit_object] = _inital_square_cube;
            hit_object.transform.position = _initial_position_cube;


            Debug.Log("objecto cambiado " + _object_push.transform.name + " por " + hit_object.transform.name);


            hit_object.transform.gameObject.tag = "Button";
            _object_push.transform.tag = "Button";

            //hit_object.transform.position = new Vector3(hit_object.transform.position.x, hit_object.transform.position.y, hit_object.transform.position.z - 1.0f);
            //hit_object.GetComponent<BoxCollider>().isTrigger = false;

        }
    }

}