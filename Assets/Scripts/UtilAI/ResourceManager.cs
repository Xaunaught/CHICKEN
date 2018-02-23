using System.Collections;
using System.Collections.Generic;
using Sirenix.OdinInspector;
using UnityEngine;
using VRTK;

public class ResourceManager : VRTK_InteractableObject
{

	//public bool Food;
	//public bool Water;
	//public bool Health;
	public bool Supply;
	public GameObject MiniCube;
	public Color OriginalColor;
	private Material MiniCubeMat;
	

	public override void StartUsing(VRTK_InteractUse usingObject)
	{
		base.StartUsing(usingObject);
		Supply = true;

	}
	
	public override void StopUsing(VRTK_InteractUse usingObject)
	{
		base.StopUsing(usingObject);
	}

	private void Update()
	{
		if (Supply)
		{
			MiniCubeMat.color = Color.green;
		}

		if (!Supply)
		{
			MiniCubeMat.color = OriginalColor;
		}
	}

	private void Start()
	{
		MiniCubeMat = MiniCube.GetComponent<Renderer>().material;
		OriginalColor = MiniCubeMat.color;
	}
}
