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
                    ControlScript.Audio.PlayOneShot(SoundControler.SorterSound);
                    ControlScript.SecondAudio.PlayOneShot(SoundControler.StartRuleSorter);
                }
                break;
            case "AnimalsIcon":
                {
                    ControlScript.Audio.PlayOneShot(SoundControler.AnimalSound);
                    ControlScript.SecondAudio.PlayOneShot(SoundControler.StartRuleAnimal);
                }
                break;
            case "GuessingIcon":
                {
                    ControlScript.Audio.PlayOneShot(SoundControler.GuessingSound);
                    ControlScript.SecondAudio.PlayOneShot(SoundControler.StartRuleGuessing);
                }
                break;
            case "CrabbyIcon":
                {
                    ControlScript.Audio.PlayOneShot(SoundControler.CrabbySound);
                    ControlScript.SecondAudio.PlayOneShot(SoundControler.StartRuleCrabby);
                }
                break;
        }
    }
}
