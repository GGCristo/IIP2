using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class sphereA : MonoBehaviour
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
        if (Input.GetKeyDown(KeyCode.Space)) {
            Push();
        }
    }

    public void Push() {
        print("Fus Ro Dah!!!");
        m_Rigidbody.AddForce(player.transform.forward * 600f);
    }
}
