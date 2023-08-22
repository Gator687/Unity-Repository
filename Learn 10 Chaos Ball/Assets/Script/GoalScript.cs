using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GoalScript : MonoBehaviour
{
    // Start is called before the first frame update
    public bool isSolved = false;
    void OnTriggerEnter(Collider collider)
    {
        GameObject colliedWith = collider.gameObject;
        if(colliedWith.tag == gameObject.tag)
        {
            isSolved = true;
            GetComponent<Light>().enabled = false;
            Destroy(colliedWith);
        }
    }
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
