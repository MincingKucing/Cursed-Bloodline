using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    private Animator animator;

    void Start()
    {
        animator = GetComponent<Animator>();
    }

    void Update()
    {
        // Mengatur animasi berdasarkan input pemain
        float horizontalInput = Input.GetAxis("Horizontal");
        float verticalInput = Input.GetAxis("Vertical");

        // Cek jika pemain sedang bergerak
        if (horizontalInput != 0f || verticalInput != 0f)
        {
            // Set animator parameter "IsWalking" menjadi true untuk memainkan animasi "Walk"
            animator.SetBool("IsWalking", true);

            // Set animator parameter "IsIdle" menjadi false untuk menghindari animasi "Idle"
            animator.SetBool("IsIdle", false);
        }
        else
        {
            // Set animator parameter "IsWalking" menjadi false untuk menghentikan animasi "Walk"
            animator.SetBool("IsWalking", false);

            // Set animator parameter "IsIdle" menjadi true untuk menjalankan animasi "Idle"
            animator.SetBool("IsIdle", true);
        }

        // Cek jika pemain mengeklik mouse kiri
        if (Input.GetMouseButtonDown(0))
        {
            // Jalankan animasi "Attack"
            animator.SetTrigger("Attack");
        }
    }
}