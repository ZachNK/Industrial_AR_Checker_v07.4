using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TappedRecev : MonoBehaviour
{
    private bool isBlue = false;
    //private Button thisButton;

    // Use this for initialization
    private void Start()
    {
        //thisButton = GetComponent<Button>();
    }

    // Update is called once per frame
    private void Update()
    {
    }

    private void OnTapped()
    {
        isBlue = !isBlue;
        GetComponent<Button>().onClick.Invoke();
    }
}