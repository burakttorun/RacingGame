using UnityEngine;

// Resharper disable all
namespace RacingGame.Vehicle
{
    public enum WheelDrive
    {
        FrontWheelDrive,
        RearWheelDrive,
        AllWheelDrive,
    }

    [CreateAssetMenu(menuName = "Racing Game/Vehicle/Vehicle Settings")]
    public class VehicleSettings : ScriptableObject
    {

        [Header("Motor Power")]
        [SerializeField] private float _motorTorque = 100f;
        public float MotorTorque
        {
            get { return _motorTorque; }
        }
        [SerializeField] private float _horsePower = 500f;
        public float HorsePower
        {
            get { return _horsePower; }
        }

        [Header("Steering Box")]
        [SerializeField] private float _maxSteerAngle = 6f;
        public float MaxSteerAngle
        {
            get { return _maxSteerAngle; }
        }
        [SerializeField] private float _turnSensitivity = 1.0f;
        public float TurnSensitivity
        {
            get { return _turnSensitivity; }
        }

        [Header("Body Settings")]
        [SerializeField] private Vector3 _centerOfMass;
        public Vector3 CenterOfMass
        {
            get { return _centerOfMass; }
        }
        [SerializeField] private float _totalMass = 1500f;
        public float TotalMass
        {
            get { return _totalMass; }
        }

        [SerializeField] private WheelDrive _driveType = WheelDrive.AllWheelDrive;
        public WheelDrive DriveType
        {
            get { return _driveType; }
        }

        [Header("Break Power")]
        [SerializeField] private float _breakTorque = 2000f;
        public float BreakTorque
        {
            get { return _breakTorque; }
        }

        [Header("Wheel Settings")]

        [Header("Suspension Spring")]
        //Süspansiyon yayýnýn sertliði
        [SerializeField] private float _spring = 100000f;
        public float Spring
        {
            get { return _spring; }
        }
        [SerializeField] private float _suspensionDistanceFront = 0.11f;
        public float SuspensionDistanceFront
        {
            get { return _suspensionDistanceFront; }
        }
        [SerializeField] private float _suspensionDistanceRear = 0.13f;
        public float SuspensionDistanceRear
        {
            get { return _suspensionDistanceRear; }
        }
        //Süspansiyon yayýnýn yayda depolanan enerjiyi daðýtma hýzý
        [SerializeField] private float _damper = 2000f;
        public float Damper
        {
            get { return _damper; }
        }
        //Süspansiyon yayýnýn kullaným açýklýðý
        [Range(0.0f, 1.0f)]
        [SerializeField] private float _targetPosition = 0.5f;
        public float TargetPosition
        {
            get { return _targetPosition; }
        }

        [Header("Forward Friction")]
        //Ýleri doðru maksimum kayma miktarý
        [Range(0.2f, 2.0f)]
        [SerializeField] private float _extremumSlipFw = 0.4f;
        public float ExtremumSlipFw
        {
            get { return _extremumSlipFw; }
        }
        //Tekerleðe uygulanmasý gereken maksimum sürtünme miktarý
        [SerializeField] private float _extremumValueFw = 1;
        public float ExtremumValueFw
        {
            get { return _extremumValueFw; }
        }
        //Drift için
        [Range(0.5f, 2.0f)]
        [SerializeField] private float _asymptoteSlipFw = 0.8f;
        public float AsymptoteSlipFw
        {
            get { return _asymptoteSlipFw; }
        }
        //Drift için deðeri düþür 
        [SerializeField] private float _asymptoteValueFw = 0.5f;
        public float AsymptoteValueFw
        {
            get { return _asymptoteValueFw; }
        }
        //Zeminlerin sürtünme sertliði
        [SerializeField] private float _stiffnessFw = 1f;
        public float StiffnessFw
        {
            get { return _stiffnessFw; }
        }

        [Header("Sideway Friction")]
        //Ýleri doðru maksimum kayma miktarý
        [Range(0.2f, 2.0f)]
        [SerializeField] private float _extremumSlipSw = 0.4f;
        public float ExtremumSlipSw
        {
            get { return _extremumSlipSw; }
        }
        //Tekerleðe uygulanmasý gereken maksimum sürtünme miktarý
        [SerializeField] private float _extremumValueSw = 1;
        public float ExtremumValueSw
        {
            get { return _extremumValueSw; }
        }
        //Drift için
        [Range(0.5f, 2.0f)]
        [SerializeField] private float _asymptoteSlipSw = 0.8f;
        public float AsymptoteSlipSw
        {
            get { return _asymptoteSlipSw; }
        }
        //Drift için deðeri düþür 
        [SerializeField] private float _asymptoteValueSw = 0.5f;
        public float AsymptoteValueSw
        {
            get { return _asymptoteValueSw; }
        }
        //Zeminlerin sürtünme sertliði
        [SerializeField] private float _stiffnessSw = 1f;
        public float StiffnessSw
        {
            get { return _stiffnessSw; }
        }
    }
}