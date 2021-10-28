using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class sphereBScript : MonoBehaviour
{
    private GameObject player;
    Rigidbody m_Rigidbody;
    // Start is called before the first frame update
    void Start()
    {
        player = GameObject.FindWithTag("Player");
        m_Rigidbody = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        float distance = Vector3.Distance (transform.position, player.transform.position);
        if (distance < 5f) {
            m_Rigidbody.AddForce(player.transform.forward * 600f);
        }
    }
}
