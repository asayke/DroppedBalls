using UnityEngine;
using Random = System.Random;

public class Ball : MonoBehaviour
{
    [SerializeField] private int minCoins;
    [SerializeField] private int maxCoins;
    private int coins;

    public int Coins()
    {
        return coins;
    }


    private void Start()
    {
        Random random = new Random();
        coins = random.Next(minCoins, maxCoins);
    }
}