using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static GameManager gameManager;
    [SerializeField] int timeToEnd = 15;
    bool gamePaused = false;
    bool win = false;
    bool EndGame = false;
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

        if (timeToEnd <= 0)
        {
            timeToEnd = 0;
            EndGame = true;
        }
    }
    public void PauseGame()
    {
        Debug.Log("Pause Game");
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
    void PauseCheck()
    {
        if (Input.GetKeyDown(KeyCode.P))
        {
            if (gamePaused)
            {
                ResumeGame();
            }
            else
            {
                PauseGame();
            }
        }
    }
    public void endGame()
    {
        CancelInvoke("Stopper");
        //TODO: Implement the rest of this code.
        if (win)
        {
            Debug.Log("Game Won. Reload?");
        }
        else
        {
            Debug.Log("Game Lost, Reload?");
        }
    }
}
