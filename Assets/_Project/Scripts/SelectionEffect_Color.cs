using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public interface ISelectionEffect
{
    void Select(Transform _transform);
    void Deselect(Transform _transform);
}

public class SelectionEffect_Color : ISelectionEffect
{
    public void Select(Transform _transform)
    {
        _transform.GetComponent<MeshRenderer>().material.color = Color.blue;
    }
        
    public void Deselect(Transform _transform)
    {
        _transform.GetComponent<MeshRenderer>().material.color = Color.green;
    }
}
