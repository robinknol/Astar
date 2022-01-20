using System.Collections.Generic;
using Pathing;
using UnityEngine.Tilemaps;

public class AStarTile : Tile, IAStarNode
{
    public int Cost;
    public IEnumerable<IAStarNode> Neighbours { get; }
    public float CostTo(IAStarNode neighbour)
    {
        throw new System.NotImplementedException();
    }

    public float EstimatedCostTo(IAStarNode goal)
    {
        throw new System.NotImplementedException();
    }
}