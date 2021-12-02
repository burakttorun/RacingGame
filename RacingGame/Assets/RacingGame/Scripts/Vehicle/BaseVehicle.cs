using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// Resharper disable all
namespace RacingGame.Vehicle
{
    public class BaseVehicle : MonoBehaviour 
    {
        public enum Axel
        {
            Front,
            Rear
        } 
        public enum Direction
        {
            Left,
            Right
        }
        [Serializable]
        public struct Wheel
        {
            public GameObject model;
            public WheelCollider collider;
            public Axel axel;
            public Direction directon;

        }

    }

}