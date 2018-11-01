using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class movement : MonoBehaviour
{
    public List<Transform> PatrolPoints;
    private int _currentPoint;
    private NavMeshAgent _myAgent;



    // Use this for initialization
    void Start()
    {
        _myAgent = GetComponent<NavMeshAgent>();
        SetDestination();

    }

    // Update is called once per frame
    void Update()
    {
        if (_myAgent.remainingDistance <= _myAgent.stoppingDistance)
        {
            if (PatrolPoints.Count > _currentPoint + 1)
            {
                _currentPoint++;
            }
            else
            {
                _currentPoint = 0;
            }
            SetDestination();
        }


    }


    private void SetDestination()
    {
        _myAgent.SetDestination(PatrolPoints[_currentPoint].position);
    }
}