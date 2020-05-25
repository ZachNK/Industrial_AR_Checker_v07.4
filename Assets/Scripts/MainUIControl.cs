using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainUIControl : MonoBehaviour
{
    public Transform upBase;
    public Transform downBase;

    private Animator upUIanim;
    private Animator downUIanim;
    private bool isOpenUp = false;

    // Use this for initialization
    private void Start()
    {
        upUIanim = upBase.GetComponent<Animator>();
        downUIanim = downBase.GetComponent<Animator>();
    }

    // Update is called once per frame
    private void FixedUpdate()
    {
        //if (Input.GetKeyDown(KeyCode.Return))
        //{
        //    OnTime();
        //}
    }

    public void OnTime()
    {
        if (isOpenUp == false)
        {
            upUIanim.SetBool("Open", true);
            downUIanim.SetBool("Open", true);
            isOpenUp = true;
        }
        else if (isOpenUp == true)
        {
            upUIanim.SetBool("Open", false);
            downUIanim.SetBool("Open", false);
            isOpenUp = false;
        }
    }
}