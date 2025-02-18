using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class boxScript : MonoBehaviour
{
    private int count;
    public GameObject thePlayer;
    private Vector3 playerPosition;
    private Rigidbody rb;
    public float speed = 20f;
    private NavMeshAgent agent;
    private Enemy theEnemy;

    //this happens before start happens
    void Awake()
    {
        this.theEnemy = new Enemy();
    }
    // Start is called before the first frame update
    void Start() //like a constructor
    {
        CORE.setEnemy(this.theEnemy);
        count = 0;
        rb = this.gameObject.GetComponent<Rigidbody>();
        agent = this.gameObject.GetComponent<NavMeshAgent>();
    }

    // Update is called once per frame
    void Update()
    {
        agent.SetDestination(thePlayer.transform.position);
    }
}
