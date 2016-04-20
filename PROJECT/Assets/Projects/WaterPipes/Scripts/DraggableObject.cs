using UnityEngine;
using System.Collections;
public class DraggableObject : MonoBehaviour
{

    private float focusx;
    private float focusy;
    private float focusz;
    private GameObject[] objects_push;
    private GameObject _object_push;
    private Vector3 _initial_position_cube;
    private SquareReceiver _inital_square_cube;
    private string _aux_name;
    private GameManagerWaterPipes _gm;
    private Color _colorCube;
    private GameObject _hitObj;

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

                    _hitObj = GetNearestHitGameObject(new Vector3(touch.position.x, touch.position.y, 0));
                    _hitObj.GetComponent<BoxCollider>().isTrigger = true;

                   
                    
                    break;

                case TouchPhase.Moved:
                    moveObject(_hitObj);
                    break;


            }
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

    void moveObject(GameObject hit_object)
    {
        focusx = Input.GetTouch(0).deltaPosition.x;
        focusz = 0;
        focusy = Input.GetTouch(0).deltaPosition.y;

        Vector3 pos = new Vector3(focusx, focusz, focusy);
        hit_object.transform.position += pos;
    }

  

}