using UnityEngine;
using System.Collections;

public class ScoreAbsorber : MonoBehaviour {

    public float score;

    void Start()
    {
        ScoreKeeper oldKeeper = GameObject.FindObjectOfType<ScoreKeeper>();
        score = 1;
        if (oldKeeper)
        {
            score = oldKeeper.score;
            Destroy(oldKeeper.gameObject);
        }
    }
}
