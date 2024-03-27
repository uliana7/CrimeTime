using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    
    [SerializeField] private Transform gameTransform;
    [SerializeField] private Transform piecePrefab;

    private List<Transform> pieces;
    private int emptyLocation;
    private int size;

    private void CreateGamePieces(float gapThickness) 
    {
        float width = 1 / (float)size;
        for (int row = 0; row < size; row ++){
            for (int col = 0; col < size; col ++) {
                Transform piece = Instantiate(piecePrefab, gameTransform);
                pieces.Add(piece);
                piece.localPosition = new Vector3(-1 + (2*width*col) + width,
                 +1 - (2*width*row) - width, 0);
                piece.localScale = ((2*width) - gapThickness) * Vector3.one;
                piece.name = $"{(row * size) + col}";
                if ((row == size - 1) && (col == size - 1)) {
                    emptyLocation = (size*size) - 1;
                    piece.gameObject.SetActive(false);
                } else {
                    float gap = gapThickness / 2;
                    Mesh mesh = piece.GetComponent<MeshFilter>().mesh;
                    Vector2[] uv = new Vector2[4];
                    uv[0] = new Vector2((width * col) + gap, 1 - ((width * (row + 1)) - gap));
                    uv[1] = new Vector2((width * (col + 1)) - gap, 1 - ((width * (row + 1)) - gap));
                    uv[2] = new Vector2((width * col) + gap, 1 - ((width * row) + gap));
                    uv[3] = new Vector2((width * (col + 1)) - gap, 1 - ((width * row) + gap));
                    Debug.Log("Mesh UV!!!!!!!!!!!!!!!!!");
                    mesh.uv = uv;
                }
            }
        }
    }

    void Start()
    {
        pieces = new List<Transform>();
        size = 3;
        CreateGamePieces(0.01f);
    }
    
    void Update()
    {
        if (Input.GetMouseButtonDown(0)) {
            //Debug.Log("!!!CLICK GETTED!!!");
            RaycastHit2D hit = Physics2D.Raycast(Camera.allCameras[1].ScreenToWorldPoint(Input.mousePosition), Vector2.zero);
            if (hit) {
                Debug.Log("Hit passed");
                for (int i = 0; i < pieces.Count; i++){
                    if (pieces[i] == hit.transform) {
                        //Debug.Log("Checking for swapping......");
                        if (SwapIfValid(i, -size, size)) { break; }
                        if (SwapIfValid(i, +size, size)) {  break; }
                        if (SwapIfValid(i, -1, 0)) {  break; }
                        if (SwapIfValid(i, +1, size-1)) {  break; }
                    }
                }
            }
        }
    }

    private bool SwapIfValid(int i, int offset, int colCheck)
    {
        if (((i % size) != colCheck) && ((i+offset) == emptyLocation)) {
            Debug.Log("Must be swp!!!!!!!!!!!"); 
            (pieces[i], pieces[i + offset]) = (pieces[i + offset], pieces[i]);
            (pieces[i].localPosition, pieces[i + offset].localPosition) = ((pieces[i + offset].localPosition, pieces[i].localPosition));
            emptyLocation = i;
            return true;
        }
        return false;
    }
}
