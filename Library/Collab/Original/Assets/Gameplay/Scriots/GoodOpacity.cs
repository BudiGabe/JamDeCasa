using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GoodOpacity : MonoBehaviour
{
    public GameObject goodImg;
    private float[] OPACITY = { 0f, 0.2f, 0.4f, 0.6f, 0.8f, 1f };
    private float opacity;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void ChangeOpacity()
    {
        opacity = OPACITY[GameState.GetMorality() % 5];
        var col = goodImg.GetComponent<Renderer>().material.color;
        col.a = opacity;
    }
}
