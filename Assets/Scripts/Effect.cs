using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Effect : MonoBehaviour
{
    float countdown = 2;

    private void Start()
    {
        countdown = 2;
    }
    private void Update()
    {
        countdown -= Time.deltaTime;
        if (countdown < 0)
        {
            print("splat destroyed");

            Destroy(gameObject);
        }

        
    }
}
