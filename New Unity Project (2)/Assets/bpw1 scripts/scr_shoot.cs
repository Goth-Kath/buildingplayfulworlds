using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class scr_shoot : MonoBehaviour
{
    public float shooteyDistance;
    public GameObject item;
    public MeshRenderer rendd;
    public Color colorr;
    public Color color2;
    public Color color3;
    public MeshRenderer rend2;
    public MeshRenderer rend3;
    public float forcee;
    float count;
    public GameObject victory;

    // Use this for initialization
    void Start()
    {
        count = 0;
        forcee = 2;
    }

 
    void FixedUpdate ()
    {
        if (count == 3)
        {
                victory.SetActive(true);
            
        }
        RaycastHit hit;
        Vector3 forward = transform.TransformDirection(new Vector3(0, 0, shooteyDistance));
        Debug.DrawRay(transform.position, forward, Color.green);
        if (Input.GetMouseButtonDown(0))
        {
            
            if (Physics.Raycast(transform.position, transform.forward, out hit, shooteyDistance))
            {
                if (hit.transform.tag == "orbs")
                {
                    rendd.material.color = colorr;
                    count = count + 1;

                }

                if (hit.transform.tag == "apple")
                {
                    hit.transform.GetComponent<scr_joints>().health -= 1;
                    hit.rigidbody.AddForce(transform.forward * forcee, ForceMode.Impulse);
                }
                
                if (hit.transform.tag == "orbs2")
                {
                    rend2.material.color = color2;
                    count = count + 1;
                }

                if (hit.transform.tag == "orbs3")
                {
                    rend3.material.color = color3;
                    count = count + 1; 
                }
            }
        }
     
    }
   
}
