using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move : MonoBehaviour
{
    public static Rigidbody2D rb;
    void Start()
    {
        rb = GetComponent<Rigidbody2D>(); 
    }

   
   public static void DoJump(float jumpforce)
    {
        rb.AddForce(Vector2.up * jumpforce);
    }
}
