using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerAttack : MonoBehaviour
{

    Animator animator;
    Object bulletRef;

    // Start is called before the first frame update
    void Start()
    {
        bulletRef = Resources.Load("Bullet") as GameObject;
        animator = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetButtonDown("Fire1"))
        {
            animator.Play("attack");
            GameObject bullet = (GameObject)Instantiate(bulletRef);
            bullet.transform.position = new Vector3(transform.position.x + .4f,transform.position.y + .2f,-1);
        }

    }
}
