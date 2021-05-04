using UnityEngine;

namespace _Project.Scripts
{
    public class SelectionEffect_size : ISelectionEffect
    {
        public void Select(Transform _transform)
        {
            _transform.localScale *= 1.5f;
        }
        
        public void Deselect(Transform _transform)
        {
            _transform.localScale = Vector3.one;
        }
    }
}