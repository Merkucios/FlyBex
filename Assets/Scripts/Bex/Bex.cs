using UnityEngine;

public class Bex : MonoBehaviour
{
    private Rigidbody2D bexRigidbody;
    [SerializeField] private Transform bexPos;
    [SerializeField] private float flapStrength;
    [SerializeField] private LogicScript logic;
    private bool bexIsAlive = true;

    void Start()
    {
        bexRigidbody = GetComponent<Rigidbody2D>();
        bexPos = GetComponent<Transform>();
        flapStrength = 7.2f;
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space) && bexIsAlive)
        {
            bexRigidbody.velocity = Vector2.up * flapStrength;
        }
        if (bexPos.position.y < -25)
        {
            logic.gameOver();
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        logic.gameOver();
        bexIsAlive = false;
    }
}
