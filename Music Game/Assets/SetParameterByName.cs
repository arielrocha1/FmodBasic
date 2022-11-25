using System;
using System.Collections;
using System.Collections.Generic;
using FMODUnityResonance;
using UnityEngine;

public class SetParameterByName : MonoBehaviour
{
    private FMOD.Studio.EventInstance instance;

    public FMODUnity.EventReference fmodEvent;

    [SerializeField] [Range(0f, 8f)] 
    private float naipe;
    
    
    public float direction;

    private void Start()
    {
        instance = FMODUnity.RuntimeManager.CreateInstance(fmodEvent);
        instance.start();
    }
    
    private void Update()
    {
        instance.setParameterByName("Naipe", naipe);
    }


    private void FixedUpdate()
    {
        direction = Input.GetAxisRaw("Horizontal");
        StartCoroutine(Cd(direction));
    }
    
    IEnumerator Cd(float direction)
    {
        if (direction == 1)
        {
            naipe += 0.01f;
        }
        else if (direction == -1)
        {
            naipe -= 0.01f;
        }
        yield return new WaitForSeconds(1f);
    }
}
