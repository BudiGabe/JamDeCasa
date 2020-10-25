using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EvilShit : MonoBehaviour
{
    [SerializeField] int money= 300;
  
    public void DoEvil()
    {
        GameState.DecreaseMorality();
        GameState.IncreaseMoney(money);
    }
}
