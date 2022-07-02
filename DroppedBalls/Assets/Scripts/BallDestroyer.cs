using UnityEngine;

public class BallDestroyer : MonoBehaviour
{
    private Renderer ballRederer;
    private Renderer destroyerRenderer;
    [SerializeField] private HealhPoints healhPoints;
    [SerializeField] private GameObject endGameMenu;
    private PlayerStats playerStats;

    
    private void Start()
    {
        endGameMenu.SetActive(false);
        playerStats = FindObjectOfType<PlayerStats>();
        playerStats.sessionCoins = 0;
        destroyerRenderer = gameObject.GetComponent<Renderer>();
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.GetComponent<BallMover>())
        {
            healhPoints.ChangePoints();
            if (healhPoints.CurrentHealthPoint() > 3)
                endGameMenu.SetActive(true);

            ballRederer = other.gameObject.GetComponent<Renderer>();
            destroyerRenderer.material.color = ballRederer.material.color;
            Destroy(other.gameObject, .1f);
        }
    }
}