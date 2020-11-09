using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class ControlScript : MonoBehaviour
{
    public static bool RightFragment;
    public static bool FragmentOnCenter;
    public static bool TourchDown;
    public static int SelectedFragment;
    public static int SelectedSensFild;
    public static GameObject Field;
    public static int WinTimer;
    public static int TotalTimer = 0;
    public static int Life = 6;
    public static int _Score = 0;
    public static GameObject ActiveTile1 = null;
    public static GameObject ActiveTile2 = null;



    //Ini GO

    public static GameObject Self;
    public static GameObject MainMenu;
    
    public static GameObject Sorter;
    public static GameObject SorterBack;
    public static GameObject SorterLenar;
    public static GameObject SorterFigures;
    public static GameObject SorterMenuNextLvL;
    public static GameObject SorterMenuGameOver;
    
    public static GameObject[] SensFilds;
    public static GameObject[] Figures;
    public static GameObject[] Tiles;
    public static GameObject[] ActiveTile;

    public static GameObject AnimalSound;
    public static GameObject AnimalImage;

    public static GameObject Guessing;
    public static GameObject GuessingContent;
    public static GameObject GuessingMenuNextLvL;
    public static GameObject GuessingMenuGameOver;


    // GameLvL

    public static int SorterLvL = 1;
    public static int GuessingLvL = 2;

    // Audio

    public AudioSource Audio;
    public AudioClip MenuMusic;

    private void Awake()
    {
        Data.SorterList.Initialize();
        Ini();
    }

    void Start()
    {
        
    }

    
    void Update()
    {
        
    }

    public void OnItem()
    {
        FragmentOnCenter = true;
    }

    public void OutItem()
    {
        FragmentOnCenter = false;
    }

    public void Ini()
    {
        Sorter = GameObject.Find("Sorter");        
        SorterBack = GameObject.Find("BackGround");
        SorterLenar = GameObject.Find("Lenar");
        SorterFigures = GameObject.Find("Figures");
        SorterMenuNextLvL = GameObject.Find("MenuNextLvL");
        SorterMenuGameOver = GameObject.Find("MenuGameOver");       
        SensFilds = GameObject.FindGameObjectsWithTag("SensFild");
        Figures = GameObject.FindGameObjectsWithTag("Figure");
        MainMenu = GameObject.Find("MainMenu");
        AnimalSound = GameObject.Find("AnimalSound");
        AnimalImage = GameObject.Find("AnimalImage");
        Tiles = GameObject.FindGameObjectsWithTag("Tile");
        Guessing = GameObject.Find("Guessing");
        GuessingContent = GameObject.Find("Tiles");
        GuessingMenuNextLvL = GameObject.Find("MenuNextLvLFrut");
        GuessingMenuGameOver = GameObject.Find("MenuGameOverFrut");
        
        Self = gameObject;

        // Off Go
        
        Sorter.SetActive(false);
        SorterMenuNextLvL.SetActive(false);
        SorterMenuGameOver.SetActive(false);
        GuessingMenuNextLvL.SetActive(false);
        GuessingMenuGameOver.SetActive(false);
        AnimalSound.SetActive(false);
        foreach(var Te in Tiles)
        {
            Te.SetActive(false);
        }
        Guessing.SetActive(false);
    }

    public void NextLvl()
    {
        if (SorterLvL < 8)
        {
            SorterLvL++;

            foreach (var F in Figures)
            {
                F.transform.parent = SorterFigures.transform;
                F.transform.position = F.GetComponent<FragmentScript>().StartPos;
                F.transform.localScale = new Vector3(0.1f, 0.1f, 0.1f);
                F.GetComponent<RectTransform>().rotation = Quaternion.Euler(0, 0, 0);
                F.GetComponent<Image>().sprite = null;
                F.GetComponent<Image>().raycastTarget = true;
                F.SetActive(true);
            }
            TotalTimer = 0;
            SorterMenuNextLvL.SetActive(false);
            IniSorter();
        }
        else
        {
            foreach (var F in Figures)
            {
                F.transform.parent = SorterFigures.transform;
                F.transform.position = F.GetComponent<FragmentScript>().StartPos;
                F.transform.localScale = new Vector3(0.1f, 0.1f, 0.1f);
                F.GetComponent<RectTransform>().rotation = Quaternion.Euler(0, 0, 0);
                F.GetComponent<Image>().sprite = null;
                F.GetComponent<Image>().raycastTarget = true;
                F.SetActive(true);
            }
            TotalTimer = 0;
            SorterMenuNextLvL.SetActive(false);
            IniSorter();
        }
    }

    public void ResetLvl()
    {        
        foreach (var F in Figures)
        {
            F.transform.parent = SorterFigures.transform;
            F.transform.position = F.GetComponent<FragmentScript>().StartPos;
            F.transform.localScale = new Vector3(0.1f, 0.1f, 0.1f);
            F.GetComponent<RectTransform>().rotation = Quaternion.Euler(0, 0, 0);
            F.GetComponent<Image>().sprite = null;
            F.GetComponent<Image>().raycastTarget = true;
            F.SetActive(true);
        }
        TotalTimer = 0;
        SorterMenuNextLvL.SetActive(false);
        IniSorter();
    }

    public void NewGame()
    {
        foreach (var F in Figures)
        {
            F.transform.parent = SorterFigures.transform;
            F.transform.position = F.GetComponent<FragmentScript>().StartPos;
            F.transform.localScale = new Vector3(0.1f, 0.1f, 0.1f);
            F.GetComponent<RectTransform>().rotation = Quaternion.Euler(0, 0, 0);
            F.GetComponent<Image>().sprite = null;
            F.GetComponent<Image>().raycastTarget = true;
            F.SetActive(true);
        }
        TotalTimer = 0;
        SorterLvL = 1;
        
        SorterMenuNextLvL.SetActive(false);
        SorterMenuGameOver.SetActive(false);
        IniSorter();
    }

    public void BackToMenu()
    {
        foreach (var F in Figures)
        {
            F.transform.parent = SorterFigures.transform;
            F.transform.position = F.GetComponent<FragmentScript>().StartPos;
            F.transform.localScale = new Vector3(0.1f, 0.1f, 0.1f);
            F.GetComponent<RectTransform>().rotation = Quaternion.Euler(0, 0, 0);
            F.GetComponent<Image>().sprite = null;
            F.GetComponent<Image>().raycastTarget = true;
            F.SetActive(true);
        }
        TotalTimer = 0;
        SorterLvL = 1;
        
        SorterMenuNextLvL.SetActive(false);
        SorterMenuGameOver.SetActive(false);
        Sorter.SetActive(false);
        MainMenu.SetActive(true);

    }

    public void IniSorter()
    {
        WinTimer = Figures.Length;
        List<int> ColorID = new List<int>();
        List<int> ColorCount = new List<int>();
        List<int> FormID = new List<int>();
        List<int> FormCount = new List<int>();
        List<int> FigureID = new List<int>();
        List<int> HoleID = new List<int>();
        int HoleCount = 0;
        bool stopwhile1 = true;
        bool stopwhile2 = true;
        int C;

        switch (SorterLvL)
            {

            case 1:
                {
                    int A = Random.Range(0, 9);

                    foreach (var F in SensFilds)
                    {
                        
                        int R = Random.Range(0, 8);
                        F.transform.GetChild(0).GetComponent<Image>().sprite = Data.SorterList.holes.Find(X => X.ColorID == A && X.FormID == R).sprite;                        
                        ColorID.Add(A);
                        FormID.Add(R);
                        HoleCount++;
                        string Q = "" + R + A;
                        int.TryParse(Q, out C);
                        F.GetComponent<SensFildScript>().ID = C;
                        HoleID.Add(C);
                       
                    }
                    
                    foreach (var U in Figures)
                    {
                        if (FigureID.Count < HoleCount)
                        {
                            while (stopwhile2)
                            {                                
                                int t = Random.Range(0, HoleCount);
                                if(!FigureID.Contains(t))
                                {
                                    U.GetComponent<Image>().sprite = Data.SorterList.figures.Find(X => X.ColorID == ColorID[t] && X.FormID == FormID[t]).OnShadow;
                                    stopwhile2 = false;
                                    FigureID.Add(t);
                                    U.GetComponent<FragmentScript>().ID = HoleID[t];
                                    U.GetComponent<Animator>().SetBool("Deselected", true);
                                }
                                
                            }
                            stopwhile2 = true;
                        }
                        else
                        {
                            int G = Random.Range(0, HoleCount);
                            U.GetComponent<Image>().sprite = Data.SorterList.figures.Find(X => X.ColorID == ColorID[G] && X.FormID == FormID[G]).OnShadow;                            
                            U.GetComponent<FragmentScript>().ID = HoleID[G];
                            U.GetComponent<Animator>().SetBool("Deselected", true);
                        }
                    }
                }
            break;

            case 2:
                {
                    
                    for(; ColorCount.Count < 2;)
                    {
                        int A = Random.Range(0, 9);
                        if (!ColorCount.Contains(A)) ColorCount.Add(A);
                    }

                    for (;FormCount.Count < 2;)
                    {
                        int R = Random.Range(0, 2);
                        if (!FormCount.Contains(R)) FormCount.Add(R);
                    }


                    foreach (var F in SensFilds)
                    {
                        int A = ColorCount[Random.Range(0, ColorCount.Count)];
                        int R = FormCount[Random.Range(0, FormCount.Count)];
                        F.transform.GetChild(0).GetComponent<Image>().sprite = Data.SorterList.holes.Find(X => X.ColorID == A && X.FormID == R).sprite;                        
                        HoleCount++;
                        ColorID.Add(A);
                        FormID.Add(R);
                        string Q = "" + R + A;                        
                        int.TryParse(Q, out C);
                        F.GetComponent<SensFildScript>().ID = C;
                        HoleID.Add(C);

                    }

                    foreach (var U in Figures)
                    {
                        if (FigureID.Count < HoleCount)
                        {
                            while (stopwhile2)
                            {
                                int t = Random.Range(0, HoleCount);
                                if (!FigureID.Contains(t))
                                {
                                    U.GetComponent<Image>().sprite = Data.SorterList.figures.Find(X => X.ColorID == ColorID[t] && X.FormID == FormID[t]).OnShadow;
                                    stopwhile2 = false;
                                    FigureID.Add(t);
                                    U.GetComponent<FragmentScript>().ID = HoleID[t];
                                    U.GetComponent<Animator>().SetBool("Deselected", true);
                                }

                            }
                            stopwhile2 = true;
                        }
                        else
                        {
                            int G = Random.Range(0, HoleCount);
                            U.GetComponent<Image>().sprite = Data.SorterList.figures.Find(X => X.ColorID == ColorID[G] && X.FormID == FormID[G]).OnShadow;
                            U.GetComponent<FragmentScript>().ID = HoleID[G];
                            U.GetComponent<Animator>().SetBool("Deselected", true);
                        }
                    }
                }
                break;

            case 3:
                {

                    for (; ColorCount.Count < 4;)
                    {
                        int A = Random.Range(0, 9);
                        if (!ColorCount.Contains(A)) ColorCount.Add(A);
                    }

                    for (; FormCount.Count < 3;)
                    {
                        int R = Random.Range(0, 3);
                        if (!FormCount.Contains(R)) FormCount.Add(R);
                    }


                    foreach (var F in SensFilds)
                    {
                        int A = ColorCount[Random.Range(0, ColorCount.Count)];
                        int R = FormCount[Random.Range(0, FormCount.Count)];
                        F.transform.GetChild(0).GetComponent<Image>().sprite = Data.SorterList.holes.Find(X => X.ColorID == A && X.FormID == R).sprite;
                        HoleCount++;
                        ColorID.Add(A);
                        FormID.Add(R);
                        string Q = "" + R + A;
                        int.TryParse(Q, out C);
                        F.GetComponent<SensFildScript>().ID = C;

                        HoleID.Add(C);

                    }

                    foreach (var U in Figures)
                    {
                        if (FigureID.Count < HoleCount)
                        {
                            while (stopwhile2)
                            {
                                int t = Random.Range(0, HoleCount);
                                if (!FigureID.Contains(t))
                                {
                                    U.GetComponent<Image>().sprite = Data.SorterList.figures.Find(X => X.ColorID == ColorID[t] && X.FormID == FormID[t]).OnShadow;
                                    stopwhile2 = false;
                                    FigureID.Add(t);
                                    U.GetComponent<FragmentScript>().ID = HoleID[t];
                                    U.GetComponent<Animator>().SetBool("Deselected", true);
                                }

                            }
                            stopwhile2 = true;
                        }
                        else
                        {
                            int G = Random.Range(0, HoleCount);
                            U.GetComponent<Image>().sprite = Data.SorterList.figures.Find(X => X.ColorID == ColorID[G] && X.FormID == FormID[G]).OnShadow;
                            U.GetComponent<FragmentScript>().ID = HoleID[G];
                            U.GetComponent<Animator>().SetBool("Deselected", true);
                        }
                    }
                }
                break;

            case 4:
                {

                    for (; ColorCount.Count < 9;)
                    {
                        int A = Random.Range(0, 9);
                        if (!ColorCount.Contains(A)) ColorCount.Add(A);
                    }

                    for (; FormCount.Count < 5;)
                    {
                        int R = Random.Range(0, 5);
                        if (!FormCount.Contains(R)) FormCount.Add(R);
                    }


                    foreach (var F in SensFilds)
                    {
                        int A = ColorCount[Random.Range(0, ColorCount.Count)];
                        int R = FormCount[Random.Range(0, FormCount.Count)];
                        F.transform.GetChild(0).GetComponent<Image>().sprite = Data.SorterList.holes.Find(X => X.ColorID == A && X.FormID == R).sprite;
                        HoleCount++;
                        ColorID.Add(A);
                        FormID.Add(R);
                        string Q = "" + R + A;
                        int.TryParse(Q, out C);
                        F.GetComponent<SensFildScript>().ID = C;
                        HoleID.Add(C);

                    }

                    foreach (var U in Figures)
                    {
                        if (FigureID.Count < HoleCount)
                        {
                            while (stopwhile2)
                            {
                                int t = Random.Range(0, HoleCount);
                                if (!FigureID.Contains(t))
                                {
                                    U.GetComponent<Image>().sprite = Data.SorterList.figures.Find(X => X.ColorID == ColorID[t] && X.FormID == FormID[t]).OnShadow;
                                    stopwhile2 = false;
                                    FigureID.Add(t);
                                    U.GetComponent<FragmentScript>().ID = HoleID[t];
                                    U.GetComponent<Animator>().SetBool("Deselected", true);
                                }

                            }
                            stopwhile2 = true;
                        }
                        else
                        {
                            int G = Random.Range(0, HoleCount);
                            U.GetComponent<Image>().sprite = Data.SorterList.figures.Find(X => X.ColorID == ColorID[G] && X.FormID == FormID[G]).OnShadow;
                            U.GetComponent<FragmentScript>().ID = HoleID[G];
                            U.GetComponent<Animator>().SetBool("Deselected", true);
                        }
                    }
                }
                break;

            case 5:
                {
                    foreach (var F in SensFilds)
                    {

                        while (stopwhile1)
                        {
                            int A = Random.Range(0, 9);
                            if (!ColorID.Contains(A))
                            {
                                int R = Random.Range(0, 2);
                                F.transform.GetChild(0).GetComponent<Image>().sprite = Data.SorterList.holes.Find(X => X.ColorID == A && X.FormID == R).sprite;
                                stopwhile1 = false;
                                ColorID.Add(A);
                                FormID.Add(R);
                                HoleCount++;
                                string Q = "" + R + A;
                                int.TryParse(Q, out C);
                                F.GetComponent<SensFildScript>().ID = C;
                                HoleID.Add(C);
                            }

                        }
                        stopwhile1 = true;
                    }

                    foreach (var U in Figures)
                    {
                        if (FigureID.Count < HoleCount)
                        {
                            while (stopwhile2)
                            {
                                int t = Random.Range(0, HoleCount);
                                if (!FigureID.Contains(t))
                                {
                                    U.GetComponent<Image>().sprite = Data.SorterList.figures.Find(X => X.ColorID == ColorID[t] && X.FormID == FormID[t]).OnShadow;
                                    stopwhile2 = false;
                                    FigureID.Add(t);
                                    U.GetComponent<FragmentScript>().ID = HoleID[t];
                                    U.GetComponent<Animator>().SetBool("Deselected", true);
                                }

                            }
                            stopwhile2 = true;
                        }
                        else
                        {
                            int G = Random.Range(0, HoleCount);
                            U.GetComponent<Image>().sprite = Data.SorterList.figures.Find(X => X.ColorID == ColorID[G] && X.FormID == FormID[G]).OnShadow;
                            U.GetComponent<FragmentScript>().ID = HoleID[G];
                            U.GetComponent<Animator>().SetBool("Deselected", true);
                        }
                    }
                }
                break;

            case 6:
                {
                    foreach (var F in SensFilds)
                    {

                        while (stopwhile1)
                        {
                            int A = Random.Range(0, 9);
                            if (!ColorID.Contains(A))
                            {
                                int R = Random.Range(0, 4);
                                F.transform.GetChild(0).GetComponent<Image>().sprite = Data.SorterList.holes.Find(X => X.ColorID == A && X.FormID == R).sprite;
                                stopwhile1 = false;
                                ColorID.Add(A);
                                FormID.Add(R);
                                HoleCount++;
                                string Q = "" + R + A;
                                int.TryParse(Q, out C);
                                F.GetComponent<SensFildScript>().ID = C;
                                HoleID.Add(C);
                            }

                        }
                        stopwhile1 = true;
                    }

                    foreach (var U in Figures)
                    {
                        if (FigureID.Count < HoleCount)
                        {
                            while (stopwhile2)
                            {
                                int t = Random.Range(0, HoleCount);
                                if (!FigureID.Contains(t))
                                {
                                    U.GetComponent<Image>().sprite = Data.SorterList.figures.Find(X => X.ColorID == ColorID[t] && X.FormID == FormID[t]).OnShadow;
                                    stopwhile2 = false;
                                    FigureID.Add(t);
                                    U.GetComponent<FragmentScript>().ID = HoleID[t];
                                    U.GetComponent<Animator>().SetBool("Deselected", true);
                                }

                            }
                            stopwhile2 = true;
                        }
                        else
                        {
                            int G = Random.Range(0, HoleCount);
                            U.GetComponent<Image>().sprite = Data.SorterList.figures.Find(X => X.ColorID == ColorID[G] && X.FormID == FormID[G]).OnShadow;
                            U.GetComponent<FragmentScript>().ID = HoleID[G];
                            U.GetComponent<Animator>().SetBool("Deselected", true);
                        }
                    }
                }
                break;

            case 7:
                {
                    foreach (var F in SensFilds)
                    {

                        while (stopwhile1)
                        {
                            int A = Random.Range(0, 9);
                            if (!ColorID.Contains(A))
                            {
                                int R = Random.Range(0, 6);
                                F.transform.GetChild(0).GetComponent<Image>().sprite = Data.SorterList.holes.Find(X => X.ColorID == A && X.FormID == R).sprite;
                                stopwhile1 = false;
                                ColorID.Add(A);
                                FormID.Add(R);
                                HoleCount++;
                                string Q = "" + R + A;
                                int.TryParse(Q, out C);
                                F.GetComponent<SensFildScript>().ID = C;
                                HoleID.Add(C);
                            }

                        }
                        stopwhile1 = true;
                    }

                    foreach (var U in Figures)
                    {
                        if (FigureID.Count < HoleCount)
                        {
                            while (stopwhile2)
                            {
                                int t = Random.Range(0, HoleCount);
                                if (!FigureID.Contains(t))
                                {
                                    U.GetComponent<Image>().sprite = Data.SorterList.figures.Find(X => X.ColorID == ColorID[t] && X.FormID == FormID[t]).OnShadow;
                                    stopwhile2 = false;
                                    FigureID.Add(t);
                                    U.GetComponent<FragmentScript>().ID = HoleID[t];
                                    U.GetComponent<Animator>().SetBool("Deselected", true);
                                }

                            }
                            stopwhile2 = true;
                        }
                        else
                        {
                            int G = Random.Range(0, HoleCount);
                            U.GetComponent<Image>().sprite = Data.SorterList.figures.Find(X => X.ColorID == ColorID[G] && X.FormID == FormID[G]).OnShadow;
                            U.GetComponent<FragmentScript>().ID = HoleID[G];
                            U.GetComponent<Animator>().SetBool("Deselected", true);
                        }
                    }
                }
                break;

            case 8:
                {
                    foreach (var F in SensFilds)
                    {

                        while (stopwhile1)
                        {
                            int A = Random.Range(0, 9);
                            if (!ColorID.Contains(A))
                            {
                                int R = Random.Range(0, 8);
                                F.transform.GetChild(0).GetComponent<Image>().sprite = Data.SorterList.holes.Find(X => X.ColorID == A && X.FormID == R).sprite;
                                stopwhile1 = false;
                                ColorID.Add(A);
                                FormID.Add(R);
                                HoleCount++;
                                string Q = "" + R + A;
                                int.TryParse(Q, out C);
                                F.GetComponent<SensFildScript>().ID = C;
                                HoleID.Add(C);
                            }

                        }
                        stopwhile1 = true;
                    }

                    foreach (var U in Figures)
                    {
                        if (FigureID.Count < HoleCount)
                        {
                            while (stopwhile2)
                            {
                                int t = Random.Range(0, HoleCount);
                                if (!FigureID.Contains(t))
                                {
                                    U.GetComponent<Image>().sprite = Data.SorterList.figures.Find(X => X.ColorID == ColorID[t] && X.FormID == FormID[t]).OnShadow;
                                    stopwhile2 = false;
                                    FigureID.Add(t);
                                    U.GetComponent<FragmentScript>().ID = HoleID[t];
                                    U.GetComponent<Animator>().SetBool("Deselected", true);
                                }

                            }
                            stopwhile2 = true;
                        }
                        else
                        {
                            int G = Random.Range(0, HoleCount);
                            U.GetComponent<Image>().sprite = Data.SorterList.figures.Find(X => X.ColorID == ColorID[G] && X.FormID == FormID[G]).OnShadow;
                            U.GetComponent<FragmentScript>().ID = HoleID[G];
                            U.GetComponent<Animator>().SetBool("Deselected", true);
                        }
                    }
                }
                break;
        }
            
            
        
    }

    public void IniGuessing()
    {
        GuessingContent.GetComponent<GridLayoutGroup>().enabled = true;
        WinTimer = GuessingLvL;

        List<int> Items = new List<int>();
        List<int> Nums = new List<int>();
        int M = 0;
        int R = 0;
        int Y = 0;

        Items.Add(M);

        for (int i = 0; 2 * GuessingLvL > i; i++)
        {
            Tiles[i].SetActive(true);
            Tiles[i].GetComponent<Animator>().SetBool("Starter", true);
        }

        ActiveTile = GameObject.FindGameObjectsWithTag("Tile");

        for (int i = 0; ActiveTile.Length > i; i++)
        {     
            
            if (R == 2)
            {
                while(true)
                {
                    M = Random.Range(0, 17);
                    if (!Items.Contains(M))
                    {                        
                        Items.Add(M);
                        R = 0;
                        break;
                    }
                    
                }
               
            }

            while (true)
            {
                Y = Random.Range(0, ActiveTile.Length);
                if(!Nums.Contains(Y))
                {
                    Nums.Add(Y);
                    break;
                }
            }
            ActiveTile[Y].GetComponent<TileScript>().OtherSide = Data.SorterList.Tiles.Find(X => X.ID == M).OtherSide;
            ActiveTile[Y].GetComponent<TileScript>().ID = M;

            R++;
        }
        
        GuessingContent.GetComponent<GridLayoutGroup>().enabled = false;
    }

    public void ActiveGuessing()
    {
        if (ActiveTile2 != null && ActiveTile1 != null && ActiveTile1.GetComponent<TileScript>().ID == ActiveTile2.GetComponent<TileScript>().ID)
        {
            ActiveTile1.GetComponent<Animator>().SetBool("Done", true);
            ActiveTile1.GetComponent<Button>().interactable = false;
            ActiveTile2.GetComponent<Animator>().SetBool("Done", true);
            ActiveTile2.GetComponent<Button>().interactable = false;
            ActiveTile1 = null;
            ActiveTile2 = null;
            TotalTimer++;

            if(TotalTimer == WinTimer)
            {
                StartCoroutine(NextLvL());
            }
        }
        else if(ActiveTile2 != null && ActiveTile1 != null && ActiveTile1.GetComponent<TileScript>().ID != ActiveTile2.GetComponent<TileScript>().ID)
        {
            ActiveTile1.GetComponent<Animator>().SetBool("Back", true);
            ActiveTile2.GetComponent<Animator>().SetBool("Back", true);
            ActiveTile1 = null;
            ActiveTile2 = null;
            
        }

    }

    public void GuessingNextLvL()
    {
        
        foreach (var T in Tiles)
        {
            T.GetComponent<Image>().sprite = T.GetComponent<TileScript>().Default;
            T.SetActive(false);
            T.GetComponent<RectTransform>().localScale = new Vector3(1, 1, 1);
        }
        if (GuessingLvL <= 15) GuessingLvL++;
        TotalTimer = 0;
        WinTimer = GuessingLvL;
        IniGuessing();
    }

    public void GuessingReset()
    {
        foreach(var T in Tiles)
        {
            T.GetComponent<Image>().sprite = T.GetComponent<TileScript>().Default;
            T.SetActive(false);
            T.GetComponent<RectTransform>().localScale = new Vector3(1, 1, 1);
        }

        TotalTimer = 0;
        WinTimer = GuessingLvL;
        IniGuessing();
    }

    public void GuessingNewGame()
    {
        foreach (var T in Tiles)
        {
            T.GetComponent<Image>().sprite = T.GetComponent<TileScript>().Default;
            T.SetActive(false);
            T.GetComponent<RectTransform>().localScale = new Vector3(1, 1, 1);
        }

        GuessingLvL = 1;
        TotalTimer = 0;
        WinTimer = GuessingLvL;
        IniGuessing();
    }

    public void GuessingBackToMenu()
    {
        foreach (var T in Tiles)
        {
            T.GetComponent<Image>().sprite = T.GetComponent<TileScript>().Default;
            T.SetActive(false);
            T.GetComponent<RectTransform>().localScale = new Vector3(1, 1, 1);
        }

        GuessingLvL = 1;
        TotalTimer = 0;

        Guessing.SetActive(false);
        MainMenu.SetActive(true);
    }

    public IEnumerator NextLvL()
    {
        yield return new WaitForSeconds(2.0f);
        GuessingMenuNextLvL.SetActive(true);
        
    }
}
