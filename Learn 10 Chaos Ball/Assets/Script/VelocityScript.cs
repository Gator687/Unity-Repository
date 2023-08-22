using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VelocityScript : MonoBehaviour
{
    // Start is called before the first frame update
    public float startSpeed = 50;
    void Start()
    {
        Rigidbody rigidbody = GetComponent<Rigidbody>();
        rigidbody.velocity = new Vector3(startSpeed, 0, startSpeed);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
