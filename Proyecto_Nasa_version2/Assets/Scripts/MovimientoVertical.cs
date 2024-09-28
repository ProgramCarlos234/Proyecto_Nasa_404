using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovimientoVertical : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        float mousey = Input.GetAxis("Mouse Y");
        transform.Rotate(mousey * -1f, 0, 0);
    }
}
