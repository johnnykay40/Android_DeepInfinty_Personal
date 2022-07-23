using System;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    internal static event Action<Transform> OnCallBoundary;

    [SerializeField] private FixedJoystick fixedJoystick;

    [Header("Values")]
    [Range(0,100)] [SerializeField] internal float speedPlayer;

    [Header("Physics")]
    [SerializeField] private Rigidbody rigidbodyPlayer;

    [Header("Position")]
    [SerializeField] private Vector3 vectorMovement;

    private void Update()
    {
        MovementPlayer();
    }

    private void MovementPlayer()
    {
        float movementHorizontal = fixedJoystick.Horizontal;
        float movementVertical = fixedJoystick.Vertical;

        vectorMovement = new Vector3(movementHorizontal, 0f, movementVertical);
        rigidbodyPlayer.velocity = vectorMovement * speedPlayer;

        OnCallBoundary?.Invoke(transform);
    }
}
