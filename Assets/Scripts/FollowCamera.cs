using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowCamera : MonoBehaviour
{
    public Camera cameraFollow;
    public Vector3 offset = new Vector3(0, 0, -10);
    // Start is called before the first frame update
    void Start()
    {
           
    }

    // Update is called once per frame
    void LateUpdate()
    {
        cameraFollow.transform.position = transform.position + offset;
    }
}
