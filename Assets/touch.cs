using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class touch : MonoBehaviour
{

    public Transform gameobject;
    // Update is called once per frame
    void Update()
    {
        void OnCollisionEnter(Collision other)
        {
            if (other.CompareTag("Player2"))
            {
                Destroy(gameobject);
            }
        }


    }
}
