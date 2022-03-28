using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.Audio;
public class SceneManagement : MonoBehaviour
{
    public AudioMixer audioMixer;

    public void ChangeScenes(int number)
    {
        SceneManager.LoadScene(number);
    }
    public void Exit()
    {
        Debug.Log("Exit");
        Application.Quit();
    }
    
    public void Restart()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
    public void Menu()
    {
        SceneManager.LoadScene(0);
    }
}
