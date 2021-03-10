using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SettingsManager : MonoBehaviour
{
    #region Declarations

    public bool showMilliseconds = true;

    public static SettingsManager instance;

    #endregion

    #region Unity Methods

    private void Awake()
    {
        instance = this;
    }

    void Start()
    {

    }

    void Update()
    {

    }

    #endregion

    #region Custom Methods



    #endregion
}
