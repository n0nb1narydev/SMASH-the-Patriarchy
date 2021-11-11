using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameController : MonoBehaviour
{
    // timers
    public float gameTimer = 60;
    public float moveUpTimer = 1.5f;
    public Text gameTimerText;

    public GameObject molesContainer;
    private Mole[] moles;

    // Start is called before the first frame update
    void Start()
    {
        moles = molesContainer.GetComponentsInChildren<Mole>();
    }

    // Update is called once per frame
    void Update()
    {
        gameTimer -= Time.deltaTime; // removes 1 second per frame
        int gameTimerRounded = (int)Mathf.Round(gameTimer);
        gameTimerText.text = "Time Remaining: " + gameTimerRounded;

        if (gameTimer > 0)
        {

            moveUpTimer -= Time.deltaTime;
            if(moveUpTimer < 0f)
            {
                moles[Random.Range(0, moles.Length)].MoveUp();
                moveUpTimer = Random.Range(.5f, 3f);
            }
            
        }
    }
}
