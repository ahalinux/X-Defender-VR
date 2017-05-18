using UnityEngine;
using System.Collections.Generic;
using System.Collections;

public class PoolManager : MonoBehaviour {

    public int Capacity = 10;
    private List<GameObject> dormantObjects = new List<GameObject>();

    public GameObject Spawn(GameObject go)
    {
        GameObject temp = null;
        if (dormantObjects.Count > 0)
        {
            foreach (GameObject dob in dormantObjects)
            {
                if (dob.name == go.name)
                {
                    temp = dob;
                    dormantObjects.Remove(temp);
                    return temp;
                }
            }
        }

        temp = GameObject.Instantiate(go) as GameObject;
        temp.name = go.name;
        return temp;
    }

    // 将用完的GameObject放入dormantObjects中
    public void Despawn(GameObject go)
    {
        go.transform.parent = this.transform;
        go.SetActive(false);
        dormantObjects.Add(go);
        Trim();
    }

    //FIFO 如果dormantObjects大于最大个数则将之前的GameObject都推出来。
    public void Trim()
    {
        while (dormantObjects.Count > Capacity)
        {
            GameObject dob = dormantObjects[0];
            dormantObjects.RemoveAt(0);
            Destroy(dob);
        }
    }
}
