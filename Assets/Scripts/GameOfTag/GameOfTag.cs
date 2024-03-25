using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class GameOfTag : MonoBehaviour
{
    public PicturePartBox boxPrefab;
    public PicturePartBox[,] boxes = new PicturePartBox[3, 3];
    public Sprite[] sprites;

    // Start is called before the first frame update
    void Start()
    {
        Init();   
    }

    void Init()
    {
        int n = 0;
        for (int y=2; y >= 0; y--) 
        {
            for (int x=0; x < 3; x ++)
            {
                PicturePartBox box = Instantiate(boxPrefab, new Vector2(x, y), Quaternion.identity);
                box.Init(x, y, n+1, sprites[n]);
                boxes[x, y] = box;
                n++;
            }
        }
    }
}
