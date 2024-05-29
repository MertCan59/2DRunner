using UnityEngine;

public class GoldCollectible : MonoBehaviour,ICollectible
{
    public void Collect()
    {
        Debug.Log("Gold Coin is collected");
        GameManager.instance.AddScore(2);
        Destroy(gameObject);
    }
}
