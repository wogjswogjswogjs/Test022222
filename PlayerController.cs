using UnityEngine;
using UnityEngine.EventSystems;


namespace _Scripts
{
    [RequireComponent((typeof(IModel)))]    
    public class PlayerController : MonoBehaviour
    {
        private static IModel _playerModel;
        private InputManager _inputManager;

        public void Init(IModel model, InputManager inputManager)
        {
            _playerModel = model;
            _inputManager = inputManager;

            _playerModel.Initialized(10);
            
            _inputManager.OnInputKeyHandler += OnInputKey;
        }

        private static void OnInputKey(Vector3 dir)
        {
            Debug.Log("test1");
        }
    }
}