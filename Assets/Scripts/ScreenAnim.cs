using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScreenAnim : MonoBehaviour
{
    public GameObject saveUI;
    public GameObject deleteUI;

    private Animator screenAnim;
    public bool isSnap = false;
    public bool isSave = false;
    public bool isDelete = false;

    // Use this for initialization
    private void Start()
    {
        screenAnim = GetComponent<Animator>();
        saveUI.SetActive(false);
        deleteUI.SetActive(false);
    }

    // Update is called once per frame
    private void Update()
    {
    }

    public void OnSnapAnim()
    {
        screenAnim.SetBool("Snap", true);
        //if (isSnap == false)
        //{
        //    screenAnim.SetBool("Snap", true);
        //    isSnap = true;
        //}
        //else if (isSnap == true)
        //{
        //    screenAnim.SetBool("Snap", false);
        //    isSnap = false;
        //}
    }

    public void OnCancelAnim()
    {
        screenAnim.SetBool("Cancel", true);
        screenAnim.SetBool("Snap", false);
        screenAnim.SetBool("Save", false);
        screenAnim.SetBool("Delete", false);
    }

    public void OnSaveAnim()
    {
        screenAnim.SetBool("Cancel", false);
        screenAnim.SetBool("Save", true);
        StartCoroutine(ShowSaveIcon());

        //if (isSave == false)
        //{
        //    screenAnim.SetBool("Save", true);
        //    isSave = true;
        //}
        //else if (isSave == true)
        //{
        //    screenAnim.SetBool("Save", false);

        //    isSave = false;
        //}
    }

    public void OnDeleteAnim()
    {
        screenAnim.SetBool("Cancel", false);
        screenAnim.SetBool("Delete", true);
        StartCoroutine(ShowDeleteIcon());
        //if (isDelete == false)
        //{
        //    screenAnim.SetBool("Delete", true);

        //    isDelete = true;
        //}
        //else if (isDelete == true)
        //{
        //    screenAnim.SetBool("Delte", false);

        //    isDelete = false;
        //}
    }

    private IEnumerator ShowSaveIcon()
    {
        saveUI.SetActive(true);
        yield return new WaitForSeconds(1.0f);
        saveUI.SetActive(false);
    }

    private IEnumerator ShowDeleteIcon()
    {
        deleteUI.SetActive(true);
        yield return new WaitForSeconds(1.0f);
        deleteUI.SetActive(false);
    }
}