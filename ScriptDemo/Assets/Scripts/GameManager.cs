using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    // Start is called before the first frame update
    private int count = 3;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        count = GameObject.FindGameObjectsWithTag("Purple").Count();
        //count = GameObject.FindGameObjectsWithTag("Purple").Length;

        if(count > 2)
        {
            Debug.Log("Game OVer :)");
        }
    }
}
