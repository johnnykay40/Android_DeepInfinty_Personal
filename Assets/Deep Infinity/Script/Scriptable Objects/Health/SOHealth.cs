using UnityEngine;

[CreateAssetMenu(menuName = "SO Deep Infinity / #Name Health")]
public class SOHealth : ScriptableObject
{
    [Range(0, 1000)]
    [SerializeField] internal float health;
}