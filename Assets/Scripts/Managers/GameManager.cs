using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : Singleton<GameManager>
{
    public Transform spawnPoint;
    public GameObject playerPrefab;
    [HideInInspector]
    public GameObject playerInstance;

    private void Awake()
    {
        base.awake();
    }

    void Start()
    {
        if (!playerInstance)
        {
            spawnPlayer();
        }
    }

    void Update()
    {
        
    }

    void spawnPlayer()
    {
        playerInstance = Instantiate(playerPrefab, spawnPoint.position, spawnPoint.rotation);
    }
}
