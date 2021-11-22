using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Inventario : MonoBehaviour
{
    public bool isActive;

    //public Player player;
    public Transform hand;

    /// <summary>
    /// ////////
    /// </summary>
    public int distance;
    public int idx = 0;
    public Transform inventario; // EL MISMO
    public GameObject canvas;
    public Transform camara_inventario;
    public Transform[] items; // TODOS LOS OBJETOS EN EL INVENTARIO CON EL INVENTARIO
    private int contador;

    public int itemsQty; // CANTIDAD DE HIJOS EN EL INVENTARIO

    public List<Transform> new_items;// TODOS LOS OBJETOS EN EL INVENTARIO SIN EL INVENTARIO

    // Start is called before the first frame update
    void Start()
    {
        inventario = this.transform;
        itemsQty = inventario.childCount;
        this.gameObject.GetComponent<Animator>().SetBool("abreInventario", false);
       
        //hand = player.hand;
    }

    // Update is called once per frame
    void Update()
    {
        

        if (Input.GetKeyDown(KeyCode.Z))
        {


            this.gameObject.GetComponent<Animator>().SetBool("abreInventario", !this.gameObject.GetComponent<Animator>().GetBool("abreInventario"));
           


        }


        SelfUpdate();


        if (this.gameObject.GetComponent<Animator>().GetBool("abreInventario") == true)
       
        {

            if (Input.GetKeyDown(KeyCode.Q))
            {
                idx--;
                if (idx < 0)
                {
                    idx = 0;
                }
                camara_inventario.localPosition = new Vector3(idx * distance, 0, camara_inventario.localPosition.z);
            }
            if (Input.GetKeyDown(KeyCode.E))
            {
                idx++;
                if (idx >= new_items.Count)
                {
                    idx = new_items.Count - 1;
                }
                camara_inventario.localPosition = new Vector3(idx * distance, 0, camara_inventario.localPosition.z);
            }

           


        }

    }

    /* void Equipar()
    {
        if (player.objInHand != null) // si tiene algo en la mano
        {
            player.objInHand.SetParent(inventario);
            itemsQty = inventario.childCount; // DEFINIMOS LA CANTIDAD DE HIJOS
            new_items[idx].SetParent(hand);
            new_items[idx].localPosition = new Vector3(0, 0, 0);

        }
        else
        {
            new_items[idx].SetParent(hand);
            new_items[idx].localPosition = new Vector3(0, 0, 0);
        }
        Toggle_Inv();
     */




  

    void SelfUpdate()
    {
        if (inventario.childCount != itemsQty) // SI LA CANTIDAD DE HIJOS ES DIFERENTE CON RESPECTO A UN PUNTO ANTERIOR
        {
            new_items = new List<Transform>(); // LIMPIAMOS LA LISTA DE ITEMS

            itemsQty = inventario.childCount; // DEFINIMOS LA CANTIDAD DE HIJOS

            items = inventario.GetComponentsInChildren<Transform>(); // OBTENEMOS TODOS LOS HIJOS + INVENTARIO
            foreach (var item in items) // CON ESTA INSTRUCCION RECORREMOS TODOS LOS HIJOS
            {
                if (item != inventario && item != camara_inventario)// FILTRAMOS EL INVENTARIO
                {
                    new_items.Add(item);
                }
            }
            Arrange(new_items);
        }
    }
    void Arrange(List<Transform> items)
    {
        var length = items.Count;//esto nos dice cuantos objetos hay en la lista

        for (int i = 0; i < length; i++)
        {
            items[i].localPosition = new Vector3(0, i * distance, -10);
            items[i].localRotation = Quaternion.Euler(0, 0, 0);

        }
    }

}