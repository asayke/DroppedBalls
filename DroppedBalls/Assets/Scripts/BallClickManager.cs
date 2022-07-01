using TMPro;
using UnityEngine;

public class BallClickManager : MonoBehaviour
{
    private TextMeshProUGUI sessionCoinsText;
    private PlayerStats playerStats;
    private Ball ball;

    private void Start()
    {
        sessionCoinsText = GameObject.Find("SessionCoims").gameObject.GetComponent<TextMeshProUGUI>();
        playerStats = FindObjectOfType<PlayerStats>();
        ball = gameObject.GetComponent<Ball>();
    }

    private void OnMouseDown()
    {
        int thisBallCoins = ball.Coins();
        playerStats.IncAllCoins(thisBallCoins);
        playerStats.sessionCoins += thisBallCoins;
        sessionCoinsText.SetText(playerStats.sessionCoins.ToString());
        Destroy(gameObject, .1f);
    }
}