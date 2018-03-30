using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class scr_joints : MonoBehaviour {
    public float health;
    


	// Use this for initialization
	
	
	// Update is called once per frame
	void Update () {
        
        if (health <= 1)
        {
            GetComponent<FixedJoint>().breakForce = -1;
            Destroy(GetComponent<scr_joints>());
        }
        
        Debug.Log(health);
		
	}
  
}
