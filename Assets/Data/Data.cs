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
        public AudioClip Sound;
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
        public AudioClip Sound1;
        public AudioClip Sound2;
        public AudioClip Sound3;
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
                    Sound = Resources.Load<AudioClip>("Sorter/Figure/Rhombus/RedSound"),
                },

                new Figure
                {
                    ColorID = 1,
                    FormID = 0,
                    OnShadow = Resources.Load<Sprite>("Sorter/FigureOnShadow/Rhombus/Blue"),
                    sprite = Resources.Load<Sprite>("Sorter/Figure/Rhombus/Blue"),
                    Sound = Resources.Load<AudioClip>("Sorter/Figure/Rhombus/BlueSound"),
                },

                new Figure
                {
                    ColorID = 2,
                    FormID = 0,
                    OnShadow = Resources.Load<Sprite>("Sorter/FigureOnShadow/Rhombus/Yellow"),
                    sprite = Resources.Load<Sprite>("Sorter/Figure/Rhombus/Yellow"),
                    Sound = Resources.Load<AudioClip>("Sorter/Figure/Rhombus/YellowSound"),
                },

                new Figure
                {
                    ColorID = 3,
                    FormID = 0,
                    OnShadow = Resources.Load<Sprite>("Sorter/FigureOnShadow/Rhombus/Green"),
                    sprite = Resources.Load<Sprite>("Sorter/Figure/Rhombus/Green"),
                    Sound = Resources.Load<AudioClip>("Sorter/Figure/Rhombus/GreenSound"),
                },

                new Figure
                {
                    ColorID = 4,
                    FormID = 0,
                    OnShadow = Resources.Load<Sprite>("Sorter/FigureOnShadow/Rhombus/Pink"),
                    sprite = Resources.Load<Sprite>("Sorter/Figure/Rhombus/Pink"),
                    Sound = Resources.Load<AudioClip>("Sorter/Figure/Rhombus/PinkSound"),
                },

                new Figure
                {
                    ColorID = 5,
                    FormID = 0,
                    OnShadow = Resources.Load<Sprite>("Sorter/FigureOnShadow/Rhombus/Violet"),
                    sprite = Resources.Load<Sprite>("Sorter/Figure/Rhombus/Violet"),
                    Sound = Resources.Load<AudioClip>("Sorter/Figure/Rhombus/VioletSound"),
                },

                new Figure
                {
                    ColorID = 6,
                    FormID = 0,
                    OnShadow = Resources.Load<Sprite>("Sorter/FigureOnShadow/Rhombus/Brown"),
                    sprite = Resources.Load<Sprite>("Sorter/Figure/Rhombus/Brown"),
                    Sound = Resources.Load<AudioClip>("Sorter/Figure/Rhombus/BrownSound"),
                },

                new Figure
                {
                    ColorID = 7,
                    FormID = 0,
                    OnShadow = Resources.Load<Sprite>("Sorter/FigureOnShadow/Rhombus/Orange"),
                    sprite = Resources.Load<Sprite>("Sorter/Figure/Rhombus/Orange"),
                    Sound = Resources.Load<AudioClip>("Sorter/Figure/Rhombus/OrangeSound"),
                },

                new Figure
                {
                    ColorID = 8,
                    FormID = 0,
                    OnShadow = Resources.Load<Sprite>("Sorter/FigureOnShadow/Rhombus/Aquamarine"),
                    sprite = Resources.Load<Sprite>("Sorter/Figure/Rhombus/Aquamarine"),
                    Sound = Resources.Load<AudioClip>("Sorter/Figure/Rhombus/AquamarineSound"),
                },

                new Figure
                {
                    ColorID = 0,
                    FormID = 1,
                    OnShadow = Resources.Load<Sprite>("Sorter/FigureOnShadow/Hexagon/Red"),
                    sprite = Resources.Load<Sprite>("Sorter/Figure/Hexagon/Red"),
                    Sound = Resources.Load<AudioClip>("Sorter/Figure/Hexagon/RedSound"),
                },

                new Figure
                {
                    ColorID = 1,
                    FormID = 1,
                    OnShadow = Resources.Load<Sprite>("Sorter/FigureOnShadow/Hexagon/Blue"),
                    sprite = Resources.Load<Sprite>("Sorter/Figure/Hexagon/Blue"),
                    Sound = Resources.Load<AudioClip>("Sorter/Figure/Hexagon/BlueSound"),
                },

                new Figure
                {
                    ColorID = 2,
                    FormID = 1,
                    OnShadow = Resources.Load<Sprite>("Sorter/FigureOnShadow/Hexagon/Yellow"),
                    sprite = Resources.Load<Sprite>("Sorter/Figure/Hexagon/Yellow"),
                    Sound = Resources.Load<AudioClip>("Sorter/Figure/Hexagon/YellowSound"),
                },

                new Figure
                {
                    ColorID = 3,
                    FormID = 1,
                    OnShadow = Resources.Load<Sprite>("Sorter/FigureOnShadow/Hexagon/Green"),
                    sprite = Resources.Load<Sprite>("Sorter/Figure/Hexagon/Green"),
                    Sound = Resources.Load<AudioClip>("Sorter/Figure/Hexagon/GreenSound"),
                },

                new Figure
                {
                    ColorID = 4,
                    FormID = 1,
                    OnShadow = Resources.Load<Sprite>("Sorter/FigureOnShadow/Hexagon/Pink"),
                    sprite = Resources.Load<Sprite>("Sorter/Figure/Hexagon/Pink"),
                    Sound = Resources.Load<AudioClip>("Sorter/Figure/Hexagon/PinkSound"),
                },

                new Figure
                {
                    ColorID = 5,
                    FormID = 1,
                    OnShadow = Resources.Load<Sprite>("Sorter/FigureOnShadow/Hexagon/Violet"),
                    sprite = Resources.Load<Sprite>("Sorter/Figure/Hexagon/Violet"),
                    Sound = Resources.Load<AudioClip>("Sorter/Figure/Hexagon/VioletSound"),
                },

                new Figure
                {
                    ColorID = 6,
                    FormID = 1,
                    OnShadow = Resources.Load<Sprite>("Sorter/FigureOnShadow/Hexagon/Brown"),
                    sprite = Resources.Load<Sprite>("Sorter/Figure/Hexagon/Brown"),
                    Sound = Resources.Load<AudioClip>("Sorter/Figure/Hexagon/BrownSound"),
                },

                new Figure
                {
                    ColorID = 7,
                    FormID = 1,
                    OnShadow = Resources.Load<Sprite>("Sorter/FigureOnShadow/Hexagon/Orange"),
                    sprite = Resources.Load<Sprite>("Sorter/Figure/Hexagon/Orange"),
                    Sound = Resources.Load<AudioClip>("Sorter/Figure/Hexagon/OrangeSound"),
                },

                new Figure
                {
                    ColorID = 8,
                    FormID = 1,
                    OnShadow = Resources.Load<Sprite>("Sorter/FigureOnShadow/Hexagon/Aquamarine"),
                    sprite = Resources.Load<Sprite>("Sorter/Figure/Hexagon/Aquamarine"),
                    Sound = Resources.Load<AudioClip>("Sorter/Figure/Hexagon/AquamarineSound"),
                },

                 new Figure
                {
                    ColorID = 0,
                    FormID = 2,
                    OnShadow = Resources.Load<Sprite>("Sorter/FigureOnShadow/Square/Red"),
                    sprite = Resources.Load<Sprite>("Sorter/Figure/Square/Red"),
                    Sound = Resources.Load<AudioClip>("Sorter/Figure/Square/RedSound"),
                },

                new Figure
                {
                    ColorID = 1,
                    FormID = 2,
                    OnShadow = Resources.Load<Sprite>("Sorter/FigureOnShadow/Square/Blue"),
                    sprite = Resources.Load<Sprite>("Sorter/Figure/Square/Blue"),
                    Sound = Resources.Load<AudioClip>("Sorter/Figure/Square/BlueSound"),
                },

                new Figure
                {
                    ColorID = 2,
                    FormID = 2,
                    OnShadow = Resources.Load<Sprite>("Sorter/FigureOnShadow/Square/Yellow"),
                    sprite = Resources.Load<Sprite>("Sorter/Figure/Square/Yellow"),
                    Sound = Resources.Load<AudioClip>("Sorter/Figure/Square/YellowSound"),
                },

                new Figure
                {
                    ColorID = 3,
                    FormID = 2,
                    OnShadow = Resources.Load<Sprite>("Sorter/FigureOnShadow/Square/Green"),
                    sprite = Resources.Load<Sprite>("Sorter/Figure/Square/Green"),
                    Sound = Resources.Load<AudioClip>("Sorter/Figure/Square/GreenSound"),
                },

                new Figure
                {
                    ColorID = 4,
                    FormID = 2,
                    OnShadow = Resources.Load<Sprite>("Sorter/FigureOnShadow/Square/Pink"),
                    sprite = Resources.Load<Sprite>("Sorter/Figure/Square/Pink"),
                    Sound = Resources.Load<AudioClip>("Sorter/Figure/Square/PinkSound"),
                },

                new Figure
                {
                    ColorID = 5,
                    FormID = 2,
                    OnShadow = Resources.Load<Sprite>("Sorter/FigureOnShadow/Square/Violet"),
                    sprite = Resources.Load<Sprite>("Sorter/Figure/Square/Violet"),
                    Sound = Resources.Load<AudioClip>("Sorter/Figure/Square/VioletSound"),
                },

                new Figure
                {
                    ColorID = 6,
                    FormID = 2,
                    OnShadow = Resources.Load<Sprite>("Sorter/FigureOnShadow/Square/Brown"),
                    sprite = Resources.Load<Sprite>("Sorter/Figure/Square/Brown"),
                    Sound = Resources.Load<AudioClip>("Sorter/Figure/Square/BrownSound"),
                },

                new Figure
                {
                    ColorID = 7,
                    FormID = 2,
                    OnShadow = Resources.Load<Sprite>("Sorter/FigureOnShadow/Square/Orange"),
                    sprite = Resources.Load<Sprite>("Sorter/Figure/Square/Orange"),
                    Sound = Resources.Load<AudioClip>("Sorter/Figure/Square/OrangeSound"),
                },

                new Figure
                {
                    ColorID = 8,
                    FormID = 2,
                    OnShadow = Resources.Load<Sprite>("Sorter/FigureOnShadow/Square/Aquamarine"),
                    sprite = Resources.Load<Sprite>("Sorter/Figure/Square/Aquamarine"),
                    Sound = Resources.Load<AudioClip>("Sorter/Figure/Square/AquamarineSound"),
                },

                new Figure
                {
                    ColorID = 0,
                    FormID = 3,
                    OnShadow = Resources.Load<Sprite>("Sorter/FigureOnShadow/Triangle/Red"),
                    sprite = Resources.Load<Sprite>("Sorter/Figure/Triangle/Red"),
                    Sound = Resources.Load<AudioClip>("Sorter/Figure/Triangle/RedSound"),
                },

                new Figure
                {
                    ColorID = 1,
                    FormID = 3,
                    OnShadow = Resources.Load<Sprite>("Sorter/FigureOnShadow/Triangle/Blue"),
                    sprite = Resources.Load<Sprite>("Sorter/Figure/Triangle/Blue"),
                    Sound = Resources.Load<AudioClip>("Sorter/Figure/Triangle/BlueSound"),
                },

                new Figure
                {
                    ColorID = 2,
                    FormID = 3,
                    OnShadow = Resources.Load<Sprite>("Sorter/FigureOnShadow/Triangle/Yellow"),
                    sprite = Resources.Load<Sprite>("Sorter/Figure/Triangle/Yellow"),
                    Sound = Resources.Load<AudioClip>("Sorter/Figure/Triangle/YellowSound"),
                },

                new Figure
                {
                    ColorID = 3,
                    FormID = 3,
                    OnShadow = Resources.Load<Sprite>("Sorter/FigureOnShadow/Triangle/Green"),
                    sprite = Resources.Load<Sprite>("Sorter/Figure/Triangle/Green"),
                    Sound = Resources.Load<AudioClip>("Sorter/Figure/Triangle/GreenSound"),
                },

                new Figure
                {
                    ColorID = 4,
                    FormID = 3,
                    OnShadow = Resources.Load<Sprite>("Sorter/FigureOnShadow/Triangle/Pink"),
                    sprite = Resources.Load<Sprite>("Sorter/Figure/Triangle/Pink"),
                    Sound = Resources.Load<AudioClip>("Sorter/Figure/Triangle/PinkSound"),
                },

                new Figure
                {
                    ColorID = 5,
                    FormID = 3,
                    OnShadow = Resources.Load<Sprite>("Sorter/FigureOnShadow/Triangle/Violet"),
                    sprite = Resources.Load<Sprite>("Sorter/Figure/Triangle/Violet"),
                    Sound = Resources.Load<AudioClip>("Sorter/Figure/Triangle/VioletSound"),
                },

                new Figure
                {
                    ColorID = 6,
                    FormID = 3,
                    OnShadow = Resources.Load<Sprite>("Sorter/FigureOnShadow/Triangle/Brown"),
                    sprite = Resources.Load<Sprite>("Sorter/Figure/Triangle/Brown"),
                    Sound = Resources.Load<AudioClip>("Sorter/Figure/Triangle/BrownSound"),
                },

                new Figure
                {
                    ColorID = 7,
                    FormID = 3,
                    OnShadow = Resources.Load<Sprite>("Sorter/FigureOnShadow/Triangle/Orange"),
                    sprite = Resources.Load<Sprite>("Sorter/Figure/Triangle/Orange"),
                    Sound = Resources.Load<AudioClip>("Sorter/Figure/Triangle/OrangeSound"),
                },

                new Figure
                {
                    ColorID = 8,
                    FormID = 3,
                    OnShadow = Resources.Load<Sprite>("Sorter/FigureOnShadow/Triangle/Aquamarine"),
                    sprite = Resources.Load<Sprite>("Sorter/Figure/Triangle/Aquamarine"),
                    Sound = Resources.Load<AudioClip>("Sorter/Figure/Triangle/AquamarineSound"),
                },

                new Figure
                {
                    ColorID = 0,
                    FormID = 4,
                    OnShadow = Resources.Load<Sprite>("Sorter/FigureOnShadow/Сircle/Red"),
                    sprite = Resources.Load<Sprite>("Sorter/Figure/Сircle/Red"),
                    Sound = Resources.Load<AudioClip>("Sorter/Figure/Сircle/RedSound"),
                },

                new Figure
                {
                    ColorID = 1,
                    FormID = 4,
                    OnShadow = Resources.Load<Sprite>("Sorter/FigureOnShadow/Сircle/Blue"),
                    sprite = Resources.Load<Sprite>("Sorter/Figure/Сircle/Blue"),
                    Sound = Resources.Load<AudioClip>("Sorter/Figure/Сircle/BlueSound"),
                },

                new Figure
                {
                    ColorID = 2,
                    FormID = 4,
                    OnShadow = Resources.Load<Sprite>("Sorter/FigureOnShadow/Сircle/Yellow"),
                    sprite = Resources.Load<Sprite>("Sorter/Figure/Сircle/Yellow"),
                    Sound = Resources.Load<AudioClip>("Sorter/Figure/Сircle/YellowSound"),
                },

                new Figure
                {
                    ColorID = 3,
                    FormID = 4,
                    OnShadow = Resources.Load<Sprite>("Sorter/FigureOnShadow/Сircle/Green"),
                    sprite = Resources.Load<Sprite>("Sorter/Figure/Сircle/Green"),
                    Sound = Resources.Load<AudioClip>("Sorter/Figure/Сircle/GreenSound"),
                },

                new Figure
                {
                    ColorID = 4,
                    FormID = 4,
                    OnShadow = Resources.Load<Sprite>("Sorter/FigureOnShadow/Сircle/Pink"),
                    sprite = Resources.Load<Sprite>("Sorter/Figure/Сircle/Pink"),
                    Sound = Resources.Load<AudioClip>("Sorter/Figure/Сircle/PinkSound"),
                },

                new Figure
                {
                    ColorID = 5,
                    FormID = 4,
                    OnShadow = Resources.Load<Sprite>("Sorter/FigureOnShadow/Сircle/Violet"),
                    sprite = Resources.Load<Sprite>("Sorter/Figure/Сircle/Violet"),
                    Sound = Resources.Load<AudioClip>("Sorter/Figure/Сircle/VioletSound"),
                },

                new Figure
                {
                    ColorID = 6,
                    FormID = 4,
                    OnShadow = Resources.Load<Sprite>("Sorter/FigureOnShadow/Сircle/Brown"),
                    sprite = Resources.Load<Sprite>("Sorter/Figure/Сircle/Brown"),
                    Sound = Resources.Load<AudioClip>("Sorter/Figure/Сircle/BrownSound"),
                },

                new Figure
                {
                    ColorID = 7,
                    FormID = 4,
                    OnShadow = Resources.Load<Sprite>("Sorter/FigureOnShadow/Сircle/Orange"),
                    sprite = Resources.Load<Sprite>("Sorter/Figure/Сircle/Orange"),
                    Sound = Resources.Load<AudioClip>("Sorter/Figure/Сircle/OrangeSound"),
                },

                new Figure
                {
                    ColorID = 8,
                    FormID = 4,
                    OnShadow = Resources.Load<Sprite>("Sorter/FigureOnShadow/Сircle/Aquamarine"),
                    sprite = Resources.Load<Sprite>("Sorter/Figure/Сircle/Aquamarine"),
                    Sound = Resources.Load<AudioClip>("Sorter/Figure/Сircle/AquamarineSound"),
                },

                new Figure
                {
                    ColorID = 0,
                    FormID = 5,
                    OnShadow = Resources.Load<Sprite>("Sorter/FigureOnShadow/Ellipse/Red"),
                    sprite = Resources.Load<Sprite>("Sorter/Figure/Ellipse/Red"),
                    Sound = Resources.Load<AudioClip>("Sorter/Figure/Ellipse/RedSound"),
                },

                new Figure
                {
                    ColorID = 1,
                    FormID = 5,
                    OnShadow = Resources.Load<Sprite>("Sorter/FigureOnShadow/Ellipse/Blue"),
                    sprite = Resources.Load<Sprite>("Sorter/Figure/Ellipse/Blue"),
                    Sound = Resources.Load<AudioClip>("Sorter/Figure/Ellipse/BlueSound"),
                },

                new Figure
                {
                    ColorID = 2,
                    FormID = 5,
                    OnShadow = Resources.Load<Sprite>("Sorter/FigureOnShadow/Ellipse/Yellow"),
                    sprite = Resources.Load<Sprite>("Sorter/Figure/Ellipse/Yellow"),
                    Sound = Resources.Load<AudioClip>("Sorter/Figure/Ellipse/YellowSound"),
                },

                new Figure
                {
                    ColorID = 3,
                    FormID = 5,
                    OnShadow = Resources.Load<Sprite>("Sorter/FigureOnShadow/Ellipse/Green"),
                    sprite = Resources.Load<Sprite>("Sorter/Figure/Ellipse/Green"),
                    Sound = Resources.Load<AudioClip>("Sorter/Figure/Ellipse/GreenSound"),
                },

                new Figure
                {
                    ColorID = 4,
                    FormID = 5,
                    OnShadow = Resources.Load<Sprite>("Sorter/FigureOnShadow/Ellipse/Pink"),
                    sprite = Resources.Load<Sprite>("Sorter/Figure/Ellipse/Pink"),
                    Sound = Resources.Load<AudioClip>("Sorter/Figure/Ellipse/PinkSound"),
                },

                new Figure
                {
                    ColorID = 5,
                    FormID = 5,
                    OnShadow = Resources.Load<Sprite>("Sorter/FigureOnShadow/Ellipse/Violet"),
                    sprite = Resources.Load<Sprite>("Sorter/Figure/Ellipse/Violet"),
                    Sound = Resources.Load<AudioClip>("Sorter/Figure/Ellipse/VioletSound"),
                },

                new Figure
                {
                    ColorID = 6,
                    FormID = 5,
                    OnShadow = Resources.Load<Sprite>("Sorter/FigureOnShadow/Ellipse/Brown"),
                    sprite = Resources.Load<Sprite>("Sorter/Figure/Ellipse/Brown"),
                    Sound = Resources.Load<AudioClip>("Sorter/Figure/Ellipse/BrownSound"),
                },

                new Figure
                {
                    ColorID = 7,
                    FormID = 5,
                    OnShadow = Resources.Load<Sprite>("Sorter/FigureOnShadow/Ellipse/Orange"),
                    sprite = Resources.Load<Sprite>("Sorter/Figure/Ellipse/Orange"),
                    Sound = Resources.Load<AudioClip>("Sorter/Figure/Ellipse/OrangeSound"),
                },

                new Figure
                {
                    ColorID = 8,
                    FormID = 5,
                    OnShadow = Resources.Load<Sprite>("Sorter/FigureOnShadow/Ellipse/Aquamarine"),
                    sprite = Resources.Load<Sprite>("Sorter/Figure/Ellipse/Aquamarine"),
                    Sound = Resources.Load<AudioClip>("Sorter/Figure/Ellipse/AquamarineSound"),
                },

                new Figure
                {
                    ColorID = 0,
                    FormID = 6,
                    OnShadow = Resources.Load<Sprite>("Sorter/FigureOnShadow/Pentagon/Red"),
                    sprite = Resources.Load<Sprite>("Sorter/Figure/Pentagon/Red"),
                    Sound = Resources.Load<AudioClip>("Sorter/Figure/Pentagon/RedSound"),
                },

                new Figure
                {
                    ColorID = 1,
                    FormID = 6,
                    OnShadow = Resources.Load<Sprite>("Sorter/FigureOnShadow/Pentagon/Blue"),
                    sprite = Resources.Load<Sprite>("Sorter/Figure/Pentagon/Blue"),
                    Sound = Resources.Load<AudioClip>("Sorter/Figure/Pentagon/BlueSound"),
                },

                new Figure
                {
                    ColorID = 2,
                    FormID = 6,
                    OnShadow = Resources.Load<Sprite>("Sorter/FigureOnShadow/Pentagon/Yellow"),
                    sprite = Resources.Load<Sprite>("Sorter/Figure/Pentagon/Yellow"),
                    Sound = Resources.Load<AudioClip>("Sorter/Figure/Pentagon/YellowSound"),
                },

                new Figure
                {
                    ColorID = 3,
                    FormID = 6,
                    OnShadow = Resources.Load<Sprite>("Sorter/FigureOnShadow/Pentagon/Green"),
                    sprite = Resources.Load<Sprite>("Sorter/Figure/Pentagon/Green"),
                    Sound = Resources.Load<AudioClip>("Sorter/Figure/Pentagon/GreenSound"),
                },

                new Figure
                {
                    ColorID = 4,
                    FormID = 6,
                    OnShadow = Resources.Load<Sprite>("Sorter/FigureOnShadow/Pentagon/Pink"),
                    sprite = Resources.Load<Sprite>("Sorter/Figure/Pentagon/Pink"),
                    Sound = Resources.Load<AudioClip>("Sorter/Figure/Pentagon/PinkSound"),
                },

                new Figure
                {
                    ColorID = 5,
                    FormID = 6,
                    OnShadow = Resources.Load<Sprite>("Sorter/FigureOnShadow/Pentagon/Violet"),
                    sprite = Resources.Load<Sprite>("Sorter/Figure/Pentagon/Violet"),
                    Sound = Resources.Load<AudioClip>("Sorter/Figure/Pentagon/VioletSound"),
                },

                new Figure
                {
                    ColorID = 6,
                    FormID = 6,
                    OnShadow = Resources.Load<Sprite>("Sorter/FigureOnShadow/Pentagon/Brown"),
                    sprite = Resources.Load<Sprite>("Sorter/Figure/Pentagon/Brown"),
                    Sound = Resources.Load<AudioClip>("Sorter/Figure/Pentagon/BrownSound"),
                },

                new Figure
                {
                    ColorID = 7,
                    FormID = 6,
                    OnShadow = Resources.Load<Sprite>("Sorter/FigureOnShadow/Pentagon/Orange"),
                    sprite = Resources.Load<Sprite>("Sorter/Figure/Pentagon/Orange"),
                    Sound = Resources.Load<AudioClip>("Sorter/Figure/Pentagon/OrangeSound"),
                },

                new Figure
                {
                    ColorID = 8,
                    FormID = 6,
                    OnShadow = Resources.Load<Sprite>("Sorter/FigureOnShadow/Pentagon/Aquamarine"),
                    sprite = Resources.Load<Sprite>("Sorter/Figure/Pentagon/Aquamarine"),
                    Sound = Resources.Load<AudioClip>("Sorter/Figure/Pentagon/AquamarineSound"),
                },

                new Figure
                {
                    ColorID = 0,
                    FormID = 7,
                    OnShadow = Resources.Load<Sprite>("Sorter/FigureOnShadow/Rectangle/Red"),
                    sprite = Resources.Load<Sprite>("Sorter/Figure/Rectangle/Red"),
                    Sound = Resources.Load<AudioClip>("Sorter/Figure/Rectangle/RedSound"),
                },

                new Figure
                {
                    ColorID = 1,
                    FormID = 7,
                    OnShadow = Resources.Load<Sprite>("Sorter/FigureOnShadow/Rectangle/Blue"),
                    sprite = Resources.Load<Sprite>("Sorter/Figure/Rectangle/Blue"),
                    Sound = Resources.Load<AudioClip>("Sorter/Figure/Rectangle/BlueSound"),
                },

                new Figure
                {
                    ColorID = 2,
                    FormID = 7,
                    OnShadow = Resources.Load<Sprite>("Sorter/FigureOnShadow/Rectangle/Yellow"),
                    sprite = Resources.Load<Sprite>("Sorter/Figure/Rectangle/Yellow"),
                    Sound = Resources.Load<AudioClip>("Sorter/Figure/Rectangle/YellowSound"),
                },

                new Figure
                {
                    ColorID = 3,
                    FormID = 7,
                    OnShadow = Resources.Load<Sprite>("Sorter/FigureOnShadow/Rectangle/Green"),
                    sprite = Resources.Load<Sprite>("Sorter/Figure/Rectangle/Green"),
                    Sound = Resources.Load<AudioClip>("Sorter/Figure/Rectangle/GreenSound"),
                },

                new Figure
                {
                    ColorID = 4,
                    FormID = 7,
                    OnShadow = Resources.Load<Sprite>("Sorter/FigureOnShadow/Rectangle/Pink"),
                    sprite = Resources.Load<Sprite>("Sorter/Figure/Rectangle/Pink"),
                    Sound = Resources.Load<AudioClip>("Sorter/Figure/Rectangle/PinkSound"),
                },

                new Figure
                {
                    ColorID = 5,
                    FormID = 7,
                    OnShadow = Resources.Load<Sprite>("Sorter/FigureOnShadow/Rectangle/Violet"),
                    sprite = Resources.Load<Sprite>("Sorter/Figure/Rectangle/Violet"),
                    Sound = Resources.Load<AudioClip>("Sorter/Figure/Rectangle/VioletSound"),
                },

                new Figure
                {
                    ColorID = 6,
                    FormID = 7,
                    OnShadow = Resources.Load<Sprite>("Sorter/FigureOnShadow/Rectangle/Brown"),
                    sprite = Resources.Load<Sprite>("Sorter/Figure/Rectangle/Brown"),
                    Sound = Resources.Load<AudioClip>("Sorter/Figure/Rectangle/BrownSound"),
                },

                new Figure
                {
                    ColorID = 7,
                    FormID = 7,
                    OnShadow = Resources.Load<Sprite>("Sorter/FigureOnShadow/Rectangle/Orange"),
                    sprite = Resources.Load<Sprite>("Sorter/Figure/Rectangle/Orange"),
                    Sound = Resources.Load<AudioClip>("Sorter/Figure/Rectangle/OrangeSound"),
                },

                new Figure
                {
                    ColorID = 8,
                    FormID = 7,
                    OnShadow = Resources.Load<Sprite>("Sorter/FigureOnShadow/Rectangle/Aquamarine"),
                    sprite = Resources.Load<Sprite>("Sorter/Figure/Rectangle/Aquamarine"),
                    Sound = Resources.Load<AudioClip>("Sorter/Figure/Rectangle/AquamarineSound"),
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
                    Sound1 = Resources.Load<AudioClip>("AnimalSound/Cow/Sound1"),
                    Sound2 = Resources.Load<AudioClip>("AnimalSound/Cow/Sound2"),
                    Sound3 = Resources.Load<AudioClip>("AnimalSound/Cow/Sound3"),
                },

                new Animal
                {
                    ID = 1,
                    Name = "Sheep",
                    Picture = Resources.Load<Sprite>("AnimalSound/Sheep/Picture"),
                    Image1 = Resources.Load<Sprite>("AnimalSound/Sheep/Image1"),
                    Image2 = Resources.Load<Sprite>("AnimalSound/Sheep/Image2"),
                    Image3 = Resources.Load<Sprite>("AnimalSound/Sheep/Image3"),
                    Sound1 = Resources.Load<AudioClip>("AnimalSound/Sheep/Sound1"),
                    Sound2 = Resources.Load<AudioClip>("AnimalSound/Sheep/Sound2"),
                    Sound3 = Resources.Load<AudioClip>("AnimalSound/Sheep/Sound3"),
                },

                new Animal
                {
                    ID = 2,
                    Name = "Cat",
                    Picture = Resources.Load<Sprite>("AnimalSound/Cat/Picture"),
                    Image1 = Resources.Load<Sprite>("AnimalSound/Cat/Image1"),
                    Image2 = Resources.Load<Sprite>("AnimalSound/Cat/Image2"),
                    Image3 = Resources.Load<Sprite>("AnimalSound/Cat/Image3"),
                    Sound1 = Resources.Load<AudioClip>("AnimalSound/Cat/Sound1"),
                    Sound2 = Resources.Load<AudioClip>("AnimalSound/Cat/Sound2"),
                    Sound3 = Resources.Load<AudioClip>("AnimalSound/Cat/Sound3"),
                },

                new Animal
                {
                    ID = 3,
                    Name = "Dog",
                    Picture = Resources.Load<Sprite>("AnimalSound/Dog/Picture"),
                    Image1 = Resources.Load<Sprite>("AnimalSound/Dog/Image1"),
                    Image2 = Resources.Load<Sprite>("AnimalSound/Dog/Image2"),
                    Image3 = Resources.Load<Sprite>("AnimalSound/Dog/Image3"),
                    Sound1 = Resources.Load<AudioClip>("AnimalSound/Dog/Sound1"),
                    Sound2 = Resources.Load<AudioClip>("AnimalSound/Dog/Sound2"),
                    Sound3 = Resources.Load<AudioClip>("AnimalSound/Dog/Sound3"),
                },

                new Animal
                {
                    ID = 4,
                    Name = "Pig",
                    Picture = Resources.Load<Sprite>("AnimalSound/Pig/Picture"),
                    Image1 = Resources.Load<Sprite>("AnimalSound/Pig/Image1"),
                    Image2 = Resources.Load<Sprite>("AnimalSound/Pig/Image2"),
                    Image3 = Resources.Load<Sprite>("AnimalSound/Pig/Image3"),
                    Sound1 = Resources.Load<AudioClip>("AnimalSound/Pig/Sound1"),
                    Sound2 = Resources.Load<AudioClip>("AnimalSound/Pig/Sound2"),
                    Sound3 = Resources.Load<AudioClip>("AnimalSound/Pig/Sound3"),
                },

                new Animal
                {
                    ID = 5,
                    Name = "Horse",
                    Picture = Resources.Load<Sprite>("AnimalSound/Horse/Picture"),
                    Image1 = Resources.Load<Sprite>("AnimalSound/Horse/Image1"),
                    Image2 = Resources.Load<Sprite>("AnimalSound/Horse/Image2"),
                    Image3 = Resources.Load<Sprite>("AnimalSound/Horse/Image3"),
                    Sound1 = Resources.Load<AudioClip>("AnimalSound/Horse/Sound1"),
                    Sound2 = Resources.Load<AudioClip>("AnimalSound/Horse/Sound2"),
                    Sound3 = Resources.Load<AudioClip>("AnimalSound/Horse/Sound3"),
                },

                new Animal
                {
                    ID = 6,
                    Name = "Chicken",
                    Picture = Resources.Load<Sprite>("AnimalSound/Chicken/Picture"),
                    Image1 = Resources.Load<Sprite>("AnimalSound/Chicken/Image1"),
                    Image2 = Resources.Load<Sprite>("AnimalSound/Chicken/Image2"),
                    Image3 = Resources.Load<Sprite>("AnimalSound/Chicken/Image3"),
                    Sound1 = Resources.Load<AudioClip>("AnimalSound/Chicken/Sound1"),
                    Sound2 = Resources.Load<AudioClip>("AnimalSound/Chicken/Sound2"),
                    Sound3 = Resources.Load<AudioClip>("AnimalSound/Chicken/Sound3"),
                },

                new Animal
                {
                    ID = 7,
                    Name = "Goose",
                    Picture = Resources.Load<Sprite>("AnimalSound/Goose/Picture"),
                    Image1 = Resources.Load<Sprite>("AnimalSound/Goose/Image1"),
                    Image2 = Resources.Load<Sprite>("AnimalSound/Goose/Image2"),
                    Image3 = Resources.Load<Sprite>("AnimalSound/Goose/Image3"),
                    Sound1 = Resources.Load<AudioClip>("AnimalSound/Goose/Sound1"),
                    Sound2 = Resources.Load<AudioClip>("AnimalSound/Goose/Sound2"),
                    Sound3 = Resources.Load<AudioClip>("AnimalSound/Goose/Sound3"),
                },

                new Animal
                {
                    ID = 8,
                    Name = "Rabbit",
                    Picture = Resources.Load<Sprite>("AnimalSound/Rabbit/Picture"),
                    Image1 = Resources.Load<Sprite>("AnimalSound/Rabbit/Image1"),
                    Image2 = Resources.Load<Sprite>("AnimalSound/Rabbit/Image2"),
                    Image3 = Resources.Load<Sprite>("AnimalSound/Rabbit/Image3"),
                    Sound1 = Resources.Load<AudioClip>("AnimalSound/Rabbit/Sound1"),
                    Sound2 = Resources.Load<AudioClip>("AnimalSound/Rabbit/Sound2"),
                    Sound3 = Resources.Load<AudioClip>("AnimalSound/Rabbit/Sound3"),
                },

                new Animal
                {
                    ID = 9,
                    Name = "Turkey",
                    Picture = Resources.Load<Sprite>("AnimalSound/Turkey/Picture"),
                    Image1 = Resources.Load<Sprite>("AnimalSound/Turkey/Image1"),
                    Image2 = Resources.Load<Sprite>("AnimalSound/Turkey/Image2"),
                    Image3 = Resources.Load<Sprite>("AnimalSound/Turkey/Image3"),
                    Sound1 = Resources.Load<AudioClip>("AnimalSound/Turkey/Sound1"),
                    Sound2 = Resources.Load<AudioClip>("AnimalSound/Turkey/Sound2"),
                    Sound3 = Resources.Load<AudioClip>("AnimalSound/Turkey/Sound3"),
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
