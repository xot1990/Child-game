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

    //Ini GO

    public static GameObject MainMenu;
    public static GameObject SorterLifes;
    public static GameObject Sorter;
    public static GameObject SorterBack;
    public static GameObject SorterLenar;
    public static GameObject SorterFigures;
    public static GameObject SorterMenuNextLvL;
    public static GameObject SorterMenuGameOver;
    public static GameObject Score;
    public static GameObject[] SensFilds;
    public static GameObject[] Figures;

    // GameLvL

    public static int SorterLvL = 1;

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
        SorterLifes = GameObject.Find("Lifes");
        SorterBack = GameObject.Find("BackGround");
        SorterLenar = GameObject.Find("Lenar");
        SorterFigures = GameObject.Find("Figures");
        SorterMenuNextLvL = GameObject.Find("MenuNextLvL");
        SorterMenuGameOver = GameObject.Find("MenuGameOver");
        Score = GameObject.Find("Score");
        SensFilds = GameObject.FindGameObjectsWithTag("SensFild");
        Figures = GameObject.FindGameObjectsWithTag("Figure");
        MainMenu = GameObject.Find("MainMenu");

        // Off Go

        Sorter.SetActive(false);
        SorterMenuNextLvL.SetActive(false);
        SorterMenuGameOver.SetActive(false);
    }

    public void NextLvl()
    {
        SorterLvL++;

        foreach (var F in Figures)
        {
            F.transform.parent = SorterFigures.transform;
            F.transform.position = F.GetComponent<FragmentScript>().StartPos;
            F.transform.localScale = new Vector3(0.1f, 0.1f, 0.1f);
            F.GetComponent<RectTransform>().rotation = Quaternion.Euler(0,0,0);
            F.GetComponent<Image>().sprite = null;
            F.GetComponent<Image>().raycastTarget = true;
            F.SetActive(true);
        }
        TotalTimer = 0;
        SorterMenuNextLvL.SetActive(false);
        IniSorter();
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

        for (int i = 0; SorterLifes.transform.childCount > i; i++)
        {
            SorterLifes.transform.GetChild(i).gameObject.SetActive(true);
        }

        Life = 6;

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

        for(int i =0; SorterLifes.transform.childCount - 1 > i; i++)
        {
            SorterLifes.transform.GetChild(i).gameObject.SetActive(true);
        }

        Life = 6;

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
                        
                        int R = Random.Range(0, 5);
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
                                F.GetComponent<SensFildScript>().ID = HoleCount;
                                HoleID.Add(HoleCount);
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
}
