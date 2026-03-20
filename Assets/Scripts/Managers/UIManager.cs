using System.Collections;
using TMPro;
using UnityEngine;

namespace Managers
{
    public class UIManager : MonoBehaviour
    {
        public int Coins { get; set; }

        private const int valueBarrHp = 160;
     
        [SerializeField] private TMP_Text coinsText;
        [SerializeField] private TMP_Text hpText;
        [SerializeField] private RectTransform hpVisual;
        [SerializeField] private GameObject bloodImage;
    
        public static UIManager Instance{ get; private set; }
        private void Awake()
        {
            if (Instance == null)
            {
                Instance = this;
            }
            else
            {
                Destroy(gameObject);
            }
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
            if (hp <= 0)
            {
                GameManager.Instance.Lose();
            }
        }

        public IEnumerator BloodEfect()
        {
            bloodImage.SetActive(true);
            yield return new WaitForSeconds(0.2f);
            bloodImage.SetActive(false);
        }

    }
}
