using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class RotatingCoin : MonoBehaviour
{
    [SerializeField] private float rotationSpeed = 100f;
    [SerializeField] private int coinValue = 1;



    void Update()
    {
        Debug.Log("Rotating...");
       transform.Rotate(Vector3.up * rotationSpeed * Time.deltaTime, Space.World);
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            GameManager.Instance.AddScore(coinValue); // ✅ Update score
            Destroy(gameObject); // ✅ Remove the coin
        }
    }
}