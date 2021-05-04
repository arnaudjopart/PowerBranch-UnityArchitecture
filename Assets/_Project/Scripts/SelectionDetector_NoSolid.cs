using System;
using UnityEngine;
using Zenject;

namespace _Project.Scripts
{
    public class SelectionDetector_NoSolid : MonoBehaviour
    {

        private ISelectionEffect m_selectionEffectSize;
        public bool m_isColor;

        [Inject]
        public void Init(ISelectionEffect _effect)
        {
            m_selectionEffectSize = _effect;
        }

        

        // Update is called once per frame
        void Update()
        {
        
        }

        private void OnMouseEnter()
        {
            print("OnMouseEnter");
            m_selectionEffectSize.Select(transform);
            
        }

        private void OnMouseExit()
        {
            print("OnMouseExit");
            m_selectionEffectSize.Deselect(transform);
            
        }

        
    }
}
