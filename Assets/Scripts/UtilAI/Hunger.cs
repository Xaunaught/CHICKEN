using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hunger : AIAction
{
	private GameObject _target;
	public override float Evaluate(AnimalAgent agent)
	{
		float evaluation = agent.Hunger;
		return evaluation;
	}

	public override void UpdateAction(AnimalAgent agents)
	{
		
		//TODO: Get this objects position
		//TODO: Set it's target through AnimalAgent
		if (_target != null && _target.GetComponent<ResourceManager>().Supply == null)
		{
			
		}
		//TODO: Distance check between animal and food source
		//TODO: If close enough to food have the animal eat
		//agents.NavMeshAgent.SetDestination(agents.FoodSource.transform.position);
		
	}
	public override void Enter(AnimalAgent agent) //Do Upon Start of Action
	{
		_target = agent.GetTarget();
		Debug.Log("Target should be set");
		agent.NavMeshAgent.SetDestination(agent.GetTarget().transform.position);
	}
	public override void Exit(AnimalAgent agent) //Do Upon End of Action
	{

	}
}
