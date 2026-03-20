using UnityEngine;

public class Settings : MonoBehaviour
{
    [SerializeField] private GameObject controls;
    public void ShowControls()
    {
        controls.SetActive(true);
    }

    public void HideControls()
    {
        controls.SetActive(false);
    }
}
