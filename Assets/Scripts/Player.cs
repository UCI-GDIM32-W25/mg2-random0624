using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Player : MonoBehaviour
{
    private bool isGrounded;
    public float jumpForce = 5f;
    [SerializeField] private Collider2D col;
    [SerializeField] private Transform _playerTransform;
    [SerializeField] private Rigidbody2D rb;
    [SerializeField] private GameObject coinPrefab;
    [SerializeField] private PlayerUI playerUI;
    private int _points = 0;
    
    
    // Start is called before the first frame update
    void Start()
    {
        playerUI.UpdatePoint(_points);
        isGrounded = true;
        rb = GetComponent<Rigidbody2D>();
        col = GetComponent<Collider2D>();

    }

    // Update is called once per frame
    void Update()
    {
        if (isGrounded && Input.GetKeyDown(KeyCode.Space))
        {
            Jump();
        }
    }

    private void Jump()
    {
        // Add your jump logic here, e.g., applying a force to the Rigidbody
        isGrounded = false;
        rb.AddForce(Vector2.up * jumpForce, ForceMode2D.Impulse);
    }
    
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Ground"))
        {
            isGrounded = true;
        }
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (!other.CompareTag("Coin"))
        {
            return;
        }

        _points++;
        if (playerUI != null)
        {
            playerUI.UpdatePoint(_points);
        }

        Destroy(other.gameObject);
    }

}