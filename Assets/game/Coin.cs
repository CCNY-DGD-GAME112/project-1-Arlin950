using UnityEngine;

public class Coin : MonoBehaviour
{
    public float xRange = 8f;
    public float yRange = 4f;
    public LayerMask obstacleLayer;
    private Timer timer; 

    void Start()
    {
        timer = FindFirstObjectByType<Timer>();
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            if (timer != null)
            {
                timer.coincount++;
            }
            
            MoveToNewPosition();
        }
    }

    void MoveToNewPosition()
    {
        Vector2 newPos;
        int safetyCounter = 0;

        do
        {
            newPos = new Vector2(
                Random.Range(-xRange, xRange),
                Random.Range(-yRange, yRange)
            );
            safetyCounter++;
        }
        while (Physics2D.OverlapCircle(newPos, 0.3f, obstacleLayer) && safetyCounter < 50);

        transform.position = newPos;
    }
}
