using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class NeutralShit : MonoBehaviour
{
    [SerializeField] private int money = 20;
    public TextMeshProUGUI textNeutral;
    public TextMeshProUGUI textNeutralPrice;
    private static ArrayList NEUTRAL_SHIT = new ArrayList() { 
        "Gasesti 5 lei pe jos",
        "Cerseste",
        "Canta muzica pe bulevard",
        "Vinde antichitati",
        "Fa pariuri sportive",
        "Completeaza chestionare online", 
        "Creeaza un website cu reclame",
        "Recicleaza hartii", 
        "Recicleaza fer", 
        "Strange puncte Carrefour", 
        "Castiga o competitie", 
        "Pune video-uri pe Youtube",
        "Mineaza bitcoin"};
    private static ArrayList NEUTRAL_SHIT_MONEY = new ArrayList() {5, 1, 2, 4, 5, 2, 3, 2, 3, 2, 4, 2, 5};
    private System.Random rnd = new System.Random();
    private int index;
    private int loto;

    private void Start()
    {
        SetTextNeutral();
    }

    public void DoNeutral()
    {
        if (textNeutral.text == "Castiga la Loto")
        {
            GameState.IncreaseMoney(10000);
        }
        else
        {
            GameState.IncreaseMoney((int)NEUTRAL_SHIT_MONEY[GetIndex()]);
        }
        SetTextNeutral();
    }

    private void SetTextNeutral()
    {
        loto = rnd.Next(0, 201);
        if (loto == 100)
        {
            textNeutral.SetText("Castiga la Loto");
            textNeutralPrice.SetText("10000 lei");
        }
        else
        {
            SetIndex();
            textNeutral.SetText(NEUTRAL_SHIT[GetIndex()].ToString());
            textNeutralPrice.SetText(NEUTRAL_SHIT_MONEY[GetIndex()].ToString() + " lei");
        }
    }

    private void SetIndex()
    {
        index = rnd.Next(0, NEUTRAL_SHIT.Count - 1);
    }

    private int GetIndex()
    {
        return index;
    }
}
