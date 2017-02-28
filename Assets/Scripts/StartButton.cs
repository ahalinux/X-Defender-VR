using UnityEngine;
using System.Collections;

public class StartButton : MonoBehaviour {

    public int gazeTime = 2;
    private LevelManager levelManager;

    void Start()
    {
        SetGazedAt(false);
        levelManager = FindObjectOfType<LevelManager>();
    }

    public void SetGazedAt(bool gazedAt)
    {
        if (levelManager)
        {
            //print("yay Yes");
            Invoke("OnGazeLoadScene", gazeTime);
        }
        else
        {
            //print("say No");
        }

    }

    private void OnGazeLoadScene()
    {
        levelManager.LoadNextScene();
    }

    public void OnGazeEnter()
    {
        SetGazedAt(true);
    }

    public void OnGazeExit()
    {
        SetGazedAt(false);
        CancelInvoke();
    }

}
