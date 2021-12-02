using System.Collections.Generic;
using RacingGame.VehicleInput;
using UnityEngine;

// Resharper disable all
namespace RacingGame.Vehicle
{

    public class VehicleController : BaseVehicle, IVehicle
    {
        [SerializeField] private InputSettings _inputSetting;
        [SerializeField] private VehicleSettings _vehicleSetting;
        [SerializeField] private List<Wheel> wheels;
        [SerializeField] private Rigidbody _rigidbody;

        private float _turnLerpTime = 0.5f;
        void Start()
        {
            _rigidbody.centerOfMass = _vehicleSetting.CenterOfMass;
        }

        void Update()
        {

            ChangeSettings();
        }

        public void WheelAnimation()
        {
            foreach (Wheel wheel in wheels)
            {
                Quaternion _rotation;
                Vector3 _position;
                wheel.collider.GetWorldPose(out _position, out _rotation);
                wheel.model.transform.position = _position;
                wheel.model.transform.rotation = _rotation;
            }
        }

        void FixedUpdate()
        {
            Move();
            WheelAnimation();
            Turn();
        }

        public void Turn()
        {
            foreach (Wheel wheel in wheels)
            {
                float _stearAngle = 0f;
                if (wheel.axel == Axel.Front)
                {
                    if (_inputSetting.Horizontal > 0)
                    {
                        if (wheel.directon == Direction.Left)
                        {
                            _stearAngle = Mathf.Rad2Deg *
                                          Mathf.Atan(2.55f / (_vehicleSetting.MaxSteerAngle + (1.5f / 2))) *
                                          _inputSetting.Horizontal;

                        }

                        if (wheel.directon == Direction.Right)
                        {
                            _stearAngle = Mathf.Rad2Deg *
                                          Mathf.Atan(2.55f / (_vehicleSetting.MaxSteerAngle - (1.5f / 2))) *
                                          _inputSetting.Horizontal;

                        }
                    }
                  else  if (_inputSetting.Horizontal < 0)
                    {
                        if (wheel.directon == Direction.Left)
                        {
                            _stearAngle = Mathf.Rad2Deg *
                                          Mathf.Atan(2.55f / (_vehicleSetting.MaxSteerAngle - (1.5f / 2))) *
                                          _inputSetting.Horizontal;

                        }

                        if (wheel.directon == Direction.Right)
                        {
                            _stearAngle = Mathf.Rad2Deg *
                                          Mathf.Atan(2.55f / (_vehicleSetting.MaxSteerAngle + (1.5f / 2))) *
                                          _inputSetting.Horizontal;

                        }
                    }
                    else
                    {
                        _stearAngle = 0f;
                    }

                    wheel.collider.steerAngle = _stearAngle;
                }
            }
        }

        public void Move()
        {
            foreach (Wheel wheel in wheels)
            {
                float totalPower = _vehicleSetting.MotorTorque * _vehicleSetting.HorsePower;
                if (_vehicleSetting.DriveType == WheelDrive.AllWheelDrive)
                {
                    totalPower /= 4;
                }
                else if ((_vehicleSetting.DriveType == WheelDrive.FrontWheelDrive && wheel.axel == Axel.Front) || (_vehicleSetting.DriveType == WheelDrive.RearWheelDrive && wheel.axel == Axel.Rear))
                {
                    totalPower /= 2;
                }
                else
                {
                    totalPower = 0;
                }
                wheel.collider.motorTorque = _inputSetting.Vertical * totalPower * Time.deltaTime;

                //if (Input.GetKey(KeyCode.Space))
                //{
                //    if (wheel.axel == Axel.Rear)
                //    {
                //        wheel.collider.brakeTorque = _vehicleSetting.BreakTorque;
                //    }
                //}
                //else
                //{
                //    wheel.collider.brakeTorque = 0;
                //}

                Debug.Log(wheel.axel + "," + "" +
                          "" + wheel.directon + ":" + wheel.collider.motorTorque);
            }


        }

        private void ChangeSettings()
        {
            _rigidbody.mass = _vehicleSetting.TotalMass;

            foreach (Wheel wheel in wheels)
            {
                var jointSpringValues = wheel.collider.suspensionSpring;
                jointSpringValues.spring = _vehicleSetting.Spring;
                jointSpringValues.damper = _vehicleSetting.Damper;
                jointSpringValues.targetPosition = _vehicleSetting.TargetPosition;

                if (_inputSetting.Horizontal > 0)
                {
                    if (wheel.directon == Direction.Left)
                    {
                        jointSpringValues.spring = _vehicleSetting.Spring / 2;
                    }
                }
                else if (_inputSetting.Horizontal < 0)
                {
                    if (wheel.directon == Direction.Right)
                    {
                        jointSpringValues.spring = _vehicleSetting.Spring / 2;
                    }
                }
                if (wheel.axel == Axel.Front)
                {
                    wheel.collider.suspensionDistance = _vehicleSetting.SuspensionDistanceFront;
                }
                else
                {
                    wheel.collider.suspensionDistance = _vehicleSetting.SuspensionDistanceRear;
                }

                wheel.collider.suspensionSpring = jointSpringValues;
            }
        }

    }
}