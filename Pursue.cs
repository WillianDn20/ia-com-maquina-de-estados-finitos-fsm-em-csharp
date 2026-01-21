using UnityEngine.AI;
using UnityEngine;

using UnityEngine;
using UnityEngine.AI;

public class Pursue : State
{
    public Pursue(GameObject _npc, NavMeshAgent _agent, Animator _anim, Transform _player)
        : base(_npc, _agent, _anim, _player)
    {
        state = STATE.PURSUE;
        agent.speed = 5;
        agent.isStopped = false;
    }

    public override void Enter()
    {
        anim.SetTrigger("isRunning");
        base.Enter();
    }

    public override void Update()
    {
        agent.SetDestination(player.position);
        // o teste é para garantir que todos os cálculos
        // necessários para a navegação sejam feitos antes de
        // verificar executar ações que dependem desses cálculos
        if (agent.hasPath)
        {
            if (CanAttackPlayer())
            {
                nextState = new Attack(npc, agent, anim, player);
                stage = EVENT.EXIT;
            }
            else if (!CanSeePlayer())
            {
                nextState = new Patrol(npc, agent, anim, player);
                stage = EVENT.EXIT;
            }
        }
    }

    public override void Exit()
    {
        anim.ResetTrigger("isRunning");
        base.Exit();
    }
}