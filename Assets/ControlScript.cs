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

    public void IniSorter()
    {
        List<int> ColorID = new List<int>();
        List<int> FormID = new List<int>();
        bool stopwhile = true;
       
       
            switch(SorterLvL)
            {
                case 1:
                    {
                    foreach (var F in SensFilds)
                    {
                        
                        while (stopwhile)
                        {
                            int A = Random.Range(0, 9);
                            if (!ColorID.Contains(A))
                            {
                                F.transform.GetChild(0).GetComponent<Image>().sprite = Data.SorterList.holes.Find(X => X.ColorID == A && X.FormID == Random.Range(0,2)).sprite;
                                stopwhile = false;
                                ColorID.Add(A);
                            }

                        }
                        stopwhile = true;
                    }
                }
                break;
            }
            
            
        
    }
}
