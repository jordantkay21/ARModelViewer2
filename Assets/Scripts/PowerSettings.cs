using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PowerSettings : MonoBehaviour
{
    public Material targetMaterial;
    public ParticleSystem[] flameBoosters;
    

    private Color originalEmissionColor;
    private bool isEmitting = false;


    // Start is called before the first frame update
    void Start()
    {
            //cache the gems initial emission color
            originalEmissionColor = targetMaterial.GetColor("_EmissionColor");
            //set the emission color to black
            targetMaterial.SetColor("_EmissionColor", Color.black);

        //turn off flame boosters
        foreach(ParticleSystem flame in flameBoosters)
        {
            flame.Stop();
        }
    }

    public void ChangeEmission()
    {
        if (!isEmitting)
            isEmitting = true;
        else
            isEmitting = false;


        if (isEmitting)
        {
            targetMaterial.SetColor("_EmissionColor", originalEmissionColor);
            foreach (ParticleSystem flame in flameBoosters)
            {
                flame.Play();
            }
        }
        else
        {
            targetMaterial.SetColor("_EmissionColor", Color.black);
            foreach (ParticleSystem flame in flameBoosters)
            {
                flame.Stop();
            }
        }
    }
}
