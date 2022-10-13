using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Selectable : MonoBehaviour
{
    public void Select()
    {
        GetComponent<Renderer>().material.color = Color.red;
    }

    public void DeSelect()
    {
        GetComponent<Renderer>().material.color = Color.grey;
    }
}
