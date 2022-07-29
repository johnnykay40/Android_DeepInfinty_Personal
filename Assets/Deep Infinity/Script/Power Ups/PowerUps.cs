using System;
using UnityEngine;

public class PowerUps : MonoBehaviour
{
    internal static event Action<SOPlayerMovement> OnSpeedPower;
    [SerializeField] internal SOPlayerMovement sOPlayerMovement;

    [SerializeField] internal PowerUpSO UpSO;

    
    public enum TypePowerUp
    {
        speed, health, rockets, bullets
    }

    public TypePowerUp typePowerUp;
    private void OnTriggerEnter(Collider other)
    {        
        switch (typePowerUp)
        {
            case TypePowerUp.speed:
                OnSpeedPower?.Invoke(sOPlayerMovement);
                break;
            case TypePowerUp.health:
                break;
            case TypePowerUp.rockets:
                break;
            case TypePowerUp.bullets:
                break;            
        }

        Destroy(gameObject);
    }    
}
