using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mole_3 : MonoBehaviour
{
    //private float molePosX = transform.position.x;
    //private float molePosZ = transform.position.z;
    Vector3 downPos = new Vector3(4.0f, -0.3f, 3.47f);
    Vector3 upPos = new Vector3(4.0f, 2.5f, 3.47f);
    public bool moleDown = true;

    public float speed = 2f;
     // calculate distance to move

    // Start is called before the first frame update
    void Start()
    {
        // Sets 3rd mole to downPos at the start of the game.
        transform.position = downPos;

    }

    // Update is called once per frame
    void Update()
    {
        if(moleDown)
        {
            StartCoroutine(MoveUp(NextFloat(10f, 30f)));
            moleDown = false;
        }
        else if(!moleDown)
        {
            StartCoroutine(MoveDown(NextFloat(1f, 3f)));
            moleDown = true;
        }

    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.tag == "Player")
        {
            print("Target Hit!");
        }
    }

    IEnumerator MoveUp(float waitTime)
    {
        float step = speed * Time.deltaTime;
        yield return new WaitForSeconds(waitTime);
        transform.position = Vector3.MoveTowards(transform.position, upPos, step);
       
    }
    IEnumerator MoveDown(float waitTime)
    {
        float step = speed * Time.deltaTime;
        yield return new WaitForSeconds(waitTime);
        transform.position = Vector3.MoveTowards(transform.position, downPos, step);
    }

    static float NextFloat(float min, float max)
    {
        System.Random random = new System.Random();
        double val = (random.NextDouble() * (max - min) + min);
        return (float)val;
    }

}
