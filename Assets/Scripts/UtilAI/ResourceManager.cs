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
	private Material _miniCubeMat;
	

	public override void StartUsing(VRTK_InteractUse usingObject)
	{
		base.StartUsing(usingObject);
		Supply = true;

	}
	
	public override void StopUsing(VRTK_InteractUse usingObject)
	{
		base.StopUsing(usingObject);
	}

	protected override void Update()
	{
		if (Supply)
		{
			_miniCubeMat.color = Color.green;
		}

		if (!Supply)
		{
			_miniCubeMat.color = OriginalColor;
		}
	}

	private void Start()
	{
		_miniCubeMat = MiniCube.GetComponent<Renderer>().material;
		OriginalColor = _miniCubeMat.color;
	}

	public bool GetSupply()
	{
		return Supply;
	}

	public void SetSupply(bool s)
	{
		Supply = s;
	}
}
