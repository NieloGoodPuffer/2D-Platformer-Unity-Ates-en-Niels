using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

public class movement1 : MonoBehaviour
{

    public float rechts = 0.3f;
    public float links = -0.3f;

    public bool cheese = true;
    void Start()
    {
    }
    // Update is called once per frame
    void FixedUpdate()
    {


        if (Input.GetKey(KeyCode.D))
        {
            transform.Translate(rechts, 0, 0);
        }
        else if (Input.GetKey(KeyCode.A))
        {
            transform.Translate(links, 0, 0);
        }

    }
}
