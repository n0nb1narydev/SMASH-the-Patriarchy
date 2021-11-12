using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameController : MonoBehaviour
{
    // timers
    public float gameTimer = 60;
    public float moveUpTimer = 1.5f;
    public Text gameTimerText;

    public GameObject molesContainer;
    private Mole[] moles;

    public GameObject gameOverScreen;

    private Player player;
    public Text scoreText;

    public AudioSource gameOverAudio;

    // Start is called before the first frame update
    void Start()
    {
        moles = molesContainer.GetComponentsInChildren<Mole>();
        player = GameObject.Find("Mallet").GetComponent<Player>();
    }

    // Update is called once per frame
    void Update()
    {
        gameTimer -= Time.deltaTime; // removes 1 second per frame
        int gameTimerRounded = (int)Mathf.Round(gameTimer);
        gameTimerText.text = "Time Remaining: " + gameTimerRounded;

        if (gameTimer > 45)
        {

            moveUpTimer -= Time.deltaTime;
            if(moveUpTimer < 0f)
            {
                moles[Random.Range(0, moles.Length)].MoveUp();
                moveUpTimer = Random.Range(1f, 3f);
            }
        }
        else if(gameTimer > 30)
        {
            moveUpTimer -= Time.deltaTime;
            if (moveUpTimer < 0f)
            {
                moles[Random.Range(0, moles.Length)].MoveUp();
                moveUpTimer = Random.Range(.75f, 2f);
            }
        }
        else if (gameTimer > 0)
        {
            moveUpTimer -= Time.deltaTime;
            if (moveUpTimer < 0f)
            {
                moles[Random.Range(0, moles.Length)].MoveUp();
                moveUpTimer = Random.Range(.5f, 1f);
            }
        }
        else
        {
            gameOverAudio.Play();
            gameOverScreen.SetActive(true);
            scoreText.text = "final score:               " + player.score + " trumps trumped.";
            //player.AppendScore();
        }
    }

    public void PlayAgain()
    {
        SceneManager.LoadScene(1);
    }
}
