using UnityEngine;


[CreateAssetMenu(menuName = "SO Deep Infinity / #name_PowerUp")]
public class PowerUpSO : ScriptableObject
{
    [SerializeField] internal float amount;

    private void OnEnable()
    {
        PowerUps.OnSpeedPower += SpeedPower;
    }

    private void SpeedPower(SOPlayerMovement speedPower)
    {
        speedPower.speedPlayer += amount;        
    }

    private void OnDisable()
    {
        PowerUps.OnSpeedPower -= SpeedPower;
    }
}
