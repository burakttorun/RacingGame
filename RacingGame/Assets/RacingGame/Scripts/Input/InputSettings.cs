using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//Resharper disable all
namespace RacingGame.VehicleInput
{
    [CreateAssetMenu(menuName = "Racing Game/Input/Input Settings")]
    public class InputSettings : ScriptableObject
    {
        [Header("Horizontal")]
        [SerializeField] private float _horizontal;
        public float Horizontal
        {
            get { return _horizontal;}
            set { _horizontal = value; }
        }

        [Header("Vertical")]
        [SerializeField] private float _vertical;
        public float Vertical
        {
            get { return _vertical; }
            set { _vertical = value; }
        }
       
    }

}
