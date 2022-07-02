using UnityEngine;
using UnityEngine.SceneManagement;

public class GameStripts : MonoBehaviour
{
   public void Reset()
   {
      SceneManager.LoadScene("GameScene");
   }

   public void BackToMenu()
   {
      SceneManager.LoadScene("SampleScene");
   }
}
