using UnityEngine;

public class BallSpawner : MonoBehaviour
{
    public GameObject ballPrefab;


    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            SpawnBall();
        }
    }

    private void SpawnBall()
    {
        Vector3 spawnPosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        spawnPosition.z = 0f;
        GameObject ball = Instantiate(ballPrefab, spawnPosition, Quaternion.identity);

        // Impulso lateral aleatorio para que no quede clavada en los pegs
        Rigidbody2D rb = ball.GetComponent<Rigidbody2D>();
        float randomX = Random.Range(-0.5f, 0.5f);
        rb.AddForce(new Vector2(randomX, 0f), ForceMode2D.Impulse);

        AudioManager.Instance?.PlayBallSpawn();
    }

}