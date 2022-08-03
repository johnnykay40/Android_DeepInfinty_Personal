using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletScript : MonoBehaviour
{
    [SerializeField] private float laserSpeed = 5f;
    [SerializeField] private Rigidbody laserRigidBody;    
    [SerializeField] private float deactivateBulletTime;

    private void OnEnable()
    {
        Invoke("OnDisable", deactivateBulletTime);
    }

    private void Update()
    {
        laserRigidBody.velocity = Vector3.forward * laserSpeed;       
    }

    private void OnDisable()
    {
        gameObject.SetActive(false);
    }
    private void OnTriggerEnter()
    {
        gameObject.SetActive(false);
    }
}
