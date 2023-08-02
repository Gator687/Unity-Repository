using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityStandardAssets.Characters.FirstPerson;

public class areaScript : MonoBehaviour
{
    // Start is called before the first frame update
    private AudioSource audioSource;
    private AudioClip laser, newArea;
    void Start()
    {
        audioSource = GetComponent<AudioSource>();
        //link to audio source of plane
        laser = Resources.Load<AudioClip>("Sounds/quick_laser");
        newArea = Resources.Load<AudioClip>("Sounds/newarea");

    }

    private void OnTriggerEnter(Collider other)
    {
        audioSource.clip = newArea;
        audioSource.Play();

        switch(this.name)
        {
            case "GrassPlane":
            default:
                FirstPersonController.footStepIndex = 0;
                break;
            case "MudPlane":
                FirstPersonController.footStepIndex = 1;
                break;
            case "RockPlane":
                FirstPersonController.footStepIndex = 2;
                break;
            case "SandPlane":
                FirstPersonController.footStepIndex = 3;
                break;
        }
    }

    private void OnTriggerExit(Collider other)
    {
        
    }

    private void OnTriggerStay(Collider other)
    {
        
    }


    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            audioSource.clip = laser;
            audioSource.Play();
        }   
    }
}
