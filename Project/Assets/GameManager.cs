using System.Collections;
using UnityEngine.UI;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public int lives = 3;
    public int bricks = 16;
    public float resetDelay = 1f;
    public Text LivesText;
    public GameObject gameOver;
    public GameObject youWon;
    public GameObject BricksPrefab;
    public GameObject paddle;
    public GameObject deathParticles;
    public static GameManager instance = null;
    private GameObject clonePaddle;

    // Start is called before the first frame update
    void Start()
    {
        if (instance == null)
            instance = this;
        else if (instance != this)
            Destroy(gameObject);

        Setup();
    }

    // Update is called once per frame
    public void Setup()
    {
        clonePaddle = Instantiate(paddle, transform.position, Quaternion.identity) as GameObject;
        Instantiate(BricksPrefab, transform.position, Quaternion.identity);

    }
    void CheckGameOver()
    {
        if (bricks < 1)
        {
            youWon.SetActive(true);
            Time.timeScale = .25f;
            Invoke ("Reset", resetDelay);
        }
        if (lives < 1)
        {
            gameOver.SetActive(true);
            Time.timeScale = .25f;
            Invoke ("Reset", resetDelay);
        }
    }
    void Reset()
    {
        Time.timeScale = 1f;
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
    public void LoseLife()
    {
        lives--;
        LivesText.text = "Lives: " + lives;
        Instantiate(deathParticles, clonePaddle.transform.position, Quaternion.identity);
        Destroy(clonePaddle);
        Invoke ("SetupPaddle", resetDelay);
        CheckGameOver();
    }
    void SetupPaddle()
    {
        clonePaddle = Instantiate(paddle, transform.position, Quaternion.identity) as GameObject;
    }
    public void DestoryBrick()
    {
        bricks--;
        CheckGameOver();
    }
}
