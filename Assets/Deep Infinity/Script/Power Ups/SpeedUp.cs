using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpeedUp : PowerUpEffect
{

    [SerializeField] private float amount;
    [SerializeField] private override void Apply(GameObject target)
    {
        target.GetComponent<Speed>().speed.value += amount;
    } 
}
