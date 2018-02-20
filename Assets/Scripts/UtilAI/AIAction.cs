using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class AIAction : MonoBehaviour {

	public abstract float Evaluate(AnimalAgent agent);
	public abstract void UpdateAction(AnimalAgent agents);

	public float Urgency;
}
