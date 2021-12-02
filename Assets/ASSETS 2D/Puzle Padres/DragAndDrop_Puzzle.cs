using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Rendering; // Para que sirva el SortingGroup, tienes que llamarlo

public class DragAndDrop_Puzzle : MonoBehaviour
{
    public Transform obj; // Objeto
    RaycastHit hit; // Nombre de la variable del objeto con el que choc�
    Vector3 mPos; // Determina la posici�n dentro del canvas
    Ray ray; // Nombre rayo

    int orderLayer;

    public PiezaPuzlePadres piezas;


    void Start()
    {
        
    }


    void Update()
    {
        ray = Camera.main.ScreenPointToRay(Input.mousePosition);  // Crea un rayo a partir de la posici�n del mouse en la pantalla
        if (Physics.Raycast(ray, out hit))
        {
            MoveObj(); // Ejecuta Mover Objeto
        }

        //Debug.Log(ray);
    }

    private void MoveObj() //Void Mover Objeto
    {
        mPos = hit.point; // La posici�n del mouse es igual al punto donde pega el ray

        if (Input.GetMouseButtonDown(0)) // Si se presiona el bot�n del mouse
        {
            if (hit.transform.CompareTag("PuzzlePadres"))  // Si tiene el tag igual a "PuzzlePadres"
            {
                
                if (!hit.transform.GetComponent<PiezaPuzlePadres>().inPlace) //Si el rayo est� en la posici�n correcta, entonces...
                {
                    obj = hit.transform; // La posici�n del objeto se transforma a donde pegue el rayo
                    obj.GetComponent<SortingGroup>().sortingOrder = orderLayer;  // orderLayer se obtiene accediendo al SortingGroup del objeto seleccionado
                    orderLayer++; //Se a�ade una layer m�s al objeto seleccionado, sirve para que la pieza seleccionada se vea ALFRENTE y no se esconda entre las dem�s
                }
            }
        }

        if (Input.GetMouseButtonUp(0)) // Si se levanta el bot�n
        {
            if (obj != null)
            {
                obj = null; // El objeto se transforma en nulo


            }
        }

        if (obj != null) // Si el objeto es nulo
        {
            obj.position = new Vector3(mPos.x, mPos.y, obj.position.z); // Se crea un nuevo vector3 a partir de la posici�n del mouse

        }

    }

}
