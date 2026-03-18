using System;
using System.Collections;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class UIManager : MonoBehaviour
{
    public int Coins { get; set; }

    private const int valueBarrHp = 160;
     
    private TMP_Text coinsText;
    private TMP_Text hpText;
    private RectTransform hpVisual;
    private GameObject bloodImage;
    
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
        hpText = GameObject.Find("HPNumber").GetComponent<TMP_Text>();
        hpVisual = GameObject.Find("BloodRed").GetComponent<RectTransform>();
        bloodImage = GameObject.Find("Blood");
        bloodImage.SetActive(false);
    }

    public void Start()
    {
        ReloadText();
    }

    public void ReloadText()
    {
        coinsText.text = "Coins: " + Coins;
    }

    public void ReloadHp(int hp, int maxHp)
    {
        hpText.text = "HP: " + hp + "/" + maxHp;
        float f = (float)hp / maxHp;//se saca el valor de la vida
        f -= 1;//se invierte ya que mis valores de la barra de vida van de 0 full vida a 160 sin vida no de 160 a 0
        f *= valueBarrHp;//se multiplica por 160 para tener el valor que tengo que poner
        hpVisual.offsetMax = new Vector2(f, hpVisual.offsetMax.y);
    }

    public IEnumerator ReloadVisualHp()
    {
        bloodImage.SetActive(true);
        yield return new WaitForSeconds(0.2f);
        bloodImage.SetActive(false);
    }

}
