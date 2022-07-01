using System;
using UnityEngine;
using UnityEngine.EventSystems;

public class BallClickManager : MonoBehaviour
{
   private void OnMouseDown()
   {
      Destroy(gameObject, .1f);
   }
}