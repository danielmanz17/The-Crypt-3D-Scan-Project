using System;
using System.Collections;
using System.Collections.Generic;
using System.Drawing;
using UnityEngine;
using UnityEngine.Rendering.HighDefinition;
using UnityEngine.UIElements;

public class OSC_transform : MonoBehaviour
{
    public OSC osc;
    //Kick
    public bool kickRoation = false;
    public int kickRotationRange = 180;
    //Snare
    public bool snareRoation = false;
    public int snareRotationRange = 180;
    public bool snarePosition = false;
    public float snarePositionRange = 2.0f;
    //Spectral Density 
    public bool spectralScale = false;
    public float spectralMagnitude = 1.0f;
    public bool colorInvertSnare = false;
    // Start is called before the first frame update
    void Start()
    {
        //values represent channel names from the audio analysis tox in touchDesigner
        osc.SetAddressHandler("/kick", OnReceiveKick);
        osc.SetAddressHandler("/snare", OnReceiveSnare);
        osc.SetAddressHandler("/fmsd", OnReceiveSpectralDensity); //fast moving spectral density
    
    }

    // Update is called once per frame
    // void Update()
    // {
        
    // }

    void OnReceiveKick(OscMessage message)
    {
        Debug.Log(message.ToString());

        if(kickRoation){
            //Debug.Log("Random Kick Rotaion enabled");

            if(message.values[0].ToString() == "1")
            {
                int x = UnityEngine.Random.Range(-kickRotationRange, kickRotationRange); 
                int y = UnityEngine.Random.Range(-kickRotationRange, kickRotationRange);
                int z = UnityEngine.Random.Range(-kickRotationRange, kickRotationRange);
                transform.Rotate(x, y, z);
            }
        }

        //Debug.Log("Received");
    }
    void OnReceiveSnare(OscMessage message)
    {
        //Debug.Log(message.ToString());

        if(snareRoation){
            //Debug.Log("Random Snare Rotaion enabled");
            if(message.values[0].ToString() == "1")
            {
                int x = UnityEngine.Random.Range(-kickRotationRange, snareRotationRange); 
                int y = UnityEngine.Random.Range(-kickRotationRange, snareRotationRange);
                int z = UnityEngine.Random.Range(-kickRotationRange, snareRotationRange);
                transform.Rotate(x, y, z);
            }
        }

        if(snarePosition) {
            //Debug.Log("Snare Position enabled");
            if(message.values[0].ToString() == "1")
            {
                Vector3 position = transform.position;
                position.x = (float)UnityEngine.Random.Range(-snarePositionRange, snarePositionRange);
                position.y = (float)UnityEngine.Random.Range(-snarePositionRange, snarePositionRange); 
                position.z = (float)UnityEngine.Random.Range(-snarePositionRange, snarePositionRange);
                transform.position = position;
            }
        }
        //Debug.Log("Received snare");
    }

    void OnReceiveSpectralDensity(OscMessage message)
    {
        //Debug.Log(message.ToString());
        if(spectralScale){
            //Debug.Log("Spectral Density Scale enabled");
            //Scale the object based on the spectral density from touchDesigner
            Vector3 scale = transform.localScale;
            scale.x = (float)message.values[0]*spectralMagnitude;
            scale.y = (float)message.values[0]*spectralMagnitude;
            scale.z = (float)message.values[0]*spectralMagnitude;
            transform.localScale = scale;
        }

        //Debug.Log("Received Spectral Density");
    }
}
