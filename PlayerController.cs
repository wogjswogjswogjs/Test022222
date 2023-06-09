﻿using UnityEngine;
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
            Debug.Log("test2");
            Debug.Log("test3");
            Debug.Log("test4");
            Debug.Log("test5");
            Debug.Log("test6");
            Debug.Log("test7");
            Debug.Log("test8");

            Debug.Log("test9");
            Debug.Log("test10");
            
            Debug.Log("test11");
            Debug.Log("test12");

        }
    }
}