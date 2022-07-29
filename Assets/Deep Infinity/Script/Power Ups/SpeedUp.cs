using UnityEngine;

[CreateAssetMenu(menuName = "SO Deep Infinity / PowerUpEffect/SpeedUp")]

public class SpeedUp : PowerUpEffect
{

    [SerializeField] private float amount;
    [SerializeField] internal override void Apply(GameObject target)
    {
        target.GetComponent<PlayerMovement>().sOPlayerMovement.speedPlayer += amount;
    } 
}
