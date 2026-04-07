using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static GameManager gameManager;
    [SerializeField] int timeToEnd = 15;
    bool gamePaused = false;
    bool win = false;
    bool EndGame = false;
    public int points = 0;
    
    public int redKey = 0;
    public int greenKey = 0;
    public int goldKey = 0;
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

        if (EndGame)
        {
            endGame();
        }
    }
    public void PauseGame()
    {
        Debug.Log("Pause Game");
        
            Time.timeScale = 0f;
            gamePaused = true;

        
    }
    public void ResumeGame()
    {
        Debug.Log("Resume Game");
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
    public void AddPoints(int point)
    {
        points += point;
    }

    public void AddTime(int addTime)
    {
        timeToEnd += addTime;
    }
    public void FreezeTime(int freeze)
    {
        CancelInvoke("Stopper");
        InvokeRepeating("Stopper", freeze, 1);
    }
    public void AddKey(Key.KeyColor color)
    {
        if (color == Key.KeyColor.Gold)
        {
            goldKey++;
        }
        else if (color == Key.KeyColor.Green)
        {
            greenKey++;
        }
        else if (color == Key.KeyColor.Red)
        {
            redKey++;
        }
    }
}
