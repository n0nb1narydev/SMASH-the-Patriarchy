using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mole : MonoBehaviour
{
    public float moleUpPos = 3.0f;
    public float moleDownPos = .3f;
    private Vector3 moleNewPos;
    public float moveDownTimer = 1.5f;


    public float speed = 2f;

    public Player player;
    // Start is called before the first frame update
    void Start()
    {
        player = GameObject.Find("Mallet").GetComponent<Player>();
    }

    void Awake()
    {
        MoveDown();

        transform.localPosition = moleNewPos;
    }
    // Update is called once per frame
    void Update()
    {
        transform.localPosition = Vector3.Lerp(
            transform.localPosition,
            moleNewPos,
            speed * Time.deltaTime
            );

        moveDownTimer -= Time.deltaTime;
        if(moveDownTimer < 0)
        {
            MoveDown();
        }
    }

    public void MoveDown()
    {
        moleNewPos = new Vector3(
            transform.localPosition.x, 
            moleDownPos, 
            transform.localPosition.z
            );
    }

    public void MoveUp()
    {
        moleNewPos = new Vector3(
            transform.localPosition.x,
            moleUpPos,
            transform.localPosition.z
        );

        moveDownTimer = Random.Range(1f, 2f);
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            player.score += 1;
            player.scoreText.text = "Score: " + player.score;
            MoveDown();
        }
    }
}
