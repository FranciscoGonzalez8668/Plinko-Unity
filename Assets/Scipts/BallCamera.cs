using UnityEngine;

public class BallCamera : MonoBehaviour
{
    public GameObject ballPrefab;
    public Canvas funnyCanvas;
    public float duration = 3f;

    private Camera cam;
    private Transform originalParent;
    private Vector3 originalPosition;
    private bool isFollowing = false;

    void Start()
    {
        cam = Camera.main;
        originalPosition = cam.transform.position;
        originalParent = cam.transform.parent;
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space) && !isFollowing)
        {
            SpawnAndFollow();
        }
    }

    void SpawnAndFollow()
    {
        Vector3 mousePos = cam.ScreenToWorldPoint(Input.mousePosition);
        mousePos.z = 0f;
        GameObject ball = Instantiate(ballPrefab, mousePos, Quaternion.identity);

        StartCoroutine(FollowBall(ball));
    }

    System.Collections.IEnumerator FollowBall(GameObject ball)
    {
        isFollowing = true;
        funnyCanvas.gameObject.SetActive(true);

        // La cámara se convierte en hija de la pelota — se mueve exacta con ella
        cam.transform.SetParent(ball.transform);
        cam.transform.localPosition = new Vector3(0f, 0f, -10f);

        yield return new WaitForSeconds(duration);

        // Vuelve a su estado original
        cam.transform.SetParent(originalParent);
        cam.transform.SetPositionAndRotation(originalPosition, Quaternion.identity);
        funnyCanvas.gameObject.SetActive(false);
        isFollowing = false;
    }
}
