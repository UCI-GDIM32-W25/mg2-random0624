using System.Collections;
using UnityEngine;

public class Coin : MonoBehaviour
{
    [SerializeField] private GameObject coinPrefab;
    [SerializeField] private Transform _coinTransform;
    [SerializeField] private float moveSpeed = 2.5f;
    [SerializeField] private float minSpawnDelay = 0.5f;
    [SerializeField] private float maxSpawnDelay = 3f;
    [SerializeField] private bool isSpawner = true;

    private Coroutine _spawnRoutine;

    private void Start()
    {
        if (!isSpawner)
        {
            return;
        }

        /*if (minSpawnDelay > maxSpawnDelay)
        {
            float temp = minSpawnDelay;
            minSpawnDelay = maxSpawnDelay;
            maxSpawnDelay = temp;
        }*/

        _spawnRoutine = StartCoroutine(SpawnLoop());
    }

    private IEnumerator SpawnLoop()
    {
        while (true)
        {
            SpawnCoin();
            float delay = Random.Range(minSpawnDelay, maxSpawnDelay);
            yield return new WaitForSeconds(delay);
            
        }
    }

    private GameObject SpawnCoin()
    {
        GameObject coin = Instantiate(coinPrefab, _coinTransform.position, Quaternion.identity);
        Rigidbody2D coinRb = coin.GetComponent<Rigidbody2D>();
        if (coinRb != null)
        {
            coinRb.velocity = Vector2.left * moveSpeed;
        }

        Coin coinComponent = coin.GetComponent<Coin>();
        if (coinComponent != null)
        {
            coinComponent.DisableSpawning();
        }

        return coin;
    }

    private void OnDisable()
    {
        if (_spawnRoutine != null)
        {
            StopCoroutine(_spawnRoutine);
            _spawnRoutine = null;
        }
    }

    public void DisableSpawning()
    {
        isSpawner = false;
    }
}
