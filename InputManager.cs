using System;
using UnityEngine;

namespace _Scripts
{
    public class InputManager : MonoBehaviour
    {

        public delegate void OnInputKey(Vector3 dir);

        public event OnInputKey OnInputKeyHandler;
        private void Update()
        {
            if (Input.GetKey(KeyCode.A))
            {
                OnInputKeyHandler?.Invoke(Vector3.forward);
            }
        }
    }
}