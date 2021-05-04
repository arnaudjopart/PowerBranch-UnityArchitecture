using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public interface ISelectionEffect
{
    void Select();
    void Deselect();
}

public class SelectionEffect_Color : MonoBehaviour, ISelectionEffect
{
    public void Select()
    {
        GetComponent<MeshRenderer>().material.color = Color.blue;
    }
        
    public void Deselect()
    {
        GetComponent<MeshRenderer>().material.color = Color.green;
    }
}
