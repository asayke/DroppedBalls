using System;
using System.Collections.Generic;
using UnityEngine;

public class BallDestroyer : MonoBehaviour
{
    private Renderer ballRederer;
    private Renderer destroyerRenderer;

    private void Start()
    {
        destroyerRenderer = gameObject.GetComponent<Renderer>();
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.GetComponent<BallMover>())
        {
            ballRederer = other.gameObject.GetComponent<Renderer>();
            destroyerRenderer.material.color = ballRederer.material.color;
            Destroy(other.gameObject, .1f);
        }
    }
}