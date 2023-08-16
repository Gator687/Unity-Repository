using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerInputUpdated : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float hVal = Input.GetAxis("Horizontal");
        float vVal = Input.GetAxis("Vertical");
        if (hVal != 0)
            print("Horizontal movement selected: " + hVal);
        if(vVal != 0)
            print("Vertical movement selected: " + vVal);

        if (Input.GetKey(KeyCode.M))
            print("The 'M' key is pressed down");
        if(Input.GetKeyDown(KeyCode.O))
            print("The 'O' key is pressed down");
    }
}
