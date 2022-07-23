using UnityEngine;

[CreateAssetMenu(menuName = "SO Deep Infinity / Player Movement")]
public class SOPlayerMovement : ScriptableObject
{
    [Header("Values")]
    [Range(0, 100)] [SerializeField] internal float speedPlayer;

    [Header("Position")]
    [SerializeField] internal Vector3 vectorMovement;
}
