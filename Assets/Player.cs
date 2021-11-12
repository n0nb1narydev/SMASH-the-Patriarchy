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
            HitMole1();
        }
        if (Input.GetKeyUp("[1]"))
        {
            ReleaseMole1();
        }
        if (Input.GetKeyDown("[2]"))
        {
            HitMole2();
        }
        if (Input.GetKeyUp("[2]"))
        {
            ReleaseMole2();
        }
        if (Input.GetKeyDown("[3]"))
        {
            HitMole3();
        }
        if (Input.GetKeyUp("[3]"))
        {
            ReleaseMole3();
        }
        if (Input.GetKeyDown("[4]"))
        {
            HitMole4();
        }
        if (Input.GetKeyUp("[4]"))
        {
            ReleaseMole4();
        }
        if (Input.GetKeyDown("[5]"))
        {
            HitMole5();
        }
        if (Input.GetKeyUp("[5]"))
        {
            ReleaseMole5();
        }
        if (Input.GetKeyDown("[6]"))
        {
            HitMole6();
        }
        if (Input.GetKeyUp("[6]"))
        {
            ReleaseMole6();
        }
        if (Input.GetKeyDown("[7]"))
        {
            HitMole7();
        }
        if (Input.GetKeyUp("[7]"))
        {
            ReleaseMole7();
        }
        if (Input.GetKeyDown("[8]"))
        {
            HitMole8();
        }
        if (Input.GetKeyUp("[8]"))
        {
            ReleaseMole8();
        }
        if (Input.GetKeyDown("[9]"))
        {
            HitMole9();
        }
        if (Input.GetKeyUp("[9]"))
        {
            ReleaseMole9();

        }


    }

    public void HitMole1()
    {
        animator.SetBool("onePressed", true);
        animator.SetBool("isHitting", true);


    }
    public void ReleaseMole1()
    {
        animator.SetBool("onePressed", false);
        animator.SetBool("isHitting", false);
    }
    public void HitMole2()
    {
        animator.SetBool("twoPressed", true);
        animator.SetBool("isHitting", true);


    }
    public void ReleaseMole2()
    {
        animator.SetBool("twoPressed", false);
        animator.SetBool("isHitting", false);
    }
    public void HitMole3()
    {
        animator.SetBool("threePressed", true);
        animator.SetBool("isHitting", true);


    }
    public void ReleaseMole3()
    {
        animator.SetBool("threePressed", false);
        animator.SetBool("isHitting", false);
    }
    public void HitMole4()
    {
        animator.SetBool("fourPressed", true);
        animator.SetBool("isHitting", true);


    }
    public void ReleaseMole4()
    {
        animator.SetBool("fourPressed", false);
        animator.SetBool("isHitting", false);
    }
    public void HitMole5()
    {
        animator.SetBool("fivePressed", true);
        animator.SetBool("isHitting", true);


    }
    public void ReleaseMole5()
    {
        animator.SetBool("fivePressed", false);
        animator.SetBool("isHitting", false);
    }
    public void HitMole6()
    {
        animator.SetBool("sixPressed", true);
        animator.SetBool("isHitting", true);


    }
    public void ReleaseMole6()
    {
        animator.SetBool("sixPressed", false);
        animator.SetBool("isHitting", false);
    }
    public void HitMole7()
    {
        animator.SetBool("sevenPressed", true);
        animator.SetBool("isHitting", true);


    }
    public void ReleaseMole7()
    {
        animator.SetBool("sevenPressed", false);
        animator.SetBool("isHitting", false);
    }
    public void HitMole8()
    {
        animator.SetBool("eightPressed", true);
        animator.SetBool("isHitting", true);


    }
    public void ReleaseMole8()
    {
        animator.SetBool("eightPressed", false);
        animator.SetBool("isHitting", false);
    }
    public void HitMole9()
    {
        animator.SetBool("ninePressed", true);
        animator.SetBool("isHitting", true);


    }
    public void ReleaseMole9()
    {
        animator.SetBool("ninePressed", false);
        animator.SetBool("isHitting", false);
    }
}
