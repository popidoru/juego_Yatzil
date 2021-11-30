using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DragAndDrop_Puzzle : MonoBehaviour
{
    public GameObject SelectedPiece;  // Pieza que está siendo seleccionada

    
    void Start()
    {
        
    }

    
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            RaycastHit2D hit = Physics2D.Raycast(Camera.main.ScreenToWorldPoint(Input.mousePosition), Vector2.zero);

            if (hit.transform.CompareTag("PuzzlePadres"))
            {
                SelectedPiece = hit.transform.gameObject;
            }
        }

        if(SelectedPiece != null)
        {
            Vector3 MousePoint = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            SelectedPiece.transform.position = new Vector3(MousePoint.x, MousePoint.y, 0);
        }
    }

}
