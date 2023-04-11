using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class PlayerController : MonoBehaviour
{
    public float jumpForce = 10f;
    public float gravity = 1f;
    [SerializeField] private GameObject game_Over_panal;

    private Rigidbody2D rb;

    void Start()
    {
        Time.timeScale = 1f;
        rb = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Jump();
        }

        if (transform.position.y <= -4.5)
        {
            game_Over_panal.SetActive(true);
            Time.timeScale = 0;
        }
    }

    void Jump()
    {
        rb.velocity = Vector2.up * jumpForce;
    }

    void FixedUpdate()
    {
        rb.velocity += Vector2.down * gravity;
    }

  
    private void OnTriggerEnter2D(Collider2D collision)
    {

        if (collision.gameObject.CompareTag("Wall"))
        {
           game_Over_panal.SetActive(true);
            Time.timeScale = 0;
          
        }
    }


}
