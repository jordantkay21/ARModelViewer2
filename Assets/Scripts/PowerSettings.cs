using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PowerSettings : MonoBehaviour
{
    public Material targetMaterial;
    

    private Color originalEmissionColor;
    private bool isEmitting = false;


    // Start is called before the first frame update
    void Start()
    {
            //cache the gems initial emission color
            originalEmissionColor = targetMaterial.GetColor("_EmissionColor");

            //set the emission color to black
            targetMaterial.SetColor("_EmissionColor", Color.black);
    }

    public void ChangeEmission()
    {
        if (!isEmitting)
            isEmitting = true;
        else
            isEmitting = false;


        if (isEmitting)
            targetMaterial.SetColor("_EmissionColor", originalEmissionColor);
        else
            targetMaterial.SetColor("_EmissionColor", Color.black);
    }
}
