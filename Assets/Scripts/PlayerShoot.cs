using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerShoot : MonoBehaviour
{
    public GameObject arrowPrefab;
    public Transform shootPoint;

    private SpriteRenderer spriteRenderer;

    void Start()
    {
        spriteRenderer = GetComponent<SpriteRenderer>();
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            ShootArrow();
        }
    }

    void ShootArrow()
    {
        GameObject arrow = Instantiate(arrowPrefab, shootPoint.position, shootPoint.rotation);

        float angle = spriteRenderer.flipX ? 180f : 0f;
        arrow.transform.rotation = Quaternion.Euler(0f, 0f, angle);
    }
}
