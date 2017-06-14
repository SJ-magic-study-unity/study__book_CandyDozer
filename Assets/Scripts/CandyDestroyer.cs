using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CandyDestroyer : MonoBehaviour {
	public CandyHolder candyHolder;
	public int reward;
	public GameObject effectPrefab;
	public Vector3 effectRotation;
	
	void OnTriggerEnter(Collider other){
		if(other.gameObject.tag == "Candy"){
			candyHolder.AddCandy(reward);
			
			Destroy(other.gameObject);
			
			if(effectPrefab != null){
				Instantiate(
					effectPrefab,
					other.transform.position,
					Quaternion.Euler(effectRotation)
				);
			}
		}
	}
	
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
