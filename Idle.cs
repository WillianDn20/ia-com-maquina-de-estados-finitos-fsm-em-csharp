using UnityEngine;
using UnityEngine.AI;

public class Idle : State
{
    public Idle(GameObject _npc, NavMeshAgent _agent, Animator _anim, Transform _player)
        : base(_npc, _agent, _anim, _player)
    {
        state = STATE.IDLE;
    }

    public override void Enter()
    {
        Debug.Log("Entrando no estado IDLE");
        anim.SetTrigger("isIdle");
        base.Enter();
    }

    public override void Update()
    {
        if (CanSeePlayer())
        {
            nextState = new Pursue(npc, agent, anim, player);
            stage = EVENT.EXIT;
        }
        
        if (Random.Range(0, 100) < 10)
        {
            nextState = new Patrol(npc, agent, anim, player);
            stage = EVENT.EXIT;
        }
    }

    public override void Exit()
    {
        Debug.Log("Saindo do estado IDLE");
        // Reseta o gatilho. Isso é necessário para que,
        // caso o trigger não tenha sido executado, ele
        // permaneça como um "evento" a ser executado e isso
        // impede que outros triggers possam ser acionados.
        // Ao resetar o trigger, garantimos que ele possa ser
        // alterado corretamente.
        anim.ResetTrigger("isIdle");
        base.Exit();
    }
}