using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bex : MonoBehaviour
{
    [SerializeField] private Rigidbody2D bexRigidbody;
    [SerializeField] private float flapStrength = 8.5f;

    void Start()
    {
        bexRigidbody = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            bexRigidbody.velocity = Vector2.up * 8.5f;
        }
    }
}
