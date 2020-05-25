using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class KeyBoardMgr : MonoBehaviour
{
    public Button captureButton;
    public Button snapButton;
    public Button cancelButton;
    public Button saveButton;
    public Button deleteButton;

    // Use this for initialization
    private void Start()
    {
    }

    // Update is called once per frame
    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.C))
        {
            captureButton.GetComponent<Button>().onClick.Invoke();
        }
        if (Input.GetKeyDown(KeyCode.Return))
        {
            snapButton.GetComponent<Button>().onClick.Invoke();
        }
        if (Input.GetKeyDown(KeyCode.X))
        {
            cancelButton.GetComponent<Button>().onClick.Invoke();
        }
        if (Input.GetKeyDown(KeyCode.S))
        {
            saveButton.GetComponent<Button>().onClick.Invoke();
        }
        if (Input.GetKeyDown(KeyCode.D))
        {
            deleteButton.GetComponent<Button>().onClick.Invoke();
        }
    }
}