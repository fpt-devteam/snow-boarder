using System;
using System.Collections.Generic;
using UnityEngine;

public class InfiniteMapManager : MonoBehaviour
{
  private Transform player;
  public GameObject platformPrefabs;
  private GameObject checkPoint;
  private GameObject spawnPoint;

  void Start()
  {
    if (player == null)
    {
      player = GameObject.FindGameObjectWithTag("Player").transform;
      checkPoint = GameObject.FindGameObjectWithTag("PlatformerCheckPoint");
      spawnPoint = GameObject.FindGameObjectWithTag("PlatformerSpawnPoint");
    }
  }

  void Update()
  {
    if (player.position.x > checkPoint.transform.position.x)
    {
      SpawnNewPlatform();
    }
  }

  private void SpawnNewPlatform()
  {
    GameObject newPlatform = Instantiate(platformPrefabs, spawnPoint.transform.position, Quaternion.identity);
    checkPoint = newPlatform.transform.Find("PlatformerCheckPoint").gameObject;
    spawnPoint = newPlatform.transform.Find("PlatformerSpawnPoint").gameObject;

    Debug.Log("New platform spawned at: " + spawnPoint.transform.position);
  }
}
