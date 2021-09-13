using UnityEngine;
using UnityEngine.AI;

public class AiControl : MonoBehaviour
{
    // Start is called before the first frame update

    NavMeshAgent agent;
    [SerializeField] Transform[] destinations;
    private string mevcuthedef;
    void Start()
    {
        agent = gameObject.GetComponent<NavMeshAgent>();
        mevcuthedef = "hedef1";
        // agent.SetDestination(destination1.transform.position);
        agent.SetDestination(destinations[0].position);
        agent.speed = 3f;
        agent.acceleration = 2f;
        agent.stoppingDistance = 2f;

    }


    // Update is called once per frame
    void Update()
    {


        for (int i = 0; i < destinations.Length; i++)
        {
            agent.SetDestination(destinations[i].position);
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.name == "hedef2")
        {
            mevcuthedef = "hedef1";
            agent.SetDestination(destinations[0].transform.position);
        }
        else
        {
            mevcuthedef = "hedef2";
            agent.SetDestination(destinations[1].transform.position);
        }



    }
}
