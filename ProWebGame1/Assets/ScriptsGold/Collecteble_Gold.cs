using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Collecteble_Gold : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            PlayerCCC_Gold variable = other.GetComponent<PlayerCCC_Gold>();
            variable.AddCoin();
            Debug.Log("Есть пробитие");
            Destroy(gameObject);
        }
    }
}
