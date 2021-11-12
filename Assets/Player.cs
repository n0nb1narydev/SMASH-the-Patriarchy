using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Player : MonoBehaviour
{
    public Animator animator;
    public int score;
    public Text scoreText;
    //public List<int> scores = new List<int>();



    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown("[1]"))
        {
            animator.SetBool("onePressed", true);
            animator.SetBool("isHitting", true);
        }
        if (Input.GetKeyUp("[1]"))
        {
            animator.SetBool("onePressed", false);
            animator.SetBool("isHitting", false);
        }
        if (Input.GetKeyDown("[2]"))
        {
            animator.SetBool("twoPressed", true);
            animator.SetBool("isHitting", true);
        }
        if (Input.GetKeyUp("[2]"))
        {
            animator.SetBool("twoPressed", false);
            animator.SetBool("isHitting", false);
        }
        if (Input.GetKeyDown("[3]"))
        {
            animator.SetBool("threePressed", true);
            animator.SetBool("isHitting", true);
        }
        if (Input.GetKeyUp("[3]"))
        {
            animator.SetBool("threePressed", false);
            animator.SetBool("isHitting", false);
        }
        if (Input.GetKeyDown("[4]"))
        {
            animator.SetBool("fourPressed", true);
            animator.SetBool("isHitting", true);
        }
        if (Input.GetKeyUp("[4]"))
        {
            animator.SetBool("fourPressed", false);
            animator.SetBool("isHitting", false);
        }
        if (Input.GetKeyDown("[5]"))
        {
            animator.SetBool("fivePressed", true);
            animator.SetBool("isHitting", true);
        }
        if (Input.GetKeyUp("[5]"))
        {
            animator.SetBool("fivePressed", false);
            animator.SetBool("isHitting", false);
        }
        if (Input.GetKeyDown("[6]"))
        {
            animator.SetBool("sixPressed", true);
            animator.SetBool("isHitting", true);
        }
        if (Input.GetKeyUp("[6]"))
        {
            animator.SetBool("sixPressed", false);
            animator.SetBool("isHitting", false);
        }
        if (Input.GetKeyDown("[7]"))
        {
            animator.SetBool("sevenPressed", true);
            animator.SetBool("isHitting", true);
        }
        if (Input.GetKeyUp("[7]"))
        {
            animator.SetBool("sevenPressed", false);
            animator.SetBool("isHitting", false);
        }
        if (Input.GetKeyDown("[8]"))
        {
            animator.SetBool("eightPressed", true);
            animator.SetBool("isHitting", true);
        }
        if (Input.GetKeyUp("[8]"))
        {
            animator.SetBool("eightPressed", false);
            animator.SetBool("isHitting", false);
        }
        if (Input.GetKeyDown("[9]"))
        {
            animator.SetBool("ninePressed", true);
            animator.SetBool("isHitting", true);
        }
        if (Input.GetKeyUp("[9]"))
        {
            animator.SetBool("ninePressed", false);
            animator.SetBool("isHitting", false);
           
        }


    }

    //public void AppendScore()
    //{
        //scores.Add(score);
    //}
}
