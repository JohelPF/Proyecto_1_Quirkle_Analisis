using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Boundaries : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = new Vector3(Mathf.Clamp(transform.position.x, -1.234883f, 1.234883f),
            Mathf.Clamp(transform.position.y, -0.4622732f, 0.4622732f), transform.position.z);
    }
}
