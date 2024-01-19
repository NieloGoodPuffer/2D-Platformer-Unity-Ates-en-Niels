using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

public class movement1 : MonoBehaviour
{

    public float rechts = 0.3f;
    public float links = 0.3f;
    public int upup = 4;
    public bool cheese = true;
    void Start()
    {
    }
    // Update is called once per frame
    void FixedUpdate()
    {

        if (gameObject.tag == "Player1")
        {
            if (Input.GetKey(KeyCode.D))
            {
                transform.Translate(rechts, 0, 0);
            }
            else if (Input.GetKey(KeyCode.A))
            {
                transform.Translate(-links, 0, 0);
            }
        }
        if (gameObject.tag == "Player2")
        {
            if (Input.GetKey(KeyCode.RightArrow))
            {
                transform.Translate(rechts, 0, 0);
            }
            else if (Input.GetKey(KeyCode.LeftArrow))
            {
                transform.Translate(-links, 0, 0);
            }
        }



    }
    void Update()
    {
        if (gameObject.tag == "Player1")
        {
            if (Input.GetKeyDown(KeyCode.W))
            {
                transform.Translate(0, upup, 0);
            }
        }
        if (gameObject.tag == "Player2")
        {
            if (Input.GetKeyDown(KeyCode.UpArrow))
            {
                transform.Translate(0, upup, 0);
            }
        }
    }
}
