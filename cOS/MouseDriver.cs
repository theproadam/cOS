using System;
using System.Collections.Generic;
using System.Text;
using Cosmos.IL2CPU;
using Cosmos.Kernel;
using Cosmos.Kernel.Plugs;
using Cosmos.Sys;

namespace CosmosBoot1
{
    static class MouseDriver
    {
        static void Initialize()
        {
            
        }

        static int MouseX()
        {


            return 0;
        }
    }

    public static class MouseD
    {
        public enum MouseState
        {
            None,
            Left,
            Right,
            Middle = 4
        }

        public static int X;

        public static int Y;

        public static MouseD.MouseState Buttons;

        private static byte mouse_cycle = 0;

        private static int[] mouse_byte = new int[4];

        public static void Initialize()
        {
        }

        private static byte Read()
        {
            MouseD.WaitData();
            return CPUBus.Read8(96);
        }

        private static void Write(byte b)
        {
            MouseD.WaitSignal();
            CPUBus.Write8(100, 212);
            MouseD.WaitSignal();
            CPUBus.Write8(96, b);
        }

        private static void WaitData()
        {
            
            int num = 0;
            while (num < 1000 & (CPUBus.Read8(100) & 1) == 1)
            {
                num++;
            }
        }

        private static void WaitSignal()
        {
            int num = 0;
            while (num < 1000 & (CPUBus.Read8(100) & 2) != 0)
            {
                num++;
            }
        }

        public static void HandleMouse(ref Cosmos.Hardware.Interrupts.InterruptContext context)
        {
            switch (MouseD.mouse_cycle)
            {
                case 0:
                    MouseD.mouse_byte[0] = (int)CPUBus.Read8(96);
                    if ((MouseD.mouse_byte[0] & 8) == 8)
                    {
                        MouseD.mouse_cycle += 1;
                    }
                    break;
                case 1:
                    MouseD.mouse_byte[1] = (int)CPUBus.Read8(96);
                    MouseD.mouse_cycle += 1;
                    break;
                case 2:
                    MouseD.mouse_byte[2] = (int)CPUBus.Read8(96);
                    MouseD.mouse_cycle = 0;
                    if ((MouseD.mouse_byte[0] & 16) == 16)
                    {
                        MouseD.X -= (MouseD.mouse_byte[1] ^ 255);
                    }
                    else
                    {
                        MouseD.X += MouseD.mouse_byte[1];
                    }
                    if ((MouseD.mouse_byte[0] & 32) == 32)
                    {
                        MouseD.Y += (MouseD.mouse_byte[2] ^ 255);
                    }
                    else
                    {
                        MouseD.Y -= MouseD.mouse_byte[2];
                    }
                    if (MouseD.X < 0)
                    {
                        MouseD.X = 0;
                    }
                    else if (MouseD.X > 319)
                    {
                        MouseD.X = 319;
                    }
                    if (MouseD.Y < 0)
                    {
                        MouseD.Y = 0;
                    }
                    else if (MouseD.Y > 199)
                    {
                        MouseD.Y = 199;
                    }
                    MouseD.Buttons = (MouseD.MouseState)(MouseD.mouse_byte[0] & 7);
                    break;
            }
        }
    }
}
