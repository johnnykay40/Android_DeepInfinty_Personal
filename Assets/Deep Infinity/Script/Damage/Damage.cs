using UnityEngine;

public class Damage : MonoBehaviour
{
    [SerializeField] private float damage;

    private Health health;

    private void OnTriggerEnter(Collider other)
    {
        health = other.GetComponent<Health>();
        System.GC.Collect();
        health.ReduceHealth(damage);
    }
}
