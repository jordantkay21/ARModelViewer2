using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonRotation : MonoBehaviour
{
    [SerializeField]
    private float _xAxisRotation = 0.0f;
    [SerializeField]
    private float _yAxisRotation = 0.0f;
    [SerializeField]
    private float _zAxisRotation = 0.0f;

  
    private float _YRotationReset;


    private void Start()
    {
        _YRotationReset = this.gameObject.transform.rotation.y;
    }
    // Update is called once per frame
    void Update()
    {
        this.gameObject.transform.Rotate(_xAxisRotation, _yAxisRotation, _zAxisRotation, Space.Self);
    }

    public void ResetRotation()
    {
        this.gameObject.transform.rotation = Quaternion.Euler(0, 0, 0);
    }


}
