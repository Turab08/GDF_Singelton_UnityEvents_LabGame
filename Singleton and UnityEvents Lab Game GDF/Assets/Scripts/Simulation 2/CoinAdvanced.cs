using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoinAdvanced : MonoBehaviour
{
    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            OnPickUp();
        }
    }

    void OnPickUp()
    {
        AudioManager.Instance.PlaySFX(AudioManager.Instance.coin);
        ScoreManager.Instance.AddScore(1);
        Destroy(gameObject);
    }
}
