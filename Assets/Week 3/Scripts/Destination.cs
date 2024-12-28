using UnityEngine;
using UnityEngine.AI;

public class AgentController : MonoBehaviour
{
    public Transform destination; // Điểm đến được gắn qua Inspector

    private NavMeshAgent agent;

    void Start()
    {
        // Lấy NavMesh Agent từ đối tượng hiện tại
        agent = GetComponent<NavMeshAgent>();

        // Đặt điểm đến nếu có
        if (agent != null && destination != null)
        {
            agent.SetDestination(destination.position);
        }
        else
        {
            Debug.LogWarning("NavMesh Agent hoặc Destination chưa được thiết lập!");
        }
    }
}

