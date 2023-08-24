using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MysteryBox : MonoBehaviour
{
    public float degreesPerSecond = 20;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 rotation = new Vector3(degreesPerSecond, 0, degreesPerSecond);
        transform.Rotate(rotation * Time.deltaTime);
        //delta time is the fraction of second for length
    }
}
