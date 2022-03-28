using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChunkPlacer : MonoBehaviour
{
    public Transform player;
    public Chunk[] ChunkPrefabs;
    public Chunk firstChunk;

    private List<Chunk> spawnedChunks = new List<Chunk>();

    private void Start()
    {
        spawnedChunks.Add(firstChunk);
    }

    private void FixedUpdate()
    {
        if (player.position.z >= spawnedChunks[spawnedChunks.Count - 1].End.position.z - 100)
        {
            SpawnChunk();
        }
    }

    private void SpawnChunk()
    {
        Chunk newroad = Instantiate(ChunkPrefabs[Random.Range(0, ChunkPrefabs.Length)]);
        Vector3 temp = spawnedChunks[spawnedChunks.Count - 1].End.position;
        temp.z += newroad.transform.localScale.z / 2;
        newroad.transform.position = temp;
        spawnedChunks.Add(newroad);

        if (spawnedChunks.Count >= 10)
        {
            Destroy(spawnedChunks[0].gameObject);
            spawnedChunks.RemoveAt(0);
        }
    }

    
}
