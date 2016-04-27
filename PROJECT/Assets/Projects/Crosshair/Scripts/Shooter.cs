using UnityEngine;
using System.Collections;

public class Shooter : MonoBehaviour {

    public    GameObject shot;

	// Update is called once per frame
	void Update () {
        // probar a trampear con una buena foto y volver a imageTarget
        // mantener texto y dibujar un rayo láser y hacer un pequeño efecto de explosión o de lanzamiento del rayo

	if (GameManager.instance.CanShoot()) {
            Debug.DrawRay(transform.position, transform.forward * 1000, Color.blue);            
            if (Input.GetMouseButtonDown(0))
            {
                GameObject projectile = Instantiate(shot, transform.position + transform.forward * 2, transform.rotation) as GameObject;
                Rigidbody rb = projectile.GetComponent<Rigidbody>();
                rb.AddForce(transform.forward * 2000);

            }
        }
	}
}
