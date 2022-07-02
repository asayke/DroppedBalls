using TMPro;
using UnityEngine;

public class PlayerStats : MonoBehaviour
{
    private TextMeshProUGUI allCoinsText;
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
        GameObject allCoinsTextOnbj = GameObject.Find("TextCanvas/AllCoimsText");
        allCoinsText = allCoinsTextOnbj.GetComponent<TextMeshProUGUI>();
        DontDestroyOnLoad(allCoinsText);
        DontDestroyOnLoad(gameObject);
        allCoinsText.SetText(allCoins.ToString());
    }
}