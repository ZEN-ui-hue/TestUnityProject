using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class Target : MonoBehaviour
{
    private float speed = 4.0f;
    private Rigidbody targetRb;

    void Start()
    {
        targetRb = GetComponent<Rigidbody>();
        // Проверь, что targetRb не null
        if (targetRb == null)
            Debug.LogError("Rigidbody не найден!");
    }

    void Update()
    {
        // Используем velocity, а не angularVelocity
        Vector3 newVelocity = targetRb.linearVelocity;
        newVelocity.z = -speed;
        targetRb.linearVelocity = newVelocity;
    }
    private void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.CompareTag("Water"))
        {
            Destroy(gameObject);
        }
    }
}
