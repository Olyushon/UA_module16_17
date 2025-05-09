using UnityEngine;

public class Dying : IBehaviour
{
    private GameObject _actor;

    public Dying(GameObject actor)
    {
        _actor = actor;
    }

    public void Update(float deltaTime)
    {
        Enemy enemy = _actor.GetComponent<Enemy>();
        
        if (enemy != null)
            enemy.Die();
    }
}
