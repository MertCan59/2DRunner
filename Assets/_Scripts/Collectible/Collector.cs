using UnityEngine;
using System;

public class Collector : MonoBehaviour
{
    public static Action OnCoinCollectedSound;
    public static Action OnCoinCollectedUI;
    private void OnTriggerEnter2D(Collider2D other)
    {
        ICollectible collectible = other.GetComponent<ICollectible>();
        if (collectible != null)
        {
            collectible.Collect();
            OnCoinCollectedSound?.Invoke();
            OnCoinCollectedUI?.Invoke();
        }
    }
}
