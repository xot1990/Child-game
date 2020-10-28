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

    //Ini GO

    public static GameObject Sorter;
    public static GameObject SorterBack;
    public static GameObject SorterLenar;
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
        SorterBack = GameObject.Find("BackGround");
        SorterLenar = GameObject.Find("Lenar");
        SensFilds = GameObject.FindGameObjectsWithTag("SensFild");
        Figures = GameObject.FindGameObjectsWithTag("Figure");

        // Off Go

        Sorter.SetActive(false);
        
    }

    public void NextLvl()
    {
        SorterLvL++;
    }

    public void IniSorter()
    {
        WinTimer = Figures.Length;
        List<int> ColorID = new List<int>();
        List<int> FormID = new List<int>();
        List<int> FigureID = new List<int>();
        List<int> HoleID = new List<int>();
        int HoleCount = 0;
        bool stopwhile1 = true;
        bool stopwhile2 = true;


        switch (SorterLvL)
            {

            case 1:
                {
                    int A = Random.Range(0, 9);

                    foreach (var F in SensFilds)
                    {
                        
                        int R = Random.Range(0, 2);
                        F.transform.GetChild(0).GetComponent<Image>().sprite = Data.SorterList.holes.Find(X => X.ColorID == A && X.FormID == R).sprite;                        
                        ColorID.Add(A);
                        FormID.Add(R);
                        HoleCount++;
                        F.GetComponent<SensFildScript>().ID = R;
                        HoleID.Add(HoleCount);
                       
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
                                    U.GetComponent<FragmentScript>().ID = FormID[t];
                                    U.GetComponent<Animator>().SetBool("Deselected", true);
                                }
                                
                            }
                            stopwhile2 = true;
                        }
                        else
                        {
                            int G = Random.Range(0, HoleCount);
                            U.GetComponent<Image>().sprite = Data.SorterList.figures.Find(X => X.ColorID == ColorID[G] && X.FormID == FormID[G]).OnShadow;
                            U.GetComponent<FragmentScript>().ID = FormID[G];
                            U.GetComponent<Animator>().SetBool("Deselected", true);
                        }
                    }
                }
            break;

            case 4:
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
