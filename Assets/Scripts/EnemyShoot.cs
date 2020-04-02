using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyShoot : MonoBehaviour
{

    public GameObject Ebullet;

    int RandomShot;
    float time;

    // Start is called before the first frame update
    void Start()
    {
        RandomShot = Random.Range(1, 3);
        time = RandomShot;
    }

    // Update is called once per frame
    void Update()
    {
        time -= Time.deltaTime;

        if (time <= 0)
        {
            foreach (Transform child in transform)
            {
                Instantiate(Ebullet, child.position, Quaternion.identity);
            }

            RandomShot = Random.Range(1, 3);
            time = RandomShot;

        }
        
    }
}
