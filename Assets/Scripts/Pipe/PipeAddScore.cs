using UnityEngine;

public class PipeAddScore : MonoBehaviour
{
    [SerializeField] private LogicScript logic;
    
    void Start()
    {
        logic = GameObject.FindGameObjectWithTag("Logic").GetComponent<LogicScript>();
    }

    
    void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.layer == 3)
        {
           logic.addScore();
        }
       
    }
}
