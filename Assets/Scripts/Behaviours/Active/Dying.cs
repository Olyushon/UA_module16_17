using UnityEngine;

public class Dying : IActBehaviour
{
    public void Act(GameObject actor, GameObject target, float deltaTime)
    {
        Enemy enemy = actor.GetComponent<Enemy>();

        if (enemy != null)
            enemy.Die();
    }
}
