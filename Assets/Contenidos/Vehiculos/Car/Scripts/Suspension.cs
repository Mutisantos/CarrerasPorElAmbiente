using System;
using UnityEngine;

namespace UnityStandardAssets.Vehicles.Car
{
    // Control de Suspension de las llantas frontales
    // Esto para para mover las llantas cuando se encuentren con baches o sobresaltos
    // Evitando que quede bloqueado para no subirlo 

    public class Suspension : MonoBehaviour
    {
        public GameObject wheel; // Referencia a la llanta de la suspensión


        private Vector3 m_TargetOriginalPosition;
        private Vector3 m_Origin;


        private void Start()
        {
            m_TargetOriginalPosition = wheel.transform.localPosition;
            m_Origin = transform.localPosition;
        }


        private void Update()
        {
            //print(transform.localPosition + "Origen");
            transform.localPosition = m_Origin + (wheel.transform.localPosition - m_TargetOriginalPosition);
        }
    }
}
