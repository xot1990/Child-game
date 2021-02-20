using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Starting : MonoBehaviour
{
    public void MusicON()
    {
        switch (gameObject.name)
        {
            case "SorterIcon":
                {
                    ControlScript.Audio.clip = SoundControler.SorterSound;
                    ControlScript.Audio.Play();
                    ControlScript.SecondAudio.PlayOneShot(SoundControler.StartRuleSorter);
                }
                break;
            case "AnimalsIcon":
                {
                    ControlScript.Audio.clip = SoundControler.AnimalSound;
                    ControlScript.Audio.Play();
                    ControlScript.SecondAudio.PlayOneShot(SoundControler.StartRuleAnimal);
                }
                break;
            case "GuessingIcon":
                {
                    ControlScript.Audio.clip = SoundControler.GuessingSound;
                    ControlScript.Audio.Play();
                    ControlScript.SecondAudio.PlayOneShot(SoundControler.StartRuleGuessing);
                }
                break;
            case "CrabbyIcon":
                {
                    ControlScript.Audio.clip = SoundControler.CrabbySound;
                    ControlScript.Audio.Play(); 
                    ControlScript.SecondAudio.PlayOneShot(SoundControler.StartRuleCrabby);
                }
                break;
        }
    }
}
