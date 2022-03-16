using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EndTrigger : MonoBehaviour
{
    private WinAndLose winAndLose;
    private PlayerController player;


    private void Start()
    {
        winAndLose = FindObjectOfType<WinAndLose>();
        player = FindObjectOfType<PlayerController>();
    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.CompareTag("Player"))
        {
            winAndLose.GameWon();
        }
    }
}
