using UnityEngine;
using System.Collections;

public class ScoreKeeper : MonoBehaviour {

    public float score = 0;

    void Start()
    {
        DontDestroyOnLoad(gameObject);
    }

    public void IncrementScore(float amount)
    {
        score += amount;
        print("You scored is: " + score);
    }
}
