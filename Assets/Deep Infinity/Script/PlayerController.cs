
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    [SerializeField] private float playerSpeed;
    [SerializeField] private float laserOffSet = 0.5f;    
    [SerializeField] private Rigidbody playerRigidbody;
    [SerializeField] private FixedJoystick fixedJoystick;

    private AutomaticFire laserPool;

    private void Start()
    {
        laserPool = FindObjectOfType<AutomaticFire>();
    }

    private void Update()
    {
        PlayerMovement();

        //if (Input.GetKey(KeyCode.E))
        //{
        //    GameObject laser = laserPool.RequestLaser();
        //    laser.transform.position = transform.position + Vector3.forward * laserOffSet;
        //}
    }

    private void PlayerMovement()
    {
        float horizontalMovement = fixedJoystick.Horizontal;
        float verticalMovement = fixedJoystick.Vertical;
        Vector3 newPosition = new Vector3(horizontalMovement, .0f, verticalMovement);
        playerRigidbody.velocity = newPosition * playerSpeed;
    }
}
