using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class PlayerCCC_Gold : MonoBehaviour
{
    public int coins = 0;

    public void AddCoin()
    {
        coins++;
    }


    void Update()
    {
        if (coins >= 209)
        {
            GameOver();
        }
    }
    public void GameOver()
    {
        StartCoroutine(Reloader());
    }
    IEnumerator Reloader()
    {
        yield return new WaitForSeconds(2);
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}
