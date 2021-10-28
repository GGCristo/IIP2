using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class secondPlayer : MonoBehaviour
{
    public float movementspeed = 5f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.I)) {
             transform.Translate(Vector3.forward * movementspeed * Time.deltaTime);
        } else if (Input.GetKey(KeyCode.J)) {
            transform.Translate(Vector3.left * movementspeed * Time.deltaTime);
        } else if (Input.GetKey(KeyCode.L)) {
            transform.Translate(Vector3.right * movementspeed * Time.deltaTime);
        } else if (Input.GetKey(KeyCode.M)) {
            transform.Translate(Vector3.forward * -1 * movementspeed * Time.deltaTime);
        }
    }
    void OnCollisionEnter() 
    {
        print("Mira por donde vas");
    }
}
