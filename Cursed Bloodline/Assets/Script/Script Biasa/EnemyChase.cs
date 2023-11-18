using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyChase : MonoBehaviour
{
    public float speed = 5f; // kecepatan musuh
    public float bounceForce = 10f; // kekuatan pantulan pemain

    private Transform player; // referensi transform pemain

    private void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player").transform; // mencari transform pemain berdasarkan tag
    }

    private void Update()
    {
        // mengatur arah gerak musuh menuju pemain
        Vector3 direction = player.position - transform.position;
        direction.Normalize();
        transform.Translate(direction * speed * Time.deltaTime);

        // memeriksa jika pemain menabrak musuh
        Collider2D hit = Physics2D.OverlapCircle(transform.position, 1f, LayerMask.GetMask("Player"));
        if (hit != null)
        {
            // pemain terpantul dari musuh
            Vector3 bounceDirection = (hit.transform.position - transform.position).normalized;
            hit.GetComponent<Rigidbody2D>().AddForce(bounceDirection * bounceForce, ForceMode2D.Impulse);
        }
    }
}