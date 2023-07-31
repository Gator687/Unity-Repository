using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveBall : MonoBehaviour
{
    // Start is called before the first frame update
    public float ballSpeed = 1000;
    void Start()
    {
        Rigidbody rb = GetComponent<Rigidbody>();
        rb.velocity = new Vector3(ballSpeed, 0, ballSpeed);
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 pos = this.transform.position;
        if(pos.z <= -22)
        {
            Material mat = Resources.Load<Material>("Purple");
            MeshRenderer mesh = GetComponent<MeshRenderer>();
            mesh.material = mat;
            //stpo ball
            //Rigidbody rb = GetComponent<Rigidbody>();
            //rb.velocity = Vector3.zero;
            //apply the tag

            this.tag = "Purple";
        }
    }
}
