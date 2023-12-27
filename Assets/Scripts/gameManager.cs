using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class gameManager : MonoBehaviour
{
    public GameObject square;
    public Text timeTxt;
    float alive = 0f;

    void Start()
    {
        InvokeRepeating("makeSquare", 0.0f, 0.5f);
    }

    
    void Update()
    {
        alive += Time.deltaTime;
        timeTxt.text = alive.ToString("N2");
    }

    void makeSquare ()
    {
        Instantiate(square);
    }
}
