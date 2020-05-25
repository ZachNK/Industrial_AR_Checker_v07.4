using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TestControl : MonoBehaviour
{
    public Transform statusUI;
    public Transform searchUI;
    public Transform captureUI;
    public Transform timeUI;
    public Transform settingsUI;

    //private Animator anim;
    private Animator statusAnim;

    private Animator searchAnim;
    private Animator captureAnim;
    private Animator timeAnim;
    private Animator settingsAnim;

    private bool ok = false;

    // Use this for initialization
    private void Start()
    {
        //anim = GetComponent<Animator>();
        statusAnim = statusUI.GetComponent<Animator>();
        searchAnim = searchUI.GetComponent<Animator>();
        captureAnim = captureUI.GetComponent<Animator>();
        timeAnim = timeUI.GetComponent<Animator>();
        settingsAnim = settingsUI.GetComponent<Animator>();
    }

    // Update is called once per frame
    private void FixedUpdate()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            OnTapped();
        }
    }

    public void OnTapped()
    {
        if (ok == false)
        {
            //anim.SetBool("Active", true);
            statusAnim.SetBool("Active", true);
            searchAnim.SetBool("Active", true);
            captureAnim.SetBool("Active", true);
            timeAnim.SetBool("Active", true);
            settingsAnim.SetBool("Active", true);

            ok = true;
        }
        else if (ok == true)
        {
            //anim.SetBool("Active", false);
            statusAnim.SetBool("Active", false);
            searchAnim.SetBool("Active", false);
            captureAnim.SetBool("Active", false);
            timeAnim.SetBool("Active", false);
            settingsAnim.SetBool("Active", false);
            ok = false;
        }
    }
}