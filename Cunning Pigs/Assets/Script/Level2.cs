using UnityEngine;
using System.Collections;

public class Level2 : MonoBehaviour {
	private int levelWidth;
	private int levelHeight;
	
	public Transform backgroundTile;
	public Transform woodWallTile;
	public Transform riverTile;
	public Transform birdgeTile;
	
	private Color[] tileColours;
	
	public Color backgroundColour;
	public Color woodWallColour;
	public Color riverColour;
	public Color bridgeColour;
	
	public Texture2D levelTexture;

	void Start () {
		levelWidth = levelTexture.width;
		levelHeight = levelTexture.height;
		loadLevel ();
	}

	void Update () {
	}

	void loadLevel()
	{
		//set tile colours to be new color
		tileColours =  new Color[levelWidth + levelHeight];
		tileColours = levelTexture.GetPixels();
		
		for(int y = 0; y < levelHeight; y++)
		{
			for(int x = 0; x < levelWidth; x++)
			{
				if(tileColours[x+y*levelWidth] == backgroundColour)
					Instantiate(backgroundTile, new Vector3(x, y, 1), Quaternion.identity);
				if(tileColours[x+y*levelWidth] == woodWallColour)
					Instantiate(woodWallTile, new Vector3(x, y, 1), Quaternion.identity);
				if(tileColours[x+y*levelWidth] == riverColour)
					Instantiate(riverTile, new Vector3(x, y, 1), Quaternion.identity);
				if(tileColours[x+y*levelWidth] == bridgeColour)
					Instantiate(birdgeTile, new Vector3(x, y, 1), Quaternion.identity);
			}
		}
	}
}