using System;
using TMPro;
using UnityEngine;

namespace _Scripts.Manager_Scripts
{
    public class UIManager : MonoBehaviour
    {
        [SerializeField] private Vehicle _vehicle;
        [SerializeField] private TextMeshProUGUI _speedIndicator;

        private int _vehicleSpeed;
        private void Update()
        {
            Speed_Indicator(_vehicleSpeed);
            SetSpeed(_vehicle.velocity * 3.6f);
        }

        private void SetSpeed(float currentSpeed) => _vehicleSpeed = Mathf.RoundToInt(currentSpeed);
        private void Speed_Indicator( int speed) => _speedIndicator.text = speed + " KM";
    }
}
