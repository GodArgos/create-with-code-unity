using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PropellerRotation : MonoBehaviour
{
    public float propellerSpeed;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(new Vector3(0,0,1) * propellerSpeed * Time.deltaTime);
    }
}
