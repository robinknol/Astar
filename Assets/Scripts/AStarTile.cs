using System.Collections.Generic;
using Pathing;
using UnityEngine;
using UnityEngine.Tilemaps;

[CreateAssetMenu]
public class AStarTile : Tile, IAStarNode
{
    public int cost;
    private int _currentCost = 0;
    
    public IEnumerable<IAStarNode> Neighbours
    {
        get;
    }
    
    
    /// <summary>
    /// I want to check the 3 tiles that point to the end goal of my neighbour's and see thier cost and add it to my currentcost
    /// then I want to compare all of the results and continue from the lowest cost close to the goal tile
    /// </summary>
    public float CostTo(IAStarNode neighbour)
    {
        Debug.Log("CostTo");
        return 0;
    }
    
    /// <summary>
    /// I want to get the goal and create a direct path between the start and the goal
    /// The plan make a line between the start and the goal and get the cost along the way and add them all up
    /// The problem I can't seem to get the cost value from the IAStarNode as it is in AStarTile
    /// 
    /// </summary>
    public float EstimatedCostTo(IAStarNode goal)
    {
        Debug.Log("estimatedCostTo");
        return 0;
    }
}