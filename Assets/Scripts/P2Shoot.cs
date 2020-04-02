using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class P2Shoot : MonoBehaviour
{

    public GameObject P2bullet;

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.RightControl))
        {
            foreach (Transform child in transform)
            {
                Instantiate(P2bullet, child.position, Quaternion.identity);
            }

        }
    }
}
