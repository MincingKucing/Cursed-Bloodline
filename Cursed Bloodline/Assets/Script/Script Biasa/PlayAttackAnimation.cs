using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayAttackAnimation : MonoBehaviour
{
    private Animator animator;

    private void Start()
    {
        // Dapatkan komponen Animator dari objek ini
        animator = GetComponent<Animator>();
    }

    private void Update()
    {
        // Cek apakah pemain mengklik mouse kiri
        if (Input.GetMouseButtonDown(0))
        {
            // Memainkan animasi "Attack" dengan tag "Attack"
            animator.SetTrigger("Attack");
        }
    }
}