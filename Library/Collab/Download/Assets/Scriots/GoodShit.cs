using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class GoodShit : MonoBehaviour
{

    [SerializeField] int money = 100;
    public TextMeshProUGUI textGood;
    private static List<string> GOOD_SHIT = new List<string> { "Ajuta o batranica", "Livreaza catre cei batrani", "Doneaza sange" };
    System.Random rnd = new System.Random();

    // Start is called before the first frame update
    void Start()
    {
        
        SetTextGood();
    }

    private void SetTextGood()
    {
        int index = rnd.Next(0, GOOD_SHIT.Count);
        textGood.SetText(GOOD_SHIT[index]);
        GOOD_SHIT.RemoveAt(index);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void DoGood()
    {
        GameState.IncreaseMorality();
        GameState.IncreaseMoney(money);
        SetTextGood();
    }

}
