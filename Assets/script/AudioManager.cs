using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum AudioClipType
{
    die,
    hit,
    point,
    wing
}

public class AudioManager : MonoBehaviour {

    public static AudioManager _instance;
    public AudioClip[] allAudioClips;
    public AudioSource audioSourceOther;

	// Use this for initialization
	void Awake () {
        _instance = this;
    }
	
	public void setAudio(AudioClipType index)
    {
        audioSourceOther.clip = allAudioClips[(int)index];
        audioSourceOther.Play();
    }
}
