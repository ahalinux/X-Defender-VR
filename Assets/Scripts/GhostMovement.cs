using UnityEngine;
using System.Collections;

public class GhostMovement : MonoBehaviour {

    public float ghostSpeed = 5;

    void FixedUpdate()
    {
        this.GetComponent<Rigidbody>().MovePosition(this.transform.position + Vector3.right * ghostSpeed * Time.deltaTime);
    }

    //void Update()
    //{
    //    this.transform.Translate(ghostSpeed * Time.deltaTime, 0, 0);
    //}
}
