using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class SoundManager : MonoBehaviour
{
    public AudioSource audioSrc;
    public AudioClip catExercise01, catExercise02, catExercise03, catExercise04, catExercise05, nameExercise;
    public List<AudioClip> wordSoundList = new List<AudioClip>();
    // public AudioClip HELLO, UMBRELLA, SALT, JUMP, SIT, CAT, QUEEN, BUS, BLOND;
    void Start()
    {

    }

    public void playSound(AudioClip audioclip)
    {
        audioSrc.PlayOneShot(audioclip);
    }

}
