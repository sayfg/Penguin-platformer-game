using System.Collections;
using System.Collections.Generic;
using System.Numerics;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.SceneManagement;
using System;

public class Saw12 : MonoBehaviour
{
    public float moveSpeed = 5;
    UnityEngine.Vector3 moveDirection = UnityEngine.Vector3.right;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (transform.position.x < -1)
        {
            transform.position = transform.position + (UnityEngine.Vector3.right * (moveSpeed * 2) * Time.deltaTime);
            moveDirection = UnityEngine.Vector3.right;
        }
        else if (transform.position.x > 6)
        {
            transform.position = transform.position + (UnityEngine.Vector3.left * (moveSpeed * 2) * Time.deltaTime);
            moveDirection = UnityEngine.Vector3.left;
        }
        else
        {
            transform.position = transform.position + (moveDirection * (moveSpeed * 2) * Time.deltaTime);
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        SceneManager.LoadScene("Level 1");
    }
}