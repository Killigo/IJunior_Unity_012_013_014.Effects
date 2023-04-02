using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ParticleManager : MonoBehaviour
{
    [SerializeField] private ParticleSystem _glowParticle;

    private int _playCount = 3;

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            _glowParticle.Play();
        }
    }

    //void Update()
    //{
    //    if (_playCount > 0)
    //    {
    //        if (!_glowParticle.isPlaying)
    //        {
    //            _glowParticle.Play();
    //            _playCount--;
    //        }
    //    }
    //    else
    //    {
    //        _glowParticle.Stop();
    //    }
    //}
}
