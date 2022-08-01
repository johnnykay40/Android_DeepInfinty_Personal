using UnityEngine;

public class PlayerController : MonoBehaviour
{
    [SerializeField] private float playerSpeed;
    [SerializeField] private Rigidbody playerRigibody;
    [SerializeField] private FixedJoystick fixedJoystick;

    private void Update()
    {
        PlayerMovement();
    }

    private void PlayerMovement()
    {
        float horizontalMovement = fixedJoystick.Horizontal;
        float verticalMovement = fixedJoystick.Vertical;
        Vector3 newPosition = new Vector3(horizontalMovement, .0f, verticalMovement);
        playerRigibody.velocity = newPosition * playerSpeed;
    }
}
