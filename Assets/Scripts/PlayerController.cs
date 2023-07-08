using UnityEngine;
using UnityEngine.Events;

public class PlayerController : MonoBehaviour
{
    public float jumpForce = 5f;
    private bool isJumping = false;
    private Rigidbody2D rb;

    public UnityEvent addScore;

    private AudioSource _jumpSound;

    [SerializeField] private GameObject _gameOverScreen;

    private void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        _jumpSound = GetComponent<AudioSource>();
    }

    private void Update()
    {
        if (Input.GetKey(KeyCode.Space) && !isJumping && rb.velocity.y == 0)
        {
            isJumping = true;
            rb.AddForce(new Vector2(0f, jumpForce), ForceMode2D.Impulse);
            _jumpSound.Play();
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Ground"))
        {
            isJumping = false;
        }

        if (collision.gameObject.CompareTag("Obstacle"))
        {
            Time.timeScale = 0;
            _gameOverScreen.SetActive(true);
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        addScore.Invoke();
    }
}