using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AttackAtRange : StateMachineBehaviour
{
    // Start is called before the first frame update
    TowerManager tm;

    //on state enter is called when a transistion starts and the state machine starts to evaluate this state
    override public void OnStateEnter(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
    {
        tm = animator.GetComponent<TowerManager>();
        animator.speed = tm.self.attackRange;
    }
    override public void OnStateUpdate(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
    {
        if(tm.currentTarget != null)
        {
            tm.AttackTarget();
        }
        else
        {
            animator.SetBool("hasTarget", false);
        }    

    }
    public override void OnStateExit(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
    {
        animator.speed = 1;
    }
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
