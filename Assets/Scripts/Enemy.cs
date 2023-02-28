using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;
using UnityEngine.UI;

public class Enemy : MonoBehaviour
{
    protected Transform target;
    
    private float timer = 0;
    [SerializeField]
    private float timertotal = 1;
    protected NavMeshAgent nav;

    // Start is called before the first frame update
    protected virtual void Start()
    {
        //hp = hpTotal;
        target = GameManager.instance.player;
        nav = GetComponent<NavMeshAgent>();
    }

    // Update is called once per frame
    protected virtual void Update()
    {
        TimerTool();
    }
    private void TimerTool()
    {
        if (timer > timertotal)
        {
            timer = 0;
            TimerContent();
        }
        else
        {
            timer += Time.deltaTime;
        }
    }
    protected virtual void TimerContent()
    {
        if(GameManager.instance.TreasureTaken == true)
        {
            nav.SetDestination(target.position);
        }
    }
}
