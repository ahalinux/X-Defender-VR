using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class TimeRemainingDisplay : MonoBehaviour {

    LevelManager levelManager;
    Text text;

    void Start()
    {
        levelManager = GameObject.FindObjectOfType<LevelManager>();
        text = this.GetComponent<Text>();
    }

    void Update()
    {
        text.text = "剩余时间: " + levelManager.timeTillNextLevel;
    }
}
