using UnityEngine;

[CreateAssetMenu(menuName = "SO Deep Infinity / Boundary")]
public class SOPlayerBoundary : ScriptableObject
{
   [SerializeField] internal float xMin;
   [SerializeField] internal float xMax;
   [SerializeField] internal float zMin;
   [SerializeField] internal float zMax;
}
