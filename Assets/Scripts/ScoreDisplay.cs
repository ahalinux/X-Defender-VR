using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class ScoreDisplay : MonoBehaviour {

    ScoreKeeper scoreKeeper;
    Text text;

    void Start()
    {
        scoreKeeper = GameObject.FindObjectOfType<ScoreKeeper>();
        text = this.GetComponent<Text>();
    }

    void Update()
    {
        text.text = "得分: " + scoreKeeper.score;
    }
}
