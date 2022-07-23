using UnityEngine;


public class PlayerBoundary : MonoBehaviour
{
    [SerializeField] private SOPlayerBoundary boundary;

    private void OnEnable()
    {
        PlayerMovement.OnCallBoundary += CallBoundary;
    }

    private void CallBoundary(Transform player)
    {
        player.position = new Vector3 (Mathf.Clamp(player.position.x, boundary.xMin, boundary.xMax), 0, Mathf.Clamp(player.position.z, boundary.zMin, boundary.zMax));
    }

    private void OnDisable()
    {
        
        PlayerMovement.OnCallBoundary -= CallBoundary;
    }
} 
