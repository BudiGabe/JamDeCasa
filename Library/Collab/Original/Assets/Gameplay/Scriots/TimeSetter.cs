﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class TimeSetter : MonoBehaviour
{
    public TextMeshProUGUI title;
    public Button buttonGood;
    public Button buttonNeutral;
    public Button buttonEvil;
    public TextMeshProUGUI time;
    // Start is called before the first frame update
    void Start()
    {
        time.SetText(GameState.GetTimeCountString());
        InvokeRepeating("UpdateTime", 1f, 1f);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void UpdateTime()
    {
        GameState.DecreaseTime(GameState.GetMorality());

        if (GameState.GetTimeCount() > 0)
        {
            time.SetText(GameState.GetTimeCountString());
        }
        else
        {
            time.SetText("0");
            Over();
            PlayerPrefs.DeleteAll();
        }
        
    }

    public void Over()
    {
        if (GameState.GetMoneyCount() >= GameState.GetMoneyGoal())
        {
            title.SetText("Felicitari!");
        }
        else
        {
            title.SetText("ESEC! Click aici pentru a incerca din nou");
        }

        buttonGood.enabled = false;
        buttonNeutral.enabled = false;
        buttonEvil.enabled = false;
        CancelInvoke();
        
    }
}
