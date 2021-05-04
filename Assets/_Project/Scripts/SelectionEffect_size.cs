using UnityEngine;

namespace _Project.Scripts
{
    public class SelectionEffect_size : MonoBehaviour, ISelectionEffect
    {
        public void Select()
        {
            transform.localScale *= 1.5f;
        }
        
        public void Deselect()
        {
            transform.localScale = Vector3.one;
        }
    }
}