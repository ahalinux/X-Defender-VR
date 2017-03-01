using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class GameOverScoreDisplay : MonoBehaviour {

    ScoreAbsorber scoreAbsorber;
    Text text;

    void Start()
    {
        scoreAbsorber = GameObject.FindObjectOfType<ScoreAbsorber>();
        text = this.GetComponent<Text>();
    }

    void Update()
    {
        text.text = "" + scoreAbsorber.score;
    }
}
