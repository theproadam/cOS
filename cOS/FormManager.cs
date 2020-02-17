using System;
using System.Collections.Generic;
using System.Text;
using System.Drawing;

namespace CosmosBoot1
{
    public static class FormManager
    {
        public static void ClearForm(object Form)
        { 
            
        } 
    }


    public static class BitMapConverter
    {
        public static void ConvertToBitmap()
        { 
        
        }

        public static void AddEntry()
        {
        //Program.SetPallete(



        }

        public static void ConvertToVGAScreen(Bitmap BitMap)
        { 
            
            
        }

        public static int GetXCol()
        {

            return 0;
        }
    }

    public class Form
    {
        public static uint LastFormCreatedPosX;
        public static uint LastFormCreatedPosY;
        public static uint LastFormCreatedWidth;
        public static uint LastFormCreatedHeight;

        /// <summary>
        /// Form Name
        /// </summary>
        /// <param name="FormName"></param>
        /// 
        /// <summary>
        /// Creates a Form. This method is outdated, please do not use.
        /// </summary>
        /// <param name="Create"></param>
        /// <summary>
        /// Displays The Form. Optional (posx, posy) options.
        /// </summary>
        /// <param name="Show"></param>

        public void Create(string FormName)
        {

        }

        public void Add(Control obj, string Text, uint posx, uint posy)
        {
            if (obj == Control.Button)
            {
                Program.DrawButton(posx, posy, Text, Program.ButtonPosition.CenterX);
            }
        }

        public void Show(uint posx, uint posy, int pow, int poh, uint Col)
        { 
          //  Program.DrawRectangle(38, 18, 320 - 76, 200 - 36, 4);
            Program.DrawRectangle(posx, posy, pow, poh, Col);
            LastFormCreatedPosX = posx;
            LastFormCreatedPosY = posy;
            LastFormCreatedWidth = (uint)pow;
            LastFormCreatedHeight = (uint)poh;
        }



        public enum Control
        { 
            Button,

            Label,

            Other
        
        }
    }
}
