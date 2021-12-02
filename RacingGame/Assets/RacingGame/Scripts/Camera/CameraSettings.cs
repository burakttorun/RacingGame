using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//Resharper disable all
namespace RacingGame.Camera
{
    [CreateAssetMenu(menuName = "Racing Game/Camera/Camera Settings")]
    public class CameraSettings : ScriptableObject
    {
        [Header("Rotation")]
        [SerializeField] private float _rotationLerpSpeed = 1;
        public float RotationLerpSpeed { get { return _rotationLerpSpeed; } }

        [Header("Position")]
        [SerializeField] private Vector3 _positionOffset;
        public Vector3 PositionOffset { get { return _positionOffset; } }

        [SerializeField] private float _positionLerpSpeed = 1;
        public float PositionLerpSpeed { get { return _positionLerpSpeed; } }
    }
}