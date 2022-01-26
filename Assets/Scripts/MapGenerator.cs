using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Tilemaps;

public class MapGenerator : MonoBehaviour
{
    private Tile[] _pallets;
    private Tilemap _tilemap;
        
    [SerializeField] private Vector2Int size;
        
    private void Awake()
    {
        _pallets = Resources.LoadAll<Tile>("Palettes");
        _tilemap = GetComponent<Tilemap>();

        GenerateMap();
    }

    private void GenerateMap()
    {
        _tilemap.ClearAllTiles();

        var positions = new Vector3Int[size.x * size.y];

        for (var i = 0; i < positions.Length; i++)
        {
            positions[i] = new Vector3Int(i % size.x, i / size.y, 0);
            var tileName = _pallets[Random.Range(0, _pallets.Length)];
            tileName.color = Color.white;
            _tilemap.SetTile(positions[i], tileName);
        }
    }
}