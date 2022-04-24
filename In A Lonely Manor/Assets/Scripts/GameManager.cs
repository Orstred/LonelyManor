using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{

    #region Singleton
    public static GameManager instance;
    private void Awake()
    {
        if (instance is null)
        {
            instance = this;
        }
        else
            Destroy(this);
    }

    #endregion


}
