using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class SoundManager : MonoBehaviour
{
    public AudioSource audioSrc;
    public AudioClip helloExercise01, nameExercise01, nameExercise02, catExercise01, catExercise02, catExercise03, catExercise04, catExercise05, saltExercise01;
    public List<AudioClip> wordSoundList = new List<AudioClip>();
    // public AudioClip HELLO, UMBRELLA, SALT, JUMP, SIT, CAT, QUEEN, BUS, BLOND;

    public void playSound(AudioClip audioClip)
    {
        audioSrc.PlayOneShot(audioClip);
    }
}
