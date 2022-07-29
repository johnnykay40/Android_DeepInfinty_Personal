using UnityEngine;

public class PowerUps : MonoBehaviour
{
    [SerializeField] internal PowerUpSO powerUpSO;
    [SerializeField] internal SOPlayerMovement sOPlayerMovement;

    private void OnTriggerEnter(Collider other)
    {
        powerUpSO.Invoke(sOPlayerMovement.speedPlayer);
        Debug.Log("Speed");
    }

}
