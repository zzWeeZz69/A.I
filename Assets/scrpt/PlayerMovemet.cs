using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovemet : MonoBehaviour
{
    [Range(0, 20f)]
    public float MoveSpeed;

    public Animator Anim;
    


    Rigidbody2D rbody;
    // Use this for initialization
    void Start()
    {
        rbody = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    { 
        rbody.velocity = new Vector2(Input.GetAxis("Horizontal") * MoveSpeed, rbody.velocity.y);
        Anim.SetFloat("Walk", Mathf.Abs(rbody.velocity.x));
        if (Input.GetKey(KeyCode.A))
        {
            transform.localScale = new Vector3(-1, 1, 1);
        }
        if (Input.GetKey(KeyCode.D))
        {
            transform.localScale = new Vector3(1, 1, 1);
        }
    }
}
