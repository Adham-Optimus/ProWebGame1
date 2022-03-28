using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Chunk : MonoBehaviour
{
    public Transform Begin;
    public Transform End;
    ChunkCubeScript chunkCubeScript;
    private void Start()
    {
        chunkCubeScript = GetComponent<ChunkCubeScript>();
    }
    private void FixedUpdate()
    {
        transform.position -= new Vector3(0,0,15*Time.deltaTime* 1.5f);
        
    }
}
