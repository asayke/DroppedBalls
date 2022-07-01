using UnityEngine;
using Random = UnityEngine.Random;

public class BallColorContoller : MonoBehaviour
{
    private Renderer ballRenderer;

    private void Start()
    {
        ballRenderer = gameObject.GetComponent<Renderer>();
        ballRenderer.material.color = new Color(Random.value, Random.value, Random.value, 1);
    }
}