using System;
using System.Collections;
using System.Collections.Generic;
using System.Numerics;
using JetBrains.Annotations;
using UnityEngine;

public class randConfiguration : MonoBehaviour
{   
    int count = 0;
    private UnityEngine.Vector3 positionVector;
    private UnityEngine.Vector3 rotationVector;
    int previousNumber = 100;
    // Start is called before thVee first frame update
    void Start()
    { 
        positionVector = new UnityEngine.Vector3(-0.1814807f,-0.6224548f,1.24304f);
        rotationVector = new UnityEngine.Vector3(270,180,-53.54199f);
    }

    // Update is called once per frame
    void Update()
    {          
        count++;
        if(Input.GetKey("r") && count > 25){
            count = 0;
            int randomNumber = UnityEngine.Random.Range(0,8);
            if(randomNumber == previousNumber){
                randomNumber = (randomNumber + 1) % 6;
            }
            previousNumber = randomNumber;
            switch(randomNumber){
                case 0:
                    positionVector = new UnityEngine.Vector3(-0.265f,-0.646f,1.264f);
                    rotationVector = new UnityEngine.Vector3(231.417f,267.496f,-245.503f);
                    break;
                case 1:
                    positionVector = new UnityEngine.Vector3(-0.194f,-0.123f,0.601f);
                    rotationVector = new UnityEngine.Vector3(212.986f,198.194f,-67.01001f);
                    break;
                case 2:
                    positionVector = new UnityEngine.Vector3(0.225f,-0.203f,0.881f);
                    rotationVector = new UnityEngine.Vector3(227.962f,123.614f,-13.634f);
                    break;
                case 3:
                    positionVector = new UnityEngine.Vector3(0.394f,-0.197f,1.351f);
                    rotationVector = new UnityEngine.Vector3(179.255f,19.717f,69.598f);
                    break;
                case 4:
                    positionVector = new UnityEngine.Vector3(0.397f,-0.583f,1.663f);
                    rotationVector = new UnityEngine.Vector3(-79.289f,364.477f,-3200.717f);
                    break;
                case 5:
                    positionVector = new UnityEngine.Vector3(-0.409f,-0.351f,2.065f);
                    rotationVector = new UnityEngine.Vector3(-24.895f,520.644f,-3173.998f);
                    break;

                case 6:
                    positionVector = new UnityEngine.Vector3(-0.591f,-0.275f,2.054f);
                    rotationVector = new UnityEngine.Vector3(-19.508f,83.915f,-3114.693f);
                    break;
            }
            transform.position = positionVector;
            transform.eulerAngles = rotationVector;
        }
}

    
}
