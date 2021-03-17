using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class SoundManager : MonoBehaviour
{
    public AudioSource audioSrc;
    public List<AudioClip> wordSoundList = new List<AudioClip>();
    public AudioClip HELLO, UMBRELLA, SALT, JUMP, SIT, CAT, QUEEN, BUS, BLOND;
    void Start()
    {
        //wordSoundList.Add(HELLO);
        wordSoundList.Insert(0, JUMP);
        wordSoundList.Insert(1, HELLO);
        wordSoundList.Insert(2, SIT);
        wordSoundList.Insert(3, CAT);
        wordSoundList.Insert(4, BUS);
        wordSoundList.Insert(7, QUEEN);
        wordSoundList.Insert(8, SALT);
        wordSoundList.Insert(9, UMBRELLA);
        wordSoundList.Insert(11, BLOND);
    }

    public void playSound(AudioClip audioclip)
    {
        audioSrc.PlayOneShot(audioclip);
    }
}
