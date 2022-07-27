using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class PowerUpEffect : ScriptableObject
{
    [SerializeField] private abstract void Apply(GameObject target);

}
