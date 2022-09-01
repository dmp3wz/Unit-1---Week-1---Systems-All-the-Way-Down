using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotateAroundSun : MonoBehaviour
{
    // Start is called before the first frame update
    public float rotationSpeed;
    public GameObject pivot;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.RotateAround(pivot.transform.position, new Vector3(0,1,0), rotationSpeed * Time.deltaTime);
    }
}
