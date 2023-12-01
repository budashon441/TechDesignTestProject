using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class script_animation_sprite : MonoBehaviour
{
    public bool isLooped = false;
    private Animator animator;
    private void Start()
    {
        animator = GetComponent<Animator>();

        if (isLooped)
        {
            animator.SetTrigger("Idle");
        }
    }
    private void OnMouseDown()
    {
        if (!isLooped)
        {
            animator.SetTrigger("Click");
        }
    }
    
}
