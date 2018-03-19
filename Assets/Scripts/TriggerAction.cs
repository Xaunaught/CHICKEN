using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using VRTK;

public class TriggerAction : VRTK_InteractableObject {

	private Animator anim;
	
	public override void StartUsing(VRTK_InteractUse usingObject)
	{
		base.StartUsing(usingObject);
		PlayAnim();
	}
	
	public override void StopUsing(VRTK_InteractUse usingObject)
	{
		base.StopUsing(usingObject);
	}
	
	void Start () {
		anim = GetComponent<Animator>();
	}
	
	void PlayAnim()
	{
		if (anim.GetBool("isOpen") == false)
		{
			anim.SetBool("isOpen", true);
		}
		else if (anim.GetBool("isOpen") == true)
		{
			anim.SetBool("isOpen", false);
		}
	}
}
