using UnityEngine;
using System.Collections;

public class BulletSpawner : MonoBehaviour {

    public GameObject ballPrefab;
    public float ballSpeed = 5.0f;
    public Vector3 bulletSpawnerPosition;
    public float spawnInterval = 2.0f;

    private float nextSpawnTime = 0;
    private PoolManager poolManager;

    void Start()
    {
        poolManager = GameObject.FindObjectOfType<PoolManager>();
    }

    void Update()
    {
        if(Time.time > nextSpawnTime)
        {
            BulletShoot();
            nextSpawnTime = Time.time + spawnInterval;
        }
    }

    private void BulletShoot()
    {
        GameObject instance = Instantiate(ballPrefab);
        instance.transform.position = bulletSpawnerPosition;
        Rigidbody rb = instance.GetComponent<Rigidbody>();
        Camera camera = this.GetComponentInChildren<Camera>();
        rb.velocity = camera.transform.rotation * (Vector3.forward * ballSpeed);
    }

    private void BulletShootTest()
    {
        GameObject instance = Instantiate(ballPrefab, bulletSpawnerPosition, this.transform.rotation) as GameObject;
        instance.GetComponent<Rigidbody>().velocity = new Vector3(-30, 10, 0);
    }
}
