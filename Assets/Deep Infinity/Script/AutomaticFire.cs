
using System.Collections.Generic;
using UnityEngine;

public class AutomaticFire : MonoBehaviour
{
    [SerializeField] private GameObject PlayerBullet;
    [SerializeField] private int poolSize = 10;
    [SerializeField] private List<GameObject> laserList;
    
    private void Start()
    {
        AddLaserToPool(poolSize);
    }
    private void AddLaserToPool(int amount)
    {
        for (int i = 0; i < amount; i++)
        {
            GameObject laser = Instantiate(PlayerBullet);            
            laserList.Add(laser);
            laser.transform.parent = transform;
            laser.SetActive(false);
        }
        InvokeRepeating(nameof(RequestLaser), 1f, 1f);
    }

    internal void RequestLaser()
    {
        for (int i = 0; i < laserList.Count; i++)
        {
            if (!laserList[i].activeInHierarchy)
            {
                laserList[i].SetActive(true);
                laserList[i].transform.position = transform.position;
                laserList[i].transform.rotation = transform.rotation;
                
                break;
            }
        }
    }


}
