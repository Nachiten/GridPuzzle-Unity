using System.Collections.Generic;
using UnityEngine;

public class RightGridManager : GridManager
{
    public static RightGridManager instance;

    private Dictionary<Vector2, Tile> tiles;
    private Transform parent;
    
    private readonly Vector3 parentPosition = new(-2, -2, -2.51f);
    private readonly Quaternion parentRotation = Quaternion.Euler(0, 0, 0);

    private const string faceName = "Right";
    
    void Awake()
    {
        instance = this;
        parent = GameObject.Find("Tiles " + faceName).transform;
        tiles = new Dictionary<Vector2, Tile>();
    }

    public new void generateGrid()
    {
        generateParticularGrid(parent, parentPosition, parentRotation, ref tiles);
    }
    
    public new Tile getHeroSpawnTile()
    {
        return getHeroSpawnTile(tiles);
    }
    
    public new Tile getTileAtPosition(Vector2 pos)
    {
        return getTileAtPosition(pos, tiles);
    }

    public new Vector2 getPositionOfTile(Tile tile)
    {
        return getPositionOfTile(tile, tiles);
    }
}