using System;
using System.Collections;
using System.Collections.Generic;
using Sirenix.OdinInspector;
using Sirenix.Utilities;
using UnityEngine;
using UnityEngine.AI;
using Random = UnityEngine.Random;

public class AnimalAgent : MonoBehaviour
{
	public float StatUpdateDelay;
	public float Hunger;
	public float Hydration;
	public float Affection;
	public float Health;
	
	private GameObject _closestResource;


	public GameObject FoodSources;

	public NavMeshAgent NavMeshAgent;
	
	public AIAction[] Actions;
	private AIAction _currentAction;

	private void Start()
	{
		NavMeshAgent = GetComponent<NavMeshAgent>();
		StartCoroutine("StatsUpdate");
	}


	private void Update()
	{
		var best = Calculate();
		
		//--Update Current Action--\\
		if (best != _currentAction)
		{
			if (_currentAction)
				_currentAction.Exit(this); //do that action's exit funtion
			_currentAction = best; //switch to best action
			if (_currentAction)
				_currentAction.Enter(this); //do new action's enter function 
		}
		if (_currentAction) //If not null
			_currentAction.UpdateAction(this); //Do the current action's Update Fuction
		
	}

	private AIAction Calculate()
	{
		float bestValue = 0;
		AIAction action = null;
		foreach (var a in Actions)
		{
			var value = a.Evaluate(this);

			a.Urgency = value;
			if (action == null || value > bestValue)
			{
				action = a;
				bestValue = value;
			}
		}

		return action;
	}

	private void OnTriggerEnter(Collider other)
	{
		if (other.CompareTag("Food"))
		{
			Hunger = 0;
			//TODO: Play eating animation
			_closestResource.GetComponent<ResourceManager>().Supply = false;
		}
	}

	private IEnumerator StatsUpdate()
	{
		//TODO: update all of the stats
		Hunger += Random.Range(0,5);
		yield return new WaitForSeconds(StatUpdateDelay);
		StartCoroutine("StatsUpdate");
	}

	public GameObject GetTarget()
	{
		ResourceManager[] targetList = FoodSources.GetComponentsInChildren<ResourceManager>();
		Debug.Log(targetList.Length + " food sources");
		float shortestDistance = Mathf.Infinity;
		
		foreach (var target in targetList)
		{
			float distance = Vector3.Distance(target.transform.position, transform.position);
			if (distance < shortestDistance && target.Supply)
			{
				Debug.Log("Something was found to be shorter");
				_closestResource = target.gameObject;
				shortestDistance = distance;
			}
		}

		return _closestResource;
	}
}
