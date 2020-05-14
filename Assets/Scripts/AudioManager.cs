using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioManager : MonoBehaviour{
    // Start is called before the first frame update
    public AudioSource JumpSound;
    public AudioSource CoinSound;

    public void PlayJump(){
      JumpSound.Play();
    }

    public void PlayCoin(){
      CoinSound.Play();
    }

    public static void MuteAllSound(){
        AudioListener.volume = 0;
    }
}

