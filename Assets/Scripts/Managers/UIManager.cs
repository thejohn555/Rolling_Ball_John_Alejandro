using System;
using TMPro;
using UnityEngine;

public class UIManager : MonoBehaviour
{
    public int Coins { get; set; }
    
    private TMP_Text coinsText;
    
    public static UIManager instance;
    private void Awake()
    {
        if (instance == null)
        {
            instance = this;
        }
        else
        {
            Destroy(gameObject);
        }
        coinsText = GameObject.Find("Coins").GetComponent<TMP_Text>();
    }

    public void Start()
    {
        ReloadText();
    }

    public void ReloadText()
    {
        coinsText.text = "Coins: " + Coins;
    }
    

}
