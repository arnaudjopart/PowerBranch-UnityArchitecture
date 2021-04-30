using UnityEngine;

namespace _Project.Scripts
{
    public class SelectionDetector_NoSolid : MonoBehaviour
    {
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
            transform.localScale *= 1.5f;
        }
        
        private void OnMouseExit()
        {
            print("OnMouseExit");
            transform.localScale = Vector3.one;
        }
    }
}
