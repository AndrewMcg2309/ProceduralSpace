using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioSyncer : MonoBehaviour
{
    public float bias;
    public float timeStep;
    public float timeToBeat;
    public float restSmoothTime;


    public float m_previousAudioValue;
    public float m_audioValue;
    public float m_timer;


    public bool m_isBeat;


    public virtual void OnBeat()
    {
        Debug.Log("beat");
        m_timer = 0;
        m_isBeat = true;
    }

    public virtual void OnUpdate()
    {
        m_previousAudioValue = m_audioValue;
        m_audioValue = AudioSpectrum.spectrumValue;

        if(m_previousAudioValue > bias && m_audioValue <= bias)
        {
            if(m_timer > timeStep)
            {
                OnBeat();
            }
        }

        if(m_previousAudioValue <= bias && m_audioValue > bias)
        {
            if(m_timer > timeStep)
            {
                OnBeat();
            }
        }

        m_timer += Time.deltaTime;

    }

    void Update()
    {
        OnUpdate();
    }
}
