using System;
using UnityEngine;

public static class EventsManager
{
    public static event Action PlayerShot = delegate { };
    public static event Action<Toy> BulletHitToy = delegate { };

    public static void OnPlayerShot()
    {
        PlayerShot();
    }

    public static void OnBulletHitToy(Toy toy)
    {
        BulletHitToy(toy);
    }
}
