using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class flowermove : MonoBehaviour
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
            anim.SetBool("flowermoving", true);
        }
    }
    private void OnTriggerExit2D(Collider2D collision)
    {
        anim.SetBool("flowermoving", false);
    }
}
