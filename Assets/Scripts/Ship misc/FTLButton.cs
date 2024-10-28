using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FTLButton : MonoBehaviour
{
    [Header("Ship Settings")]
    [SerializeField] private Vector3 shipSpawnPos;
    [SerializeField] private Vector3 shipSpawnRot;
    [SerializeField] private GameObject ship;

    [Header("System Settings")]
    [SerializeField] private GameObject system;
    public void EngageFTL()
    {
        ship.transform.position = shipSpawnPos;
        ship.transform.eulerAngles = shipSpawnRot;

        GameObject.FindWithTag("StarSystem").SetActive(false);

        system.SetActive(true);
    }
}
