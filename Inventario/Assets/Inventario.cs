using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Inventario : MonoBehaviour
{
    public GameObject mouseItem;

    public void ArrastarItem(GameObject button)
    {
        mouseItem = button;
        mouseItem.transform.position = Input.mousePosition;
    }

    public void DropItem(GameObject button)
    {
        if (mouseItem != null)
        {
            Transform aux = mouseItem.transform.parent;
            mouseItem.transform.SetParent(button.transform.parent);
            button.transform.SetParent(aux);
        }
    }
}
