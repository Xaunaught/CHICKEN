using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class AnimalAgent : MonoBehaviour
{

	public float Hunger;
	public float Hydration;
	public float Affection;
	public float Health;

	public GameObject FoodSource;
	public GameObject WaterSource;

	public NavMeshAgent NavMeshAgent;
	
	public AIAction[] Actions;
	private AIAction _currentAction;

	private void Start()
	{
		NavMeshAgent = GetComponent<NavMeshAgent>();
	}

	private void Update()
	{
		Calculate();
		_currentAction.UpdateAction(this);
		
	}

	void Calculate()
	{
		float bestValue = 0;
		foreach (AIAction action in Actions)
		{
			float value = action.Evaluate(this);

			action.Urgency = value;
			if (_currentAction == null || value > bestValue)
			{
				_currentAction = action;
				bestValue = value;
			}
		}
	}

	private void OnTriggerEnter(Collider other)
	{
		Debug.Log("Hit object");
		if (other.CompareTag("Food"))
		{
			Hunger = 0;
		}
	}
}
