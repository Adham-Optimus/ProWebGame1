using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class canDie_Gold : MonoBehaviour
{
    Animator anim;
    void Start()
    {
        anim = GetComponent<Animator>();
    }

    private void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.GetComponent<EnemyAI>())
        {
            anim.SetBool("Die", true);

            GetComponent<PlayerCCC_Gold>().GameOver();
        }
    }
}
