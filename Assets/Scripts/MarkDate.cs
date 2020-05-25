using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MarkDate : MonoBehaviour
{
    public Text dateClock;

    private System.DateTime theTime = System.DateTime.Now;

    // Start is called before the first frame update
    private void Start()
    {
    }

    // Update is called once per frame
    private void Update()
    {
        string date = theTime.ToString("yyyy-MM-dd");

        dateClock.text = date;
    }
}