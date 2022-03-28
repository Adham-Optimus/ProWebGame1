using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Collecteble : MonoBehaviour
{
    /*private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            var variable = other.GetComponent<PlayerCCC>();
            variable.AddCoin();
            Destroy(gameObject);
            Debug.Log("Есть пробитие");
        }
        
    }*/

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            PlayerCCC variable = other.GetComponent<PlayerCCC>();
            variable.AddCoin();
            Debug.Log("Есть пробитие");
        }
    }
}
