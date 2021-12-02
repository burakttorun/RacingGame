using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// Resharper disable all
namespace RacingGame.VehicleInput
{
    public class InputController : MonoBehaviour
    {
        [SerializeField] private InputSettings _setting;
        // Update is called once per frame
        void Update()
        {
            _setting.Horizontal = Input.GetAxis("Horizontal");
            _setting.Vertical = Input.GetAxis("Vertical");

        }
    }
}