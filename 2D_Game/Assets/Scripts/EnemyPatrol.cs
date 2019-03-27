using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyPatrol : MonoBehaviour
{
    //movement variables
    public float moveSpeed;
    public bool moveRight;
    //wall check
    public Transform wallCheck;
    public float wallCheckRadius;
    public LayerMask whatIsWall;
    private bool hittingWall;
    //edge check
    bool notAtEdge;
    public Transform edgeCheck;
    public Vector3 scale;
    // Start is called before the first frame update
    void Start()
    {
        scale = transform.localScale;
        
    }

    // Update is called once per frame
    void Update()
    {
        notAtEdge = Physics2D.OverlapCircle(edgeCheck.position, wallCheckRadius, whatIsWall);

        hittingWall = Physics2D.OverlapCircle(edgeCheck.position, wallCheckRadius, whatIsWall);

        if(hittingWall || !notAtEdge){
            moveRight = !moveRight;
        }

        if (moveRight){
            transform.localScale = new Vector3(-scale.x,scale.y,scale.z);
            GetComponent<Rigidbody2D>().velocity = new Vector2(moveSpeed, GetComponent<Rigidbody2D>().velocity.y);
        }
        else {
            transform.localScale = new Vector3(scale.x,scale.y,scale.z);
            GetComponent<Rigidbody2D>().velocity = new Vector2(-moveSpeed, GetComponent<Rigidbody2D>().velocity.y);
        }
        
    }
}
