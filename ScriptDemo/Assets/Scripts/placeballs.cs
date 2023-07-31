using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class placeballs : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        int x = 1, y = 1, z = 1;
        //x = 30;
        //z = -10;
        x = Random.Range(-40, 40);
        z = Random.Range(-20, 20);
        this.transform.position = new Vector3(x, y, z);

        //debug demo
        Debug.Log(this.name + " is at position " + this.transform.position.ToString());

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
