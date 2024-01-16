using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

public class movement1 : MonoBehaviour
{

    float kaas = 0.1f;
    void Start()
    {
        
    }
    // Update is called once per frame
    void Update()
    {
       

        if (Input.GetKeyDown(KeyCode.D))
        {
                transform.Translate(kaas, 0 ,0);
        }
    }
}
