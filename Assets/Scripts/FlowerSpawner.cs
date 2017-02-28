using UnityEngine;
using System.Collections;

public class FlowerSpawner : MonoBehaviour {

    public GameObject flowerPrefab;
    public int minFlowers = 5;
    public int maxFlowers = 15;

    void Start()
    {
        int flowerNumber = Random.Range(minFlowers, maxFlowers);
        for(int currentFlower = 0; currentFlower < flowerNumber; currentFlower++)
        {
            CreateFlower();
        }
    }

    private void CreateFlower()
    {
        var flower = GameObject.Instantiate(flowerPrefab);
        flower.transform.parent = this.transform;
        flower.transform.localPosition = new Vector3(Random.Range(-50, 50), 2.5f, Random.Range(-5, 5));
    }
}
