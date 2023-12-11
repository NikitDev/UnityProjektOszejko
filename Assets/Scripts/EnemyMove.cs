using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMove : MonoBehaviour
{
    public float moveSpeed = 15f;
    private Vector2 direction = Vector2.right;
    private Rigidbody2D rb;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        MoveEnemy();
    }

    public void SetDirection(Vector2 newDirection)
    {
        direction = newDirection.normalized;
    }

    void MoveEnemy()
    {
        Vector2 movement = direction * moveSpeed * Time.deltaTime;
        rb.MovePosition(rb.position + movement);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Castle"))
        {
            DealDamageToCastle();
        }
    }

    private void DealDamageToCastle()
    {
        CastleHealth castleHealth = GameObject.FindGameObjectWithTag("Castle").GetComponent<CastleHealth>();
        castleHealth.TakeDamage(10);
        Destroy(gameObject);
    }
}
