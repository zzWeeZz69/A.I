using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlantMove : MonoBehaviour
{
    public Animator anim;
    public bool Move;

    private void Start()
    {
        Move = GameObject.FindGameObjectWithTag("Player");
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (Move == true)
        {
            anim.SetBool("PlantBool", true);
        }
    }
    private void OnTriggerExit2D(Collider2D collision)
    {
        anim.SetBool("PlantBool", false);
    }
}
