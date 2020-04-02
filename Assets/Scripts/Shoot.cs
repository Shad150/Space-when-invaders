using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shoot : MonoBehaviour
{

    public GameObject bullet;

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey("space"))
        {
            foreach(Transform child in transform)
            {
                Instantiate(bullet, child.position, Quaternion.identity);
            }
            
        }
        
    }
}
