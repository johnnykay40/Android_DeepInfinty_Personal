using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerFire : MonoBehaviour
{
    [SerializeField] private GameObject PlayerBullet;
    [SerializeField] private int poolSize = 10;
    [SerializeField] private List<GameObject> laserList;
    [SerializeField] private Button rocketButton;
    [SerializeField] private Transform rocketPosition;

    private void Start()
    {
        rocketButton.onClick.AddListener(RequestLaser);
        AddLaserToPool(poolSize);
    }
    private void AddLaserToPool(int amount)
    {
        for (int i = 0; i < amount; i++)
        {
            GameObject laser = Instantiate(PlayerBullet);
            laserList.Add(laser);
            laser.transform.parent = rocketPosition;
            laser.SetActive(false);
        }        
    }

    internal void RequestLaser()
    {
        for (int i = 0; i < laserList.Count; i++)
        {
            if (!laserList[i].activeInHierarchy)
            {
                laserList[i].SetActive(true);
                laserList[i].transform.position = rocketPosition.position;
                laserList[i].transform.rotation = rocketPosition.rotation;

                break;
            }
        }
    }
}
