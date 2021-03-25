using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class displaySystem : MonoBehaviour
{

    public Text text;
    private int count = 0;

    void Start()
    {
        text.text = "Score: " + count;    
    }

    public void CollectCoin()
    {
        count += 100;
        text.text = "Score: " + count;
    }
}
