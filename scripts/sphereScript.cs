using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class sphereScript : MonoBehaviour
{
    private GameObject player;
    private characterController script;

    // Start is called before the first frame update
    void Start()
    {
        player = GameObject.FindWithTag("Player");
        if (player) {
            script = player.GetComponent<characterController>();
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnCollisionEnter() 
    {
        Vector3 scale = transform.localScale;
        Vector3 position = transform.position;
        position.y += 0.5f;
        transform.position = position;
        transform.localScale = new Vector3(scale.x + 1, scale.y + 1, scale.z + 1);
        script.puntuation++;
    }
}
