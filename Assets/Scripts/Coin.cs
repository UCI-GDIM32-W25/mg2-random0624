using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Coin : MonoBehaviour
{
    [SerializeField] private GameObject coinPrefab;
    [SerializeField] private Transform _coinTransform;
    [SerializeField] private float moveSpeed = 2f;

    private static GameObject _activeCoin;

    private void Start()
    {
        if (_activeCoin == null)
        {
            _activeCoin = SpawnCoin();
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

        return coin;
    }
}
