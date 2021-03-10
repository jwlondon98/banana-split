using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InputManager : MonoBehaviour
{
    #region Declarations

    public KeyCode startTimerBtn = KeyCode.None;
    public KeyCode newSplitBtn = KeyCode.None;
    public KeyCode pauseTimerBtn = KeyCode.None;
    public KeyCode resetTimerBtn = KeyCode.None;

    private SplitManager splitManager;
    public static InputManager instance;

    #endregion

    #region Unity Methods

    private void Awake()
    {
        instance = this;
    }

    void Start()
    {
        splitManager = SplitManager.instance;
    }

    void Update()
    {
        DetectInput();

        //ListenForKeypress();
    }

    #endregion

    #region Custom Methods

    private void DetectInput()
    {
        // start timer button
        if (Input.GetKeyDown(startTimerBtn))
            splitManager.StartTimer();

        // new split button
        if (Input.GetKeyDown(newSplitBtn))
            splitManager.NewSplit();

        // pause timer button
        if (Input.GetKeyDown(pauseTimerBtn))
            splitManager.PauseTimer();

        // reset timer button
        if (Input.GetKeyDown(resetTimerBtn))
            splitManager.ResetTimer();
    }

    private void ListenForKeypress()
    {
        foreach (KeyCode vKey in System.Enum.GetValues(typeof(KeyCode)))
        {
            if (Input.GetKey(vKey))
            {
                print(vKey.ToString());
            }
        }
    }

    #endregion
}
