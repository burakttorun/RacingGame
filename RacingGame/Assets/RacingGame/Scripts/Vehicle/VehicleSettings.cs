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
        //S�spansiyon yay�n�n sertli�i
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
        //S�spansiyon yay�n�n yayda depolanan enerjiyi da��tma h�z�
        [SerializeField] private float _damper = 2000f;
        public float Damper
        {
            get { return _damper; }
        }
        //S�spansiyon yay�n�n kullan�m a��kl���
        [Range(0.0f, 1.0f)]
        [SerializeField] private float _targetPosition = 0.5f;
        public float TargetPosition
        {
            get { return _targetPosition; }
        }

        [Header("Forward Friction")]
        //�leri do�ru maksimum kayma miktar�
        [Range(0.2f, 2.0f)]
        [SerializeField] private float _extremumSlipFw = 0.4f;
        public float ExtremumSlipFw
        {
            get { return _extremumSlipFw; }
        }
        //Tekerle�e uygulanmas� gereken maksimum s�rt�nme miktar�
        [SerializeField] private float _extremumValueFw = 1;
        public float ExtremumValueFw
        {
            get { return _extremumValueFw; }
        }
        //Drift i�in
        [Range(0.5f, 2.0f)]
        [SerializeField] private float _asymptoteSlipFw = 0.8f;
        public float AsymptoteSlipFw
        {
            get { return _asymptoteSlipFw; }
        }
        //Drift i�in de�eri d���r 
        [SerializeField] private float _asymptoteValueFw = 0.5f;
        public float AsymptoteValueFw
        {
            get { return _asymptoteValueFw; }
        }
        //Zeminlerin s�rt�nme sertli�i
        [SerializeField] private float _stiffnessFw = 1f;
        public float StiffnessFw
        {
            get { return _stiffnessFw; }
        }

        [Header("Sideway Friction")]
        //�leri do�ru maksimum kayma miktar�
        [Range(0.2f, 2.0f)]
        [SerializeField] private float _extremumSlipSw = 0.4f;
        public float ExtremumSlipSw
        {
            get { return _extremumSlipSw; }
        }
        //Tekerle�e uygulanmas� gereken maksimum s�rt�nme miktar�
        [SerializeField] private float _extremumValueSw = 1;
        public float ExtremumValueSw
        {
            get { return _extremumValueSw; }
        }
        //Drift i�in
        [Range(0.5f, 2.0f)]
        [SerializeField] private float _asymptoteSlipSw = 0.8f;
        public float AsymptoteSlipSw
        {
            get { return _asymptoteSlipSw; }
        }
        //Drift i�in de�eri d���r 
        [SerializeField] private float _asymptoteValueSw = 0.5f;
        public float AsymptoteValueSw
        {
            get { return _asymptoteValueSw; }
        }
        //Zeminlerin s�rt�nme sertli�i
        [SerializeField] private float _stiffnessSw = 1f;
        public float StiffnessSw
        {
            get { return _stiffnessSw; }
        }
    }
}