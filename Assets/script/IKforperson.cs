using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[RequireComponent(typeof(Animator))]
public class IKforperson : MonoBehaviour
{
    public Animator anim;
    public bool InvokeIk = false;
    public Transform head;
    void Start()
    {
        anim = GetComponent<Animator>();
    }

    void Update()
    {
        if (InvokeIk)
        {
            anim.SetLookAtPosition(head.position);
            anim.SetLookAtWeight(1);
        }
        else
        {
            anim.SetLookAtWeight(0);
        }
    }
}
