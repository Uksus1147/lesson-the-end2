using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[RequireComponent(typeof(Animator))]
public class thehand : MonoBehaviour
{
    public Animator animator;
    public bool invokeIKHead = false;
    public Transform head;
    public Transform Key;
    void Start()
    {
        animator = GetComponent<Animator>();
    }
    void OnAnimatorIK()
    {
        if (invokeIKHead)
        {
            animator.SetLookAtWeight(1);
            animator.SetLookAtPosition(head.position);
        }
        else
        {
            animator.SetLookAtWeight(0);
        }
        if (invokeIKHead)
        {
            animator.SetIKPositionWeight(AvatarIKGoal.RightHand, 1);
            animator.SetIKPosition(AvatarIKGoal.RightHand, Key.position);
            animator.SetIKPositionWeight(AvatarIKGoal.LeftHand, 1);
            animator.SetIKPosition(AvatarIKGoal.LeftHand, Key.position);
        }
        else
        {
            animator.SetIKPositionWeight(AvatarIKGoal.LeftHand, 0);
        }
        

    }
}
