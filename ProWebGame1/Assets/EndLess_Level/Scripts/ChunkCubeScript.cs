using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChunkCubeScript : MonoBehaviour
{
    [HideInInspector]
    public float speed = 3f;
    Transform player;
    public Transform cube;
    bool spawn = true;

    private void Start()
    {
        player = FindObjectOfType<PlayerC_EndLess>().transform;
        Transform temp = Instantiate(cube);
        temp.parent = this.gameObject.transform;
        temp.localPosition = new Vector3(Random.RandomRange(-0.3f, 0.3f), -0.5f, -0.5f);

        temp = Instantiate(cube);
        temp.parent = this.gameObject.transform;
        temp.localPosition = new Vector3(Random.RandomRange(-0.3f, 0.3f), -0.5f, 0);


    }
    void Update()
    {
        //if (spawn) StartCoroutine(SpawnCube());
    }

    /*private IEnumerator SpawnCube()
    {
        spawn = false;
        Transform temp = Instantiate(cube);
        temp.localPosition = new Vector3(Random.RandomRange(-11, 3), 1.45f, -0.5f);
        temp.parent = this.gameObject.transform;
        yield return new WaitForSeconds(0.5f / 1.5f);
        //spawn = true;

        spawn = false;
        Transform temp1 = Instantiate(cube);
        temp1.localPosition = new Vector3(Random.RandomRange(-11, 3), 1.45f, 0);
        temp1.parent = this.gameObject.transform;
        yield return new WaitForSeconds(0.5f / 1.5f);
        spawn = true;

        spawn = false;
    }*/
}
