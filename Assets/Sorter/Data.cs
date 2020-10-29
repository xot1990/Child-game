using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Data : ScriptableObject
{
    public class Figure
    {
        public int ColorID;
        public int FormID;
        public Sprite OnShadow;
        public Sprite sprite;
    }

    public class Hole
    {
        public int ColorID;
        public int FormID;
        public Sprite sprite;
    }

    public static class SorterList
    {
        public static List<Figure> figures;
        public static List<Hole> holes;

        public static void Initialize()
        {
            figures = new List<Figure>
            {
                new Figure
                {
                    ColorID = 0,
                    FormID = 0,
                    OnShadow = Resources.Load<Sprite>("Sorter/FigureOnShadow/Rhombus/Red"),
                    sprite = Resources.Load<Sprite>("Sorter/Figure/Rhombus/Red"),
                },

                new Figure
                {
                    ColorID = 1,
                    FormID = 0,
                    OnShadow = Resources.Load<Sprite>("Sorter/FigureOnShadow/Rhombus/Blue"),
                    sprite = Resources.Load<Sprite>("Sorter/Figure/Rhombus/Blue"),
                },

                new Figure
                {
                    ColorID = 2,
                    FormID = 0,
                    OnShadow = Resources.Load<Sprite>("Sorter/FigureOnShadow/Rhombus/Yellow"),
                    sprite = Resources.Load<Sprite>("Sorter/Figure/Rhombus/Yellow"),
                },

                new Figure
                {
                    ColorID = 3,
                    FormID = 0,
                    OnShadow = Resources.Load<Sprite>("Sorter/FigureOnShadow/Rhombus/Green"),
                    sprite = Resources.Load<Sprite>("Sorter/Figure/Rhombus/Green"),
                },

                new Figure
                {
                    ColorID = 4,
                    FormID = 0,
                    OnShadow = Resources.Load<Sprite>("Sorter/FigureOnShadow/Rhombus/Pink"),
                    sprite = Resources.Load<Sprite>("Sorter/Figure/Rhombus/Pink"),
                },

                new Figure
                {
                    ColorID = 5,
                    FormID = 0,
                    OnShadow = Resources.Load<Sprite>("Sorter/FigureOnShadow/Rhombus/Violet"),
                    sprite = Resources.Load<Sprite>("Sorter/Figure/Rhombus/Violet"),
                },

                new Figure
                {
                    ColorID = 6,
                    FormID = 0,
                    OnShadow = Resources.Load<Sprite>("Sorter/FigureOnShadow/Rhombus/Brown"),
                    sprite = Resources.Load<Sprite>("Sorter/Figure/Rhombus/Brown"),
                },

                new Figure
                {
                    ColorID = 7,
                    FormID = 0,
                    OnShadow = Resources.Load<Sprite>("Sorter/FigureOnShadow/Rhombus/Orange"),
                    sprite = Resources.Load<Sprite>("Sorter/Figure/Rhombus/Orange"),
                },

                new Figure
                {
                    ColorID = 8,
                    FormID = 0,
                    OnShadow = Resources.Load<Sprite>("Sorter/FigureOnShadow/Rhombus/Aquamarine"),
                    sprite = Resources.Load<Sprite>("Sorter/Figure/Rhombus/Aquamarine"),
                },

                new Figure
                {
                    ColorID = 0,
                    FormID = 1,
                    OnShadow = Resources.Load<Sprite>("Sorter/FigureOnShadow/Hexagon/Red"),
                    sprite = Resources.Load<Sprite>("Sorter/Figure/Hexagon/Red"),
                },

                new Figure
                {
                    ColorID = 1,
                    FormID = 1,
                    OnShadow = Resources.Load<Sprite>("Sorter/FigureOnShadow/Hexagon/Blue"),
                    sprite = Resources.Load<Sprite>("Sorter/Figure/Hexagon/Blue"),
                },

                new Figure
                {
                    ColorID = 2,
                    FormID = 1,
                    OnShadow = Resources.Load<Sprite>("Sorter/FigureOnShadow/Hexagon/Yellow"),
                    sprite = Resources.Load<Sprite>("Sorter/Figure/Hexagon/Yellow"),
                },

                new Figure
                {
                    ColorID = 3,
                    FormID = 1,
                    OnShadow = Resources.Load<Sprite>("Sorter/FigureOnShadow/Hexagon/Green"),
                    sprite = Resources.Load<Sprite>("Sorter/Figure/Hexagon/Green"),
                },

                new Figure
                {
                    ColorID = 4,
                    FormID = 1,
                    OnShadow = Resources.Load<Sprite>("Sorter/FigureOnShadow/Hexagon/Pink"),
                    sprite = Resources.Load<Sprite>("Sorter/Figure/Hexagon/Pink"),
                },

                new Figure
                {
                    ColorID = 5,
                    FormID = 1,
                    OnShadow = Resources.Load<Sprite>("Sorter/FigureOnShadow/Hexagon/Violet"),
                    sprite = Resources.Load<Sprite>("Sorter/Figure/Hexagon/Violet"),
                },

                new Figure
                {
                    ColorID = 6,
                    FormID = 1,
                    OnShadow = Resources.Load<Sprite>("Sorter/FigureOnShadow/Hexagon/Brown"),
                    sprite = Resources.Load<Sprite>("Sorter/Figure/Hexagon/Brown"),
                },

                new Figure
                {
                    ColorID = 7,
                    FormID = 1,
                    OnShadow = Resources.Load<Sprite>("Sorter/FigureOnShadow/Hexagon/Orange"),
                    sprite = Resources.Load<Sprite>("Sorter/Figure/Hexagon/Orange"),
                },

                new Figure
                {
                    ColorID = 8,
                    FormID = 1,
                    OnShadow = Resources.Load<Sprite>("Sorter/FigureOnShadow/Hexagon/Aquamarine"),
                    sprite = Resources.Load<Sprite>("Sorter/Figure/Hexagon/Aquamarine"),
                },

                 new Figure
                {
                    ColorID = 0,
                    FormID = 2,
                    OnShadow = Resources.Load<Sprite>("Sorter/FigureOnShadow/Square/Red"),
                    sprite = Resources.Load<Sprite>("Sorter/Figure/Square/Red"),
                },

                new Figure
                {
                    ColorID = 1,
                    FormID = 2,
                    OnShadow = Resources.Load<Sprite>("Sorter/FigureOnShadow/Square/Blue"),
                    sprite = Resources.Load<Sprite>("Sorter/Figure/Square/Blue"),
                },

                new Figure
                {
                    ColorID = 2,
                    FormID = 2,
                    OnShadow = Resources.Load<Sprite>("Sorter/FigureOnShadow/Square/Yellow"),
                    sprite = Resources.Load<Sprite>("Sorter/Figure/Square/Yellow"),
                },

                new Figure
                {
                    ColorID = 3,
                    FormID = 2,
                    OnShadow = Resources.Load<Sprite>("Sorter/FigureOnShadow/Square/Green"),
                    sprite = Resources.Load<Sprite>("Sorter/Figure/Square/Green"),
                },

                new Figure
                {
                    ColorID = 4,
                    FormID = 2,
                    OnShadow = Resources.Load<Sprite>("Sorter/FigureOnShadow/Square/Pink"),
                    sprite = Resources.Load<Sprite>("Sorter/Figure/Square/Pink"),
                },

                new Figure
                {
                    ColorID = 5,
                    FormID = 2,
                    OnShadow = Resources.Load<Sprite>("Sorter/FigureOnShadow/Square/Violet"),
                    sprite = Resources.Load<Sprite>("Sorter/Figure/Square/Violet"),
                },

                new Figure
                {
                    ColorID = 6,
                    FormID = 2,
                    OnShadow = Resources.Load<Sprite>("Sorter/FigureOnShadow/Square/Brown"),
                    sprite = Resources.Load<Sprite>("Sorter/Figure/Square/Brown"),
                },

                new Figure
                {
                    ColorID = 7,
                    FormID = 2,
                    OnShadow = Resources.Load<Sprite>("Sorter/FigureOnShadow/Square/Orange"),
                    sprite = Resources.Load<Sprite>("Sorter/Figure/Square/Orange"),
                },

                new Figure
                {
                    ColorID = 8,
                    FormID = 2,
                    OnShadow = Resources.Load<Sprite>("Sorter/FigureOnShadow/Square/Aquamarine"),
                    sprite = Resources.Load<Sprite>("Sorter/Figure/Square/Aquamarine"),
                },

                new Figure
                {
                    ColorID = 0,
                    FormID = 3,
                    OnShadow = Resources.Load<Sprite>("Sorter/FigureOnShadow/Triangle/Red"),
                    sprite = Resources.Load<Sprite>("Sorter/Figure/Triangle/Red"),
                },

                new Figure
                {
                    ColorID = 1,
                    FormID = 3,
                    OnShadow = Resources.Load<Sprite>("Sorter/FigureOnShadow/Triangle/Blue"),
                    sprite = Resources.Load<Sprite>("Sorter/Figure/Triangle/Blue"),
                },

                new Figure
                {
                    ColorID = 2,
                    FormID = 3,
                    OnShadow = Resources.Load<Sprite>("Sorter/FigureOnShadow/Triangle/Yellow"),
                    sprite = Resources.Load<Sprite>("Sorter/Figure/Triangle/Yellow"),
                },

                new Figure
                {
                    ColorID = 3,
                    FormID = 3,
                    OnShadow = Resources.Load<Sprite>("Sorter/FigureOnShadow/Triangle/Green"),
                    sprite = Resources.Load<Sprite>("Sorter/Figure/Triangle/Green"),
                },

                new Figure
                {
                    ColorID = 4,
                    FormID = 3,
                    OnShadow = Resources.Load<Sprite>("Sorter/FigureOnShadow/Triangle/Pink"),
                    sprite = Resources.Load<Sprite>("Sorter/Figure/Triangle/Pink"),
                },

                new Figure
                {
                    ColorID = 5,
                    FormID = 3,
                    OnShadow = Resources.Load<Sprite>("Sorter/FigureOnShadow/Triangle/Violet"),
                    sprite = Resources.Load<Sprite>("Sorter/Figure/Triangle/Violet"),
                },

                new Figure
                {
                    ColorID = 6,
                    FormID = 3,
                    OnShadow = Resources.Load<Sprite>("Sorter/FigureOnShadow/Triangle/Brown"),
                    sprite = Resources.Load<Sprite>("Sorter/Figure/Triangle/Brown"),
                },

                new Figure
                {
                    ColorID = 7,
                    FormID = 3,
                    OnShadow = Resources.Load<Sprite>("Sorter/FigureOnShadow/Triangle/Orange"),
                    sprite = Resources.Load<Sprite>("Sorter/Figure/Triangle/Orange"),
                },

                new Figure
                {
                    ColorID = 8,
                    FormID = 3,
                    OnShadow = Resources.Load<Sprite>("Sorter/FigureOnShadow/Triangle/Aquamarine"),
                    sprite = Resources.Load<Sprite>("Sorter/Figure/Triangle/Aquamarine"),
                },

                new Figure
                {
                    ColorID = 0,
                    FormID = 4,
                    OnShadow = Resources.Load<Sprite>("Sorter/FigureOnShadow/Сircle/Red"),
                    sprite = Resources.Load<Sprite>("Sorter/Figure/Сircle/Red"),
                },

                new Figure
                {
                    ColorID = 1,
                    FormID = 4,
                    OnShadow = Resources.Load<Sprite>("Sorter/FigureOnShadow/Сircle/Blue"),
                    sprite = Resources.Load<Sprite>("Sorter/Figure/Сircle/Blue"),
                },

                new Figure
                {
                    ColorID = 2,
                    FormID = 4,
                    OnShadow = Resources.Load<Sprite>("Sorter/FigureOnShadow/Сircle/Yellow"),
                    sprite = Resources.Load<Sprite>("Sorter/Figure/Сircle/Yellow"),
                },

                new Figure
                {
                    ColorID = 3,
                    FormID = 4,
                    OnShadow = Resources.Load<Sprite>("Sorter/FigureOnShadow/Сircle/Green"),
                    sprite = Resources.Load<Sprite>("Sorter/Figure/Сircle/Green"),
                },

                new Figure
                {
                    ColorID = 4,
                    FormID = 4,
                    OnShadow = Resources.Load<Sprite>("Sorter/FigureOnShadow/Сircle/Pink"),
                    sprite = Resources.Load<Sprite>("Sorter/Figure/Сircle/Pink"),
                },

                new Figure
                {
                    ColorID = 5,
                    FormID = 4,
                    OnShadow = Resources.Load<Sprite>("Sorter/FigureOnShadow/Сircle/Violet"),
                    sprite = Resources.Load<Sprite>("Sorter/Figure/Сircle/Violet"),
                },

                new Figure
                {
                    ColorID = 6,
                    FormID = 4,
                    OnShadow = Resources.Load<Sprite>("Sorter/FigureOnShadow/Сircle/Brown"),
                    sprite = Resources.Load<Sprite>("Sorter/Figure/Сircle/Brown"),
                },

                new Figure
                {
                    ColorID = 7,
                    FormID = 4,
                    OnShadow = Resources.Load<Sprite>("Sorter/FigureOnShadow//Сircle/Orange"),
                    sprite = Resources.Load<Sprite>("Sorter/Figure/Сircle/Orange"),
                },

                new Figure
                {
                    ColorID = 8,
                    FormID = 4,
                    OnShadow = Resources.Load<Sprite>("Sorter/FigureOnShadow/Сircle/Aquamarine"),
                    sprite = Resources.Load<Sprite>("Sorter/Figure/Сircle/Aquamarine"),
                },
            };

            holes = new List<Hole>
            {
                new Hole
                {
                    ColorID = 0,
                    FormID = 0,
                    sprite = Resources.Load<Sprite>("Sorter/Hole/Rhombus/Red"),
                },

                new Hole
                {
                    ColorID = 1,
                    FormID = 0,
                    sprite = Resources.Load<Sprite>("Sorter/Hole/Rhombus/Blue"),
                },

                new Hole
                {
                    ColorID = 2,
                    FormID = 0,
                    sprite = Resources.Load<Sprite>("Sorter/Hole/Rhombus/Yellow"),
                },

                new Hole
                {
                    ColorID = 3,
                    FormID = 0,
                    sprite = Resources.Load<Sprite>("Sorter/Hole/Rhombus/Green"),
                },

                new Hole
                {
                    ColorID = 4,
                    FormID = 0,
                    sprite = Resources.Load<Sprite>("Sorter/Hole/Rhombus/Pink"),
                },

                new Hole
                {
                    ColorID = 5,
                    FormID = 0,
                    sprite = Resources.Load<Sprite>("Sorter/Hole/Rhombus/Violet"),
                },

                new Hole
                {
                    ColorID = 6,
                    FormID = 0,
                    sprite = Resources.Load<Sprite>("Sorter/Hole/Rhombus/Brown"),
                },

                new Hole
                {
                    ColorID = 7,
                    FormID = 0,
                    sprite = Resources.Load<Sprite>("Sorter/Hole/Rhombus/Orange"),
                },

                new Hole
                {
                    ColorID = 8,
                    FormID = 0,
                    sprite = Resources.Load<Sprite>("Sorter/Hole/Rhombus/Aquamarine"),
                },

                new Hole
                {
                    ColorID = 0,
                    FormID = 1,
                    sprite = Resources.Load<Sprite>("Sorter/Hole/Hexagon/Red"),
                },

                new Hole
                {
                    ColorID = 1,
                    FormID = 1,
                    sprite = Resources.Load<Sprite>("Sorter/Hole/Hexagon/Blue"),
                },

                new Hole
                {
                    ColorID = 2,
                    FormID = 1,
                    sprite = Resources.Load<Sprite>("Sorter/Hole/Hexagon/Yellow"),
                },

                new Hole
                {
                    ColorID = 3,
                    FormID = 1,
                    sprite = Resources.Load<Sprite>("Sorter/Hole/Hexagon/Green"),
                },

                new Hole
                {
                    ColorID = 4,
                    FormID = 1,
                    sprite = Resources.Load<Sprite>("Sorter/Hole/Hexagon/Pink"),
                },

                new Hole
                {
                    ColorID = 5,
                    FormID = 1,
                    sprite = Resources.Load<Sprite>("Sorter/Hole/Hexagon/Violet"),
                },

                new Hole
                {
                    ColorID = 6,
                    FormID = 1,
                    sprite = Resources.Load<Sprite>("Sorter/Hole/Hexagon/Brown"),
                },

                new Hole
                {
                    ColorID = 7,
                    FormID = 1,
                    sprite = Resources.Load<Sprite>("Sorter/Hole/Hexagon/Orange"),
                },

                new Hole
                {
                    ColorID = 8,
                    FormID = 1,
                    sprite = Resources.Load<Sprite>("Sorter/Hole/Hexagon/Aquamarine"),
                },

                new Hole
                {
                    ColorID = 0,
                    FormID = 2,
                    sprite = Resources.Load<Sprite>("Sorter/Hole/Square/Red"),
                },

                new Hole
                {
                    ColorID = 1,
                    FormID = 2,
                    sprite = Resources.Load<Sprite>("Sorter/Hole/Square/Blue"),
                },

                new Hole
                {
                    ColorID = 2,
                    FormID = 2,
                    sprite = Resources.Load<Sprite>("Sorter/Hole/Square/Yellow"),
                },

                new Hole
                {
                    ColorID = 3,
                    FormID = 2,
                    sprite = Resources.Load<Sprite>("Sorter/Hole/Square/Green"),
                },

                new Hole
                {
                    ColorID = 4,
                    FormID = 2,
                    sprite = Resources.Load<Sprite>("Sorter/Hole/Square/Pink"),
                },

                new Hole
                {
                    ColorID = 5,
                    FormID = 2,
                    sprite = Resources.Load<Sprite>("Sorter/Hole/Square/Violet"),
                },

                new Hole
                {
                    ColorID = 6,
                    FormID = 2,
                    sprite = Resources.Load<Sprite>("Sorter/Hole/Square/Brown"),
                },

                new Hole
                {
                    ColorID = 7,
                    FormID = 2,
                    sprite = Resources.Load<Sprite>("Sorter/Hole/Square/Orange"),
                },

                new Hole
                {
                    ColorID = 8,
                    FormID = 2,
                    sprite = Resources.Load<Sprite>("Sorter/Hole/Square/Aquamarine"),
                },

                new Hole
                {
                    ColorID = 0,
                    FormID = 3,
                    sprite = Resources.Load<Sprite>("Sorter/Hole/Triangle/Red"),
                },

                new Hole
                {
                    ColorID = 1,
                    FormID = 3,
                    sprite = Resources.Load<Sprite>("Sorter/Hole/Triangle/Blue"),
                },

                new Hole
                {
                    ColorID = 2,
                    FormID = 3,
                    sprite = Resources.Load<Sprite>("Sorter/Hole/Triangle/Yellow"),
                },

                new Hole
                {
                    ColorID = 3,
                    FormID = 3,
                    sprite = Resources.Load<Sprite>("Sorter/Hole/Triangle/Green"),
                },

                new Hole
                {
                    ColorID = 4,
                    FormID = 3,
                    sprite = Resources.Load<Sprite>("Sorter/Hole/Triangle/Pink"),
                },

                new Hole
                {
                    ColorID = 5,
                    FormID = 3,
                    sprite = Resources.Load<Sprite>("Sorter/Hole/Triangle/Violet"),
                },

                new Hole
                {
                    ColorID = 6,
                    FormID = 3,
                    sprite = Resources.Load<Sprite>("Sorter/Hole/Triangle/Brown"),
                },

                new Hole
                {
                    ColorID = 7,
                    FormID = 3,
                    sprite = Resources.Load<Sprite>("Sorter/Hole/Triangle/Orange"),
                },

                new Hole
                {
                    ColorID = 8,
                    FormID = 3,
                    sprite = Resources.Load<Sprite>("Sorter/Hole/Triangle/Aquamarine"),
                },

                new Hole
                {
                    ColorID = 0,
                    FormID = 4,
                    sprite = Resources.Load<Sprite>("Sorter/Hole/Сircle/Red"),
                },

                new Hole
                {
                    ColorID = 1,
                    FormID = 4,
                    sprite = Resources.Load<Sprite>("Sorter/Hole/Сircle/Blue"),
                },

                new Hole
                {
                    ColorID = 2,
                    FormID = 4,
                    sprite = Resources.Load<Sprite>("Sorter/Hole/Сircle/Yellow"),
                },

                new Hole
                {
                    ColorID = 3,
                    FormID = 4,
                    sprite = Resources.Load<Sprite>("Sorter/Hole/Сircle/Green"),
                },

                new Hole
                {
                    ColorID = 4,
                    FormID = 4,
                    sprite = Resources.Load<Sprite>("Sorter/Hole/Сircle/Pink"),
                },

                new Hole
                {
                    ColorID = 5,
                    FormID = 4,
                    sprite = Resources.Load<Sprite>("Sorter/Hole/Сircle/Violet"),
                },

                new Hole
                {
                    ColorID = 6,
                    FormID = 4,
                    sprite = Resources.Load<Sprite>("Sorter/Hole/Сircle/Brown"),
                },

                new Hole
                {
                    ColorID = 7,
                    FormID = 4,
                    sprite = Resources.Load<Sprite>("Sorter/Hole/Сircle/Orange"),
                },

                new Hole
                {
                    ColorID = 8,
                    FormID = 4,
                    sprite = Resources.Load<Sprite>("Sorter/Hole/Сircle/Aquamarine"),
                },
            };
        }
    }
}
