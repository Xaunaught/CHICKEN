using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OpenGate : MonoBehaviour {
    private Animator anim;
	// Use this for initialization
	void Start () {
        anim = GetComponent<Animator>();
	}
	
	// Update is called once per frame
	void Update () {
	if(Input.GetKeyDown("space") && anim.GetBool("isOpen") == false)
        {
            anim.SetBool("isOpen", true);
        }
    else
        {
            anim.SetBool("isOpen", false);
        }
	}
}
