using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class SplitManager : MonoBehaviour
{
    #region Declarations

    public bool tickTimer;
    public float timer;

    public TMP_Text mainTimerText;

    public GameObject splitElementPrefab;
    public Transform splitSVContentTransform;

    private Split currentSplit;
    public int splitIndex;

    public DateTime startTime;
    public DateTime currentTime;

    public Speedrun bestSpeedrun;
    public Speedrun currentSpeedrun;

    private SettingsManager settingsManager;
    public static SplitManager instance;

    #endregion

    #region Unity Methods

    private void Awake()
    {
        instance = this;
    }

    void Start()
    {
        settingsManager = SettingsManager.instance;
    }

    void Update()
    {
        if (tickTimer)
            TickTimer();
    }

    #endregion

    #region Custom Methods

    private void TickTimer()
    {
        currentTime = DateTime.Now;
        mainTimerText.text = GetUpdatedTimerText();
    }

    public void StartTimer()
    {
        tickTimer = true;

        startTime = DateTime.Now;
    }

    public void PauseTimer()
    {
        tickTimer = false;
    }

    public void UnPauseTimer()
    {
        tickTimer = true;
    }

    public void ResetTimer()
    {

    }

    public void NewSplit()
    {

    }

    #region Helpers

    public string GetUpdatedTimerText()
    {
        TimeSpan timerSpan = GetCurrentTimerSpan();

        string hrsText = "";
        if (timerSpan.Hours > 0)
            hrsText = string.Format("{0:D2}", timerSpan.Hours) + ":";

        string minsText = string.Format("{0:D2}", timerSpan.Minutes);
        string secsText = string.Format("{0:D2}", timerSpan.Seconds);

        string millisecsText = "";
        if (settingsManager.showMilliseconds)
            millisecsText = ":" + string.Format("{0:D2}", timerSpan.Milliseconds);

        return hrsText + minsText + ":" + secsText + millisecsText;
    }

    public TimeSpan GetCurrentTimerSpan()
    {
        return currentTime - startTime;
    }

    #endregion

    #endregion
}
