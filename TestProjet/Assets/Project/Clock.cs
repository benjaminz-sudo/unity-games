using NUnit.Framework;
using System;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.ProBuilder.Shapes;
using UnityEngine.XR;

public class Clock : MonoBehaviour
{
    private float time=0;
    public float speed = 1f;
    public GameObject HourPivot;
    public GameObject MinutePivot;
    public GameObject SecondPivot;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        DateTime now = DateTime.Now;
        time = now.Hour * 3600 + now.Minute * 60 + now.Second;
    }

    // Update is called once per frame
    void Update()
    {
        time += Time.deltaTime * speed;

        float seconds = (time % 60) / 60f * 360f;
        float minutes = (time % 3600) / 3600f * 360f;
        float hours = (time % 43200) / 43200f * 360f;
        SecondPivot.transform.eulerAngles = new Vector3(seconds, 0f, 0f);
        MinutePivot.transform.eulerAngles = new Vector3(minutes, 0f, 0f);
        HourPivot.transform.eulerAngles = new Vector3(hours, 0f, 0f);
    }
}