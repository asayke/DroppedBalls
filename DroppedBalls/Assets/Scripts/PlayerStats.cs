using TMPro;
using UnityEngine;

public class PlayerStats : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI allCoinsText;
    private int heathPoint = 3;
    
    private static int allCoins;
    public int sessionCoins;
    
    public void IncAllCoins(int coins)
    {
        allCoins += coins;
        allCoinsText.SetText(allCoins.ToString());
    }

    private void Start()
    {
        DontDestroyOnLoad(allCoinsText);
        DontDestroyOnLoad(gameObject);
        allCoinsText.SetText(allCoins.ToString());
    }
    
    
}