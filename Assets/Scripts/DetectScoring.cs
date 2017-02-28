using UnityEngine;
using System.Collections;

public class DetectScoring : MonoBehaviour {

    public float scorePerHit = 0.5f;

    void OnCollisionEnter(Collision collision)
    {
        ScoreKeeper scoreKeeper = GameObject.FindObjectOfType<ScoreKeeper>();
        scoreKeeper.IncrementScore(scorePerHit);
        DestoryGameObject(collision);
    }

    private void DestoryGameObject(Collision collision)
    {
        Destroy(this.gameObject);
        Destroy(collision.gameObject);
    }
}
