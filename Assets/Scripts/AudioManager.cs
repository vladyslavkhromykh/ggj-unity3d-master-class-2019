using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioManager : MonoBehaviour
{
    private AudioSource source;
    private AudioClip shoot;
    private AudioClip hit;

    private void Awake()
    {
        source = GetComponent<AudioSource>();
        shoot = Resources.Load<AudioClip>("Audio/cannon-shot");
        hit = Resources.Load<AudioClip>("Audio/cannon-hit");

        EventsManager.PlayerShot += delegate { source.PlayOneShot(shoot); };
        EventsManager.BulletHitToy += delegate { source.PlayOneShot(hit); };
    }
}
