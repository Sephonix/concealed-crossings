using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimationStateController : MonoBehaviour

{

    Animator animator;
    int isWalkingHash;
    int isRunningHash;
    public KeyCode sprintInput = KeyCode.LeftShift;


    // Start is called before the first frame update
    void Start()
    {
        animator = GetComponent<Animator>();

        //increases performance when using StringToHash
        isWalkingHash = Animator.StringToHash("isWalking");
        isRunningHash = Animator.StringToHash("isRunning");


    }

    // Update is called once per frame
    void Update()
    {
        //bool runPressed = false;
        bool forwardPressed = false;
        bool isRunning = animator.GetBool(isRunningHash);
        bool isWalking = animator.GetBool(isWalkingHash);

        if (Input.GetAxis("Horizontal") != 0f)
        {
            forwardPressed = true;
        } else 
        {
            forwardPressed = false;

        }

        /*if (Input.GetKeyDown(sprintInput))
            cc.Sprint(true);
        else if (Input.GetKeyUp(sprintInput))
            cc.Sprint(false);*/

        //Walking Controller
        if (forwardPressed == true)
        {
            animator.SetBool("isWalking", true);
        
        }
        if (forwardPressed == false)
        {
            animator.SetBool("isWalking", false);

        }
    }
}
