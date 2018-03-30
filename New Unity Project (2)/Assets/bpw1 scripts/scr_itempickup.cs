using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class scr_itempickup : MonoBehaviour {

    public float rayDistance;
    public GameObject item;
    public Text Pickuptxt;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        RaycastHit hit;
        Pickuptxt.enabled = false;
        if (Physics.Raycast(transform.position, transform.forward, out hit, rayDistance))
        {
            if (hit.transform.tag == "item")
            {
                Pickuptxt.enabled = true;
            }
            if (Input.GetKey("e") && hit.transform.tag == "item")
            {
                item.SetActive(true);
                Destroy(hit.transform.gameObject);
                Pickuptxt.enabled = false;
                GetComponent<scr_shoot>().enabled = true;
                
            }
        }
		
	}
}
