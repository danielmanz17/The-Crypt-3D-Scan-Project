using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UIElements;
using UnityEngine.VFX;

//ONLY USE THIS SCRIPT ON A GAMEOBJECT WITH A VISUAL EFFECT COMPONENT! :D 
public class OSC_aduio_vfx : MonoBehaviour
{
    [Header("OSC Settings")]

    public OSC osc;
    private VisualEffect vfx;
    [Header("VFX Settings")]
    //Kick
    public bool kickTurbulance = false;
    public bool kickVectorField = false;
    //Snare
    public bool snareTurbulance = false;
    public bool snareVectorField = false;
    public bool midiController = false;
    public bool colorFlash = false;
    // Start is called before the first frame update
    void Start()
    {
        vfx = GetComponent<VisualEffect>();
        //values represent channel names from the audio analysis tox in touchDesigner but you can use it for any OSC messages! 
        osc.SetAddressHandler("/kick", OnReceiveKick);
        osc.SetAddressHandler("/snare", OnReceiveSnare);
        osc.SetAddressHandler("/slider1", OnReceiveSlider1);
        osc.SetAddressHandler("/slider2", OnReceiveSlider2);
        //osc.SetAddressHandler("/fmsd", OnReceiveSpectralDensity); //fast moving spectral density
    }

    private void HandleVFXParameter(bool condition, string parameter, OscMessage message)
    {
        if (condition)
        {
            vfx.SetBool(parameter, message.values[0].ToString() == "1");
        }
    }

    void OnReceiveKick(OscMessage message)
    {
        HandleVFXParameter(kickTurbulance, "turbulance", message);
        HandleVFXParameter(kickVectorField, "vectorField", message);
        HandleVFXParameter(colorFlash, "colorFlash", message);
    }

    void OnReceiveSnare(OscMessage message)
    {
        HandleVFXParameter(snareTurbulance, "turbulance", message);
        HandleVFXParameter(snareVectorField, "vectorField", message);
    }
    void OnReceiveSlider1(OscMessage message)
    {
        if(midiController){
            float value = Convert.ToSingle(message.values[0]);
            vfx.SetFloat("turbulenceIntensity", value);
        }
    }
    void OnReceiveSlider2(OscMessage message)
    {
        if(midiController){
            float value = Convert.ToSingle(message.values[0]);
            vfx.SetFloat("fieldIntensity", value);
        }
    }

}