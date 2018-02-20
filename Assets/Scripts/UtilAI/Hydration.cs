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
		agents.NavMeshAgent.SetDestination(agents.WaterSource.transform.position);
	}
}
