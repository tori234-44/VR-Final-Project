using UnityEngine;
using System;

public class AnalogClock : MonoBehaviour
{
    public Transform hourHand;    // Reference to the hour hand's transform
    public Transform minuteHand;  // Reference to the minute hand's transform
    public Transform secondHand;  // Reference to the second hand's transform

    void Start()
    {
        // Initialize the hands to the current time immediately
        UpdateClockHands();
    }

    void Update()
    {
        // Continuously update the clock hands every frame
        UpdateClockHands();
    }

    void UpdateClockHands()
    {
        DateTime currentTime = DateTime.Now;

        float hours = currentTime.Hour % 12 + currentTime.Minute / 60f + currentTime.Second / 3600f;
        float minutes = currentTime.Minute + currentTime.Second / 60f;
        float seconds = currentTime.Second + currentTime.Millisecond / 1000f;

        float hourAngle = hours * 30f;    // 360 degrees / 12 hours = 30 degrees per hour
        float minuteAngle = minutes * 6f; // 360 degrees / 60 minutes = 6 degrees per minute
        float secondAngle = seconds * 6f; // 360 degrees / 60 seconds = 6 degrees per second

        // Apply the rotation using Quaternions
        hourHand.localRotation = Quaternion.Euler(0f, 0f, -hourAngle);
        minuteHand.localRotation = Quaternion.Euler(0f, 0f, -minuteAngle);
        secondHand.localRotation = Quaternion.Euler(0f, 0f, -secondAngle);
    }

}
