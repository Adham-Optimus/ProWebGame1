using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class PlayerC_EndLess : MonoBehaviour
{
    public int coins = 0;
    public GameObject MenuAgain;
    public Text text;

    public void AddCoin()
    {
        coins++;
    }


    private void OnTriggerEnter(Collider collision)
    {
        if (collision.tag == "DeathWall")
        {
            GameOver();
        }
        if (collision.tag == "Monetka")
        {
            coins++;
            text.text = coins.ToString();
            Destroy(collision.gameObject);
        }
    }
    
    public void GameOver()
    {
        MenuAgain.SetActive(true);
    }

    
}
