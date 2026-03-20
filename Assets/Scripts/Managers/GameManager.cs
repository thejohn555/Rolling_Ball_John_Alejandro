
using System;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    
    [SerializeField] private GameObject win;
    [SerializeField] private GameObject secretWin;
    [SerializeField] private GameObject loss;
    
    public static GameManager Instance{get; private set;}

    public void Awake()
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

    public void Win()
    {
        win.SetActive(true);
        UnloockCursor();
    }
    
    public void SecretWin()
    {
        secretWin.SetActive(true);
        UnloockCursor();
    }

    public void Lose()
    {
        loss.SetActive(true);
        UnloockCursor();
    }
    public void UnloockCursor()
    {
        Cursor.visible = true;
        Cursor.lockState = CursorLockMode.None;
    }
}
