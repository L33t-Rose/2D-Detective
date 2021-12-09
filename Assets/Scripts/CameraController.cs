using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    float timer = 0.5f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(timer == 0.5f)
        {
            shakeLeft();
        }
        else if(timer <= 0)
        {
            shakeRight();
            timer = 0.5f;
            return;
        }
        timer -= Time.deltaTime;
    }

    void shakeLeft()
    {
        print("shake left");
        var test = transform.position;
        test.x = -10;
        transform.position = test;
    }
    void shakeRight()
    {
        print("shake right");
        var test = transform.position;
        test.x = 10;
        transform.position = test;
    }

    
}
