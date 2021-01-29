using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundControler : MonoBehaviour
{
    // Main sounds

    public AudioClip _MainSound;
    public AudioClip _SorterSound;
    public AudioClip _GuessingSound;
    public AudioClip _AnimalSound;
    public AudioClip _CrabbySound;

    // Click sounds

    public AudioClip _ButtonClick1;
    public AudioClip _ButtonClick2;
    public AudioClip _ButtonClick3;
    public AudioClip _ButtonClick4;

    // Sorter personal sounds

    public AudioClip _StartRuleSorter;
    public AudioClip _RightStep;
    public AudioClip _WrongStep;
    public AudioClip _Victory;

    // Animal personal sounds

    public AudioClip _StartRuleAnimal;

    // Guessing personal sounds

    public AudioClip _StartRuleGuessing;
    public AudioClip _Tup;
    public AudioClip _RightCouple;
    public AudioClip _GuessingVictory;

    // Crabby personal sounds

    public AudioClip _StartRuleCrabby;
    public AudioClip _CrabbyStep;
    public AudioClip _CrabbyClap;
    public AudioClip _RightFigure;
    public AudioClip _WrongFigure;
    public AudioClip _CrabbyVictory;

    //Static varibles

    public static AudioClip MainSound;
    public static AudioClip SorterSound;
    public static AudioClip GuessingSound;
    public static AudioClip AnimalSound;
    public static AudioClip CrabbySound;

    public static AudioClip ButtonClick1;
    public static AudioClip ButtonClick2;
    public static AudioClip ButtonClick3;
    public static AudioClip ButtonClick4;

    public static AudioClip StartRuleSorter;
    public static AudioClip RightStep;
    public static AudioClip WrongStep;
    public static AudioClip Victory;

    public static AudioClip StartRuleAnimal;

    public static AudioClip StartRuleGuessing;
    public static AudioClip Tup;
    public static AudioClip RightCouple;
    public static AudioClip GuessingVictory;

    public static AudioClip StartRuleCrabby;
    public static AudioClip CrabbyStep;
    public static AudioClip CrabbyClap;
    public static AudioClip RightFigure;
    public static AudioClip WrongFigure;
    public static AudioClip CrabbyVictory;


    void Start()
    {
        MainSound = _MainSound;
        SorterSound = _SorterSound;
        GuessingSound = _GuessingSound;
        AnimalSound = _AnimalSound;
        CrabbySound = _CrabbySound;

        ButtonClick1 = _ButtonClick1;
        ButtonClick2 = _ButtonClick2;
        ButtonClick3 = _ButtonClick3;
        ButtonClick4 = _ButtonClick4;

        StartRuleSorter = _StartRuleAnimal;
        RightStep = _RightStep;
        WrongStep = _WrongStep;
        Victory = _Victory;

        StartRuleAnimal = _StartRuleAnimal;

        StartRuleGuessing = _StartRuleGuessing;
        Tup = _Tup;
        RightCouple = _RightCouple;
        GuessingVictory = _GuessingVictory;

        StartRuleCrabby = _StartRuleCrabby;
        CrabbyStep = _CrabbyStep;
        CrabbyClap = _CrabbyClap;
        RightFigure = _RightFigure;
        WrongFigure = _WrongFigure;
        CrabbyVictory = _CrabbyVictory;
    }

    
    void Update()
    {
        
    }
}
