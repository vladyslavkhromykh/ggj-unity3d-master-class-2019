using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioManager : MonoBehaviour
{
    private AudioSource source;

    private void Awake()
    {
        source = GetComponent<AudioSource>();
        var shoot = Resources.Load<AudioClip>("Audio/player-shot");
        var hit = Resources.Load<AudioClip>("Audio/bullet-hit");
        var cannon = Resources.Load<AudioClip>("Audio/cannon-shot");

        EventsManager.ToySpawn += delegate { source.PlayOneShot(cannon, 0.02f); };
        EventsManager.PlayerShot += delegate { source.PlayOneShot(shoot, 0.2f); };
        EventsManager.BulletHitToy += delegate { source.PlayOneShot(hit, 0.5f); };
    }
}
