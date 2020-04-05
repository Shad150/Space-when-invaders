using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Menu : MonoBehaviour
{

    public GameObject MainMenu;
    public GameObject DeathMenu;
    public GameObject EDeathMenu;
    public GameObject P2DeathMenu;

    public Movement Movement;
    public P2Movement P2Movement;
    public EnemyMovement EnemyMovement;

    void Start()
    {
        Time.timeScale = 0;
        MainMenu.SetActive(true);
        DeathMenu.SetActive(false);
        EDeathMenu.SetActive(false);
        P2DeathMenu.SetActive(false);
    }

    void Update()
    {
        if (Movement.pDeath == true)
        {
            DeathMenu.SetActive(true);
        }
        else if (EnemyMovement.eDeath == true)
        {
            EDeathMenu.SetActive(true);
        }
        else if (P2Movement.p2Death == true)
        {
            P2DeathMenu.SetActive(true);
        }
    }

    public void Player1Button()
    {
        EnemyMovement.gameObject.SetActive(false);
        Time.timeScale = 1;
        MainMenu.SetActive(false);
    }

    public void Player2Button()
    {
        P2Movement.gameObject.SetActive(false);
        Time.timeScale = 1;
        MainMenu.SetActive(false);
    }

    public void ReturnToMenu()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

}
