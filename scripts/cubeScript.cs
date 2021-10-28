using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cubeScript : MonoBehaviour
{
    private GameObject player;
    private GameObject[] spheres;
    // Start is called before the first frame update
    void Start()
    {
        player = GameObject.FindWithTag("Player");
        spheres = GameObject.FindGameObjectsWithTag("Sphere");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void FixedUpdate() {
        float distancePlayer = Vector3.Distance(transform.position, player.transform.position);
        if (distancePlayer < 5f) {
            print("Esta cerca");
            Vector3 scale = transform.localScale;
            if (transform.localScale.x - 0.1f >= 1) {
                scale.x -= 0.1f;
            }
            if (transform.localScale.y - 0.1f >= 1) {
                scale.y -= 0.1f;
            }
            if (transform.localScale.z - 0.1f >= 1) {
                scale.z -= 0.1f;
            }
            transform.localScale = new Vector3(scale.x, scale.y, scale.z);
        }
        foreach (GameObject sphere in spheres) {
            float distanceSphere = Vector3.Distance(transform.position, sphere.transform.position);
            if (distanceSphere < 5f) {
                Vector3 scale = transform.localScale;
                transform.localScale = new Vector3(scale.x + 0.1f, scale.y + 0.1f, scale.z + 0.1f);
            }
        }
    }
}
