using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MarkTime : MonoBehaviour
{
    public Text timeClock;
    private float time;
    private int min;
    private int sec;
    private string fmt = "00";

    // Use this for initialization
    private void Start()
    {
        time = 0;
        min = 0;
        sec = 0;
    }

    // Update is called once per frame
    private void Update()
    {
        time += Time.deltaTime;
        timeClock.text = MarkMin() + ": " + MarkSec();
    }

    private string MarkMin()
    {
        min = (int)time / 60;
        return min.ToString(fmt);
    }

    private string MarkSec()
    {
        sec = (int)time % 60;
        return sec.ToString(fmt);
    }
}