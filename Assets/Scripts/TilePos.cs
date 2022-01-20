using UnityEngine;
using UnityEngine.Tilemaps;

public class TilePos : MonoBehaviour
{
    private void Start()
    {
        var tilemap = GetComponent<Tilemap>();

        var bounds = tilemap.cellBounds;
        var allTiles = tilemap.GetTilesBlock(bounds);

        for (var x = 0; x < bounds.size.x; x++)
        {
            for (var y = 0; y < bounds.size.y; y++)
            {
                var tile = allTiles[x + y * bounds.size.x];
                if (tile != null)
                {
                    Debug.Log("x:" + x + " - y:" + y + ": tile:" + tile.name);
                }
                else
                {
                    Debug.Log("x:" + x + " - y:" + y + ": tile: null");
                }
            }
        }        

    }
}