using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class ajanlar : MonoBehaviour
{

    NavMeshAgent agent;
    /*  public GameObject hedef1;
      public GameObject hedef2;*/

    public GameObject[] hedefler;
    // private string mevcuthedef;
    private int mevcuthedef;


    void Start()
    {
        agent = GetComponent<NavMeshAgent>();
        mevcuthedef = 0;
        agent.SetDestination(hedefler[mevcuthedef].transform.position);
       
    }

    // Update is called once per frame
    void Update()
    {

      //  agent.SetDestination(hedef.transform.position);
        
    }

    private void OnTriggerEnter(Collider other)
    {
       
        if (mevcuthedef==0)
        {
            mevcuthedef = 1;
            agent.SetDestination(hedefler[mevcuthedef].transform.position);
        }
        else
        {
            mevcuthedef = 0;
            agent.SetDestination(hedefler[mevcuthedef].transform.position);
        }
        
    }
}
