using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static GameManager gameManager;
    [SerializeField] int timeToEnd = 15;
    bool gamePaused = false;
    // Start is called before the first frame update
    void Start()
    {
        if (gameManager == null)
        {
            gameManager = this;
            if (timeToEnd <= 0)
            {
                timeToEnd = 100;
            }
            InvokeRepeating("Stopper", 2, 1);
        }
    }

    // Update is called once per frame
    void Update()
    {

    }
    void Stopper()
    {
        timeToEnd--;
        Debug.Log("Time" + timeToEnd + "s");
    }
    public void PauseGame()
    {
        Debug.Log("Pause Game")
        {
            Time.timeScale = 0f;
            gamePaused = true;

        }
    }
    public void ResumeGame()
    {
        Time.timeScale = 1f;
        gamePaused = false;
    }
    void PauseCheck
    {
        if(Input.GetKeyDown(KeyCode.P)
        {
        }
}
