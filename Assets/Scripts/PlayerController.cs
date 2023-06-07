using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float verticalMove = Input.GetAxis("Vertical");
        transform.Translate(Vector3.forward * Time.deltaTime * 15 * verticalMove); 
    }
}
