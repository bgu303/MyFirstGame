using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FloorCreation : MonoBehaviour
{
    public GameObject floorPrefab;
    public GameObject floorPrefab2;
    public GameObject floorPrefab3;
    public float respawnTime = 1.0f;

    void Start()
    {

        StartCoroutine(floorSpawning());
    }

    IEnumerator floorSpawning()
    {
        while (true)
        {
            yield return new WaitForSeconds(Random.Range(2.0f, 2.6f));
            spawnFloor();
        }

    }

    void Update()
    {

    }

    private void spawnFloor()
    {
        int floorDecider = Random.Range(1, 10);

        if (floorDecider < 7)
        {
            GameObject floor = Instantiate(floorPrefab);
            floor.transform.position = new Vector2(ScreenBounds.getScreenBounds().x + 4, Random.Range(ScreenBounds.getScreenBounds().y - 4, ScreenBounds.getScreenBounds().y - 6));
        }
        else if (floorDecider >= 7 && floorDecider < 9)
        {
            GameObject floor2 = Instantiate(floorPrefab2);
            floor2.transform.position = new Vector2(ScreenBounds.getScreenBounds().x + 2, Random.Range(ScreenBounds.getScreenBounds().y - 4, ScreenBounds.getScreenBounds().y - 6));
        }
        else {
            GameObject floor3 = Instantiate(floorPrefab3);
            floor3.transform.position = new Vector2(ScreenBounds.getScreenBounds().x + 4, Random.Range(ScreenBounds.getScreenBounds().y - 4, ScreenBounds.getScreenBounds().y - 6));
        }

    }
}
