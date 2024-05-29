using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    [SerializeField] private List<GameObject> prefab;
    private float minX = -4.3f;
    private float maxX = 0.9f;
    
    void Start()
    {
        StartCoroutine(Spawn());
    }

    IEnumerator Spawn()
    {
        while (true)
        {
            float randomX = Random.Range(minX, maxX);
            float randomValue = Random.Range(0f, 1f);
            Vector2 position = new Vector2(randomX,4f);
            GameObject go;
            if (randomValue <= 0.7f)
            {
                go=Instantiate(prefab[0], position, Quaternion.identity);
            }
            else
            {
                go=Instantiate(prefab[1], position, Quaternion.identity);
            }
            yield return new WaitForSeconds(0.9f);
            Destroy(go, 3f);
        }
    }
}
