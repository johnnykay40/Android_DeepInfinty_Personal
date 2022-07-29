using UnityEngine;


[CreateAssetMenu(menuName = "SO Deep Infinity / #name_PowerUp")]
public class PowerUpSO : ScriptableObject
{
    [SerializeField] internal float amount;

    internal void Invoke(float value)
    {
        value += amount;    
    }
}
