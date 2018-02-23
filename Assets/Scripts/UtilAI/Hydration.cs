using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hydration : AIAction {

	public override float Evaluate(AnimalAgent agent)
	{
		float evaluation = agent.Hydration;
		return evaluation;
	}

	public override void UpdateAction(AnimalAgent agents)
	{
		//agents.NavMeshAgent.SetDestination(agents.WaterSource.transform.position);
	}
	
	public override void Enter(AnimalAgent agent) //Do Upon Start of Action
	{

	}
	public override void Exit(AnimalAgent agent) //Do Upon End of Action
	{

	}
}
