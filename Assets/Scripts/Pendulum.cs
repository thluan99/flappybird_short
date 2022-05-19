using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pendulum : MonoBehaviour
{
    public float leftRange;
    public float rightRange;
    public float velocity;

    Rigidbody2D rig;

    private void Awake()
    {
        rig = gameObject.GetComponent<Rigidbody2D>();
    }
    // Start is called before the first frame update
    void Start()
    {
        rig.angularVelocity = velocity;
    }

    // Update is called once per frame
    void Update()
    {

    }

    void Push()
    {
        if (
            transform.rotation.z > 0 &&
            transform.rotation.z < rightRange &&
            rig.angularVelocity > 0 &&
            rig.angularVelocity < velocity
        ){
            rig.angularVelocity = velocity;
        }
        else if (
            transform.rotation.z < 0 &&
            transform.rotation.z > leftRange &&
            rig.angularVelocity < 0 &&
            rig.angularVelocity > velocity * -1
        ){
            rig.angularVelocity = velocity * -1;
        }
    }
}
