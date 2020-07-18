using CollViewFondo.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace CollViewFondo.Services
{
    public class ColorsService
    {
        public static List<SquareColor> GetColors(int numberOfSquares = 15)
        {
            int colorSpace = 255 / numberOfSquares;
            int color = 10;
            List<SquareColor> SquareColors = new List<SquareColor>();
            for (int i = 0; i < numberOfSquares; i++)
            {
                SquareColors.Add(new SquareColor
                {
                    HexCode = $"#0000{color:x2}",
                    Size = color
                });
                color += colorSpace;
            }
            return SquareColors;
        }
    }


}
