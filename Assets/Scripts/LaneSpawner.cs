using UnityEngine;
using System.Collections;

public class LaneSpawner : MonoBehaviour {

    public GameObject[] lanePrefabs;
    public float offsetClearance = 10;
    public float offsetAll = 100;

    private float offset = 0;

    void Start()
    {
        while(offset < offsetAll)
        {
            CreateRandomLane(offset);
            offset += offsetClearance;
        }
    }

    private void CreateRandomLane(float offset)
    {
        int laneIndex = Random.Range(0, lanePrefabs.Length);
        GameObject lane = GameObject.Instantiate(lanePrefabs[laneIndex]);
        lane.transform.parent = transform;
        lane.transform.position = new Vector3(0, 0, offset);
    }
}
