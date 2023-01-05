using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PoroController : MonoBehaviour
{
    public Transform homePosition;

    private Animator anim;
    private Transform target;
    [SerializeField]
    private float speed = 0f;
    [SerializeField]
    private float maxRange = 0f;
    [SerializeField]
    private float minRange = 0f;

    // Start is called before the first frame update
    void Start()
    {   
        //get the components
        anim = GetComponent<Animator>();
        target = FindObjectOfType<PukkiMovement03>().transform;
    }

    // Update is called once per frame
    void Update()
    {
        //checking if player is in range of sight that we have been declared in Unity and if player is indeed in that range enemy will follow the player facing the player
        if (Vector3.Distance(target.position, transform.position) <= maxRange && Vector3.Distance(target.position, transform.position) >= minRange)
        {
            FollowPukki();
        }
        //checking if player is over the enemy's range of sight so it will return to homePosition
        else if (Vector3.Distance(target.position, transform.position) >= maxRange)
        {
            ReturnToHomePosition();
        }
    }

    public void FollowPukki()
    {
        //checking if player is moving and facing it into right direction
        anim.SetBool("isMoving", true);
        anim.SetFloat("moveX", (target.position.x - transform.position.x));
        anim.SetFloat("moveY", (target.position.y - transform.position.y));
        transform.position = Vector3.MoveTowards(transform.position, target.position, speed * Time.deltaTime);
    }

    public void ReturnToHomePosition()
    {
        //checking the raindeer x and y value and facing it to towards the homePosition varibale
        anim.SetFloat("moveX", (homePosition.position.x - transform.position.x));
        anim.SetFloat("moveY", (homePosition.position.y - transform.position.y));
        transform.position = Vector3.MoveTowards(transform.position, homePosition.position, speed * Time.deltaTime);

        //checking if enemy is already in homePosition and then play idle anim
        if (Vector3.Distance(transform.position, homePosition.position) == 0)
        {
            anim.SetBool("isMoving", false);
        }
    }
}
