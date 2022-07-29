using UnityEngine;

public class Health : MonoBehaviour
{
    [Range(0, 1000)]
    [SerializeField] internal float healthMax;
    [Range(0, 1000)]
    [SerializeField] internal float healthCurrent;

    internal void CheckHealth()
    {
        if(healthCurrent <= 0)
        {
            Debug.Log("Me morí");
            //Bomb gonorrea
            //Panel de game over
        }

        if(healthCurrent >= healthMax)
        {
            healthCurrent = healthMax;
        }
    }

    internal void ReduceHealth(float _damage)
    {
        healthCurrent -= _damage;
        CheckHealth();
    }

}
