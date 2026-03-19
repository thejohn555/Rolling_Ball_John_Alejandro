using System;
using Objects;
using TMPro;
using UnityEngine;
using Random = System.Random;

public class PipeManager : MonoBehaviour
{
    [SerializeField] private Pipe[] pipe;
    private TMP_Text correctPipe;

    // public void Awake()
    // {
    //     foreach (Pipe p in pipe)
    //     {
    //         
    //     }
    // }
    Random rnd;
    public void Start()
    {
        rnd = new Random();
        int correct = rnd.Next(0,pipe.Length);
        pipe[correct].Correct = true;
        correctPipe = GameObject.Find("CorrectPipe").GetComponent<TMP_Text>();
        correctPipe.text = (correct+1).ToString();
    }
}
