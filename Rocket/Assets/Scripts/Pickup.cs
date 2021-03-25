using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Pickup : MonoBehaviour
{
    public Text display;
    private displaySystem displaySystem;

    private void Start()
    {
        displaySystem = display.GetComponent<displaySystem>();
    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.tag == "Player"){
            displaySystem.CollectCoin();
            Destroy(gameObject);
        }
    }
}
