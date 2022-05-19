using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotate : MonoBehaviour
{  
    [SerializeField] private Vector3 rotation = new Vector3(0, 0, 1);
    [SerializeField] private float rotateSpeed = 1;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(rotation * rotateSpeed);
    }
}
