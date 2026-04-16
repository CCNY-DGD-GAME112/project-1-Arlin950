using UnityEngine;

public class e1 : MonoBehaviour
{
    public Transform player;
    public float speed = 2f;
    public GameObject gameOverText;
    private Timer timer;
    private float startSpeed;
    public float maxSpeed = 6f;
    void Start()
    {
        timer = FindFirstObjectByType<Timer>();
        startSpeed = speed;
    }
    void Update()
    {
        if (timer != null)
        {
            speed = startSpeed + timer.coincount / 10;
            speed = Mathf.Min(speed, maxSpeed);
        }
        transform.position = Vector3.MoveTowards(transform.position, player.position, speed * Time.deltaTime);
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            gameOverText.SetActive(true);
            Time.timeScale = 0f;
        }
    }
}