using System;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    internal static event Action<Transform> OnCallBoundary;

    [SerializeField] private FixedJoystick fixedJoystick;

    [Header("Data")]
    [SerializeField] internal SOPlayerMovement sOPlayerMovement;

    [Header("Physics")]
    [SerializeField] private Rigidbody rigidbodyPlayer;

    private void Update()
    {
        MovementPlayer();
    }

    private void MovementPlayer()
    {
        float movementHorizontal = fixedJoystick.Horizontal;
        float movementVertical = fixedJoystick.Vertical;

        sOPlayerMovement.vectorMovement = new Vector3(movementHorizontal, 0f, movementVertical);
        rigidbodyPlayer.velocity = sOPlayerMovement.vectorMovement * sOPlayerMovement.speedPlayer;

        OnCallBoundary?.Invoke(transform);
    }
}
