using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hunger : AIAction {

	public override float Evaluate(AnimalAgent agent)
	{
		float evaluation = agent.Hunger;
		return evaluation;
	}

	public override void UpdateAction(AnimalAgent agents)
	{
		agents.NavMeshAgent.SetDestination(agents.FoodSource.transform.position);
	}
}
