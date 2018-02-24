using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hunger : AIAction
{
	private GameObject _target;
	private ResourceManager _supply;
	public override float Evaluate(AnimalAgent agent)
	{
		float evaluation = agent.Hunger;
		return evaluation;
	}

	public override void UpdateAction(AnimalAgent agents)
	{
		if (_target != null && _supply.GetSupply())
		{
			agents.NavMeshAgent.SetDestination(_target.transform.position);
		}
		else if (_supply.GetSupply() == false)
		{
			_target = agents.GetTarget();
			_supply = _target.GetComponent<ResourceManager>();
		}
		if (_target.transform.position.magnitude - agents.transform.position.magnitude < 1f)
		{
			_supply.SetSupply(false);
			agents.Hunger = 0;
		}
	}
	public override void Enter(AnimalAgent agent) //Do Upon Start of Action
	{
		_target = agent.GetTarget();
		if (_target)
		{
			_supply = _target.GetComponent<ResourceManager>();
		}
	}
	public override void Exit(AnimalAgent agent) //Do Upon End of Action
	{

	}
	
	private void OnTriggerEnter(Collider other)
	{
		if (other == _target)
		{
		}
	}
}
