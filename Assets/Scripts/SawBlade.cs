using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SawBlade : MonoBehaviour
{
    public RunAxis runAxis;
    [SerializeField] private float translateSpeed = 0.1f;
    [SerializeField] private float rangeTranslate = 5;

    private Vector3 verticalTranslate;
    private Vector3 horizontalTraslate;
    private float initCenterPos;
    private int direction = 1;

    private void Awake()
    {
        verticalTranslate = new Vector3(0, 1, 0);
        horizontalTraslate = new Vector3(1, 0, 0);

        if (runAxis == RunAxis.VERTICAL)
        {
            initCenterPos = transform.position.y;
        }
        else
        {
            initCenterPos = transform.position.x;
        }
    }
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (runAxis == RunAxis.VERTICAL)
        {
            if (rangeTranslate <= Mathf.Abs(transform.position.y - initCenterPos))
            {
                direction = -direction;
            }
            transform.Translate(direction * verticalTranslate * Time.deltaTime * translateSpeed);
        }
        else
        {
            if (rangeTranslate <= Mathf.Abs(transform.position.x - initCenterPos))
            {
                direction = -direction;
            }
            transform.Translate(direction * horizontalTraslate * Time.deltaTime * translateSpeed);
        }
    }

    public enum RunAxis
    {
        VERTICAL,
        HORIZONTAL
    }
}
