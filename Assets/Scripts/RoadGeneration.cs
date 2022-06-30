using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RoadGeneration : MonoBehaviour
{
    public GameObject[] tiles;
    public List<GameObject> activeTiles = new List<GameObject>();
    private float tileLength = 500; 
    private float spawnX = 0;
    private int startTiles = 2;

    [SerializeField] private Transform player;
    void Start()
    {
        Time.timeScale = 0f;
        for (int i = 0; i < startTiles; i++)
        {
            SpawnTiles(Random.Range(0, tiles.Length));
        }
    }
    
    void Update()
    {
        if (player.position.x + 350 < -1 * (spawnX - startTiles * tileLength))
        {
            SpawnTiles(Random.Range(0, tiles.Length));
            DeleteTile();
        }
    }

    private void SpawnTiles(int tilesIndex)
    {
        GameObject newTile = Instantiate(tiles[tilesIndex], spawnX * new Vector3(-1, 0, 0), transform.rotation);
        activeTiles.Add(newTile);
        spawnX += tileLength;
    }

    private void DeleteTile()
    {
        Destroy(activeTiles[0]);
        activeTiles.Remove(activeTiles[0]);
    }
    
}
