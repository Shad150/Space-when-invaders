using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Menu : MonoBehaviour
{

    public P2Movement P2Movement;
    public EnemyMovement EnemyMovement;

    void Start()
    {
        Time.timeScale = 0;
        gameObject.SetActive(true);
    }

    

    public void Player1Button()
    {
        EnemyMovement.gameObject.SetActive(false);
        Time.timeScale = 1;
        gameObject.SetActive(false);
    }

    public void Player2Button()
    {
        P2Movement.gameObject.SetActive(false);
        Time.timeScale = 1;
        gameObject.SetActive(false);
    }

}
