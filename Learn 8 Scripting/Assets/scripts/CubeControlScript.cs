using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeControlScript : MonoBehaviour
{
    private GameObject target;
    private GameObject cam;
    private Boolean big = false;
    // Start is called before the first frame update
    void Start()
    {
        target = GameObject.Find("Cube");
        cam = GameObject.Find("Main Camera");
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.UpArrow))
        {
            target.transform.Translate(0f, .05f, 0f);
        }

        if (Input.GetKey(KeyCode.DownArrow))
        {
            target.transform.Translate(0f, -.05f, 0f);
        }

        if (Input.GetKey(KeyCode.LeftArrow))
        {
            target.transform.Translate(-.05f, 0f, 0f);
        }

        if (Input.GetKey(KeyCode.RightArrow))
        {
            target.transform.Translate(.05f, 0f, 0f);
        }

        float mxVal = Input.GetAxis("Mouse X");
        float myVal = Input.GetAxis("Mouse Y");
        if (mxVal != 0)
            cam.transform.Rotate(0f, .05f, 0f);
        if (myVal != 0)
            cam.transform.Rotate(.05f, 0f, 0f);

        if (Input.GetKey(KeyCode.M))
        {
            if (big)
            {
                target.transform.localScale = new Vector3(1f, 1f, 1f);
            }

            else
            {
                target.transform.localScale = new Vector3(2f, 2f, 2f);
            }

            big = !big;
        }
    }
}
