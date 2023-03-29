using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SocialPlatforms.Impl;

public class PlayerController : MonoBehaviour
{
    // Start is called before the first frame update

    public CharacterController cc;
    public GameObject fire;
    public Animator animator;

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float hAxis = Input.GetAxis("Horizontal");
        float vAxis = Input.GetAxis("Vertical");

        transform.Rotate(0, 80 * hAxis * Time.deltaTime, 0);

        if (Mathf.Abs(vAxis) > 0)
        {
            animator.SetBool("IsWalking", true);
        }
        else
        {
            animator.SetBool("IsWalking", false);
        }

        cc.Move(transform.forward * 5 * vAxis * Time.deltaTime);

        if (Input.GetKey(KeyCode.Space))
        {
            fire.SetActive(true);
        }
        else 
        {
            fire.SetActive(false);
        }
    }
}
