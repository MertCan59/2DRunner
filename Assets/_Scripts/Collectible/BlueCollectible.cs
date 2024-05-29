using UnityEngine;

public class BlueCollectible : MonoBehaviour,ICollectible
{
    
    public void Collect()
    {
        Debug.Log("Blue Coin is collected");
        GameManager.instance.AddScore(1);
        Destroy(gameObject);
        
    }
}
