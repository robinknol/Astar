using Pathing;
using UnityEngine;
using UnityEngine.Tilemaps;

public class MouseClick : MonoBehaviour
{
        private Tilemap _tilemap;
        private AStarTile _startingTile;
        private AStarTile _endingTile;
        private Vector3Int _startingTileVec;
        private Vector3Int _endingTileVec;
        
        private void Start()
        { 
                _tilemap = GetComponent<Tilemap>();
        }

        private void Update()
        {
                if (Input.GetKey(KeyCode.Space))
                {
                        AStar.GetPath(_startingTile, _endingTile);
                        return;
                }
                
                if (Input.GetMouseButton(0))
                {
                        if (_startingTile != null)
                        {
                                _startingTile.color = Color.white;
                                _tilemap.SetTile(_startingTileVec, null);
                                _tilemap.SetTile(_startingTileVec, _startingTile);
                        }
                        GetTileName(true);
                        _tilemap.SetTile(_startingTileVec, null);
                        _tilemap.SetTile(_startingTileVec, _startingTile);
                        return;
                }

                if (!Input.GetMouseButton(1)) return;
                
                if (_endingTile != null)
                {
                        _endingTile.color = Color.white;
                        _tilemap.SetTile(_endingTileVec, null);
                        _tilemap.SetTile(_endingTileVec, _endingTile);
                }

                GetTileName(false);
                _tilemap.SetTile(_endingTileVec, null);
                _tilemap.SetTile(_endingTileVec, _endingTile);
        }

        private void GetTileName(bool leftClick)
        {
                var mpos = Input.mousePosition;
                
                var ray = Camera.main.ScreenPointToRay(mpos);
                
                var plane = new Plane(Vector3.back, Vector3.zero); 
                plane.Raycast(ray, out var hitDist);
                
                var pos = ray.GetPoint(hitDist);
                var tPos = _tilemap.WorldToCell(pos);
                
                var tile = _tilemap.GetTile<Tile>(tPos);

                if (leftClick)
                {
                        _startingTileVec = tPos;
                        _startingTile = (AStarTile) tile;
                        _startingTile.color = Color.green;
                        Debug.Log(_startingTileVec + " = " + _startingTile.name);
                        return;
                }
                
                _endingTileVec = tPos;
                _endingTile = (AStarTile) tile;
                _endingTile.color = Color.blue;
                Debug.Log(_endingTileVec + " = " + _endingTile.name);
        }
}