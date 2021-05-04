using System;
using UnityEngine;

namespace _Project.Scripts
{
    public class SelectionDetector_NoSolid : MonoBehaviour
    {
        private ISelectionEffect m_selectionEffectSize;

        private void Awake()
        {
            m_selectionEffectSize = GetComponent<ISelectionEffect>();
        }

        // Start is called before the first frame update
        void Start()
        {
        
        }

        // Update is called once per frame
        void Update()
        {
        
        }

        private void OnMouseEnter()
        {
            print("OnMouseEnter");
            m_selectionEffectSize.Select();
            
        }

        private void OnMouseExit()
        {
            print("OnMouseExit");
            m_selectionEffectSize.Deselect();
            
        }

        
    }
}
