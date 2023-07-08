using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnPlatforms : MonoBehaviour
{
    public GameObject platformPrefab;
    public int distance = 18;

    public float lastPos = 18;

    public Vector2 direction;

    [SerializeField] private Score _score;

    private void Spawn()
    {
        var prefab =  Instantiate(platformPrefab, transform);
        lastPos += distance;
        prefab.transform.localPosition = new Vector2(lastPos,0);

        Destroy(transform.GetChild(0).gameObject);
    }

    private void Update()
    {
        transform.Translate(direction * _score.gameSpeed * Time.deltaTime);

        if (transform.position.x <= -lastPos)
        {
            Spawn();
        }
    }
}
