using UnityEngine;

[CreateAssetMenu(menuName = "SO Deep Infinity / PowerUpEffect")]

public abstract class PowerUpEffect : ScriptableObject
{
    [SerializeField] internal abstract void Apply(GameObject target);

}
