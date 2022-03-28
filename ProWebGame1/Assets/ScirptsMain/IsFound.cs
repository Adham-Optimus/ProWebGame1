using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IsFound : MonoBehaviour
{
    EnemyAI enemyAI;
    Light light;
    Material material;
    void Start()
    {
        enemyAI = GetComponent<EnemyAI>();
        material = GetComponent<Renderer>().material;
        light = GetComponentInChildren<Light>();
    }
    void Update()
    {
        if(enemyAI.playerInView)
        {
            light.intensity = 5f;
            light.color = Color.yellow;
            material.color = Color.red;
        }
        else if (!enemyAI.playerInView)
        {
            light.intensity = 3f;
            light.color = Color.green;
            material.color = Color.green;
        }
    }
}
