using UnityEngine;

public class HealhPoints : MonoBehaviour
{
    [SerializeField] private GameObject[] healthSprites;
    private int currentHealthPoint;


    public int CurrentHealthPoint()
    {
        return currentHealthPoint + 1;
    }

    public void ChangePoints()
    {
        if (currentHealthPoint <= 2)
        {
            healthSprites[currentHealthPoint].gameObject.SetActive(false);
            currentHealthPoint += 1;
        }
    }
}