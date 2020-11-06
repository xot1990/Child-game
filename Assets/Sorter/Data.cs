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

    public class Animal
    {
        public int ID;
        public string Name;
        public Sprite Picture;
        public Sprite Image1;
        public Sprite Image2;
        public Sprite Image3;
        public AudioClip Sound;
    }

    public class Tile
    {
        public int ID;
        public Sprite OtherSide;
    }

    public static class SorterList
    {
        public static List<Figure> figures;
        public static List<Hole> holes;
        public static List<Animal> Animals;
        public static List<Tile> Tiles;

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
                    OnShadow = Resources.Load<Sprite>("Sorter/FigureOnShadow/Сircle/Orange"),
                    sprite = Resources.Load<Sprite>("Sorter/Figure/Сircle/Orange"),
                },

                new Figure
                {
                    ColorID = 8,
                    FormID = 4,
                    OnShadow = Resources.Load<Sprite>("Sorter/FigureOnShadow/Сircle/Aquamarine"),
                    sprite = Resources.Load<Sprite>("Sorter/Figure/Сircle/Aquamarine"),
                },

                new Figure
                {
                    ColorID = 0,
                    FormID = 5,
                    OnShadow = Resources.Load<Sprite>("Sorter/FigureOnShadow/Ellipse/Red"),
                    sprite = Resources.Load<Sprite>("Sorter/Figure/Ellipse/Red"),
                },

                new Figure
                {
                    ColorID = 1,
                    FormID = 5,
                    OnShadow = Resources.Load<Sprite>("Sorter/FigureOnShadow/Ellipse/Blue"),
                    sprite = Resources.Load<Sprite>("Sorter/Figure/Ellipse/Blue"),
                },

                new Figure
                {
                    ColorID = 2,
                    FormID = 5,
                    OnShadow = Resources.Load<Sprite>("Sorter/FigureOnShadow/Ellipse/Yellow"),
                    sprite = Resources.Load<Sprite>("Sorter/Figure/Ellipse/Yellow"),
                },

                new Figure
                {
                    ColorID = 3,
                    FormID = 5,
                    OnShadow = Resources.Load<Sprite>("Sorter/FigureOnShadow/Ellipse/Green"),
                    sprite = Resources.Load<Sprite>("Sorter/Figure/Ellipse/Green"),
                },

                new Figure
                {
                    ColorID = 4,
                    FormID = 5,
                    OnShadow = Resources.Load<Sprite>("Sorter/FigureOnShadow/Ellipse/Pink"),
                    sprite = Resources.Load<Sprite>("Sorter/Figure/Ellipse/Pink"),
                },

                new Figure
                {
                    ColorID = 5,
                    FormID = 5,
                    OnShadow = Resources.Load<Sprite>("Sorter/FigureOnShadow/Ellipse/Violet"),
                    sprite = Resources.Load<Sprite>("Sorter/Figure/Ellipse/Violet"),
                },

                new Figure
                {
                    ColorID = 6,
                    FormID = 5,
                    OnShadow = Resources.Load<Sprite>("Sorter/FigureOnShadow/Ellipse/Brown"),
                    sprite = Resources.Load<Sprite>("Sorter/Figure/Ellipse/Brown"),
                },

                new Figure
                {
                    ColorID = 7,
                    FormID = 5,
                    OnShadow = Resources.Load<Sprite>("Sorter/FigureOnShadow/Ellipse/Orange"),
                    sprite = Resources.Load<Sprite>("Sorter/Figure/Ellipse/Orange"),
                },

                new Figure
                {
                    ColorID = 8,
                    FormID = 5,
                    OnShadow = Resources.Load<Sprite>("Sorter/FigureOnShadow/Ellipse/Aquamarine"),
                    sprite = Resources.Load<Sprite>("Sorter/Figure/Ellipse/Aquamarine"),
                },

                new Figure
                {
                    ColorID = 0,
                    FormID = 6,
                    OnShadow = Resources.Load<Sprite>("Sorter/FigureOnShadow/Pentagon/Red"),
                    sprite = Resources.Load<Sprite>("Sorter/Figure/Pentagon/Red"),
                },

                new Figure
                {
                    ColorID = 1,
                    FormID = 6,
                    OnShadow = Resources.Load<Sprite>("Sorter/FigureOnShadow/Pentagon/Blue"),
                    sprite = Resources.Load<Sprite>("Sorter/Figure/Pentagon/Blue"),
                },

                new Figure
                {
                    ColorID = 2,
                    FormID = 6,
                    OnShadow = Resources.Load<Sprite>("Sorter/FigureOnShadow/Pentagon/Yellow"),
                    sprite = Resources.Load<Sprite>("Sorter/Figure/Pentagon/Yellow"),
                },

                new Figure
                {
                    ColorID = 3,
                    FormID = 6,
                    OnShadow = Resources.Load<Sprite>("Sorter/FigureOnShadow/Pentagon/Green"),
                    sprite = Resources.Load<Sprite>("Sorter/Figure/Pentagon/Green"),
                },

                new Figure
                {
                    ColorID = 4,
                    FormID = 6,
                    OnShadow = Resources.Load<Sprite>("Sorter/FigureOnShadow/Pentagon/Pink"),
                    sprite = Resources.Load<Sprite>("Sorter/Figure/Pentagon/Pink"),
                },

                new Figure
                {
                    ColorID = 5,
                    FormID = 6,
                    OnShadow = Resources.Load<Sprite>("Sorter/FigureOnShadow/Pentagon/Violet"),
                    sprite = Resources.Load<Sprite>("Sorter/Figure/Pentagon/Violet"),
                },

                new Figure
                {
                    ColorID = 6,
                    FormID = 6,
                    OnShadow = Resources.Load<Sprite>("Sorter/FigureOnShadow/Pentagon/Brown"),
                    sprite = Resources.Load<Sprite>("Sorter/Figure/Pentagon/Brown"),
                },

                new Figure
                {
                    ColorID = 7,
                    FormID = 6,
                    OnShadow = Resources.Load<Sprite>("Sorter/FigureOnShadow/Pentagon/Orange"),
                    sprite = Resources.Load<Sprite>("Sorter/Figure/Pentagon/Orange"),
                },

                new Figure
                {
                    ColorID = 8,
                    FormID = 6,
                    OnShadow = Resources.Load<Sprite>("Sorter/FigureOnShadow/Pentagon/Aquamarine"),
                    sprite = Resources.Load<Sprite>("Sorter/Figure/Pentagon/Aquamarine"),
                },

                new Figure
                {
                    ColorID = 0,
                    FormID = 7,
                    OnShadow = Resources.Load<Sprite>("Sorter/FigureOnShadow/Rectangle/Red"),
                    sprite = Resources.Load<Sprite>("Sorter/Figure/Rectangle/Red"),
                },

                new Figure
                {
                    ColorID = 1,
                    FormID = 7,
                    OnShadow = Resources.Load<Sprite>("Sorter/FigureOnShadow/Rectangle/Blue"),
                    sprite = Resources.Load<Sprite>("Sorter/Figure/Rectangle/Blue"),
                },

                new Figure
                {
                    ColorID = 2,
                    FormID = 7,
                    OnShadow = Resources.Load<Sprite>("Sorter/FigureOnShadow/Rectangle/Yellow"),
                    sprite = Resources.Load<Sprite>("Sorter/Figure/Rectangle/Yellow"),
                },

                new Figure
                {
                    ColorID = 3,
                    FormID = 7,
                    OnShadow = Resources.Load<Sprite>("Sorter/FigureOnShadow/Rectangle/Green"),
                    sprite = Resources.Load<Sprite>("Sorter/Figure/Rectangle/Green"),
                },

                new Figure
                {
                    ColorID = 4,
                    FormID = 7,
                    OnShadow = Resources.Load<Sprite>("Sorter/FigureOnShadow/Rectangle/Pink"),
                    sprite = Resources.Load<Sprite>("Sorter/Figure/Rectangle/Pink"),
                },

                new Figure
                {
                    ColorID = 5,
                    FormID = 7,
                    OnShadow = Resources.Load<Sprite>("Sorter/FigureOnShadow/Rectangle/Violet"),
                    sprite = Resources.Load<Sprite>("Sorter/Figure/Rectangle/Violet"),
                },

                new Figure
                {
                    ColorID = 6,
                    FormID = 7,
                    OnShadow = Resources.Load<Sprite>("Sorter/FigureOnShadow/Rectangle/Brown"),
                    sprite = Resources.Load<Sprite>("Sorter/Figure/Rectangle/Brown"),
                },

                new Figure
                {
                    ColorID = 7,
                    FormID = 7,
                    OnShadow = Resources.Load<Sprite>("Sorter/FigureOnShadow/Rectangle/Orange"),
                    sprite = Resources.Load<Sprite>("Sorter/Figure/Rectangle/Orange"),
                },

                new Figure
                {
                    ColorID = 8,
                    FormID = 7,
                    OnShadow = Resources.Load<Sprite>("Sorter/FigureOnShadow/Rectangle/Aquamarine"),
                    sprite = Resources.Load<Sprite>("Sorter/Figure/Rectangle/Aquamarine"),
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

                new Hole
                {
                    ColorID = 0,
                    FormID = 5,
                    sprite = Resources.Load<Sprite>("Sorter/Hole/Ellipse/Red"),
                },

                new Hole
                {
                    ColorID = 1,
                    FormID = 5,
                    sprite = Resources.Load<Sprite>("Sorter/Hole/Ellipse/Blue"),
                },

                new Hole
                {
                    ColorID = 2,
                    FormID = 5,
                    sprite = Resources.Load<Sprite>("Sorter/Hole/Ellipse/Yellow"),
                },

                new Hole
                {
                    ColorID = 3,
                    FormID = 5,
                    sprite = Resources.Load<Sprite>("Sorter/Hole/Ellipse/Green"),
                },

                new Hole
                {
                    ColorID = 4,
                    FormID = 5,
                    sprite = Resources.Load<Sprite>("Sorter/Hole/Ellipse/Pink"),
                },

                new Hole
                {
                    ColorID = 5,
                    FormID = 5,
                    sprite = Resources.Load<Sprite>("Sorter/Hole/Ellipse/Violet"),
                },

                new Hole
                {
                    ColorID = 6,
                    FormID = 5,
                    sprite = Resources.Load<Sprite>("Sorter/Hole/Ellipse/Brown"),
                },

                new Hole
                {
                    ColorID = 7,
                    FormID = 5,
                    sprite = Resources.Load<Sprite>("Sorter/Hole/Ellipse/Orange"),
                },

                new Hole
                {
                    ColorID = 8,
                    FormID = 5,
                    sprite = Resources.Load<Sprite>("Sorter/Hole/Ellipse/Aquamarine"),
                },

                new Hole
                {
                    ColorID = 0,
                    FormID = 6,
                    sprite = Resources.Load<Sprite>("Sorter/Hole/Pentagon/Red"),
                },

                new Hole
                {
                    ColorID = 1,
                    FormID = 6,
                    sprite = Resources.Load<Sprite>("Sorter/Hole/Pentagon/Blue"),
                },

                new Hole
                {
                    ColorID = 2,
                    FormID = 6,
                    sprite = Resources.Load<Sprite>("Sorter/Hole/Pentagon/Yellow"),
                },

                new Hole
                {
                    ColorID = 3,
                    FormID = 6,
                    sprite = Resources.Load<Sprite>("Sorter/Hole/Pentagon/Green"),
                },

                new Hole
                {
                    ColorID = 4,
                    FormID = 6,
                    sprite = Resources.Load<Sprite>("Sorter/Hole/Pentagon/Pink"),
                },

                new Hole
                {
                    ColorID = 5,
                    FormID = 6,
                    sprite = Resources.Load<Sprite>("Sorter/Hole/Pentagon/Violet"),
                },

                new Hole
                {
                    ColorID = 6,
                    FormID = 6,
                    sprite = Resources.Load<Sprite>("Sorter/Hole/Pentagon/Brown"),
                },

                new Hole
                {
                    ColorID = 7,
                    FormID = 6,
                    sprite = Resources.Load<Sprite>("Sorter/Hole/Pentagon/Orange"),
                },

                new Hole
                {
                    ColorID = 8,
                    FormID = 6,
                    sprite = Resources.Load<Sprite>("Sorter/Hole/Pentagon/Aquamarine"),
                },

                new Hole
                {
                    ColorID = 0,
                    FormID = 7,
                    sprite = Resources.Load<Sprite>("Sorter/Hole/Rectangle/Red"),
                },

                new Hole
                {
                    ColorID = 1,
                    FormID = 7,
                    sprite = Resources.Load<Sprite>("Sorter/Hole/Rectangle/Blue"),
                },

                new Hole
                {
                    ColorID = 2,
                    FormID = 7,
                    sprite = Resources.Load<Sprite>("Sorter/Hole/Rectangle/Yellow"),
                },

                new Hole
                {
                    ColorID = 3,
                    FormID = 7,
                    sprite = Resources.Load<Sprite>("Sorter/Hole/Rectangle/Green"),
                },

                new Hole
                {
                    ColorID = 4,
                    FormID = 7,
                    sprite = Resources.Load<Sprite>("Sorter/Hole/Rectangle/Pink"),
                },

                new Hole
                {
                    ColorID = 5,
                    FormID = 7,
                    sprite = Resources.Load<Sprite>("Sorter/Hole/Rectangle/Violet"),
                },

                new Hole
                {
                    ColorID = 6,
                    FormID = 7,
                    sprite = Resources.Load<Sprite>("Sorter/Hole/Rectangle/Brown"),
                },

                new Hole
                {
                    ColorID = 7,
                    FormID = 7,
                    sprite = Resources.Load<Sprite>("Sorter/Hole/Rectangle/Orange"),
                },

                new Hole
                {
                    ColorID = 8,
                    FormID = 7,
                    sprite = Resources.Load<Sprite>("Sorter/Hole/Rectangle/Aquamarine"),
                },
            };

            Animals = new List<Animal>
            {
                new Animal
                {
                    ID = 0,
                    Name = "Cow",
                    Picture = Resources.Load<Sprite>("AnimalSound/Cow/Picture"),
                    Image1 = Resources.Load<Sprite>("AnimalSound/Cow/Image1"),
                    Image2 = Resources.Load<Sprite>("AnimalSound/Cow/Image2"),
                    Image3 = Resources.Load<Sprite>("AnimalSound/Cow/Image3"),
                },

                new Animal
                {
                    ID = 1,
                    Name = "Sheep",
                    Picture = Resources.Load<Sprite>("AnimalSound/Sheep/Picture"),
                    Image1 = Resources.Load<Sprite>("AnimalSound/Sheep/Image1"),
                    Image2 = Resources.Load<Sprite>("AnimalSound/Sheep/Image2"),
                    Image3 = Resources.Load<Sprite>("AnimalSound/Sheep/Image3"),
                },

                new Animal
                {
                    ID = 2,
                    Name = "Cat",
                    Picture = Resources.Load<Sprite>("AnimalSound/Cat/Picture"),
                    Image1 = Resources.Load<Sprite>("AnimalSound/Cat/Image1"),
                    Image2 = Resources.Load<Sprite>("AnimalSound/Cat/Image2"),
                    Image3 = Resources.Load<Sprite>("AnimalSound/Cat/Image3"),
                },

                new Animal
                {
                    ID = 3,
                    Name = "Dog",
                    Picture = Resources.Load<Sprite>("AnimalSound/Dog/Picture"),
                    Image1 = Resources.Load<Sprite>("AnimalSound/Dog/Image1"),
                    Image2 = Resources.Load<Sprite>("AnimalSound/Dog/Image2"),
                    Image3 = Resources.Load<Sprite>("AnimalSound/Dog/Image3"),
                },

                new Animal
                {
                    ID = 4,
                    Name = "Pig",
                    Picture = Resources.Load<Sprite>("AnimalSound/Pig/Picture"),
                    Image1 = Resources.Load<Sprite>("AnimalSound/Pig/Image1"),
                    Image2 = Resources.Load<Sprite>("AnimalSound/Pig/Image2"),
                    Image3 = Resources.Load<Sprite>("AnimalSound/Pig/Image3"),
                },

                new Animal
                {
                    ID = 5,
                    Name = "Horse",
                    Picture = Resources.Load<Sprite>("AnimalSound/Horse/Picture"),
                    Image1 = Resources.Load<Sprite>("AnimalSound/Horse/Image1"),
                    Image2 = Resources.Load<Sprite>("AnimalSound/Horse/Image2"),
                    Image3 = Resources.Load<Sprite>("AnimalSound/Horse/Image3"),
                },

                new Animal
                {
                    ID = 6,
                    Name = "Chicken",
                    Picture = Resources.Load<Sprite>("AnimalSound/Chicken/Picture"),
                    Image1 = Resources.Load<Sprite>("AnimalSound/Chicken/Image1"),
                    Image2 = Resources.Load<Sprite>("AnimalSound/Chicken/Image2"),
                    Image3 = Resources.Load<Sprite>("AnimalSound/Chicken/Image3"),
                },

                new Animal
                {
                    ID = 7,
                    Name = "Goose",
                    Picture = Resources.Load<Sprite>("AnimalSound/Goose/Picture"),
                    Image1 = Resources.Load<Sprite>("AnimalSound/Goose/Image1"),
                    Image2 = Resources.Load<Sprite>("AnimalSound/Goose/Image2"),
                    Image3 = Resources.Load<Sprite>("AnimalSound/Goose/Image3"),
                },

                new Animal
                {
                    ID = 8,
                    Name = "Rabbit",
                    Picture = Resources.Load<Sprite>("AnimalSound/Rabbit/Picture"),
                    Image1 = Resources.Load<Sprite>("AnimalSound/Rabbit/Image1"),
                    Image2 = Resources.Load<Sprite>("AnimalSound/Rabbit/Image2"),
                    Image3 = Resources.Load<Sprite>("AnimalSound/Rabbit/Image3"),
                },

                new Animal
                {
                    ID = 9,
                    Name = "Turkey",
                    Picture = Resources.Load<Sprite>("AnimalSound/Turkey/Picture"),
                    Image1 = Resources.Load<Sprite>("AnimalSound/Turkey/Image1"),
                    Image2 = Resources.Load<Sprite>("AnimalSound/Turkey/Image2"),
                    Image3 = Resources.Load<Sprite>("AnimalSound/Turkey/Image3"),
                },
            };

            Tiles = new List<Tile>
            {
                new Tile
                {
                    ID = 0,
                    OtherSide = Resources.Load<Sprite>("Guessing/Cherry"),
                },

                new Tile
                {
                    ID = 1,
                    OtherSide = Resources.Load<Sprite>("Guessing/Plum"),
                },

                new Tile
                {
                    ID = 2,
                    OtherSide = Resources.Load<Sprite>("Guessing/Watermelon"),
                },

                new Tile
                {
                    ID = 3,
                    OtherSide = Resources.Load<Sprite>("Guessing/Melon"),
                },

                new Tile
                {
                    ID = 4,
                    OtherSide = Resources.Load<Sprite>("Guessing/Grapes"),
                },

                new Tile
                {
                    ID = 5,
                    OtherSide = Resources.Load<Sprite>("Guessing/Orange"),
                },

                new Tile
                {
                    ID = 6,
                    OtherSide = Resources.Load<Sprite>("Guessing/Lemon"),
                },

                new Tile
                {
                    ID = 7,
                    OtherSide = Resources.Load<Sprite>("Guessing/Appel"),
                },

                new Tile
                {
                    ID = 8,
                    OtherSide = Resources.Load<Sprite>("Guessing/Pear"),
                },

                new Tile
                {
                    ID = 9,
                    OtherSide = Resources.Load<Sprite>("Guessing/Beet"),
                },

                new Tile
                {
                    ID = 10,
                    OtherSide = Resources.Load<Sprite>("Guessing/Cabbage"),
                },

                new Tile
                {
                    ID = 11,
                    OtherSide = Resources.Load<Sprite>("Guessing/Carrot"),
                },

                new Tile
                {
                    ID = 12,
                    OtherSide = Resources.Load<Sprite>("Guessing/Cucumber"),
                },

                new Tile
                {
                    ID = 13,
                    OtherSide = Resources.Load<Sprite>("Guessing/Eggplant"),
                },

                new Tile
                {
                    ID = 14,
                    OtherSide = Resources.Load<Sprite>("Guessing/Pepper"),
                },

                new Tile
                {
                    ID = 15,
                    OtherSide = Resources.Load<Sprite>("Guessing/Tomato"),
                },

                new Tile
                {
                    ID = 16,
                    OtherSide = Resources.Load<Sprite>("Guessing/Radish"),
                },
            };
        }
    }
}
