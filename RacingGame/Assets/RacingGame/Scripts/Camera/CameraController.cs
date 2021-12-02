using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//Resharper disable all
namespace RacingGame.Camera
{
    public class CameraController : MonoBehaviour
    {
        [SerializeField] private GameObject _camera;
        [SerializeField] private GameObject _target;
        [SerializeField] private GameObject _child;
        [SerializeField] private CameraSettings _settings;

        void Start()
        {
            _child = _target.transform.Find("camera constraint").gameObject;
        }

        void FixedUpdate()
        {
            CameraMovement();
            CameraRotation();
        }

        private void CameraMovement()
        {
            _camera.transform.position = Vector3.Lerp(_camera.transform.position,
                (_child.transform.position + _settings.PositionOffset), Time.deltaTime * _settings.PositionLerpSpeed);
        }
        private void CameraRotation()
        {
            _camera.transform.LookAt(_target.transform.position);
        }

    }
}