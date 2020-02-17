using System;
using System.Threading;
using Cosmos.Sys.FileSystem.FAT32;
using Cosmos.Sys.FileSystem;
using Cosmos.Compiler.Builder;
using Cosmos.Hardware;
using Cosmos.Hardware.Network.TCPIPModel.NetworkLayer.IPv4;
using Cosmos.Hardware.Network.TCPIPModel.PhysicalLayer.Ethernet2;
using Cosmos.Sys;
using Cosmos.Kernel;
using Cosmos.IL2CPU;
using Cosmos.IL2CPU.Plugs;
using Cosmos.IL2CPU.ILOpCodes;


// using CosmosBoot1;


using Network = Cosmos.Sys.Network;

namespace CosmosBoot1
{
    class Program
    {
        #region Cosmos Builder logic
        // Most users wont touch this. This will call the Cosmos Build tool
        [STAThread]
        static void Main(string[] args)
        {
            BuildUI.Run();
            
        }
        #endregion

        // Main entry point of the kernel
      //  public static VGAScreen VScreen = new VGAScreen();
        public static int ClockFormatSettings = 1;
        public static bool Clock24HourSetting = true;
        public static uint sensitivity = 2;

        public static void Init()
        {
            var xBoot = new Cosmos.Sys.Boot();
            xBoot.Execute();

            
            
           

        //  AfterRun("gorsk");
          
        //    VidInit();

            Cosmos.Hardware.Mouse.Initialize();


           // MouseDriver test = new MouseDriver();

          //  test.Initialize();

            
         //   Mouse = new Cosmos.Hardware.Mouse;

           
            
            
            /*/
         //   Console.WriteLine(Cosmos.Hardware.RTC.GetHours());
        //    Console.WriteLine(Cosmos.Hardware.RTC.GetMinutes());
            Console.WriteLine(Cosmos.Hardware.RTC.GetSeconds());

            Cosmos.Hardware.PIT.PlaySound(1500);

            /*/

            uint mem = CPU.AmountOfMemory;
            mem = mem + 1;

         //   Console.WriteLine();
            

         //   Console.WriteLine(Cosmos.Kernel.Plugs.CPU.GetAmountOfRAM().ToString());

            

            


         //   Console.ReadLine();
            
           // VGAScreen.Clear(1);


        //    Console.WriteLine("Coolest");

            

  //          Cosmos.Hardware.VGAScreen.Colors
          
            
          //  PIT.EnableSound();
          //  Cosmos.Hardware.PIT.PlaySound(1500);

       //     Cosmos.Hardware.Keyboard.ReadKey();

       //     AfterRun("user");
            /*/
                Console.WriteLine("Use Quick Start? Y/N");
                string rep = Console.ReadLine();
                if (rep.ToLower() == "y")
                {
                    AfterRun("user");
                }
             * /*/
            
            //    Console.Clear();
          //      Console.WriteLine("isolinux -kernel cOS -RunMode Old");
            //    Cosmos.Hardware.PIT.Wait(1000);
            //    Console.Clear();

            Console.ForegroundColor = ConsoleColor.Gray;
          //  Console.WriteLine("Welcome! You just booted C# code. Please edit Program.cs to fit your needs");
            Console.WriteLine("---------------------------------Boot Successful--------------------------------");
            Cosmos.Hardware.PIT.Wait(100);
            Cosmos.Hardware.PIT.Wait(100);
            Console.WriteLine("cOS Starter Version 0.0.0.1");
            Cosmos.Hardware.PIT.Wait(100);
            Console.WriteLine("Running Self Check");
            Cosmos.Hardware.PIT.Wait(100);

            Console.Write("Checking RAM = ");
            Console.ForegroundColor = ConsoleColor.Green;
            Cosmos.Hardware.PIT.Wait(100);
            Console.WriteLine("OK");
            Console.ForegroundColor = ConsoleColor.Gray;
            Cosmos.Hardware.PIT.Wait(100);

            


            Console.Write("Checking CPU = ");
            Console.ForegroundColor = ConsoleColor.Green;
            Cosmos.Hardware.PIT.Wait(100);
            Console.WriteLine("OK");
            Console.ForegroundColor = ConsoleColor.Gray;
            Cosmos.Hardware.PIT.Wait(100);

            Console.Write("Checking Network = ");
            Console.ForegroundColor = ConsoleColor.Red;
            Cosmos.Hardware.PIT.Wait(100);
            Console.WriteLine("No Network Detected");
            Cosmos.Hardware.PIT.Wait(100);


            Console.ForegroundColor = ConsoleColor.Gray;


            Console.Write("Checking Storage = ");
            Console.ForegroundColor = ConsoleColor.Red;
            Cosmos.Hardware.PIT.Wait(100);
            Console.WriteLine("None Found");

            Cosmos.Hardware.PIT.Wait(1000);
            Console.Write("No Strorage Found: ");
            Console.ForegroundColor = ConsoleColor.Gray;
            Console.WriteLine("cOS Will Start In Live Disc Mode");
            Cosmos.Hardware.PIT.Wait(100);
            Console.WriteLine("");
            Cosmos.Hardware.PIT.Wait(2000);
            Console.Clear();

            Cosmos.Hardware.PIT.Wait(2000);
        Console.Clear();
            /*/
        try
        {
           

           
            

            Partition part = null;
            for (int j = 0; j < Cosmos.Hardware.BlockDevice.Devices.Count; j++)
            {
                if (Cosmos.Hardware.BlockDevice.Devices[j] is Partition)
                {
                    part = (Partition)Cosmos.Hardware.BlockDevice.Devices[j];
                }
            }
            var fs = new Cosmos.Sys.FileSystem.FAT32.FAT32(part);
            uint cluster = 100;
            fs.Format("newCluster", cluster);
         

        }
        catch 
        { }

            /*/
        Console.Clear();
        Cosmos.Hardware.PIT.Wait(1500);
        Console.WriteLine("cOS Is Starting");
        Cosmos.Hardware.PIT.Wait(1000);

        Console.WriteLine(@"Loaded -> HDD:\FileSystem\System\BOOT.CFG");
        Cosmos.Hardware.PIT.Wait(50);
        Console.WriteLine(@"Loaded -> HDD:\FileSystem\System\TEXT.CFG");
        Cosmos.Hardware.PIT.Wait(50);
        Console.WriteLine(@"Loaded -> HDD:\FileSystem\System\SETTINGS.SYS");
        Cosmos.Hardware.PIT.Wait(50);
        Console.WriteLine(@"Loaded -> HDD:\FileSystem\System\VIDEO.SYS");
        Cosmos.Hardware.PIT.Wait(50);
        Console.WriteLine(@"Loaded -> HDD:\FileSystem\System\RUN.SYS");
        Cosmos.Hardware.PIT.Wait(50);
        Console.WriteLine(@"Loaded -> HDD:\FileSystem\System\IO.SYS");
        Cosmos.Hardware.PIT.Wait(50);
        Console.WriteLine(@"Loaded -> HDD:\FileSystem\System\INPUT.FILE");
        Cosmos.Hardware.PIT.Wait(50);
        Console.WriteLine(@"Loaded -> HDD:\FileSystem\System\SYS.FILE");
        Cosmos.Hardware.PIT.Wait(50);
        Console.WriteLine(@"Loaded -> HDD:\FileSystem\System\USR.SYS");
        Cosmos.Hardware.PIT.Wait(50);
        Console.WriteLine(@"Loaded -> HDD:\FileSystem\cOS\FileMngmt\DirSys.SYS");
        Cosmos.Hardware.PIT.Wait(50);
        Console.WriteLine(@"Loaded -> HDD:\FileSystem\cOS\User\Login.MSG");
        Cosmos.Hardware.PIT.Wait(50);
        Console.WriteLine(@"Loaded -> HDD:\FileSystem\cOS\Startup\Init.SYS");
        Cosmos.Hardware.PIT.Wait(50);
        Console.WriteLine(@"Loaded -> HDD:\FileSystem\cOS\Startup\Init.int");

      //  Cosmos.Kernel.Plugs.CPU.Halt();
      //  Cosmos.Hardware.ACPIManager.Enabled = true;
     //   Cosmos.Sys.Deboot.ShutDown();


  //      Console.ReadLine();
            Console.ForegroundColor = ConsoleColor.White;
            



        Console.WriteLine("     ÛÛÛÛ ÛÛÛÛ");
        Console.WriteLine("     Û  Û Û");
        Console.WriteLine("ÛÛÛÛ Û  Û ÛÛÛÛ");
        Console.WriteLine("Û    Û  Û    Û");
        Console.WriteLine("ÛÛÛÛ ÛÛÛÛ ÛÛÛÛ");
        Console.Clear();

        Console.WriteLine("");
        Console.WriteLine("");
        Console.WriteLine("");
        Console.WriteLine("");
        
        Console.WriteLine("");
        Console.WriteLine("");
        Console.WriteLine("");
        Console.ForegroundColor = ConsoleColor.Green;
        Console.WriteLine("");

        Console.WriteLine("                                      ÛÛÛÛ ÛÛÛÛ");
        Console.WriteLine("                                      Û  Û Û");
        Console.WriteLine("                                 ÛÛÛÛ Û  Û ÛÛÛÛ");
        Console.WriteLine("                                 Û    Û  Û    Û");
        Console.WriteLine("                                 ÛÛÛÛ ÛÛÛÛ ÛÛÛÛ");


        Console.WriteLine("");
        Console.WriteLine("");
        Cosmos.Hardware.PIT.Wait(1000);
        Console.ForegroundColor = ConsoleColor.White;
        Console.WriteLine("                                 Is Starting Up                             ");

        Cosmos.Hardware.PIT.Wait(2500);


      //  Cosmos.Hardware.Global.Sleep_Old(5);
        Cosmos.Hardware.PIT.Wait(2500);

            Console.ForegroundColor = ConsoleColor.White;
            Cosmos.Hardware.PIT.Wait(2000);
          //  Console.WriteLine("cOS Is Starting");

            Cosmos.Hardware.PIT.Wait(1000);


            /*/

            Console.WriteLine("     ÛÛÛÛ ÛÛÛÛ");
            Console.WriteLine("     Û  Û Û");
            Console.WriteLine("ÛÛÛÛ Û  Û ÛÛÛÛ");
            Console.WriteLine("Û    Û  Û    Û");
            Console.WriteLine("ÛÛÛÛ ÛÛÛÛ ÛÛÛÛ");
            /*/
            while (true)
            {
                Console.Clear();
                Console.WriteLine("");
                Console.WriteLine("");
                Console.WriteLine("");
                Console.WriteLine("");
                Console.WriteLine("");
                Console.WriteLine("");
                Console.WriteLine("");
                Console.WriteLine("");




                Console.WriteLine("                                      ÛÛÛÛ ÛÛÛÛ");
                Console.WriteLine("                                      Û  Û Û");
                Console.WriteLine("                                 ÛÛÛÛ Û  Û ÛÛÛÛ");
                Console.WriteLine("                                 Û    Û  Û    Û");
                Console.WriteLine("                                 ÛÛÛÛ ÛÛÛÛ ÛÛÛÛ");


                Console.WriteLine("");
                Console.WriteLine("");

                Console.WriteLine("                          Please Press Any Key To Login                          ");

               // Console.ReadLine();
                Cosmos.Hardware.Keyboard.ReadKey();
                Console.Clear();

                Console.WriteLine("");
                Console.WriteLine("");
                Console.WriteLine("");
                Console.WriteLine("");
                Console.WriteLine("");
                Console.WriteLine("");
                Console.WriteLine("");
                Console.WriteLine("");

                Console.WriteLine("                                      ÛÛÛÛ ÛÛÛÛ");
                Console.WriteLine("                                      Û  Û Û");
                Console.WriteLine("                                 ÛÛÛÛ Û  Û ÛÛÛÛ");
                Console.WriteLine("                                 Û    Û  Û    Û");
                Console.WriteLine("                                 ÛÛÛÛ ÛÛÛÛ ÛÛÛÛ");


                Console.WriteLine("");
                Console.WriteLine("");

                Console.Write("                             Username: ");



                string typuser = string.Empty;
                string typpass = string.Empty;
                typuser = Console.ReadLine();

                 Console.Write("                             Password: ");

                 typpass = GetPassword(false);


            if (typuser == "adam")
            {

                if (typpass == "pass")
                {


                    Console.Clear();
                    Console.WriteLine("");
                    Console.WriteLine("");
                    Console.WriteLine("");

                    Console.WriteLine("");
                    Console.WriteLine("");
                    Console.WriteLine("");
                    Console.WriteLine("");
                    Console.WriteLine("");

                    Console.ForegroundColor = ConsoleColor.Green;

                    Console.WriteLine("                                      ÛÛÛÛ ÛÛÛÛ");
                    Console.WriteLine("                                      Û  Û Û");
                    Console.WriteLine("                                 ÛÛÛÛ Û  Û ÛÛÛÛ");
                    Console.WriteLine("                                 Û    Û  Û    Û");
                    Console.WriteLine("                                 ÛÛÛÛ ÛÛÛÛ ÛÛÛÛ");


                    Console.WriteLine("");
                    Console.WriteLine("");

                    Console.WriteLine("                                 Access Granted                                  ");
                    Console.ForegroundColor = ConsoleColor.White;
                    Cosmos.Hardware.PIT.Wait(2000);

                    Console.Clear();
                    // AfterLogin;


                    break;

                    // AfterLogin(typusr, ram, cpu, psu)
                }
                else
                {
                    Console.Clear();
                    Console.WriteLine("");
                    Console.WriteLine("");
                    Console.WriteLine("");
                    Console.WriteLine("");
                    Console.WriteLine("");
                    Console.WriteLine("");
                    Console.WriteLine("");
                    Console.WriteLine("");

                    Console.ForegroundColor = ConsoleColor.Red;

                    Console.WriteLine("                                      ÛÛÛÛ ÛÛÛÛ");
                    Console.WriteLine("                                      Û  Û Û");
                    Console.WriteLine("                                 ÛÛÛÛ Û  Û ÛÛÛÛ");
                    Console.WriteLine("                                 Û    Û  Û    Û");
                    Console.WriteLine("                                 ÛÛÛÛ ÛÛÛÛ ÛÛÛÛ");


                    Console.WriteLine("");
                    Console.WriteLine("");

                    Console.WriteLine("                                 Access Denied                                   ");
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.WriteLine("                             Press any key to Retry                             ");
                    Console.ReadLine();
                }


            }
            else
            {
                Console.Clear();
                Console.WriteLine("");
                Console.WriteLine("");
                Console.WriteLine("");
                Console.WriteLine("");
                Console.WriteLine("");
                Console.WriteLine("");
                Console.WriteLine("");
                Console.WriteLine("");

                Console.ForegroundColor = ConsoleColor.Red;

                Console.WriteLine("                                      ÛÛÛÛ ÛÛÛÛ");
                Console.WriteLine("                                      Û  Û Û");
                Console.WriteLine("                                 ÛÛÛÛ Û  Û ÛÛÛÛ");
                Console.WriteLine("                                 Û    Û  Û    Û");
                Console.WriteLine("                                 ÛÛÛÛ ÛÛÛÛ ÛÛÛÛ");


                Console.WriteLine("");
                Console.WriteLine("");

                Console.WriteLine("                                 Access Denied                                   ");
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine("                             Press any key to Retry                             ");
                Console.ReadLine();
            
            }
            }      
        
        Console.Clear();
    
        AfterRun("adam");

        }
        #region VideoDrawing



        #endregion


        static void VidTest()
        {


            uint col = 0;
            uint xco = 0;
            uint yco = 0;

            while (col < 64)
            {
                while (yco < 200)
                {
                    VGAScreen.SetPixel(0 + xco, yco, col);
                    VGAScreen.SetPixel(1 + xco, yco, col);
                    VGAScreen.SetPixel(2 + xco, yco, col);
                    VGAScreen.SetPixel(3 + xco, yco, col);
                    VGAScreen.SetPixel(4 + xco, yco, col);
                    yco = yco + 1;

                }
                yco = 0;
                xco = xco + 5;
                col = col + 1;

            }
        }


        static void drawOS()
        {
            DrawString("cOS is Starting UP", 106, 180, 6, 0, true, false);


  
        }
      //  public static Mouse m = new Mouse;
        public static uint oldmx = 0;
        public static uint oldmy = 0;

        static void InitMouse()
        {
            
               // Mouse.Initialize();
           // Mouse.Initialize();

         //   Console.WriteLine(Cosmos.Hardware.Device.Find(Device.DeviceType.Mouse).ToString());

          //  Mouse.Initialize();

            Form TestForm = new Form();

            
//
         //   TestForm.Show(38,18, 320 - 76 , 200 - 36, 4);

        //    TestForm.Add(Form.Control.Button, "test", 5, 5);


           // Program.DrawRectangle(38, 18, 320 - 76, 200 - 36, 4);

              MouseA = VGAScreen.GetPixel320x200x8(0, 0);
              MouseB = VGAScreen.GetPixel320x200x8(0 + 1, 0);
              MouseC = VGAScreen.GetPixel320x200x8(0, 0 + 1);

            uint mx = 0;
            uint my = 0;

            while (true)
            {
              //  string resp = GetPassword(true);

                LPosx = mx;
                LPosy = my;
                

                if ((uint)MouseD.X == oldmx && (uint)MouseD.Y == oldmy)
                {
                
                }
                else
                {
                    
                }

                mx = (uint)MouseD.X;
                my = (uint)MouseD.Y;

                mx = (uint)Mouse.X;
                my = (uint)Mouse.Y;

                


            /*/    if (resp == "RIGHT")
                {
                    mx = mx + sensitivity; 
                }
                else if (resp == "LEFT")
                {
                    mx = mx - sensitivity;
                }
                else if (resp == "UP")
                {
                    my = my - sensitivity;
                }
                else if (resp == "DOWN")
                {
                    my = my + sensitivity;
                }
                /*/

                if (mx > 2 && mx < 20 && my > 2 && my < 10)
                {
                    DrawString("cOS", 2, 2, 6, 7 , true, false);

                }
                else 
                {
                    DrawString("cOS", 2, 2, 6, 63, true, false);
                }


               



               // DrawMouse(mx, my, 1); 

                VGAScreen.SetPixel(LPosx, LPosy, MouseA);
                VGAScreen.SetPixel(LPosx + 1, LPosy, MouseB);
                VGAScreen.SetPixel(LPosx, LPosy + 1, MouseC);

                MouseA = VGAScreen.GetPixel320x200x8(mx, my);
                MouseB = VGAScreen.GetPixel320x200x8(mx + 1, my);
                MouseC = VGAScreen.GetPixel320x200x8(mx, my + 1);


                AltMouse(mx, my, 1);

            }
            //while (true)
       //     {
       //         DrawMouse((uint)Mouse.X, (uint)Mouse.Y, 1);
                
       //     }

            
        }

        static void DrawcOSMenu()
        { 
        
        
        }


        static void DrawMouse(uint posx, uint posy, uint Col)
        {
            VGAScreen.SetPixel(posx, posy, Col);
            VGAScreen.SetPixel(posx + 1, posy, Col);
            VGAScreen.SetPixel(posx + 0, posy + 1, Col);
            VGAScreen.SetPixel(posx + 1, posy + 1, Col);
            VGAScreen.SetPixel(posx + 2, posy + 1, Col);
            VGAScreen.SetPixel(posx + 0, posy + 2, Col);
            VGAScreen.SetPixel(posx + 1, posy + 2, Col);
            VGAScreen.SetPixel(posx + 2, posy + 2, Col);
            VGAScreen.SetPixel(posx + 3, posy + 2, Col);
            VGAScreen.SetPixel(posx + 0, posy + 3, Col);
            VGAScreen.SetPixel(posx + 1, posy + 3, Col);
            VGAScreen.SetPixel(posx + 2, posy + 3, Col);
            VGAScreen.SetPixel(posx + 3, posy + 3, Col);
            VGAScreen.SetPixel(posx + 4, posy + 3, Col);
            VGAScreen.SetPixel(posx + 0, posy + 4, Col);
            VGAScreen.SetPixel(posx + 1, posy + 4, Col);
            VGAScreen.SetPixel(posx + 2, posy + 4, Col);
            VGAScreen.SetPixel(posx + 3, posy + 4, Col);
            VGAScreen.SetPixel(posx + 0, posy + 5, Col);
            VGAScreen.SetPixel(posx + 2, posy + 5, Col);
            VGAScreen.SetPixel(posx + 3, posy + 5, Col);
            VGAScreen.SetPixel(posx + 3, posy + 6, Col);
            VGAScreen.SetPixel(posx + 4, posy + 6, Col);
        }

        static public uint MouseA = 0;
        static public uint MouseB = 0;
        static public uint MouseC = 0;

        static public uint AMouseA = 0;
        static public uint AMouseB = 0;
        static public uint AMouseC = 0;

        static public uint LPosx;
        static public uint LPosy;


        static void AltMouse(uint posx, uint posy, uint Col)
        {
            
         //   MouseA = VGAScreen.GetPixel320x200x8(posx, posy);
          //  MouseB = VGAScreen.GetPixel320x200x8(posx + 1, posy);
         //   MouseC = VGAScreen.GetPixel320x200x8(posx, posy + 1);


            VGAScreen.SetPixel(posx, posy, Col);
            VGAScreen.SetPixel(posx + 1, posy, Col);
            VGAScreen.SetPixel(posx, posy + 1, Col);

            

        }

        public static int PalleteNumb = 64;

        public static void SetPallete()
        {
            
        
        }

        public static void DrawRectangle(uint stx, uint sty, int width, int height, uint Color)
        {
            uint px = stx;
            uint py = sty;
            uint col = Color;

            while (px < (stx + width))
            {
                while (py < (sty + height))
                {
                    VGAScreen.SetPixel(px, py, Color);
                    py = py + 1;
                }
                py = sty;
                px = px + 1;
            }     
        }


        static void Notepad()
        {
            DrawRectangle(38, 18, 320 - 76, 200 - 36, 4);
            DrawRectangle(40, 20, 320 - 80, 200 - 40, 63);
            DrawRectangle(40, 20, 320 - 80, 10, 4);
            DrawString("notepad", 160 - 42 / 2, 20, 6, 63, true, false);

                uint posx = 42;
                int letter = 0;
                int lines = 0;
                uint posy = 30;
                string newuser = "";

                while (true)
                {

                    if (lines > 10)
                    {
                        break;

                    }

                    string user = GetPassword(true);
                    if (user == "ENTER")
                    {
                        lines = lines + 1;
                        letter = 0;
                        posx = 42;
                        posy = posy + 10;

                     //   break;

                    }
                   
                    else
                    {
                        if (letter == 40)
                        {
                            posx = 42;
                            letter = 0;
                            posy = posy + 10;
                            lines = lines + 1;
                        }
                        
                            // DrawLetter("*", posx, 82, 1, true, false);
                            DrawLetter(user, posx, posy, 1, true, false, 63);

                            newuser = newuser + user;
                            posx = posx + 6;
                        
                    }
                    letter = letter + 1;
                }
            
            
        }
    

        static void VidInit()

        {
            VGAScreen.Clear(0);
           Cosmos.Hardware.VGAScreen.SetMode320x200x8();
           // VGAScreen.SetMode320x240x4();

         //   VGAScreen.SetPaletteEntry(0, 0, 0, 0);
        //    VGAScreen.SetPaletteEntry(1, 63, 0, 0);
        //   VGAScreen.SetPaletteEntry(2, 63, 63, 63);
            
            // Increases color range
            

          //  
            //Cosmos.Hardware.VGAScreen.SetMode640x480x4();
          //  Cosmos.Hardware.VGAScreen.SetMode720x480x16();
            //   Cosmos.Hardware.VGAScreen.GetPaletteEntry(1);
            //  Cosmos.Hardware.VGAScreen.SetPixel640x480x4(0,0,0);
          //  VGAScreen.Clear(63);
            VGAScreen.Clear(22);

          //  VGAScreen.Test();

                drawOS();
                uint px = 0;
         //   uint col = 0;

            
                
                
                

                
                while (px < 320)
                {
                    VGAScreen.SetPixel(px, 199, 56); //56
                   // Cosmos.Hardware.PIT.Wait(1);
                  //  Cosmos.Kernel.Plugs.ThreadImpl.Sleep(1);

                    for (int i = 0; i < 100000; i++)
                    {
                        
                    }

                    px = px + 1;
                }


            // 4 = red
            // SWITCH BACK TO TEXT MODE WITHOUT WEIRD QUESTION MARKS:
            //    VGAScreen.Clear(0);
            //    VGAScreen.SetTextMode(VGAScreen.TextSize.Size80x25);

                /*/
                  if (col >= 63)
                     {
                         col = 0;
                     }
                     else
                     {
                         col = col + 1;
                     }
                 /*/

                LogInUI();

                VGAScreen.Clear(42);

                DrawRectangle(78, 48, 164, 104, 1);

                DrawRectangle(80, 50, 160, 100, 4);
                DrawString("Logging in", 130, 100, 6, 63, true, false);  //70   
                Cosmos.Hardware.PIT.Wait(2000);

                VGAScreen.Clear(42); // 61 pink

              //  VGAScreen.Test();
                Cosmos.Hardware.PIT.Wait(10);
                DrawRectangle(0, 0, 320, 12, 4);


                DrawString("cOS", 2, 2, 6, 63, true, false);
                DrawString("Log Out", 274, 2, 6, 63, true, false);

                Cosmos.Hardware.Device.DriversInit();
                //Cosmos.Hardware.Device.Add(Dev);
               // Device.Devices.Add(Mouse);

                Cosmos.Hardware.PIT.Wait(5000);

                Notepad();

             //   DrawDesktop();

                

                
                //Mouse.Initialize(test);

                InitMouse();

             //   InitMouse();    
                
                    

            // MAX COLORS 64!!!
            /*/
            //   VGAScreen.Test();
            VGAScreen.SetPixel(1, 150, 0);
            VGAScreen.SetPixel(2, 150, 2);
            VGAScreen.SetPixel(3, 150, 3);
            VGAScreen.SetPixel(4, 150, 4);
            VGAScreen.SetPixel(5, 150, 5);
            VGAScreen.SetPixel(6, 150, 6);
            VGAScreen.SetPixel(7, 150, 7);
            VGAScreen.SetPixel(7, 150, 8);
            VGAScreen.SetPixel(7, 150, 9);
            VGAScreen.SetPixel(7, 150, 10);
            VGAScreen.SetPixel(7, 150, 11);
            VGAScreen.SetPixel(7, 150, 12);
        //    VGAScreen.Clear(0);
            /*/



       //     VidTest();
            
            //DrawcOS();

            }
        public enum ButtonPosition
        { 
            Custom,
            CenterX
        }

        public static void DrawButton(uint posx, uint posy, string text, ButtonPosition pos)
        {
            

            if (pos == ButtonPosition.Custom)
            {
                DrawRectangle(posx, posy, 40, 10 + 1, 1);
                DrawRectangle(posx + 1, posy + 1, 38, 8 + 1, 63);
            }
            else if (pos == ButtonPosition.CenterX)
            {
                DrawRectangle((uint)GetXFormCenter((int)Form.LastFormCreatedWidth, (int)Form.LastFormCreatedPosX), posy, 40, 10 + 1, 1);
                DrawRectangle((uint)GetXFormCenter((int)Form.LastFormCreatedWidth, (int)Form.LastFormCreatedPosX) + 1, posy + 1, 38, 8 + 1, 63);
            }

         //   DrawRectangle(160 + 50 - 12, 100 + 40 - 3, 40, 10 + 1, 1);
        //    DrawRectangle(160 + 50 - 11, 100 + 40 - 2, 38, 8 + 1, 63);


        //    DrawString("ok", 212, 140 - 1, 6, 1, true, false);
            DrawString(text, posx + 14, posy + 1, 6, 1, true, false);

            if (GetWidth(text, 6) > 5)
            {
                DrawString("...", posx + 14, posy + 1, 6, 1, true, false);
            }
            else
            {
                DrawString(text, posx + 14, posy + 1, 6, 1, true, false);
            }
        
        }

        public static int GetWidth(string str, int Spacing)
        {
            int strLength = str.Length;
            int Width = strLength * Spacing;
            return Width;
        }

        public static int GetCenter(string str, int Spacing)
        {
            int strLength = str.Length;
            int Width = strLength * Spacing;
            int Center = Width / 2;
            return Center;
        }
        public static int GetXFormCenter(int FormWidth, int FormPosX)
        {
            int Center = FormPosX + (FormWidth / 2);
            return Center;
        }
        public static int GetYFormCenter(int FormHeight, int FormPosY)
        {
            int Center = FormPosY + (FormHeight / 2);
            return Center;
        }
        public static int GetXStringCenter(int StringWidth)
        {
            int strcen = StringWidth / 2;
            return strcen;
        }


        static void DrawDesktop()
        {
            VGAScreen.Clear(42); // 61 pink

            //  VGAScreen.Test();
            Cosmos.Hardware.PIT.Wait(10);
            DrawRectangle(0, 0, 320, 12, 4);


            DrawString("cOS", 1, 1, 6, 63, true, false);
            DrawString("Log Out", 274, 1, 6, 63, true, false);

        }


        static void LogInUI()
        {
            while (true)
            {
                VGAScreen.Clear(63);
                DrawRectangle(78, 48, 164, 104, 1);

                DrawRectangle(80, 50, 160, 100, 4);

                DrawString("Log in", 82, 52, 6, 63, true, false); // 82
                DrawString("Username:", 82, 82, 6, 63, true, false);
                DrawRectangle(150, 82, 80, 8, 56);

                DrawString("Password:", 82, 120, 6, 63, true, false);
                DrawRectangle(150, 120, 80, 8, 56);


                uint posx = 150;
                string newpass = "";
                string newuser = "";

                while (true)
                {
                    string user = GetPassword(true);
                    if (user == "ENTER")
                    {
                        break;

                    }
                    else
                    {
                        // DrawLetter("*", posx, 82, 1, true, false);
                        DrawLetter(user, posx, 82, 1, true, false, 63);

                        newuser = newuser + user;
                        posx = posx + 6;
                    }
                }
                posx = 150;

                while (true)
                {
                    string pass = GetPassword(true);
                    if (pass == "ENTER")
                    {
                        break;

                    }
                    else if (pass == "BACKSPACE")
                    {
                       // DrawLetter(" ", posx, 120, 1, true, false, 63);
                      //  posx = posx - 6;
                     //   newpass = newpass.Substring(newpass.Length - 1);
                    }
                    else
                    {
                        DrawLetter("*", posx, 120, 1, true, false, 63);
                        //  DrawLetter(pass, posx, 82, 1, true, false, 63);

                        newpass = newpass + pass;
                        posx = posx + 6;
                    }
                }

                if (newuser == "adam")
                {
                    if (newpass == "pass")
                    {
                        break;

                    }
                    else
                    {
                        badLogin();
                    }
                }
                else
                {
                    badLogin();
                }

            }
        }
        static void badLogin()
        {
            VGAScreen.Clear(63);
            DrawRectangle(78, 48, 164, 104, 1);

            DrawRectangle(80, 50, 160, 100, 4);

            DrawString("Incorrect username", 82 + 27, 52 + 10, 6, 63, true, false); // 82
            DrawString("or password", 102 + 21, 60 + 10, 6, 63, true, false); // 82

            DrawRectangle(160 + 50 - 12, 100 + 40 - 3, 40, 10 + 1, 1);
            DrawRectangle(160 + 50 - 11, 100 + 40 - 2 , 38, 8 + 1, 63);


            DrawString("ok", 212, 140 - 1, 6, 1, true, false);

         //   DrawString("Username:", 82, 82, 6, 63, true, false);
         //   DrawRectangle(150, 82, 80, 8, 56);

          //  DrawString("Password:", 82, 120, 6, 63, true, false);
          //  DrawRectangle(150, 120, 80, 8, 56);


            while (true)
            {
                string resp = GetPassword(true);
                if (resp == "ENTER")
                {
                    VGAScreen.Clear(63);
                    break;
                    
                }
                
            }

        }


        static void MessageBox(string Message, string Line, int Type)
        {
            DrawRectangle(78, 48, 164, 104, 1);

            DrawRectangle(80, 50, 160, 100, 4);

            DrawString(Message, 82, 52, 6, 63, true, false); // 82
            DrawString(Line, 102, 60, 6, 63, true, false); // 82
            DrawString("ok", 212, 140 - 1, 6, 1, true, false);
            while (true)
            {
                string resp = GetPassword(true);
                if (resp == "ENTER")
                {
                    VGAScreen.Clear(63);
                    break;

                }

            }
        
        }


        static void VGAGetEnter()
        {
            while (true)
            {
                string resp = GetPassword(true);
                if (resp == "ENTER")
                {
                  //  VGAScreen.Clear(63);
                    break;

                }

            }
        }

        static void fillScreen(uint Color)
        {
            uint px = 0;
            uint py = 0;
            uint col = Color;

            while (px < 320)
            {
                while (py < 200)
                {
                    VGAScreen.SetPixel(px, py, Color);
                }
                py = 0;
                px = px + 1;
            }
        
        }
            
        static void ColTxt(string Text, int col, bool line)
        {
            if (col == 1)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                if (line == false)
                {
                    Console.Write(Text);
                }
                else if (line == true)
                {
                    Console.WriteLine(Text);
                }
                Console.ForegroundColor = ConsoleColor.White;
            }
            else if (col == 2)
            {
                Console.ForegroundColor = ConsoleColor.Green;
                if (line == false)
                {
                Console.Write(Text);
                }
                else if (line == true)
                {
                Console.WriteLine(Text);
                }
                Console.ForegroundColor = ConsoleColor.White;
            }
            
            
        }

       

        static void AfterRun(string user)
        {
            Console.Clear();
            int ram = 512;
            int cpu = 500;
            int psu = 120;
            string net = "";
            string hdd = "";

            Console.WriteLine("cOS Version 0.0.0.1                             ");
            Console.WriteLine("<c> 2017 Gorski Incorporated. All Rights Reserved");
            Console.WriteLine();
            Console.Write(@"HDD:\>");
            

            while (true) 
            {
                string command = Console.ReadLine(); 

                switch (command.ToLower())
                { 
                    case "help":
                        Console.WriteLine("Currently Available Commands:");
                    Console.WriteLine();
                    Console.WriteLine("HELP        Displays The Help Dialog.");
                    Console.WriteLine("ABOUT       Displays Information Regarding the Operating System.");
                    Console.WriteLine("CLEAR       Clears The Console.");
                    Console.WriteLine("CLS         Clears The Console.");
                    Console.WriteLine("RESTART     Reboots The System.");
                    Console.WriteLine("USERINFO    Displays The User Information Dialog.");
                    Console.WriteLine("STORAGE     Shows The Current Installed Disc(s).");
                    Console.WriteLine("NETWORK     Displays Network Settings.");
                    Console.WriteLine("SHUTDOWN    Shutsdown The System.");
                    Console.WriteLine("LOGOUT      Logs Out Of The Computer.");
                    Console.WriteLine("TIME        Displays The Time.");
                    Console.WriteLine("SYSTIME     Displays The System Time.");
                    Console.WriteLine("CFG         Modify a Programs Configuration.");
                    

                    Console.WriteLine();
                    break;

                    case "clear":
                    Console.Clear();
                    Console.WriteLine("cOS Version 0.0.0.1                             ") ;
                    Console.WriteLine("<c> 2017 Gorski Incorporated. All Rights Reserved");
                    Console.WriteLine();
                    break;

                    case "cls":
                    Console.Clear();
                    Console.WriteLine("cOS Version 0.0.0.1                             ");
                    Console.WriteLine("<c> 2017 Gorski Incorporated. All Rights Reserved");
                    Console.WriteLine();
                    break;

                    case "about":
                     Console.WriteLine("cOS Version 0.0.0.1");
                    Console.WriteLine("cOS Version 0.0.0.1");
                    Console.Clear();
                    Console.WriteLine("");
                    Console.WriteLine("");
                    Console.WriteLine("");
                    Console.WriteLine("");
                    Console.WriteLine("");
                    
                    Console.WriteLine("");
                    Console.WriteLine("");

                    Console.ForegroundColor = ConsoleColor.Green;

                    Console.WriteLine("                                      ÛÛÛÛ ÛÛÛÛ");
                    Console.WriteLine("                                      Û  Û Û");
                    Console.WriteLine("                                 ÛÛÛÛ Û  Û ÛÛÛÛ");
                    Console.WriteLine("                                 Û    Û  Û    Û");
                    Console.WriteLine("                                 ÛÛÛÛ ÛÛÛÛ ÛÛÛÛ");


                    Console.WriteLine("");
                    Console.WriteLine("");

                    Console.WriteLine("                              cOS Version 0.0.0.1                                   ");
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.Write("                         Currently Running On ");
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.Write("LIVE");
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.WriteLine(" Mode                             ");
                    Console.WriteLine("                              <c> 2017 Adam Gorski                            ");
                    Console.ReadLine();
                    Console.Clear();
                    Console.WriteLine("cOS Version 0.0.0.1                             ");
                    Console.WriteLine("<c> 2017 Gorski Incorporated. All Rights Reserved");
                    Console.WriteLine("");
                    Console.WriteLine("System Specifications:");
                    Console.WriteLine("RAM: " + ram.ToString() + "MB");
                    Console.WriteLine("CPU: " + cpu.ToString() + "MHz");
                    Console.WriteLine("Network Name: " + net);
                    Console.WriteLine("HDD: " + hdd);
                    Console.WriteLine("Psu Voltage: " + psu + " Volts");

                    Console.ReadLine();
                    Console.Clear();

                    Console.WriteLine("cOS Version 0.0.0.1                             ");
                    Console.WriteLine("<c> 2017 Gorski Incorporated. All Rights Reserved");
                    Console.WriteLine();

                    
                        
                    
                    

                    break;
/*/
                case "userinfo":
                 //   Console.WriteLine("Logged In As: " + user);
                    Console.Write("User Access Level: ");
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("Administrator");
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.WriteLine();
                    break;
                    /*//*/
             //   case "logoutu":
                  //  Console.WriteLine("Error: Cannot Logout");
                 //   Console.WriteLine("");
                //    break;
                        /*/
                case "storage":
                        Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("No Storage Detected");
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.Write("Scanning For Any Other Storage Mediums");
                    Console.Write(".");
                    Cosmos.Hardware.PIT.Wait(500);
                    Console.Write(".");
                    Cosmos.Hardware.PIT.Wait(500);
                    Console.Write(".");
                    Cosmos.Hardware.PIT.Wait(500);
                        
/*/
                    Console.Write("\b");
                    Console.Write("\b");
                    Console.Write("\b");
                    Console.Write("   ");
                    Console.Write("\b");
                    Console.Write("\b");
                    Console.Write("\b");
   /*/                     
                    Cosmos.Hardware.PIT.Wait(500);
                    Console.Write(".");
                    Cosmos.Hardware.PIT.Wait(500);
                    Console.Write(".");
                    Cosmos.Hardware.PIT.Wait(500);
                    Console.Write(".");
                    Cosmos.Hardware.PIT.Wait(500);
/*/
                    Console.Write("/b");
                    Console.Write("/b");
                    Console.Write("/b");
                    Console.Write("   ");
                    Console.Write("/b");
                    Console.Write("/b");
                    Console.Write("/b");
/*/
                    Cosmos.Hardware.PIT.Wait(500);
                    Console.Write(".");
                    Cosmos.Hardware.PIT.Wait(500);
                    Console.Write(".");
                    Cosmos.Hardware.PIT.Wait(500);
                    Console.Write(".");
                    Cosmos.Hardware.PIT.Wait(500);

                   /*/ Console.Write("\b");
                    Console.Write("\b");
                    Console.Write("\b");
                    Console.Write("   ");
                    Console.Write("\b");
                    Console.Write("\b");
                    Console.Write("\b");
                    /*/ 
                    Cosmos.Hardware.PIT.Wait(500);
                    Console.Write(".");
                    Cosmos.Hardware.PIT.Wait(500);
                    Console.Write(".");
                    Cosmos.Hardware.PIT.Wait(500);
                    Console.WriteLine(".");
                    Cosmos.Hardware.PIT.Wait(500);
                    Console.WriteLine("No Storage Mediums Detected");

                    Console.WriteLine("Displaying LIVE Mode Data:");
                    Cosmos.Hardware.PIT.Wait(500);
                    Console.ForegroundColor = ConsoleColor.Red;

                    Console.WriteLine("WARNING: No Storage Available");
                    Console.ForegroundColor = ConsoleColor.White;
                    Cosmos.Hardware.PIT.Wait(500);

                    Console.WriteLine("");
                    Console.WriteLine("Drives Detected:         | Root      | Storage | Description");
                    Console.WriteLine("------------------------------------------------------------");
                    Cosmos.Hardware.PIT.Wait(500);
                    Console.Write(@"Storage 0                 HDD:\        ");
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.Write("Full");
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.WriteLine("/0GB   Hard Drive ");



                    Cosmos.Hardware.PIT.Wait(100);
                    Console.Write(@"Disc X                    X:\          ");
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.Write("Full");
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.WriteLine("/0GB   Disc X");

                    Cosmos.Hardware.PIT.Wait(100);
                    Console.Write(@"System 0                  \\SYSTEM\    ");
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.Write("Full");
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.WriteLine("/0GB   System Root");
                    Console.WriteLine();
                    break;

                    
        
                    default:   // Another switch is required after default for more items without crashing...
                   
                        //string commandn = Console.ReadLine();

                        switch (command.ToLower())
                        {
                            case "userinfo":
                                //   Console.WriteLine("Logged In As: " + user);
                                Console.Write("User Access Level: ");
                                Console.ForegroundColor = ConsoleColor.Green;
                                Console.WriteLine("Administrator");
                                Console.ForegroundColor = ConsoleColor.White;
                                Console.WriteLine();
                                break;

                            case "logout":
                                ColTxt("Error: ", 1, false);
                                Console.WriteLine("Cannot Logout");
                                Console.WriteLine("");
                                break;

                            case "network":
                                Console.WriteLine("Connecting To Network. Please Wait.");
                                Cosmos.Hardware.PIT.Wait(1000);
                                Console.ForegroundColor = ConsoleColor.Red;
                                Console.WriteLine("Error: No Network Detected.");
                                Console.ForegroundColor = ConsoleColor.White;
                                Console.WriteLine();
                                Cosmos.Hardware.PIT.Wait(1000);
                                
                                break;

                            case "start":
                                VidInit();
                                break;

                            case "test":
                                Console.WriteLine();
                                string pass = GetPassword(false);
                                Console.WriteLine("You Typed: " + pass);
                               
                                break;

                             default:

                                switch (command.ToLower())
                                {
                                case "htest":


                                    MouseD.Initialize();
                                    Console.WriteLine(MouseD.X.ToString());
                                    Console.WriteLine(MouseD.Y.ToString());
                                    Console.WriteLine(Console.CursorLeft.ToString());

                                    MouseD.Initialize();
                                    VGAScreen.SetPixel320x200x8((uint)MouseD.X, (uint)MouseD.Y, 1);

                                    break;

                                    case "time":

                                   // Console.WriteLine(Cosmos.Sys.VFSManager.GetLogicalDrives());  
                                    string sec = RTC.GetSeconds().ToString();
                                    string min = RTC.GetMinutes().ToString();
                                    string hrs = RTC.GetHours().ToString();
                                    int althrs = RTC.GetHours();

                                    if (Clock24HourSetting == false)
                                    {
                                       // Console.WriteLine(hrs);
                                        int abc = 0;
                                        uint aabc = 0;

                                        abc = althrs - 12;
                                        aabc = (uint)abc;

                                       // Console.WriteLine(aabc.ToString());


                                        if (min.Length < 2)
                                        {
                                            min = "0" + min;
                                        }

                                        if (aabc > 13)
                                        {
                                         //   if (hrs = "0")
                                       //     { 
                                            
                                       //     }

                                            Console.Write("The Current Time Is: " + hrs + ":");


                                            Console.WriteLine(min + "AM");
                                        }
                                        else
                                        {
                                            Console.Write("The Current Time Is: " + aabc.ToString() + ":");
                                            Console.WriteLine(min + "PM");
                                        }
                                     //  Console.WriteLine(min + ":");
                                    //    Console.Write(min + ":");
                                     //   Console.WriteLine(sec);
                                      //  Console.WriteLine("");
                                    }
                                    else if (Clock24HourSetting == true)
                                    {
                                        Console.Write("The Current Time Is: " + hrs + "h");
                                      //  Console.Write(min+ ":");
                                        Console.WriteLine(min);

                                     //   Console.WriteLine(sec);
                                     //   Console.WriteLine("");

                                    }
                                //   Console.WriteLine("The Current Time Is: " + hrs +  ":" + min + ":" + sec);
                                  //  Console.WriteLine("The Current Time Is: "  + sec + "s");
                                 //   Console.WriteLine("The Current Time Is: " + min + "m");
                                //    Console.WriteLine("The Current Time Is: " + hrs + "h");
                                    Console.WriteLine("");

                                       

                                    break;

                                    case "systime":

                                    string secc = RTC.GetSeconds().ToString();
                                    string minc = RTC.GetMinutes().ToString();
                                    string hrsc = RTC.GetHours().ToString();

                                    Console.Write("System Time: " + hrsc + ":");

                                    if (minc.Length < 2)
                                    {
                                        minc = "0" + minc;
                                    }
                                    
                                    if (secc.Length > 2)
                                    {
                                        secc = "0" + secc;
                                    }

                                    Console.Write(minc + ":");
                                    
                                    
                                    Console.WriteLine(secc);
                                    Console.WriteLine("");
                                    break;
                                case "nettest":

                                  //  Console.WriteLine(Cosmos.Hardware.Device.Devices.Count.ToString());
                                //    Console.WriteLine(Cosmos.Hardware.Device.Find(Device.DeviceType.Mouse));
                                  //      Console.WriteLine(Cosmos.Hardware.Device.DeviceTypeToString(Device.DeviceType.Mouse));
                                    //    Console.WriteLine(Cosmos.Hardware.Device.DeviceTypeToString(Device.DeviceType.Keyboard));
                                      //  Console.WriteLine(Cosmos.Hardware.Device.DeviceTypeToString(Device.DeviceType.Network));
                                        //Console.WriteLine(Cosmos.Hardware.Device.DeviceTypeToString(Device.DeviceType.Other));
                                        //Console.WriteLine(Cosmos.Hardware.Device.DeviceTypeToString(Device.DeviceType.Storage));

                            //       Cosmos.Sys.Network.TcpClient TCPCON;
                                //   Network.IPv4Address ipaddr = Network.IPv4Address.Parse("0.0.0.0.");

                                   

                                   string testtt;
                                  // ipaddr = System.Net.IPAddress.Parse(testtt);
                                            
                                   testtt = Console.ReadLine();

                                //   ipaddr = Network.IPv4Address.Zero.address;
                                //   ipaddr = Network.IPv4Address.Parse(testtt);


                                  

                                  // TCPCON = new Cosmos.Sys.Network.TcpClient(ipaddr,10);

                                //    Console.WriteLine("Connected: " + TCPCON.Connected.ToString());

                                //    Console.WriteLine("Connected TO: " + TCPCON.RemoteEndpoint.IPAddress.ToString());


                                //    TCPCON.SendString("testtest");


                                 //   byte[] byteValue1;



                                 //   TCPCON.SendData(byteValue1[0]);
                                  


                                //    Cosmos.Sys.VFSManager.Init();



                                   

                                 //   Console.WriteLine(test);
                                  //  Cosmos.Sys.VFSManager.GetFiles("");
                                    


                                    break;
                                default:

                                    if (command.ToLower().StartsWith("cfg"))
                                    {
                                        string test = command.ToLower();
                                        test =  test.Remove(0, 3);

                                        if (test == " start")
                                        {
                                            
                                            Console.WriteLine("Changing CFG for [start]");
                                            Console.WriteLine("");
                                            Console.WriteLine("Current Settings:");
                                            Console.WriteLine("1. Video Resolution                       320x200");
                                            Console.WriteLine("2. Color Depth                            64 Color Mode");
                                            Console.WriteLine("3. Exit");
                                            Console.WriteLine("");

                                            while (true)
                                            {
                                                Console.Write("Select Option To Change: ");
                                                string altt = Console.ReadLine();

                                                if (altt == "1")
                                                {

                                                }
                                                else if (altt == "2")
                                                {

                                                }
                                                else if (altt == "3")
                                                {
                                                    Console.WriteLine("");
                                                    break;
                                                }

                                                else
                                                {
                                                    Console.WriteLine("Error: Invalid Answer. Please Try Again.");
                                                    Console.WriteLine("");

                                                }

                                            }
                                        }
                                        else if (test == " time")
                                        {
                                            Console.WriteLine("Changing CFG for [time]");
                                            Console.WriteLine("");
                                            Console.WriteLine("Current Settings:");
                                            if (ClockFormatSettings == 1)
                                            {
                                                Console.WriteLine("1. Time Format                            HH:MM:SS");
                                            }
                                            else if (ClockFormatSettings == 2)
                                            {
                                                Console.WriteLine("1. Time Format                            MM:SS:HH");
                                            }
                                            else if (ClockFormatSettings == 3)
                                            {
                                                Console.WriteLine("1. Time Format                            SS:HH:MM");
                                            }
                                            else if (ClockFormatSettings == 4)
                                            {
                                                Console.WriteLine("1. Time Format                            SS:MM:HH");
                                            }
                                            else if (ClockFormatSettings == 5)
                                            {
                                                Console.WriteLine("1. Time Format                            SS:MM:HH");
                                            }

                                        //    Console.WriteLine("1. Time Format                            HH:MM:SS");

                                            if (Clock24HourSetting == false)
                                            { 
                                            Console.WriteLine("2. 24 Hour Clock                          False");
                                            }
                                            else if (Clock24HourSetting == true)
                                            {
                                                Console.WriteLine("2. 24 Hour Clock                          True");
                                            }
                                           // Console.WriteLine("2. 24 Hour Clock                          True");
                                            Console.WriteLine("3. Exit");
                                            Console.WriteLine("");
                                            
                                            while (true)
                                            {
                                                Console.Write("Select Option To Change: ");
                                                string altt = Console.ReadLine();

                                                if (altt == "1")
                                                {
                                                    while (true)
                                                    {
                                                        Console.WriteLine("");
                                                        Console.WriteLine("Select New Format Option:");
                                                        Console.WriteLine("1. HH:MM:SS");
                                                        Console.WriteLine("2. MM:SS:HH");
                                                        Console.WriteLine("3. SS:HH:MM");
                                                        Console.WriteLine("4. SS:MM:HH");
                                                        Console.WriteLine("5. SS:MM:HH");
                                                        Console.WriteLine("6. Cancel");
                                                        Console.WriteLine("");
                                                        Console.Write("Select New Option: ");
                                                        string alt = Console.ReadLine();

                                                        if (alt == "1")
                                                        {
                                                            ClockFormatSettings = 1;
                                                            break;
                                                        }
                                                        else if (alt == "2")
                                                        {
                                                            ClockFormatSettings = 2;
                                                            break;
                                                        }
                                                        else if (alt == "3")
                                                        {
                                                            ClockFormatSettings = 3;
                                                            break;
                                                        }
                                                        else if (alt == "4")
                                                        {
                                                            ClockFormatSettings = 4;
                                                            break;
                                                        }
                                                        else if (alt == "5")
                                                        {
                                                            ClockFormatSettings = 5;
                                                            break;
                                                        }
                                                        else if (alt == "6")
                                                        {
                                                            Console.WriteLine("");
                                                            break;
                                                        }

                                                        else
                                                        {
                                                            Console.WriteLine("Error: Invalid Answer. Please Try Again.");
                                                            Console.WriteLine("");

                                                        }
                                                        
                                                    }
                                                    Console.WriteLine("");
                                                    break;
                                                }
                                                else if (altt == "2")
                                                {
                                                    while (true)
                                                    {
                                                        Console.WriteLine("");
                                                        Console.WriteLine("Select New 24 Hour Option:");
                                                        Console.WriteLine("1. 24 Hour Clock");
                                                        Console.WriteLine("2. 12 Hour Clock");
                                                        Console.WriteLine("3. Cancel");
                                                        Console.WriteLine("");
                                                        Console.Write("Select New Option: ");
                                                        string alt = Console.ReadLine();

                                                        if (alt == "1")
                                                        {
                                                            Clock24HourSetting = true;
                                                            break;
                                                        }
                                                        else if (alt == "2")
                                                        {
                                                            Clock24HourSetting = false;
                                                            break;
                                                        }
                                                        else if (alt == "3")
                                                        {
                                                            Console.WriteLine("");
                                                            break;
                                                        }

                                                        else
                                                        {
                                                            Console.WriteLine("Error: Invalid Answer. Please Try Again.");
                                                            Console.WriteLine("");

                                                        }

                                                    }
                                                    Console.WriteLine("");
                                                    break;
                                                }
                                                else if (altt == "3")
                                                {
                                                    Console.WriteLine("");
                                                    break;
                                                }

                                                else
                                                {
                                                    Console.WriteLine("Error: Invalid Answer. Please Try Again.");
                                                    Console.WriteLine("");

                                                }
                                                
                                            }
                                        }
                                        else
                                        {
                                            Console.WriteLine("Usage: cfg [application]");
                                            Console.WriteLine("");

                                        }
                                        


                                    }
                                    else
                                    {

                                        Console.WriteLine(@"""" + command + @"""" + " is not recognized as a internal or external command,");
                                        Console.WriteLine("valid program or a batch file.");
                                        Console.WriteLine("");
                                    }
                                break;
                            }       

                        break;
                        }
                    
                   




                    break;

                }

                
            Console.Write(@"HDD:\>");
            }
            

        }


        public static string GetPassword(bool SendByOne)
        {
            string Pass = "";

            ConsoleKey key = ConsoleKey.A;
            

           

            while (key != ConsoleKey.Enter)
            {
                key = Cosmos.Hardware.Keyboard.ReadKey();
               // Pass = Pass + key;
                Console.Write("*");
                


                if (key == ConsoleKey.A && Cosmos.Hardware.Keyboard.ShiftPressed == true)
                {
                    Pass = Pass + "A";
                }
                else if (key == ConsoleKey.A && Cosmos.Hardware.Keyboard.ShiftPressed == false)
                {
                    Pass = Pass + "a";
                }
                else if (key == ConsoleKey.B && Cosmos.Hardware.Keyboard.ShiftPressed == true)
                {
                    Pass = Pass + "B";
                }
                else if (key == ConsoleKey.B && Cosmos.Hardware.Keyboard.ShiftPressed == false)
                {
                    Pass = Pass + "b";
                }
                else if (key == ConsoleKey.C && Cosmos.Hardware.Keyboard.ShiftPressed == true)
                {
                    Pass = Pass + "C";
                }
                else if (key == ConsoleKey.C && Cosmos.Hardware.Keyboard.ShiftPressed == false)
                {
                    Pass = Pass + "c";
                }
                else if (key == ConsoleKey.D && Cosmos.Hardware.Keyboard.ShiftPressed == true)
                {
                    Pass = Pass + "D";
                }
                else if (key == ConsoleKey.D && Cosmos.Hardware.Keyboard.ShiftPressed == false)
                {
                    Pass = Pass + "d";
                }
                else if (key == ConsoleKey.E && Cosmos.Hardware.Keyboard.ShiftPressed == true)
                {
                    Pass = Pass + "E";
                }
                else if (key == ConsoleKey.E && Cosmos.Hardware.Keyboard.ShiftPressed == false)
                {
                    Pass = Pass + "e";
                }
                else if (key == ConsoleKey.F && Cosmos.Hardware.Keyboard.ShiftPressed == true)
                {
                    Pass = Pass + "F";
                }
                else if (key == ConsoleKey.F && Cosmos.Hardware.Keyboard.ShiftPressed == false)
                {
                    Pass = Pass + "f";
                }
                else if (key == ConsoleKey.G && Cosmos.Hardware.Keyboard.ShiftPressed == true)
                {
                    Pass = Pass + "G";
                }
                else if (key == ConsoleKey.G && Cosmos.Hardware.Keyboard.ShiftPressed == false)
                {
                    Pass = Pass + "g";
                }
                else if (key == ConsoleKey.H && Cosmos.Hardware.Keyboard.ShiftPressed == true)
                {
                    Pass = Pass + "H";
                }
                else if (key == ConsoleKey.H && Cosmos.Hardware.Keyboard.ShiftPressed == false)
                {
                    Pass = Pass + "h";
                }
                else if (key == ConsoleKey.I && Cosmos.Hardware.Keyboard.ShiftPressed == true)
                {
                    Pass = Pass + "I";
                }
                else if (key == ConsoleKey.I && Cosmos.Hardware.Keyboard.ShiftPressed == false)
                {
                    Pass = Pass + "i";
                }
                else if (key == ConsoleKey.J && Cosmos.Hardware.Keyboard.ShiftPressed == true)
                {
                    Pass = Pass + "J";
                }
                else if (key == ConsoleKey.J && Cosmos.Hardware.Keyboard.ShiftPressed == false)
                {
                    Pass = Pass + "j";
                }
                else if (key == ConsoleKey.K && Cosmos.Hardware.Keyboard.ShiftPressed == true)
                {
                    Pass = Pass + "K";
                }
                else if (key == ConsoleKey.K && Cosmos.Hardware.Keyboard.ShiftPressed == false)
                {
                    Pass = Pass + "k";
                }
                else if (key == ConsoleKey.L && Cosmos.Hardware.Keyboard.ShiftPressed == true)
                {
                    Pass = Pass + "L";
                }
                else if (key == ConsoleKey.L && Cosmos.Hardware.Keyboard.ShiftPressed == false)
                {
                    Pass = Pass + "l";
                }
                else if (key == ConsoleKey.M && Cosmos.Hardware.Keyboard.ShiftPressed == true)
                {
                    Pass = Pass + "M";
                }
                else if (key == ConsoleKey.M && Cosmos.Hardware.Keyboard.ShiftPressed == false)
                {
                    Pass = Pass + "m";
                }
                else if (key == ConsoleKey.N && Cosmos.Hardware.Keyboard.ShiftPressed == true)
                {
                    Pass = Pass + "N";
                }
                else if (key == ConsoleKey.N && Cosmos.Hardware.Keyboard.ShiftPressed == false)
                {
                    Pass = Pass + "n";
                }
                else if (key == ConsoleKey.O && Cosmos.Hardware.Keyboard.ShiftPressed == true)
                {
                    Pass = Pass + "O";
                }
                else if (key == ConsoleKey.O && Cosmos.Hardware.Keyboard.ShiftPressed == false)
                {
                    Pass = Pass + "o";
                }
                else if (key == ConsoleKey.P && Cosmos.Hardware.Keyboard.ShiftPressed == true)
                {
                    Pass = Pass + "P";
                }
                else if (key == ConsoleKey.P && Cosmos.Hardware.Keyboard.ShiftPressed == false)
                {
                    Pass = Pass + "p";
                }
                else if (key == ConsoleKey.Q && Cosmos.Hardware.Keyboard.ShiftPressed == true)
                {
                    Pass = Pass + "Q";
                }
                else if (key == ConsoleKey.Q && Cosmos.Hardware.Keyboard.ShiftPressed == false)
                {
                    Pass = Pass + "q";
                }
                else if (key == ConsoleKey.R && Cosmos.Hardware.Keyboard.ShiftPressed == true)
                {
                    Pass = Pass + "R";
                }
                else if (key == ConsoleKey.R && Cosmos.Hardware.Keyboard.ShiftPressed == false)
                {
                    Pass = Pass + "r";
                }
                else if (key == ConsoleKey.S && Cosmos.Hardware.Keyboard.ShiftPressed == true)
                {
                    Pass = Pass + "S";
                }
                else if (key == ConsoleKey.S && Cosmos.Hardware.Keyboard.ShiftPressed == false)
                {
                    Pass = Pass + "s";
                }
                else if (key == ConsoleKey.T && Cosmos.Hardware.Keyboard.ShiftPressed == true)
                {
                    Pass = Pass + "T";
                }
                else if (key == ConsoleKey.T && Cosmos.Hardware.Keyboard.ShiftPressed == false)
                {
                    Pass = Pass + "t";
                }
                else if (key == ConsoleKey.U && Cosmos.Hardware.Keyboard.ShiftPressed == true)
                {
                    Pass = Pass + "U";
                }
                else if (key == ConsoleKey.U && Cosmos.Hardware.Keyboard.ShiftPressed == false)
                {
                    Pass = Pass + "u";
                }
                else if (key == ConsoleKey.V && Cosmos.Hardware.Keyboard.ShiftPressed == true)
                {
                    Pass = Pass + "V";
                }
                else if (key == ConsoleKey.V && Cosmos.Hardware.Keyboard.ShiftPressed == false)
                {
                    Pass = Pass + "v";
                }
                else if (key == ConsoleKey.W && Cosmos.Hardware.Keyboard.ShiftPressed == true)
                {
                    Pass = Pass + "W";
                }
                else if (key == ConsoleKey.W && Cosmos.Hardware.Keyboard.ShiftPressed == false)
                {
                    Pass = Pass + "w";
                }
                else if (key == ConsoleKey.X && Cosmos.Hardware.Keyboard.ShiftPressed == true)
                {
                    Pass = Pass + "X";
                }
                else if (key == ConsoleKey.X && Cosmos.Hardware.Keyboard.ShiftPressed == false)
                {
                    Pass = Pass + "x";
                }
                else if (key == ConsoleKey.Y && Cosmos.Hardware.Keyboard.ShiftPressed == true)
                {
                    Pass = Pass + "Y";
                }
                else if (key == ConsoleKey.Y && Cosmos.Hardware.Keyboard.ShiftPressed == false)
                {
                    Pass = Pass + "y";
                }
                else if (key == ConsoleKey.Z && Cosmos.Hardware.Keyboard.ShiftPressed == true)
                {
                    Pass = Pass + "Z";
                }
                else if (key == ConsoleKey.Z && Cosmos.Hardware.Keyboard.ShiftPressed == false)
                {
                    Pass = Pass + "z";
                }

                else if (key == ConsoleKey.Backspace && SendByOne == true)
                {
                    Pass = "BACKSPACE";
                    break;
                }

                else if (key == ConsoleKey.RightArrow && SendByOne == true)
                {
                    Pass = "RIGHT";
                    break;
                }

                else if (key == ConsoleKey.LeftArrow&& SendByOne == true)
                {
                    Pass = "LEFT";
                    break;
                }

                else if (key == ConsoleKey.UpArrow && SendByOne == true)
                {
                    Pass = "UP";
                    break;
                }

                else if (key == ConsoleKey.DownArrow && SendByOne == true)
                {
                    Pass = "DOWN";
                    break;
                }

                else if (key == ConsoleKey.Enter && SendByOne == true)
                {
                    Pass = "ENTER";
                    break;
                }




                if (SendByOne == true)
                {
                    break;
                }
               
               
               

            }
        //    Console.WriteLine();
        //    Console.WriteLine("You Typed: " + Pass);

            

            return Pass;
        }
        


        public static void DrawString(string String, uint posx, uint posy, uint Spacing, uint Color, bool Transparent, bool disableLower)
        {
            int LtrProc = 0;
            

            while (LtrProc < String.Length)
            {

                DrawLetter(String[LtrProc].ToString(), posx, posy, Color, Transparent, disableLower, 63);
                posx = posx + Spacing;

                LtrProc = LtrProc + 1;
            }
        }


        public static void DrawLetter(string letter, uint posx, uint posy, uint Col, bool Transparent, bool disableLower, uint BgCol)
        {
            if (letter == "C")
            {
                VGAScreen.SetPixel(posx, posy, Col);
                VGAScreen.SetPixel(posx + 1, posy, Col);
                VGAScreen.SetPixel(posx + 2, posy, Col);
                VGAScreen.SetPixel(posx + 3, posy, Col);
                VGAScreen.SetPixel(posx + 4, posy, Col);
                VGAScreen.SetPixel(posx + 0, posy + 1, Col);
                VGAScreen.SetPixel(posx + 0, posy + 2, Col);
                VGAScreen.SetPixel(posx + 0, posy + 3, Col);
                VGAScreen.SetPixel(posx + 0, posy + 4, Col);
                VGAScreen.SetPixel(posx + 0, posy + 5, Col);
                VGAScreen.SetPixel(posx + 1, posy + 6, Col);
                VGAScreen.SetPixel(posx + 2, posy + 6, Col);
                VGAScreen.SetPixel(posx + 3, posy + 6, Col);
                VGAScreen.SetPixel(posx + 4, posy + 6, Col);

                if (Transparent == false)
                {
                    VGAScreen.SetPixel(posx + 1, posy + 1, 63);
                    VGAScreen.SetPixel(posx + 2, posy + 1, 63);
                    VGAScreen.SetPixel(posx + 3, posy + 1, 63);
                    VGAScreen.SetPixel(posx + 4, posy + 1, 63);
                    VGAScreen.SetPixel(posx + 1, posy + 2, 63);
                    VGAScreen.SetPixel(posx + 2, posy + 2, 63);
                    VGAScreen.SetPixel(posx + 3, posy + 2, 63);
                    VGAScreen.SetPixel(posx + 4, posy + 2, 63);
                    VGAScreen.SetPixel(posx + 1, posy + 3, 63);
                    VGAScreen.SetPixel(posx + 2, posy + 3, 63);
                    VGAScreen.SetPixel(posx + 3, posy + 3, 63);
                    VGAScreen.SetPixel(posx + 4, posy + 3, 63);
                    VGAScreen.SetPixel(posx + 1, posy + 4, 63);
                    VGAScreen.SetPixel(posx + 2, posy + 4, 63);
                    VGAScreen.SetPixel(posx + 3, posy + 4, 63);
                    VGAScreen.SetPixel(posx + 4, posy + 4, 63);
                    VGAScreen.SetPixel(posx + 1, posy + 5, 63);
                    VGAScreen.SetPixel(posx + 2, posy + 5, 63);
                    VGAScreen.SetPixel(posx + 3, posy + 5, 63);
                    VGAScreen.SetPixel(posx + 4, posy + 5, 63);
                    VGAScreen.SetPixel(posx + 0, posy + 6, 63);
                }

               
            }
            else if (letter == "j")
            {
                if (disableLower == false)
                {
                    posy = posy + 2;
                }
                VGAScreen.SetPixel(posx + 3, posy, Col);
                VGAScreen.SetPixel(posx + 3, posy + 2, Col);
                VGAScreen.SetPixel(posx + 3, posy + 3, Col);
                VGAScreen.SetPixel(posx + 3, posy + 4, Col);
                VGAScreen.SetPixel(posx + 1, posy + 5, Col);
                VGAScreen.SetPixel(posx + 3, posy + 5, Col);
                VGAScreen.SetPixel(posx + 2, posy + 6, Col);

                if (Transparent == false)
                {
                    VGAScreen.SetPixel(posx, posy, BgCol);
                    VGAScreen.SetPixel(posx + 1, posy, BgCol);
                    VGAScreen.SetPixel(posx + 2, posy, BgCol);
                    VGAScreen.SetPixel(posx + 4, posy, BgCol);
                    VGAScreen.SetPixel(posx + 0, posy + 1, BgCol);
                    VGAScreen.SetPixel(posx + 1, posy + 1, BgCol);
                    VGAScreen.SetPixel(posx + 2, posy + 1, BgCol);
                    VGAScreen.SetPixel(posx + 3, posy + 1, BgCol);
                    VGAScreen.SetPixel(posx + 4, posy + 1, BgCol);
                    VGAScreen.SetPixel(posx + 0, posy + 2, BgCol);
                    VGAScreen.SetPixel(posx + 1, posy + 2, BgCol);
                    VGAScreen.SetPixel(posx + 2, posy + 2, BgCol);
                    VGAScreen.SetPixel(posx + 4, posy + 2, BgCol);
                    VGAScreen.SetPixel(posx + 0, posy + 3, BgCol);
                    VGAScreen.SetPixel(posx + 1, posy + 3, BgCol);
                    VGAScreen.SetPixel(posx + 2, posy + 3, BgCol);
                    VGAScreen.SetPixel(posx + 4, posy + 3, BgCol);
                    VGAScreen.SetPixel(posx + 0, posy + 4, BgCol);
                    VGAScreen.SetPixel(posx + 1, posy + 4, BgCol);
                    VGAScreen.SetPixel(posx + 2, posy + 4, BgCol);
                    VGAScreen.SetPixel(posx + 4, posy + 4, BgCol);
                    VGAScreen.SetPixel(posx + 0, posy + 5, BgCol);
                    VGAScreen.SetPixel(posx + 2, posy + 5, BgCol);
                    VGAScreen.SetPixel(posx + 4, posy + 5, BgCol);
                    VGAScreen.SetPixel(posx + 0, posy + 6, BgCol);
                    VGAScreen.SetPixel(posx + 1, posy + 6, BgCol);
                    VGAScreen.SetPixel(posx + 3, posy + 6, BgCol);
                    VGAScreen.SetPixel(posx + 4, posy + 6, BgCol);
                }

            }
            else if (letter == "v")
            {
                VGAScreen.SetPixel(posx + 0, posy + 2, Col);
                VGAScreen.SetPixel(posx + 4, posy + 2, Col);
                VGAScreen.SetPixel(posx + 0, posy + 3, Col);
                VGAScreen.SetPixel(posx + 4, posy + 3, Col);
                VGAScreen.SetPixel(posx + 1, posy + 4, Col);
                VGAScreen.SetPixel(posx + 3, posy + 4, Col);
                VGAScreen.SetPixel(posx + 1, posy + 5, Col);
                VGAScreen.SetPixel(posx + 3, posy + 5, Col);
                VGAScreen.SetPixel(posx + 2, posy + 6, Col);
                if (Transparent == false)
                {
                    VGAScreen.SetPixel(posx, posy, BgCol);
                    VGAScreen.SetPixel(posx + 1, posy, BgCol);
                    VGAScreen.SetPixel(posx + 2, posy, BgCol);
                    VGAScreen.SetPixel(posx + 3, posy, BgCol);
                    VGAScreen.SetPixel(posx + 4, posy, BgCol);
                    VGAScreen.SetPixel(posx + 0, posy + 1, BgCol);
                    VGAScreen.SetPixel(posx + 1, posy + 1, BgCol);
                    VGAScreen.SetPixel(posx + 2, posy + 1, BgCol);
                    VGAScreen.SetPixel(posx + 3, posy + 1, BgCol);
                    VGAScreen.SetPixel(posx + 4, posy + 1, BgCol);
                    VGAScreen.SetPixel(posx + 1, posy + 2, BgCol);
                    VGAScreen.SetPixel(posx + 2, posy + 2, BgCol);
                    VGAScreen.SetPixel(posx + 3, posy + 2, BgCol);
                    VGAScreen.SetPixel(posx + 1, posy + 3, BgCol);
                    VGAScreen.SetPixel(posx + 2, posy + 3, BgCol);
                    VGAScreen.SetPixel(posx + 3, posy + 3, BgCol);
                    VGAScreen.SetPixel(posx + 0, posy + 4, BgCol);
                    VGAScreen.SetPixel(posx + 2, posy + 4, BgCol);
                    VGAScreen.SetPixel(posx + 4, posy + 4, BgCol);
                    VGAScreen.SetPixel(posx + 0, posy + 5, BgCol);
                    VGAScreen.SetPixel(posx + 2, posy + 5, BgCol);
                    VGAScreen.SetPixel(posx + 4, posy + 5, BgCol);
                    VGAScreen.SetPixel(posx + 0, posy + 6, BgCol);
                    VGAScreen.SetPixel(posx + 1, posy + 6, BgCol);
                    VGAScreen.SetPixel(posx + 3, posy + 6, BgCol);
                    VGAScreen.SetPixel(posx + 4, posy + 6, BgCol);
                }

            }

            else if (letter == "q")
            {
                if (disableLower == false)
                {
                    posy = posy + 2;
                }
                VGAScreen.SetPixel(posx + 1, posy, Col);
                VGAScreen.SetPixel(posx + 2, posy, Col);
                VGAScreen.SetPixel(posx + 3, posy, Col);
                VGAScreen.SetPixel(posx + 0, posy + 1, Col);
                VGAScreen.SetPixel(posx + 4, posy + 1, Col);
                VGAScreen.SetPixel(posx + 0, posy + 2, Col);
                VGAScreen.SetPixel(posx + 4, posy + 2, Col);
                VGAScreen.SetPixel(posx + 0, posy + 3, Col);
                VGAScreen.SetPixel(posx + 4, posy + 3, Col);
                VGAScreen.SetPixel(posx + 1, posy + 4, Col);
                VGAScreen.SetPixel(posx + 2, posy + 4, Col);
                VGAScreen.SetPixel(posx + 3, posy + 4, Col);
                VGAScreen.SetPixel(posx + 4, posy + 4, Col);
                VGAScreen.SetPixel(posx + 4, posy + 5, Col);
                VGAScreen.SetPixel(posx + 4, posy + 6, Col);
                if (Transparent == false)
                {
                    VGAScreen.SetPixel(posx, posy, BgCol);
                    VGAScreen.SetPixel(posx + 4, posy, BgCol);
                    VGAScreen.SetPixel(posx + 1, posy + 1, BgCol);
                    VGAScreen.SetPixel(posx + 2, posy + 1, BgCol);
                    VGAScreen.SetPixel(posx + 3, posy + 1, BgCol);
                    VGAScreen.SetPixel(posx + 1, posy + 2, BgCol);
                    VGAScreen.SetPixel(posx + 2, posy + 2, BgCol);
                    VGAScreen.SetPixel(posx + 3, posy + 2, BgCol);
                    VGAScreen.SetPixel(posx + 1, posy + 3, BgCol);
                    VGAScreen.SetPixel(posx + 2, posy + 3, BgCol);
                    VGAScreen.SetPixel(posx + 3, posy + 3, BgCol);
                    VGAScreen.SetPixel(posx + 0, posy + 4, BgCol);
                    VGAScreen.SetPixel(posx + 0, posy + 5, BgCol);
                    VGAScreen.SetPixel(posx + 1, posy + 5, BgCol);
                    VGAScreen.SetPixel(posx + 2, posy + 5, BgCol);
                    VGAScreen.SetPixel(posx + 3, posy + 5, BgCol);
                    VGAScreen.SetPixel(posx + 0, posy + 6, BgCol);
                    VGAScreen.SetPixel(posx + 1, posy + 6, BgCol);
                    VGAScreen.SetPixel(posx + 2, posy + 6, BgCol);
                    VGAScreen.SetPixel(posx + 3, posy + 6, BgCol);
                }


            }
            else if (letter == "y")
            {
                if (disableLower == false)
                {
                    posy = posy + 2;
                }
                VGAScreen.SetPixel(posx, posy, Col);
                VGAScreen.SetPixel(posx + 4, posy, Col);
                VGAScreen.SetPixel(posx + 0, posy + 1, Col);
                VGAScreen.SetPixel(posx + 4, posy + 1, Col);
                VGAScreen.SetPixel(posx + 0, posy + 2, Col);
                VGAScreen.SetPixel(posx + 4, posy + 2, Col);
                VGAScreen.SetPixel(posx + 1, posy + 3, Col);
                VGAScreen.SetPixel(posx + 2, posy + 3, Col);
                VGAScreen.SetPixel(posx + 3, posy + 3, Col);
                VGAScreen.SetPixel(posx + 4, posy + 3, Col);
                VGAScreen.SetPixel(posx + 4, posy + 4, Col);
                VGAScreen.SetPixel(posx + 4, posy + 5, Col);
                VGAScreen.SetPixel(posx + 0, posy + 6, Col);
                VGAScreen.SetPixel(posx + 1, posy + 6, Col);
                VGAScreen.SetPixel(posx + 2, posy + 6, Col);
                VGAScreen.SetPixel(posx + 3, posy + 6, Col);

                if (Transparent == false)
                {
                    VGAScreen.SetPixel(posx + 1, posy, BgCol);
                    VGAScreen.SetPixel(posx + 2, posy, BgCol);
                    VGAScreen.SetPixel(posx + 3, posy, BgCol);
                    VGAScreen.SetPixel(posx + 1, posy + 1, BgCol);
                    VGAScreen.SetPixel(posx + 2, posy + 1, BgCol);
                    VGAScreen.SetPixel(posx + 3, posy + 1, BgCol);
                    VGAScreen.SetPixel(posx + 1, posy + 2, BgCol);
                    VGAScreen.SetPixel(posx + 2, posy + 2, BgCol);
                    VGAScreen.SetPixel(posx + 3, posy + 2, BgCol);
                    VGAScreen.SetPixel(posx + 0, posy + 3, BgCol);
                    VGAScreen.SetPixel(posx + 0, posy + 4, BgCol);
                    VGAScreen.SetPixel(posx + 1, posy + 4, BgCol);
                    VGAScreen.SetPixel(posx + 2, posy + 4, BgCol);
                    VGAScreen.SetPixel(posx + 3, posy + 4, BgCol);
                    VGAScreen.SetPixel(posx + 0, posy + 5, BgCol);
                    VGAScreen.SetPixel(posx + 1, posy + 5, BgCol);
                    VGAScreen.SetPixel(posx + 2, posy + 5, BgCol);
                    VGAScreen.SetPixel(posx + 3, posy + 5, BgCol);
                    VGAScreen.SetPixel(posx + 4, posy + 6, BgCol);
                }

            }
            else if (letter == "z")
            {
                VGAScreen.SetPixel(posx + 0, posy + 2, Col);
                VGAScreen.SetPixel(posx + 1, posy + 2, Col);
                VGAScreen.SetPixel(posx + 2, posy + 2, Col);
                VGAScreen.SetPixel(posx + 3, posy + 2, Col);
                VGAScreen.SetPixel(posx + 4, posy + 2, Col);
                VGAScreen.SetPixel(posx + 3, posy + 3, Col);
                VGAScreen.SetPixel(posx + 2, posy + 4, Col);
                VGAScreen.SetPixel(posx + 1, posy + 5, Col);
                VGAScreen.SetPixel(posx + 0, posy + 6, Col);
                VGAScreen.SetPixel(posx + 1, posy + 6, Col);
                VGAScreen.SetPixel(posx + 2, posy + 6, Col);
                VGAScreen.SetPixel(posx + 3, posy + 6, Col);
                VGAScreen.SetPixel(posx + 4, posy + 6, Col);

                if (Transparent == false)
                {
                    VGAScreen.SetPixel(posx, posy, BgCol);
                    VGAScreen.SetPixel(posx + 1, posy, BgCol);
                    VGAScreen.SetPixel(posx + 2, posy, BgCol);
                    VGAScreen.SetPixel(posx + 3, posy, BgCol);
                    VGAScreen.SetPixel(posx + 4, posy, BgCol);
                    VGAScreen.SetPixel(posx + 0, posy + 1, BgCol);
                    VGAScreen.SetPixel(posx + 1, posy + 1, BgCol);
                    VGAScreen.SetPixel(posx + 2, posy + 1, BgCol);
                    VGAScreen.SetPixel(posx + 3, posy + 1, BgCol);
                    VGAScreen.SetPixel(posx + 4, posy + 1, BgCol);
                    VGAScreen.SetPixel(posx + 0, posy + 3, BgCol);
                    VGAScreen.SetPixel(posx + 1, posy + 3, BgCol);
                    VGAScreen.SetPixel(posx + 2, posy + 3, BgCol);
                    VGAScreen.SetPixel(posx + 4, posy + 3, BgCol);
                    VGAScreen.SetPixel(posx + 0, posy + 4, BgCol);
                    VGAScreen.SetPixel(posx + 1, posy + 4, BgCol);
                    VGAScreen.SetPixel(posx + 3, posy + 4, BgCol);
                    VGAScreen.SetPixel(posx + 4, posy + 4, BgCol);
                    VGAScreen.SetPixel(posx + 0, posy + 5, BgCol);
                    VGAScreen.SetPixel(posx + 2, posy + 5, BgCol);
                    VGAScreen.SetPixel(posx + 3, posy + 5, BgCol);
                    VGAScreen.SetPixel(posx + 4, posy + 5, BgCol);
                }

            }
            else if (letter == "l")
            {
                VGAScreen.SetPixel(posx + 2, posy, Col);
                VGAScreen.SetPixel(posx + 2, posy + 1, Col);
                VGAScreen.SetPixel(posx + 2, posy + 2, Col);
                VGAScreen.SetPixel(posx + 2, posy + 3, Col);
                VGAScreen.SetPixel(posx + 2, posy + 4, Col);
                VGAScreen.SetPixel(posx + 2, posy + 5, Col);
                VGAScreen.SetPixel(posx + 2, posy + 6, Col);
                if (Transparent == false)
                {
                    VGAScreen.SetPixel(posx, posy, BgCol);
                    VGAScreen.SetPixel(posx + 1, posy, BgCol);
                    VGAScreen.SetPixel(posx + 3, posy, BgCol);
                    VGAScreen.SetPixel(posx + 4, posy, BgCol);
                    VGAScreen.SetPixel(posx + 0, posy + 1, BgCol);
                    VGAScreen.SetPixel(posx + 1, posy + 1, BgCol);
                    VGAScreen.SetPixel(posx + 3, posy + 1, BgCol);
                    VGAScreen.SetPixel(posx + 4, posy + 1, BgCol);
                    VGAScreen.SetPixel(posx + 0, posy + 2, BgCol);
                    VGAScreen.SetPixel(posx + 1, posy + 2, BgCol);
                    VGAScreen.SetPixel(posx + 3, posy + 2, BgCol);
                    VGAScreen.SetPixel(posx + 4, posy + 2, BgCol);
                    VGAScreen.SetPixel(posx + 0, posy + 3, BgCol);
                    VGAScreen.SetPixel(posx + 1, posy + 3, BgCol);
                    VGAScreen.SetPixel(posx + 3, posy + 3, BgCol);
                    VGAScreen.SetPixel(posx + 4, posy + 3, BgCol);
                    VGAScreen.SetPixel(posx + 0, posy + 4, BgCol);
                    VGAScreen.SetPixel(posx + 1, posy + 4, BgCol);
                    VGAScreen.SetPixel(posx + 3, posy + 4, BgCol);
                    VGAScreen.SetPixel(posx + 4, posy + 4, BgCol);
                    VGAScreen.SetPixel(posx + 0, posy + 5, BgCol);
                    VGAScreen.SetPixel(posx + 1, posy + 5, BgCol);
                    VGAScreen.SetPixel(posx + 3, posy + 5, BgCol);
                    VGAScreen.SetPixel(posx + 4, posy + 5, BgCol);
                    VGAScreen.SetPixel(posx + 0, posy + 6, BgCol);
                    VGAScreen.SetPixel(posx + 1, posy + 6, BgCol);
                    VGAScreen.SetPixel(posx + 3, posy + 6, BgCol);
                    VGAScreen.SetPixel(posx + 4, posy + 6, BgCol);
                }

            }
            else if (letter == "x")
            {
                VGAScreen.SetPixel(posx + 0, posy + 2, Col);
                VGAScreen.SetPixel(posx + 4, posy + 2, Col);
                VGAScreen.SetPixel(posx + 1, posy + 3, Col);
                VGAScreen.SetPixel(posx + 3, posy + 3, Col);
                VGAScreen.SetPixel(posx + 2, posy + 4, Col);
                VGAScreen.SetPixel(posx + 1, posy + 5, Col);
                VGAScreen.SetPixel(posx + 3, posy + 5, Col);
                VGAScreen.SetPixel(posx + 0, posy + 6, Col);
                VGAScreen.SetPixel(posx + 4, posy + 6, Col);

                if (Transparent == false)
                {
                    VGAScreen.SetPixel(posx, posy, BgCol);
                    VGAScreen.SetPixel(posx + 1, posy, BgCol);
                    VGAScreen.SetPixel(posx + 2, posy, BgCol);
                    VGAScreen.SetPixel(posx + 3, posy, BgCol);
                    VGAScreen.SetPixel(posx + 4, posy, BgCol);
                    VGAScreen.SetPixel(posx + 0, posy + 1, BgCol);
                    VGAScreen.SetPixel(posx + 1, posy + 1, BgCol);
                    VGAScreen.SetPixel(posx + 2, posy + 1, BgCol);
                    VGAScreen.SetPixel(posx + 3, posy + 1, BgCol);
                    VGAScreen.SetPixel(posx + 4, posy + 1, BgCol);
                    VGAScreen.SetPixel(posx + 1, posy + 2, BgCol);
                    VGAScreen.SetPixel(posx + 2, posy + 2, BgCol);
                    VGAScreen.SetPixel(posx + 3, posy + 2, BgCol);
                    VGAScreen.SetPixel(posx + 0, posy + 3, BgCol);
                    VGAScreen.SetPixel(posx + 2, posy + 3, BgCol);
                    VGAScreen.SetPixel(posx + 4, posy + 3, BgCol);
                    VGAScreen.SetPixel(posx + 0, posy + 4, BgCol);
                    VGAScreen.SetPixel(posx + 1, posy + 4, BgCol);
                    VGAScreen.SetPixel(posx + 3, posy + 4, BgCol);
                    VGAScreen.SetPixel(posx + 4, posy + 4, BgCol);
                    VGAScreen.SetPixel(posx + 0, posy + 5, BgCol);
                    VGAScreen.SetPixel(posx + 2, posy + 5, BgCol);
                    VGAScreen.SetPixel(posx + 4, posy + 5, BgCol);
                    VGAScreen.SetPixel(posx + 1, posy + 6, BgCol);
                    VGAScreen.SetPixel(posx + 2, posy + 6, BgCol);
                    VGAScreen.SetPixel(posx + 3, posy + 6, BgCol);
                }

            }
            else if (letter == "I")
            {
                VGAScreen.SetPixel(posx, posy, Col);
                VGAScreen.SetPixel(posx + 1, posy, Col);
                VGAScreen.SetPixel(posx + 2, posy, Col);
                VGAScreen.SetPixel(posx + 3, posy, Col);
                VGAScreen.SetPixel(posx + 4, posy, Col);
                VGAScreen.SetPixel(posx + 2, posy + 1, Col);
                VGAScreen.SetPixel(posx + 2, posy + 2, Col);
                VGAScreen.SetPixel(posx + 2, posy + 3, Col);
                VGAScreen.SetPixel(posx + 2, posy + 4, Col);
                VGAScreen.SetPixel(posx + 2, posy + 5, Col);
                VGAScreen.SetPixel(posx + 0, posy + 6, Col);
                VGAScreen.SetPixel(posx + 1, posy + 6, Col);
                VGAScreen.SetPixel(posx + 2, posy + 6, Col);
                VGAScreen.SetPixel(posx + 3, posy + 6, Col);
                VGAScreen.SetPixel(posx + 4, posy + 6, Col);
                if (Transparent == false)
                {
                    VGAScreen.SetPixel(posx + 0, posy + 1, BgCol);
                    VGAScreen.SetPixel(posx + 1, posy + 1, BgCol);
                    VGAScreen.SetPixel(posx + 3, posy + 1, BgCol);
                    VGAScreen.SetPixel(posx + 4, posy + 1, BgCol);
                    VGAScreen.SetPixel(posx + 0, posy + 2, BgCol);
                    VGAScreen.SetPixel(posx + 1, posy + 2, BgCol);
                    VGAScreen.SetPixel(posx + 3, posy + 2, BgCol);
                    VGAScreen.SetPixel(posx + 4, posy + 2, BgCol);
                    VGAScreen.SetPixel(posx + 0, posy + 3, BgCol);
                    VGAScreen.SetPixel(posx + 1, posy + 3, BgCol);
                    VGAScreen.SetPixel(posx + 3, posy + 3, BgCol);
                    VGAScreen.SetPixel(posx + 4, posy + 3, BgCol);
                    VGAScreen.SetPixel(posx + 0, posy + 4, BgCol);
                    VGAScreen.SetPixel(posx + 1, posy + 4, BgCol);
                    VGAScreen.SetPixel(posx + 3, posy + 4, BgCol);
                    VGAScreen.SetPixel(posx + 4, posy + 4, BgCol);
                    VGAScreen.SetPixel(posx + 0, posy + 5, BgCol);
                    VGAScreen.SetPixel(posx + 1, posy + 5, BgCol);
                    VGAScreen.SetPixel(posx + 3, posy + 5, BgCol);
                    VGAScreen.SetPixel(posx + 4, posy + 5, BgCol);
                }

            }
            else if (letter == "e")
            {
                VGAScreen.SetPixel(posx + 1, posy + 2, Col);
                VGAScreen.SetPixel(posx + 2, posy + 2, Col);
                VGAScreen.SetPixel(posx + 3, posy + 2, Col);
                VGAScreen.SetPixel(posx + 0, posy + 3, Col);
                VGAScreen.SetPixel(posx + 4, posy + 3, Col);
                VGAScreen.SetPixel(posx + 0, posy + 4, Col);
                VGAScreen.SetPixel(posx + 1, posy + 4, Col);
                VGAScreen.SetPixel(posx + 2, posy + 4, Col);
                VGAScreen.SetPixel(posx + 3, posy + 4, Col);
                VGAScreen.SetPixel(posx + 0, posy + 5, Col);
                VGAScreen.SetPixel(posx + 1, posy + 6, Col);
                VGAScreen.SetPixel(posx + 2, posy + 6, Col);
                VGAScreen.SetPixel(posx + 3, posy + 6, Col);
                VGAScreen.SetPixel(posx + 4, posy + 6, Col);


                if (Transparent == false)
                {
                    VGAScreen.SetPixel(posx, posy, BgCol);
                    VGAScreen.SetPixel(posx + 1, posy, BgCol);
                    VGAScreen.SetPixel(posx + 2, posy, BgCol);
                    VGAScreen.SetPixel(posx + 3, posy, BgCol);
                    VGAScreen.SetPixel(posx + 4, posy, BgCol);
                    VGAScreen.SetPixel(posx + 0, posy + 1, BgCol);
                    VGAScreen.SetPixel(posx + 1, posy + 1, BgCol);
                    VGAScreen.SetPixel(posx + 2, posy + 1, BgCol);
                    VGAScreen.SetPixel(posx + 3, posy + 1, BgCol);
                    VGAScreen.SetPixel(posx + 4, posy + 1, BgCol);
                    VGAScreen.SetPixel(posx + 0, posy + 2, BgCol);
                    VGAScreen.SetPixel(posx + 4, posy + 2, BgCol);
                    VGAScreen.SetPixel(posx + 1, posy + 3, BgCol);
                    VGAScreen.SetPixel(posx + 2, posy + 3, BgCol);
                    VGAScreen.SetPixel(posx + 3, posy + 3, BgCol);
                    VGAScreen.SetPixel(posx + 4, posy + 4, BgCol);
                    VGAScreen.SetPixel(posx + 1, posy + 5, BgCol);
                    VGAScreen.SetPixel(posx + 2, posy + 5, BgCol);
                    VGAScreen.SetPixel(posx + 3, posy + 5, BgCol);
                    VGAScreen.SetPixel(posx + 4, posy + 5, BgCol);
                    VGAScreen.SetPixel(posx + 0, posy + 6, BgCol);
                }

            }
            else if (letter == "m")
            {

                VGAScreen.SetPixel(posx + 0, posy + 2, Col);
                VGAScreen.SetPixel(posx + 1, posy + 2, Col);
                VGAScreen.SetPixel(posx + 2, posy + 2, Col);
                VGAScreen.SetPixel(posx + 3, posy + 2, Col);
                VGAScreen.SetPixel(posx + 4, posy + 2, Col);
                VGAScreen.SetPixel(posx + 0, posy + 3, Col);
                VGAScreen.SetPixel(posx + 2, posy + 3, Col);
                VGAScreen.SetPixel(posx + 4, posy + 3, Col);
                VGAScreen.SetPixel(posx + 0, posy + 4, Col);
                VGAScreen.SetPixel(posx + 2, posy + 4, Col);
                VGAScreen.SetPixel(posx + 4, posy + 4, Col);
                VGAScreen.SetPixel(posx + 0, posy + 5, Col);
                VGAScreen.SetPixel(posx + 2, posy + 5, Col);
                VGAScreen.SetPixel(posx + 4, posy + 5, Col);
                VGAScreen.SetPixel(posx + 0, posy + 6, Col);
                VGAScreen.SetPixel(posx + 2, posy + 6, Col);
                VGAScreen.SetPixel(posx + 4, posy + 6, Col);

                if (Transparent == false)
                {
                    VGAScreen.SetPixel(posx, posy, BgCol);
                    VGAScreen.SetPixel(posx + 1, posy, BgCol);
                    VGAScreen.SetPixel(posx + 2, posy, BgCol);
                    VGAScreen.SetPixel(posx + 3, posy, BgCol);
                    VGAScreen.SetPixel(posx + 4, posy, BgCol);
                    VGAScreen.SetPixel(posx + 0, posy + 1, BgCol);
                    VGAScreen.SetPixel(posx + 1, posy + 1, BgCol);
                    VGAScreen.SetPixel(posx + 2, posy + 1, BgCol);
                    VGAScreen.SetPixel(posx + 3, posy + 1, BgCol);
                    VGAScreen.SetPixel(posx + 4, posy + 1, BgCol);
                    VGAScreen.SetPixel(posx + 1, posy + 3, BgCol);
                    VGAScreen.SetPixel(posx + 3, posy + 3, BgCol);
                    VGAScreen.SetPixel(posx + 1, posy + 4, BgCol);
                    VGAScreen.SetPixel(posx + 3, posy + 4, BgCol);
                    VGAScreen.SetPixel(posx + 1, posy + 5, BgCol);
                    VGAScreen.SetPixel(posx + 3, posy + 5, BgCol);
                    VGAScreen.SetPixel(posx + 1, posy + 6, BgCol);
                    VGAScreen.SetPixel(posx + 3, posy + 6, BgCol);
                }




            }
            else if (letter == ":")
            {
                VGAScreen.SetPixel(posx + 2, posy + 2, Col);
                VGAScreen.SetPixel(posx + 2, posy + 4, Col);



                if (Transparent == false)
                {
                    VGAScreen.SetPixel(posx, posy, 63);
                    VGAScreen.SetPixel(posx + 1, posy, 63);
                    VGAScreen.SetPixel(posx + 2, posy, 63);
                    VGAScreen.SetPixel(posx + 3, posy, 63);
                    VGAScreen.SetPixel(posx + 4, posy, 63);
                    VGAScreen.SetPixel(posx + 0, posy + 1, 63);
                    VGAScreen.SetPixel(posx + 1, posy + 1, 63);
                    VGAScreen.SetPixel(posx + 2, posy + 1, 63);
                    VGAScreen.SetPixel(posx + 3, posy + 1, 63);
                    VGAScreen.SetPixel(posx + 4, posy + 1, 63);
                    VGAScreen.SetPixel(posx + 0, posy + 2, 63);
                    VGAScreen.SetPixel(posx + 1, posy + 2, 63);
                    VGAScreen.SetPixel(posx + 3, posy + 2, 63);
                    VGAScreen.SetPixel(posx + 4, posy + 2, 63);
                    VGAScreen.SetPixel(posx + 0, posy + 3, 63);
                    VGAScreen.SetPixel(posx + 1, posy + 3, 63);
                    VGAScreen.SetPixel(posx + 2, posy + 3, 63);
                    VGAScreen.SetPixel(posx + 3, posy + 3, 63);
                    VGAScreen.SetPixel(posx + 4, posy + 3, 63);
                    VGAScreen.SetPixel(posx + 0, posy + 4, 63);
                    VGAScreen.SetPixel(posx + 1, posy + 4, 63);
                    VGAScreen.SetPixel(posx + 3, posy + 4, 63);
                    VGAScreen.SetPixel(posx + 4, posy + 4, 63);
                    VGAScreen.SetPixel(posx + 0, posy + 5, 63);
                    VGAScreen.SetPixel(posx + 1, posy + 5, 63);
                    VGAScreen.SetPixel(posx + 2, posy + 5, 63);
                    VGAScreen.SetPixel(posx + 3, posy + 5, 63);
                    VGAScreen.SetPixel(posx + 4, posy + 5, 63);
                    VGAScreen.SetPixel(posx + 0, posy + 6, 63);
                    VGAScreen.SetPixel(posx + 1, posy + 6, 63);
                    VGAScreen.SetPixel(posx + 2, posy + 6, 63);
                    VGAScreen.SetPixel(posx + 3, posy + 6, 63);
                    VGAScreen.SetPixel(posx + 4, posy + 6, 63);
                }
            }
            else if (letter == "k")
            {
                VGAScreen.SetPixel(posx, posy, Col);
                VGAScreen.SetPixel(posx + 0, posy + 1, Col);
                VGAScreen.SetPixel(posx + 0, posy + 2, Col);
                VGAScreen.SetPixel(posx + 3, posy + 2, Col);
                VGAScreen.SetPixel(posx + 0, posy + 3, Col);
                VGAScreen.SetPixel(posx + 2, posy + 3, Col);
                VGAScreen.SetPixel(posx + 0, posy + 4, Col);
                VGAScreen.SetPixel(posx + 1, posy + 4, Col);
                VGAScreen.SetPixel(posx + 0, posy + 5, Col);
                VGAScreen.SetPixel(posx + 2, posy + 5, Col);
                VGAScreen.SetPixel(posx + 0, posy + 6, Col);
                VGAScreen.SetPixel(posx + 3, posy + 6, Col);

                if (Transparent == false)
                {
                    VGAScreen.SetPixel(posx + 1, posy, BgCol);
                    VGAScreen.SetPixel(posx + 2, posy, BgCol);
                    VGAScreen.SetPixel(posx + 3, posy, BgCol);
                    VGAScreen.SetPixel(posx + 4, posy, BgCol);
                    VGAScreen.SetPixel(posx + 1, posy + 1, BgCol);
                    VGAScreen.SetPixel(posx + 2, posy + 1, BgCol);
                    VGAScreen.SetPixel(posx + 3, posy + 1, BgCol);
                    VGAScreen.SetPixel(posx + 4, posy + 1, BgCol);
                    VGAScreen.SetPixel(posx + 1, posy + 2, BgCol);
                    VGAScreen.SetPixel(posx + 2, posy + 2, BgCol);
                    VGAScreen.SetPixel(posx + 4, posy + 2, BgCol);
                    VGAScreen.SetPixel(posx + 1, posy + 3, BgCol);
                    VGAScreen.SetPixel(posx + 3, posy + 3, BgCol);
                    VGAScreen.SetPixel(posx + 4, posy + 3, BgCol);
                    VGAScreen.SetPixel(posx + 2, posy + 4, BgCol);
                    VGAScreen.SetPixel(posx + 3, posy + 4, BgCol);
                    VGAScreen.SetPixel(posx + 4, posy + 4, BgCol);
                    VGAScreen.SetPixel(posx + 1, posy + 5, BgCol);
                    VGAScreen.SetPixel(posx + 3, posy + 5, BgCol);
                    VGAScreen.SetPixel(posx + 4, posy + 5, BgCol);
                    VGAScreen.SetPixel(posx + 1, posy + 6, BgCol);
                    VGAScreen.SetPixel(posx + 2, posy + 6, BgCol);
                    VGAScreen.SetPixel(posx + 4, posy + 6, BgCol);
                }

            }
            else if (letter == "h")
            {
                VGAScreen.SetPixel(posx, posy, Col);
                VGAScreen.SetPixel(posx + 0, posy + 1, Col);
                VGAScreen.SetPixel(posx + 0, posy + 2, Col);
                VGAScreen.SetPixel(posx + 1, posy + 2, Col);
                VGAScreen.SetPixel(posx + 2, posy + 2, Col);
                VGAScreen.SetPixel(posx + 3, posy + 2, Col);
                VGAScreen.SetPixel(posx + 0, posy + 3, Col);
                VGAScreen.SetPixel(posx + 4, posy + 3, Col);
                VGAScreen.SetPixel(posx + 0, posy + 4, Col);
                VGAScreen.SetPixel(posx + 4, posy + 4, Col);
                VGAScreen.SetPixel(posx + 0, posy + 5, Col);
                VGAScreen.SetPixel(posx + 4, posy + 5, Col);
                VGAScreen.SetPixel(posx + 0, posy + 6, Col);
                VGAScreen.SetPixel(posx + 4, posy + 6, Col);

                if (Transparent == false)
                {
                    VGAScreen.SetPixel(posx + 1, posy, BgCol);
                    VGAScreen.SetPixel(posx + 2, posy, BgCol);
                    VGAScreen.SetPixel(posx + 3, posy, BgCol);
                    VGAScreen.SetPixel(posx + 4, posy, BgCol);
                    VGAScreen.SetPixel(posx + 1, posy + 1, BgCol);
                    VGAScreen.SetPixel(posx + 2, posy + 1, BgCol);
                    VGAScreen.SetPixel(posx + 3, posy + 1, BgCol);
                    VGAScreen.SetPixel(posx + 4, posy + 1, BgCol);
                    VGAScreen.SetPixel(posx + 4, posy + 2, BgCol);
                    VGAScreen.SetPixel(posx + 1, posy + 3, BgCol);
                    VGAScreen.SetPixel(posx + 2, posy + 3, BgCol);
                    VGAScreen.SetPixel(posx + 3, posy + 3, BgCol);
                    VGAScreen.SetPixel(posx + 1, posy + 4, BgCol);
                    VGAScreen.SetPixel(posx + 2, posy + 4, BgCol);
                    VGAScreen.SetPixel(posx + 3, posy + 4, BgCol);
                    VGAScreen.SetPixel(posx + 1, posy + 5, BgCol);
                    VGAScreen.SetPixel(posx + 2, posy + 5, BgCol);
                    VGAScreen.SetPixel(posx + 3, posy + 5, BgCol);
                    VGAScreen.SetPixel(posx + 1, posy + 6, BgCol);
                    VGAScreen.SetPixel(posx + 2, posy + 6, BgCol);
                    VGAScreen.SetPixel(posx + 3, posy + 6, BgCol);
                }

            }
            else if (letter == "f")
            {
                VGAScreen.SetPixel(posx + 3, posy, Col);
                VGAScreen.SetPixel(posx + 2, posy + 1, Col);
                VGAScreen.SetPixel(posx + 4, posy + 1, Col);
                VGAScreen.SetPixel(posx + 2, posy + 2, Col);
                VGAScreen.SetPixel(posx + 1, posy + 3, Col);
                VGAScreen.SetPixel(posx + 2, posy + 3, Col);
                VGAScreen.SetPixel(posx + 3, posy + 3, Col);
                VGAScreen.SetPixel(posx + 2, posy + 4, Col);
                VGAScreen.SetPixel(posx + 2, posy + 5, Col);
                VGAScreen.SetPixel(posx + 2, posy + 6, Col);

                if (Transparent == false)
                {
                    VGAScreen.SetPixel(posx, posy, BgCol);
                    VGAScreen.SetPixel(posx + 1, posy, BgCol);
                    VGAScreen.SetPixel(posx + 2, posy, BgCol);
                    VGAScreen.SetPixel(posx + 4, posy, BgCol);
                    VGAScreen.SetPixel(posx + 0, posy + 1, BgCol);
                    VGAScreen.SetPixel(posx + 1, posy + 1, BgCol);
                    VGAScreen.SetPixel(posx + 3, posy + 1, BgCol);
                    VGAScreen.SetPixel(posx + 0, posy + 2, BgCol);
                    VGAScreen.SetPixel(posx + 1, posy + 2, BgCol);
                    VGAScreen.SetPixel(posx + 3, posy + 2, BgCol);
                    VGAScreen.SetPixel(posx + 4, posy + 2, BgCol);
                    VGAScreen.SetPixel(posx + 0, posy + 3, BgCol);
                    VGAScreen.SetPixel(posx + 4, posy + 3, BgCol);
                    VGAScreen.SetPixel(posx + 0, posy + 4, BgCol);
                    VGAScreen.SetPixel(posx + 1, posy + 4, BgCol);
                    VGAScreen.SetPixel(posx + 3, posy + 4, BgCol);
                    VGAScreen.SetPixel(posx + 4, posy + 4, BgCol);
                    VGAScreen.SetPixel(posx + 0, posy + 5, BgCol);
                    VGAScreen.SetPixel(posx + 1, posy + 5, BgCol);
                    VGAScreen.SetPixel(posx + 3, posy + 5, BgCol);
                    VGAScreen.SetPixel(posx + 4, posy + 5, BgCol);
                    VGAScreen.SetPixel(posx + 0, posy + 6, BgCol);
                    VGAScreen.SetPixel(posx + 1, posy + 6, BgCol);
                    VGAScreen.SetPixel(posx + 3, posy + 6, BgCol);
                    VGAScreen.SetPixel(posx + 4, posy + 6, BgCol);
                }

            }
            else if (letter == "b")
            {
                VGAScreen.SetPixel(posx, posy, Col);
                VGAScreen.SetPixel(posx + 0, posy + 1, Col);
                VGAScreen.SetPixel(posx + 0, posy + 2, Col);
                VGAScreen.SetPixel(posx + 1, posy + 2, Col);
                VGAScreen.SetPixel(posx + 2, posy + 2, Col);
                VGAScreen.SetPixel(posx + 3, posy + 2, Col);
                VGAScreen.SetPixel(posx + 0, posy + 3, Col);
                VGAScreen.SetPixel(posx + 4, posy + 3, Col);
                VGAScreen.SetPixel(posx + 0, posy + 4, Col);
                VGAScreen.SetPixel(posx + 4, posy + 4, Col);
                VGAScreen.SetPixel(posx + 0, posy + 5, Col);
                VGAScreen.SetPixel(posx + 4, posy + 5, Col);
                VGAScreen.SetPixel(posx + 0, posy + 6, Col);
                VGAScreen.SetPixel(posx + 1, posy + 6, Col);
                VGAScreen.SetPixel(posx + 2, posy + 6, Col);
                VGAScreen.SetPixel(posx + 3, posy + 6, Col);

                if (Transparent == false)
                {
                    VGAScreen.SetPixel(posx + 1, posy, BgCol);
                    VGAScreen.SetPixel(posx + 2, posy, BgCol);
                    VGAScreen.SetPixel(posx + 3, posy, BgCol);
                    VGAScreen.SetPixel(posx + 4, posy, BgCol);
                    VGAScreen.SetPixel(posx + 1, posy + 1, BgCol);
                    VGAScreen.SetPixel(posx + 2, posy + 1, BgCol);
                    VGAScreen.SetPixel(posx + 3, posy + 1, BgCol);
                    VGAScreen.SetPixel(posx + 4, posy + 1, BgCol);
                    VGAScreen.SetPixel(posx + 4, posy + 2, BgCol);
                    VGAScreen.SetPixel(posx + 1, posy + 3, BgCol);
                    VGAScreen.SetPixel(posx + 2, posy + 3, BgCol);
                    VGAScreen.SetPixel(posx + 3, posy + 3, BgCol);
                    VGAScreen.SetPixel(posx + 1, posy + 4, BgCol);
                    VGAScreen.SetPixel(posx + 2, posy + 4, BgCol);
                    VGAScreen.SetPixel(posx + 3, posy + 4, BgCol);
                    VGAScreen.SetPixel(posx + 1, posy + 5, BgCol);
                    VGAScreen.SetPixel(posx + 2, posy + 5, BgCol);
                    VGAScreen.SetPixel(posx + 3, posy + 5, BgCol);
                    VGAScreen.SetPixel(posx + 4, posy + 6, BgCol);
                }

            }
            else if (letter == "*")
            {

                VGAScreen.SetPixel(posx + 2, posy + 1, 1);
                VGAScreen.SetPixel(posx + 0, posy + 2, 1);
                VGAScreen.SetPixel(posx + 1, posy + 2, 1);
                VGAScreen.SetPixel(posx + 2, posy + 2, 1);
                VGAScreen.SetPixel(posx + 3, posy + 2, 1);
                VGAScreen.SetPixel(posx + 4, posy + 2, 1);
                VGAScreen.SetPixel(posx + 2, posy + 3, 1);
                VGAScreen.SetPixel(posx + 1, posy + 4, 1);
                VGAScreen.SetPixel(posx + 3, posy + 4, 1);


                if (Transparent == false)
                {
                    VGAScreen.SetPixel(posx, posy, 63);
                    VGAScreen.SetPixel(posx + 1, posy, 63);
                    VGAScreen.SetPixel(posx + 2, posy, 63);
                    VGAScreen.SetPixel(posx + 3, posy, 63);
                    VGAScreen.SetPixel(posx + 4, posy, 63);
                    VGAScreen.SetPixel(posx + 0, posy + 1, 63);
                    VGAScreen.SetPixel(posx + 1, posy + 1, 63);
                    VGAScreen.SetPixel(posx + 3, posy + 1, 63);
                    VGAScreen.SetPixel(posx + 4, posy + 1, 63);
                    VGAScreen.SetPixel(posx + 0, posy + 3, 63);
                    VGAScreen.SetPixel(posx + 1, posy + 3, 63);
                    VGAScreen.SetPixel(posx + 3, posy + 3, 63);
                    VGAScreen.SetPixel(posx + 4, posy + 3, 63);
                    VGAScreen.SetPixel(posx + 0, posy + 4, 63);
                    VGAScreen.SetPixel(posx + 2, posy + 4, 63);
                    VGAScreen.SetPixel(posx + 4, posy + 4, 63);
                    VGAScreen.SetPixel(posx + 0, posy + 5, 63);
                    VGAScreen.SetPixel(posx + 1, posy + 5, 63);
                    VGAScreen.SetPixel(posx + 2, posy + 5, 63);
                    VGAScreen.SetPixel(posx + 3, posy + 5, 63);
                    VGAScreen.SetPixel(posx + 4, posy + 5, 63);
                    VGAScreen.SetPixel(posx + 0, posy + 6, 63);
                    VGAScreen.SetPixel(posx + 1, posy + 6, 63);
                    VGAScreen.SetPixel(posx + 2, posy + 6, 63);
                    VGAScreen.SetPixel(posx + 3, posy + 6, 63);
                    VGAScreen.SetPixel(posx + 4, posy + 6, 63);
                }
            }
            else if (letter == "O")
            {

                VGAScreen.SetPixel(posx + 1, posy, Col);
                VGAScreen.SetPixel(posx + 2, posy, Col);
                VGAScreen.SetPixel(posx + 3, posy, Col);
                VGAScreen.SetPixel(posx + 0, posy + 1, Col);
                VGAScreen.SetPixel(posx + 4, posy + 1, Col);
                VGAScreen.SetPixel(posx + 0, posy + 2, Col);
                VGAScreen.SetPixel(posx + 4, posy + 2, Col);
                VGAScreen.SetPixel(posx + 0, posy + 3, Col);
                VGAScreen.SetPixel(posx + 4, posy + 3, Col);
                VGAScreen.SetPixel(posx + 0, posy + 4, Col);
                VGAScreen.SetPixel(posx + 4, posy + 4, Col);
                VGAScreen.SetPixel(posx + 0, posy + 5, Col);
                VGAScreen.SetPixel(posx + 4, posy + 5, Col);
                VGAScreen.SetPixel(posx + 1, posy + 6, Col);
                VGAScreen.SetPixel(posx + 2, posy + 6, Col);
                VGAScreen.SetPixel(posx + 3, posy + 6, Col);


                if (Transparent == false)
                {
                    VGAScreen.SetPixel(posx, posy, 63);
                    VGAScreen.SetPixel(posx + 4, posy, 63);
                    VGAScreen.SetPixel(posx + 1, posy + 1, 63);
                    VGAScreen.SetPixel(posx + 2, posy + 1, 63);
                    VGAScreen.SetPixel(posx + 3, posy + 1, 63);
                    VGAScreen.SetPixel(posx + 1, posy + 2, 63);
                    VGAScreen.SetPixel(posx + 2, posy + 2, 63);
                    VGAScreen.SetPixel(posx + 3, posy + 2, 63);
                    VGAScreen.SetPixel(posx + 1, posy + 3, 63);
                    VGAScreen.SetPixel(posx + 2, posy + 3, 63);
                    VGAScreen.SetPixel(posx + 3, posy + 3, 63);
                    VGAScreen.SetPixel(posx + 1, posy + 4, 63);
                    VGAScreen.SetPixel(posx + 2, posy + 4, 63);
                    VGAScreen.SetPixel(posx + 3, posy + 4, 63);
                    VGAScreen.SetPixel(posx + 1, posy + 5, 63);
                    VGAScreen.SetPixel(posx + 2, posy + 5, 63);
                    VGAScreen.SetPixel(posx + 3, posy + 5, 63);
                    VGAScreen.SetPixel(posx + 0, posy + 6, 63);
                    VGAScreen.SetPixel(posx + 4, posy + 6, 63);
                }
            }
            else if (letter == "U")
            {
                VGAScreen.SetPixel(posx, posy, Col);
                VGAScreen.SetPixel(posx + 4, posy, Col);
                VGAScreen.SetPixel(posx + 0, posy + 1, Col);
                VGAScreen.SetPixel(posx + 4, posy + 1, Col);
                VGAScreen.SetPixel(posx + 0, posy + 2, Col);
                VGAScreen.SetPixel(posx + 4, posy + 2, Col);
                VGAScreen.SetPixel(posx + 0, posy + 3, Col);
                VGAScreen.SetPixel(posx + 4, posy + 3, Col);
                VGAScreen.SetPixel(posx + 0, posy + 4, Col);
                VGAScreen.SetPixel(posx + 4, posy + 4, Col);
                VGAScreen.SetPixel(posx + 0, posy + 5, Col);
                VGAScreen.SetPixel(posx + 4, posy + 5, Col);
                VGAScreen.SetPixel(posx + 1, posy + 6, Col);
                VGAScreen.SetPixel(posx + 2, posy + 6, Col);
                VGAScreen.SetPixel(posx + 3, posy + 6, Col);


                if (Transparent == false)
                {
                    VGAScreen.SetPixel(posx + 1, posy, 63);
                    VGAScreen.SetPixel(posx + 2, posy, 63);
                    VGAScreen.SetPixel(posx + 3, posy, 63);
                    VGAScreen.SetPixel(posx + 1, posy + 1, 63);
                    VGAScreen.SetPixel(posx + 2, posy + 1, 63);
                    VGAScreen.SetPixel(posx + 3, posy + 1, 63);
                    VGAScreen.SetPixel(posx + 1, posy + 2, 63);
                    VGAScreen.SetPixel(posx + 2, posy + 2, 63);
                    VGAScreen.SetPixel(posx + 3, posy + 2, 63);
                    VGAScreen.SetPixel(posx + 1, posy + 3, 63);
                    VGAScreen.SetPixel(posx + 2, posy + 3, 63);
                    VGAScreen.SetPixel(posx + 3, posy + 3, 63);
                    VGAScreen.SetPixel(posx + 1, posy + 4, 63);
                    VGAScreen.SetPixel(posx + 2, posy + 4, 63);
                    VGAScreen.SetPixel(posx + 3, posy + 4, 63);
                    VGAScreen.SetPixel(posx + 1, posy + 5, 63);
                    VGAScreen.SetPixel(posx + 2, posy + 5, 63);
                    VGAScreen.SetPixel(posx + 3, posy + 5, 63);
                    VGAScreen.SetPixel(posx + 0, posy + 6, 63);
                    VGAScreen.SetPixel(posx + 4, posy + 6, 63);
                }
            }
            else if (letter == "w")
            {
                VGAScreen.SetPixel(posx + 0, posy + 2, Col);
                VGAScreen.SetPixel(posx + 2, posy + 2, Col);
                VGAScreen.SetPixel(posx + 4, posy + 2, Col);
                VGAScreen.SetPixel(posx + 0, posy + 3, Col);
                VGAScreen.SetPixel(posx + 2, posy + 3, Col);
                VGAScreen.SetPixel(posx + 4, posy + 3, Col);
                VGAScreen.SetPixel(posx + 0, posy + 4, Col);
                VGAScreen.SetPixel(posx + 2, posy + 4, Col);
                VGAScreen.SetPixel(posx + 4, posy + 4, Col);
                VGAScreen.SetPixel(posx + 0, posy + 5, Col);
                VGAScreen.SetPixel(posx + 2, posy + 5, Col);
                VGAScreen.SetPixel(posx + 4, posy + 5, Col);
                VGAScreen.SetPixel(posx + 0, posy + 6, Col);
                VGAScreen.SetPixel(posx + 1, posy + 6, Col);
                VGAScreen.SetPixel(posx + 2, posy + 6, Col);
                VGAScreen.SetPixel(posx + 3, posy + 6, Col);
                VGAScreen.SetPixel(posx + 4, posy + 6, Col);

                if (Transparent == false)
                {
                    VGAScreen.SetPixel(posx, posy, BgCol);
                    VGAScreen.SetPixel(posx + 1, posy, BgCol);
                    VGAScreen.SetPixel(posx + 2, posy, BgCol);
                    VGAScreen.SetPixel(posx + 3, posy, BgCol);
                    VGAScreen.SetPixel(posx + 4, posy, BgCol);
                    VGAScreen.SetPixel(posx + 0, posy + 1, BgCol);
                    VGAScreen.SetPixel(posx + 1, posy + 1, BgCol);
                    VGAScreen.SetPixel(posx + 2, posy + 1, BgCol);
                    VGAScreen.SetPixel(posx + 3, posy + 1, BgCol);
                    VGAScreen.SetPixel(posx + 4, posy + 1, BgCol);
                    VGAScreen.SetPixel(posx + 1, posy + 2, BgCol);
                    VGAScreen.SetPixel(posx + 3, posy + 2, BgCol);
                    VGAScreen.SetPixel(posx + 1, posy + 3, BgCol);
                    VGAScreen.SetPixel(posx + 3, posy + 3, BgCol);
                    VGAScreen.SetPixel(posx + 1, posy + 4, BgCol);
                    VGAScreen.SetPixel(posx + 3, posy + 4, BgCol);
                    VGAScreen.SetPixel(posx + 1, posy + 5, BgCol);
                    VGAScreen.SetPixel(posx + 3, posy + 5, BgCol);
                }

            }
            else if (letter == "p")
            {
                if (disableLower == false)
                {
                    posy = posy + 2;
                }

                VGAScreen.SetPixel(posx, posy, Col);
                VGAScreen.SetPixel(posx + 1, posy, Col);
                VGAScreen.SetPixel(posx + 2, posy, Col);
                VGAScreen.SetPixel(posx + 3, posy, Col);
                VGAScreen.SetPixel(posx + 0, posy + 1, Col);
                VGAScreen.SetPixel(posx + 4, posy + 1, Col);
                VGAScreen.SetPixel(posx + 0, posy + 2, Col);
                VGAScreen.SetPixel(posx + 4, posy + 2, Col);
                VGAScreen.SetPixel(posx + 0, posy + 3, Col);
                VGAScreen.SetPixel(posx + 4, posy + 3, Col);
                VGAScreen.SetPixel(posx + 0, posy + 4, Col);
                VGAScreen.SetPixel(posx + 1, posy + 4, Col);
                VGAScreen.SetPixel(posx + 2, posy + 4, Col);
                VGAScreen.SetPixel(posx + 3, posy + 4, Col);
                VGAScreen.SetPixel(posx + 0, posy + 5, Col);
                VGAScreen.SetPixel(posx + 0, posy + 6, Col);

                if (Transparent == false)
                {
                    if (Transparent == false)
                    {
                        VGAScreen.SetPixel(posx + 4, posy, BgCol);
                        VGAScreen.SetPixel(posx + 1, posy + 1, BgCol);
                        VGAScreen.SetPixel(posx + 2, posy + 1, BgCol);
                        VGAScreen.SetPixel(posx + 3, posy + 1, BgCol);
                        VGAScreen.SetPixel(posx + 1, posy + 2, BgCol);
                        VGAScreen.SetPixel(posx + 2, posy + 2, BgCol);
                        VGAScreen.SetPixel(posx + 3, posy + 2, BgCol);
                        VGAScreen.SetPixel(posx + 1, posy + 3, BgCol);
                        VGAScreen.SetPixel(posx + 2, posy + 3, BgCol);
                        VGAScreen.SetPixel(posx + 3, posy + 3, BgCol);
                        VGAScreen.SetPixel(posx + 4, posy + 4, BgCol);
                        VGAScreen.SetPixel(posx + 1, posy + 5, BgCol);
                        VGAScreen.SetPixel(posx + 2, posy + 5, BgCol);
                        VGAScreen.SetPixel(posx + 3, posy + 5, BgCol);
                        VGAScreen.SetPixel(posx + 4, posy + 5, BgCol);
                        VGAScreen.SetPixel(posx + 1, posy + 6, BgCol);
                        VGAScreen.SetPixel(posx + 2, posy + 6, BgCol);
                        VGAScreen.SetPixel(posx + 3, posy + 6, BgCol);
                        VGAScreen.SetPixel(posx + 4, posy + 6, BgCol);
                    }

                }

            }
            else if (letter == "P")
            {

                VGAScreen.SetPixel(posx, posy, Col);
                VGAScreen.SetPixel(posx + 1, posy, Col);
                VGAScreen.SetPixel(posx + 2, posy, Col);
                VGAScreen.SetPixel(posx + 3, posy, Col);
                VGAScreen.SetPixel(posx + 0, posy + 1, Col);
                VGAScreen.SetPixel(posx + 4, posy + 1, Col);
                VGAScreen.SetPixel(posx + 0, posy + 2, Col);
                VGAScreen.SetPixel(posx + 4, posy + 2, Col);
                VGAScreen.SetPixel(posx + 0, posy + 3, Col);
                VGAScreen.SetPixel(posx + 1, posy + 3, Col);
                VGAScreen.SetPixel(posx + 2, posy + 3, Col);
                VGAScreen.SetPixel(posx + 3, posy + 3, Col);
                VGAScreen.SetPixel(posx + 0, posy + 4, Col);
                VGAScreen.SetPixel(posx + 0, posy + 5, Col);
                VGAScreen.SetPixel(posx + 0, posy + 6, Col);

                if (Transparent == false)
                {
                    VGAScreen.SetPixel(posx + 4, posy, 63);
                    VGAScreen.SetPixel(posx + 1, posy + 1, 63);
                    VGAScreen.SetPixel(posx + 2, posy + 1, 63);
                    VGAScreen.SetPixel(posx + 3, posy + 1, 63);
                    VGAScreen.SetPixel(posx + 1, posy + 2, 63);
                    VGAScreen.SetPixel(posx + 2, posy + 2, 63);
                    VGAScreen.SetPixel(posx + 3, posy + 2, 63);
                    VGAScreen.SetPixel(posx + 4, posy + 3, 63);
                    VGAScreen.SetPixel(posx + 1, posy + 4, 63);
                    VGAScreen.SetPixel(posx + 2, posy + 4, 63);
                    VGAScreen.SetPixel(posx + 3, posy + 4, 63);
                    VGAScreen.SetPixel(posx + 4, posy + 4, 63);
                    VGAScreen.SetPixel(posx + 1, posy + 5, 63);
                    VGAScreen.SetPixel(posx + 2, posy + 5, 63);
                    VGAScreen.SetPixel(posx + 3, posy + 5, 63);
                    VGAScreen.SetPixel(posx + 4, posy + 5, 63);
                    VGAScreen.SetPixel(posx + 1, posy + 6, 63);
                    VGAScreen.SetPixel(posx + 2, posy + 6, 63);
                    VGAScreen.SetPixel(posx + 3, posy + 6, 63);
                    VGAScreen.SetPixel(posx + 4, posy + 6, 63);
                }


            }
            else if (letter == "d")
            {
                VGAScreen.SetPixel(posx + 4, posy, Col);
                VGAScreen.SetPixel(posx + 4, posy + 1, Col);
                VGAScreen.SetPixel(posx + 1, posy + 2, Col);
                VGAScreen.SetPixel(posx + 2, posy + 2, Col);
                VGAScreen.SetPixel(posx + 3, posy + 2, Col);
                VGAScreen.SetPixel(posx + 4, posy + 2, Col);
                VGAScreen.SetPixel(posx + 0, posy + 3, Col);
                VGAScreen.SetPixel(posx + 4, posy + 3, Col);
                VGAScreen.SetPixel(posx + 0, posy + 4, Col);
                VGAScreen.SetPixel(posx + 4, posy + 4, Col);
                VGAScreen.SetPixel(posx + 0, posy + 5, Col);
                VGAScreen.SetPixel(posx + 4, posy + 5, Col);
                VGAScreen.SetPixel(posx + 1, posy + 6, Col);
                VGAScreen.SetPixel(posx + 2, posy + 6, Col);
                VGAScreen.SetPixel(posx + 3, posy + 6, Col);
                VGAScreen.SetPixel(posx + 4, posy + 6, Col);



                if (Transparent == false)
                {
                    if (Transparent == false)
                    {
                        VGAScreen.SetPixel(posx, posy, BgCol);
                        VGAScreen.SetPixel(posx + 1, posy, BgCol);
                        VGAScreen.SetPixel(posx + 2, posy, BgCol);
                        VGAScreen.SetPixel(posx + 3, posy, BgCol);
                        VGAScreen.SetPixel(posx + 0, posy + 1, BgCol);
                        VGAScreen.SetPixel(posx + 1, posy + 1, BgCol);
                        VGAScreen.SetPixel(posx + 2, posy + 1, BgCol);
                        VGAScreen.SetPixel(posx + 3, posy + 1, BgCol);
                        VGAScreen.SetPixel(posx + 0, posy + 2, BgCol);
                        VGAScreen.SetPixel(posx + 1, posy + 3, BgCol);
                        VGAScreen.SetPixel(posx + 2, posy + 3, BgCol);
                        VGAScreen.SetPixel(posx + 3, posy + 3, BgCol);
                        VGAScreen.SetPixel(posx + 1, posy + 4, BgCol);
                        VGAScreen.SetPixel(posx + 2, posy + 4, BgCol);
                        VGAScreen.SetPixel(posx + 3, posy + 4, BgCol);
                        VGAScreen.SetPixel(posx + 1, posy + 5, BgCol);
                        VGAScreen.SetPixel(posx + 2, posy + 5, BgCol);
                        VGAScreen.SetPixel(posx + 3, posy + 5, BgCol);
                        VGAScreen.SetPixel(posx + 0, posy + 6, BgCol);
                    }

                }
            }
            else if (letter == "t")
            {

                VGAScreen.SetPixel(posx + 2, posy, Col);
                VGAScreen.SetPixel(posx + 2, posy + 1, Col);
                VGAScreen.SetPixel(posx + 1, posy + 2, Col);
                VGAScreen.SetPixel(posx + 2, posy + 2, Col);
                VGAScreen.SetPixel(posx + 3, posy + 2, Col);
                VGAScreen.SetPixel(posx + 2, posy + 3, Col);
                VGAScreen.SetPixel(posx + 2, posy + 4, Col);
                VGAScreen.SetPixel(posx + 2, posy + 5, Col);
                VGAScreen.SetPixel(posx + 2, posy + 6, Col);
                VGAScreen.SetPixel(posx + 3, posy + 6, Col);


                if (Transparent == false)
                {
                    VGAScreen.SetPixel(posx, posy, 63);
                    VGAScreen.SetPixel(posx + 1, posy, 63);
                    VGAScreen.SetPixel(posx + 3, posy, 63);
                    VGAScreen.SetPixel(posx + 4, posy, 63);
                    VGAScreen.SetPixel(posx + 0, posy + 1, 63);
                    VGAScreen.SetPixel(posx + 1, posy + 1, 63);
                    VGAScreen.SetPixel(posx + 3, posy + 1, 63);
                    VGAScreen.SetPixel(posx + 4, posy + 1, 63);
                    VGAScreen.SetPixel(posx + 0, posy + 2, 63);
                    VGAScreen.SetPixel(posx + 4, posy + 2, 63);
                    VGAScreen.SetPixel(posx + 0, posy + 3, 63);
                    VGAScreen.SetPixel(posx + 1, posy + 3, 63);
                    VGAScreen.SetPixel(posx + 3, posy + 3, 63);
                    VGAScreen.SetPixel(posx + 4, posy + 3, 63);
                    VGAScreen.SetPixel(posx + 0, posy + 4, 63);
                    VGAScreen.SetPixel(posx + 1, posy + 4, 63);
                    VGAScreen.SetPixel(posx + 3, posy + 4, 63);
                    VGAScreen.SetPixel(posx + 4, posy + 4, 63);
                    VGAScreen.SetPixel(posx + 0, posy + 5, 63);
                    VGAScreen.SetPixel(posx + 1, posy + 5, 63);
                    VGAScreen.SetPixel(posx + 3, posy + 5, 63);
                    VGAScreen.SetPixel(posx + 4, posy + 5, 63);
                    VGAScreen.SetPixel(posx + 0, posy + 6, 63);
                    VGAScreen.SetPixel(posx + 1, posy + 6, 63);
                    VGAScreen.SetPixel(posx + 4, posy + 6, 63);
                }
            }

            else if (letter == "a")
            {

                VGAScreen.SetPixel(posx + 1, posy + 2, Col);
                VGAScreen.SetPixel(posx + 2, posy + 2, Col);
                VGAScreen.SetPixel(posx + 3, posy + 2, Col);
                VGAScreen.SetPixel(posx + 4, posy + 3, Col);
                VGAScreen.SetPixel(posx + 1, posy + 4, Col);
                VGAScreen.SetPixel(posx + 2, posy + 4, Col);
                VGAScreen.SetPixel(posx + 3, posy + 4, Col);
                VGAScreen.SetPixel(posx + 4, posy + 4, Col);
                VGAScreen.SetPixel(posx + 0, posy + 5, Col);
                VGAScreen.SetPixel(posx + 4, posy + 5, Col);
                VGAScreen.SetPixel(posx + 1, posy + 6, Col);
                VGAScreen.SetPixel(posx + 2, posy + 6, Col);
                VGAScreen.SetPixel(posx + 3, posy + 6, Col);
                VGAScreen.SetPixel(posx + 4, posy + 6, Col);


                if (Transparent == false)
                {
                    VGAScreen.SetPixel(posx, posy, BgCol);
                    VGAScreen.SetPixel(posx + 1, posy, BgCol);
                    VGAScreen.SetPixel(posx + 2, posy, BgCol);
                    VGAScreen.SetPixel(posx + 3, posy, BgCol);
                    VGAScreen.SetPixel(posx + 4, posy, BgCol);
                    VGAScreen.SetPixel(posx + 0, posy + 1, BgCol);
                    VGAScreen.SetPixel(posx + 1, posy + 1, BgCol);
                    VGAScreen.SetPixel(posx + 2, posy + 1, BgCol);
                    VGAScreen.SetPixel(posx + 3, posy + 1, BgCol);
                    VGAScreen.SetPixel(posx + 4, posy + 1, BgCol);
                    VGAScreen.SetPixel(posx + 0, posy + 2, BgCol);
                    VGAScreen.SetPixel(posx + 4, posy + 2, BgCol);
                    VGAScreen.SetPixel(posx + 0, posy + 3, BgCol);
                    VGAScreen.SetPixel(posx + 1, posy + 3, BgCol);
                    VGAScreen.SetPixel(posx + 2, posy + 3, BgCol);
                    VGAScreen.SetPixel(posx + 3, posy + 3, BgCol);
                    VGAScreen.SetPixel(posx + 0, posy + 4, BgCol);
                    VGAScreen.SetPixel(posx + 1, posy + 5, BgCol);
                    VGAScreen.SetPixel(posx + 2, posy + 5, BgCol);
                    VGAScreen.SetPixel(posx + 3, posy + 5, BgCol);
                    VGAScreen.SetPixel(posx + 0, posy + 6, BgCol);
                }
            }
            else if (letter == ".")
            {
                VGAScreen.SetPixel(posx + 2, posy + 6, Col);

                if (Transparent == false)
                {
                    VGAScreen.SetPixel(posx, posy, BgCol);
                    VGAScreen.SetPixel(posx + 1, posy, BgCol);
                    VGAScreen.SetPixel(posx + 2, posy, BgCol);
                    VGAScreen.SetPixel(posx + 3, posy, BgCol);
                    VGAScreen.SetPixel(posx + 4, posy, BgCol);
                    VGAScreen.SetPixel(posx + 0, posy + 1, BgCol);
                    VGAScreen.SetPixel(posx + 1, posy + 1, BgCol);
                    VGAScreen.SetPixel(posx + 2, posy + 1, BgCol);
                    VGAScreen.SetPixel(posx + 3, posy + 1, BgCol);
                    VGAScreen.SetPixel(posx + 4, posy + 1, BgCol);
                    VGAScreen.SetPixel(posx + 0, posy + 2, BgCol);
                    VGAScreen.SetPixel(posx + 1, posy + 2, BgCol);
                    VGAScreen.SetPixel(posx + 2, posy + 2, BgCol);
                    VGAScreen.SetPixel(posx + 3, posy + 2, BgCol);
                    VGAScreen.SetPixel(posx + 4, posy + 2, BgCol);
                    VGAScreen.SetPixel(posx + 0, posy + 3, BgCol);
                    VGAScreen.SetPixel(posx + 1, posy + 3, BgCol);
                    VGAScreen.SetPixel(posx + 2, posy + 3, BgCol);
                    VGAScreen.SetPixel(posx + 3, posy + 3, BgCol);
                    VGAScreen.SetPixel(posx + 4, posy + 3, BgCol);
                    VGAScreen.SetPixel(posx + 0, posy + 4, BgCol);
                    VGAScreen.SetPixel(posx + 1, posy + 4, BgCol);
                    VGAScreen.SetPixel(posx + 2, posy + 4, BgCol);
                    VGAScreen.SetPixel(posx + 3, posy + 4, BgCol);
                    VGAScreen.SetPixel(posx + 4, posy + 4, BgCol);
                    VGAScreen.SetPixel(posx + 0, posy + 5, BgCol);
                    VGAScreen.SetPixel(posx + 1, posy + 5, BgCol);
                    VGAScreen.SetPixel(posx + 2, posy + 5, BgCol);
                    VGAScreen.SetPixel(posx + 3, posy + 5, BgCol);
                    VGAScreen.SetPixel(posx + 4, posy + 5, BgCol);
                    VGAScreen.SetPixel(posx + 0, posy + 6, BgCol);
                    VGAScreen.SetPixel(posx + 1, posy + 6, BgCol);
                    VGAScreen.SetPixel(posx + 3, posy + 6, BgCol);
                    VGAScreen.SetPixel(posx + 4, posy + 6, BgCol);
                }

            }
            else if (letter == "n")
            {

                VGAScreen.SetPixel(posx + 0, posy + 2, Col);
                VGAScreen.SetPixel(posx + 2, posy + 2, Col);
                VGAScreen.SetPixel(posx + 3, posy + 2, Col);
                VGAScreen.SetPixel(posx + 0, posy + 3, Col);
                VGAScreen.SetPixel(posx + 1, posy + 3, Col);
                VGAScreen.SetPixel(posx + 4, posy + 3, Col);
                VGAScreen.SetPixel(posx + 0, posy + 4, Col);
                VGAScreen.SetPixel(posx + 4, posy + 4, Col);
                VGAScreen.SetPixel(posx + 0, posy + 5, Col);
                VGAScreen.SetPixel(posx + 4, posy + 5, Col);
                VGAScreen.SetPixel(posx + 0, posy + 6, Col);
                VGAScreen.SetPixel(posx + 4, posy + 6, Col);

                if (Transparent == false)
                {
                    VGAScreen.SetPixel(posx, posy, 63);
                    VGAScreen.SetPixel(posx + 1, posy, 63);
                    VGAScreen.SetPixel(posx + 2, posy, 63);
                    VGAScreen.SetPixel(posx + 3, posy, 63);
                    VGAScreen.SetPixel(posx + 4, posy, 63);
                    VGAScreen.SetPixel(posx + 0, posy + 1, 63);
                    VGAScreen.SetPixel(posx + 1, posy + 1, 63);
                    VGAScreen.SetPixel(posx + 2, posy + 1, 63);
                    VGAScreen.SetPixel(posx + 3, posy + 1, 63);
                    VGAScreen.SetPixel(posx + 4, posy + 1, 63);
                    VGAScreen.SetPixel(posx + 1, posy + 2, 63);
                    VGAScreen.SetPixel(posx + 4, posy + 2, 63);
                    VGAScreen.SetPixel(posx + 2, posy + 3, 63);
                    VGAScreen.SetPixel(posx + 3, posy + 3, 63);
                    VGAScreen.SetPixel(posx + 1, posy + 4, 63);
                    VGAScreen.SetPixel(posx + 2, posy + 4, 63);
                    VGAScreen.SetPixel(posx + 3, posy + 4, 63);
                    VGAScreen.SetPixel(posx + 1, posy + 5, 63);
                    VGAScreen.SetPixel(posx + 2, posy + 5, 63);
                    VGAScreen.SetPixel(posx + 3, posy + 5, 63);
                    VGAScreen.SetPixel(posx + 1, posy + 6, 63);
                    VGAScreen.SetPixel(posx + 2, posy + 6, 63);
                    VGAScreen.SetPixel(posx + 3, posy + 6, 63);
                }

            }
            else if (letter == "g")
            {

                if (disableLower == false)
                {
                    posy = posy + 2;
                }

                VGAScreen.SetPixel(posx + 1, posy, Col);
                VGAScreen.SetPixel(posx + 2, posy, Col);
                VGAScreen.SetPixel(posx + 3, posy, Col);
                VGAScreen.SetPixel(posx + 4, posy, Col);
                VGAScreen.SetPixel(posx + 0, posy + 1, Col);
                VGAScreen.SetPixel(posx + 4, posy + 1, Col);
                VGAScreen.SetPixel(posx + 0, posy + 2, Col);
                VGAScreen.SetPixel(posx + 4, posy + 2, Col);
                VGAScreen.SetPixel(posx + 1, posy + 3, Col);
                VGAScreen.SetPixel(posx + 2, posy + 3, Col);
                VGAScreen.SetPixel(posx + 3, posy + 3, Col);
                VGAScreen.SetPixel(posx + 4, posy + 3, Col);
                VGAScreen.SetPixel(posx + 4, posy + 4, Col);
                VGAScreen.SetPixel(posx + 0, posy + 5, Col);
                VGAScreen.SetPixel(posx + 4, posy + 5, Col);
                VGAScreen.SetPixel(posx + 1, posy + 6, Col);
                VGAScreen.SetPixel(posx + 2, posy + 6, Col);
                VGAScreen.SetPixel(posx + 3, posy + 6, Col);


                if (Transparent == false)
                {
                    VGAScreen.SetPixel(posx, posy, 63);
                    VGAScreen.SetPixel(posx + 1, posy + 1, 63);
                    VGAScreen.SetPixel(posx + 2, posy + 1, 63);
                    VGAScreen.SetPixel(posx + 3, posy + 1, 63);
                    VGAScreen.SetPixel(posx + 1, posy + 2, 63);
                    VGAScreen.SetPixel(posx + 2, posy + 2, 63);
                    VGAScreen.SetPixel(posx + 3, posy + 2, 63);
                    VGAScreen.SetPixel(posx + 0, posy + 3, 63);
                    VGAScreen.SetPixel(posx + 0, posy + 4, 63);
                    VGAScreen.SetPixel(posx + 1, posy + 4, 63);
                    VGAScreen.SetPixel(posx + 2, posy + 4, 63);
                    VGAScreen.SetPixel(posx + 3, posy + 4, 63);
                    VGAScreen.SetPixel(posx + 1, posy + 5, 63);
                    VGAScreen.SetPixel(posx + 2, posy + 5, 63);
                    VGAScreen.SetPixel(posx + 3, posy + 5, 63);
                    VGAScreen.SetPixel(posx + 0, posy + 6, 63);
                    VGAScreen.SetPixel(posx + 4, posy + 6, 63);
                }

            }

            else if (letter == "r")
            {

                VGAScreen.SetPixel(posx + 0, posy + 2, Col);
                VGAScreen.SetPixel(posx + 2, posy + 2, Col);
                VGAScreen.SetPixel(posx + 3, posy + 2, Col);
                VGAScreen.SetPixel(posx + 0, posy + 3, Col);
                VGAScreen.SetPixel(posx + 1, posy + 3, Col);
                VGAScreen.SetPixel(posx + 4, posy + 3, Col);
                VGAScreen.SetPixel(posx + 0, posy + 4, Col);
                VGAScreen.SetPixel(posx + 0, posy + 5, Col);
                VGAScreen.SetPixel(posx + 0, posy + 6, Col);


                if (Transparent == false)
                {
                    VGAScreen.SetPixel(posx, posy, 63);
                    VGAScreen.SetPixel(posx + 1, posy, 63);
                    VGAScreen.SetPixel(posx + 2, posy, 63);
                    VGAScreen.SetPixel(posx + 3, posy, 63);
                    VGAScreen.SetPixel(posx + 4, posy, 63);
                    VGAScreen.SetPixel(posx + 0, posy + 1, 63);
                    VGAScreen.SetPixel(posx + 1, posy + 1, 63);
                    VGAScreen.SetPixel(posx + 2, posy + 1, 63);
                    VGAScreen.SetPixel(posx + 3, posy + 1, 63);
                    VGAScreen.SetPixel(posx + 4, posy + 1, 63);
                    VGAScreen.SetPixel(posx + 1, posy + 2, 63);
                    VGAScreen.SetPixel(posx + 4, posy + 2, 63);
                    VGAScreen.SetPixel(posx + 2, posy + 3, 63);
                    VGAScreen.SetPixel(posx + 3, posy + 3, 63);
                    VGAScreen.SetPixel(posx + 1, posy + 4, 63);
                    VGAScreen.SetPixel(posx + 2, posy + 4, 63);
                    VGAScreen.SetPixel(posx + 3, posy + 4, 63);
                    VGAScreen.SetPixel(posx + 4, posy + 4, 63);
                    VGAScreen.SetPixel(posx + 1, posy + 5, 63);
                    VGAScreen.SetPixel(posx + 2, posy + 5, 63);
                    VGAScreen.SetPixel(posx + 3, posy + 5, 63);
                    VGAScreen.SetPixel(posx + 4, posy + 5, 63);
                    VGAScreen.SetPixel(posx + 1, posy + 6, 63);
                    VGAScreen.SetPixel(posx + 2, posy + 6, 63);
                    VGAScreen.SetPixel(posx + 3, posy + 6, 63);
                    VGAScreen.SetPixel(posx + 4, posy + 6, 63);
                }

            }
            else if (letter == "S")
            {

                VGAScreen.SetPixel(posx + 1, posy, Col);
                VGAScreen.SetPixel(posx + 2, posy, Col);
                VGAScreen.SetPixel(posx + 3, posy, Col);
                VGAScreen.SetPixel(posx + 4, posy, Col);
                VGAScreen.SetPixel(posx + 0, posy + 1, Col);
                VGAScreen.SetPixel(posx + 0, posy + 2, Col);
                VGAScreen.SetPixel(posx + 1, posy + 3, Col);
                VGAScreen.SetPixel(posx + 2, posy + 3, Col);
                VGAScreen.SetPixel(posx + 3, posy + 3, Col);
                VGAScreen.SetPixel(posx + 4, posy + 4, Col);
                VGAScreen.SetPixel(posx + 4, posy + 5, Col);
                VGAScreen.SetPixel(posx + 0, posy + 6, Col);
                VGAScreen.SetPixel(posx + 1, posy + 6, Col);
                VGAScreen.SetPixel(posx + 2, posy + 6, Col);
                VGAScreen.SetPixel(posx + 3, posy + 6, Col);


                if (Transparent == false)
                {
                    VGAScreen.SetPixel(posx, posy, 63);
                    VGAScreen.SetPixel(posx + 1, posy + 1, 63);
                    VGAScreen.SetPixel(posx + 2, posy + 1, 63);
                    VGAScreen.SetPixel(posx + 3, posy + 1, 63);
                    VGAScreen.SetPixel(posx + 4, posy + 1, 63);
                    VGAScreen.SetPixel(posx + 1, posy + 2, 63);
                    VGAScreen.SetPixel(posx + 2, posy + 2, 63);
                    VGAScreen.SetPixel(posx + 3, posy + 2, 63);
                    VGAScreen.SetPixel(posx + 4, posy + 2, 63);
                    VGAScreen.SetPixel(posx + 0, posy + 3, 63);
                    VGAScreen.SetPixel(posx + 4, posy + 3, 63);
                    VGAScreen.SetPixel(posx + 0, posy + 4, 63);
                    VGAScreen.SetPixel(posx + 1, posy + 4, 63);
                    VGAScreen.SetPixel(posx + 2, posy + 4, 63);
                    VGAScreen.SetPixel(posx + 3, posy + 4, 63);
                    VGAScreen.SetPixel(posx + 0, posy + 5, 63);
                    VGAScreen.SetPixel(posx + 1, posy + 5, 63);
                    VGAScreen.SetPixel(posx + 2, posy + 5, 63);
                    VGAScreen.SetPixel(posx + 3, posy + 5, 63);
                    VGAScreen.SetPixel(posx + 4, posy + 6, 63);
                }
            }

            else if (letter == " ")
            {
                if (Transparent == false)
                {
                    VGAScreen.SetPixel(posx, posy, 63);
                    VGAScreen.SetPixel(posx + 1, posy, 63);
                    VGAScreen.SetPixel(posx + 2, posy, 63);
                    VGAScreen.SetPixel(posx + 3, posy, 63);
                    VGAScreen.SetPixel(posx + 4, posy, 63);
                    VGAScreen.SetPixel(posx + 0, posy + 1, 63);
                    VGAScreen.SetPixel(posx + 1, posy + 1, 63);
                    VGAScreen.SetPixel(posx + 2, posy + 1, 63);
                    VGAScreen.SetPixel(posx + 3, posy + 1, 63);
                    VGAScreen.SetPixel(posx + 4, posy + 1, 63);
                    VGAScreen.SetPixel(posx + 0, posy + 2, 63);
                    VGAScreen.SetPixel(posx + 1, posy + 2, 63);
                    VGAScreen.SetPixel(posx + 2, posy + 2, 63);
                    VGAScreen.SetPixel(posx + 3, posy + 2, 63);
                    VGAScreen.SetPixel(posx + 4, posy + 2, 63);
                    VGAScreen.SetPixel(posx + 0, posy + 3, 63);
                    VGAScreen.SetPixel(posx + 1, posy + 3, 63);
                    VGAScreen.SetPixel(posx + 2, posy + 3, 63);
                    VGAScreen.SetPixel(posx + 3, posy + 3, 63);
                    VGAScreen.SetPixel(posx + 4, posy + 3, 63);
                    VGAScreen.SetPixel(posx + 0, posy + 4, 63);
                    VGAScreen.SetPixel(posx + 1, posy + 4, 63);
                    VGAScreen.SetPixel(posx + 2, posy + 4, 63);
                    VGAScreen.SetPixel(posx + 3, posy + 4, 63);
                    VGAScreen.SetPixel(posx + 4, posy + 4, 63);
                    VGAScreen.SetPixel(posx + 0, posy + 5, 63);
                    VGAScreen.SetPixel(posx + 1, posy + 5, 63);
                    VGAScreen.SetPixel(posx + 2, posy + 5, 63);
                    VGAScreen.SetPixel(posx + 3, posy + 5, 63);
                    VGAScreen.SetPixel(posx + 4, posy + 5, 63);
                    VGAScreen.SetPixel(posx + 0, posy + 6, 63);
                    VGAScreen.SetPixel(posx + 1, posy + 6, 63);
                    VGAScreen.SetPixel(posx + 2, posy + 6, 63);
                    VGAScreen.SetPixel(posx + 3, posy + 6, 63);
                    VGAScreen.SetPixel(posx + 4, posy + 6, 63);

                }
            }
            else if (letter == "i")
            {

                VGAScreen.SetPixel(posx + 2, posy + 1, Col);
                VGAScreen.SetPixel(posx + 2, posy + 3, Col);
                VGAScreen.SetPixel(posx + 2, posy + 4, Col);
                VGAScreen.SetPixel(posx + 2, posy + 5, Col);
                VGAScreen.SetPixel(posx + 2, posy + 6, Col);


                if (Transparent == false)
                {
                    VGAScreen.SetPixel(posx, posy, 63);
                    VGAScreen.SetPixel(posx + 1, posy, 63);
                    VGAScreen.SetPixel(posx + 2, posy, 63);
                    VGAScreen.SetPixel(posx + 3, posy, 63);
                    VGAScreen.SetPixel(posx + 4, posy, 63);
                    VGAScreen.SetPixel(posx + 0, posy + 1, 63);
                    VGAScreen.SetPixel(posx + 1, posy + 1, 63);
                    VGAScreen.SetPixel(posx + 3, posy + 1, 63);
                    VGAScreen.SetPixel(posx + 4, posy + 1, 63);
                    VGAScreen.SetPixel(posx + 0, posy + 2, 63);
                    VGAScreen.SetPixel(posx + 1, posy + 2, 63);
                    VGAScreen.SetPixel(posx + 2, posy + 2, 63);
                    VGAScreen.SetPixel(posx + 3, posy + 2, 63);
                    VGAScreen.SetPixel(posx + 4, posy + 2, 63);
                    VGAScreen.SetPixel(posx + 0, posy + 3, 63);
                    VGAScreen.SetPixel(posx + 1, posy + 3, 63);
                    VGAScreen.SetPixel(posx + 3, posy + 3, 63);
                    VGAScreen.SetPixel(posx + 4, posy + 3, 63);
                    VGAScreen.SetPixel(posx + 0, posy + 4, 63);
                    VGAScreen.SetPixel(posx + 1, posy + 4, 63);
                    VGAScreen.SetPixel(posx + 3, posy + 4, 63);
                    VGAScreen.SetPixel(posx + 4, posy + 4, 63);
                    VGAScreen.SetPixel(posx + 0, posy + 5, 63);
                    VGAScreen.SetPixel(posx + 1, posy + 5, 63);
                    VGAScreen.SetPixel(posx + 3, posy + 5, 63);
                    VGAScreen.SetPixel(posx + 4, posy + 5, 63);
                    VGAScreen.SetPixel(posx + 0, posy + 6, 63);
                    VGAScreen.SetPixel(posx + 1, posy + 6, 63);
                    VGAScreen.SetPixel(posx + 3, posy + 6, 63);
                    VGAScreen.SetPixel(posx + 4, posy + 6, 63);
                }

            }
            else if (letter == "s")
            {

                VGAScreen.SetPixel(posx + 1, posy + 2, Col);
                VGAScreen.SetPixel(posx + 2, posy + 2, Col);
                VGAScreen.SetPixel(posx + 3, posy + 2, Col);
                VGAScreen.SetPixel(posx + 4, posy + 2, Col);
                VGAScreen.SetPixel(posx + 0, posy + 3, Col);
                VGAScreen.SetPixel(posx + 1, posy + 4, Col);
                VGAScreen.SetPixel(posx + 2, posy + 4, Col);
                VGAScreen.SetPixel(posx + 3, posy + 4, Col);
                VGAScreen.SetPixel(posx + 4, posy + 5, Col);
                VGAScreen.SetPixel(posx + 0, posy + 6, Col);
                VGAScreen.SetPixel(posx + 1, posy + 6, Col);
                VGAScreen.SetPixel(posx + 2, posy + 6, Col);
                VGAScreen.SetPixel(posx + 3, posy + 6, Col);


                if (Transparent == false)
                {
                    VGAScreen.SetPixel(posx, posy, 63);
                    VGAScreen.SetPixel(posx + 1, posy, 63);
                    VGAScreen.SetPixel(posx + 2, posy, 63);
                    VGAScreen.SetPixel(posx + 3, posy, 63);
                    VGAScreen.SetPixel(posx + 4, posy, 63);
                    VGAScreen.SetPixel(posx + 0, posy + 1, 63);
                    VGAScreen.SetPixel(posx + 1, posy + 1, 63);
                    VGAScreen.SetPixel(posx + 2, posy + 1, 63);
                    VGAScreen.SetPixel(posx + 3, posy + 1, 63);
                    VGAScreen.SetPixel(posx + 4, posy + 1, 63);
                    VGAScreen.SetPixel(posx + 0, posy + 2, 63);
                    VGAScreen.SetPixel(posx + 1, posy + 3, 63);
                    VGAScreen.SetPixel(posx + 2, posy + 3, 63);
                    VGAScreen.SetPixel(posx + 3, posy + 3, 63);
                    VGAScreen.SetPixel(posx + 4, posy + 3, 63);
                    VGAScreen.SetPixel(posx + 0, posy + 4, 63);
                    VGAScreen.SetPixel(posx + 4, posy + 4, 63);
                    VGAScreen.SetPixel(posx + 0, posy + 5, 63);
                    VGAScreen.SetPixel(posx + 1, posy + 5, 63);
                    VGAScreen.SetPixel(posx + 2, posy + 5, 63);
                    VGAScreen.SetPixel(posx + 3, posy + 5, 63);
                    VGAScreen.SetPixel(posx + 4, posy + 6, 63);
                }

            }
            else if (letter == "L")
            {
                VGAScreen.SetPixel(posx, posy, Col);
                VGAScreen.SetPixel(posx + 0, posy + 1, Col);
                VGAScreen.SetPixel(posx + 0, posy + 2, Col);
                VGAScreen.SetPixel(posx + 0, posy + 3, Col);
                VGAScreen.SetPixel(posx + 0, posy + 4, Col);
                VGAScreen.SetPixel(posx + 0, posy + 5, Col);
                VGAScreen.SetPixel(posx + 0, posy + 6, Col);
                VGAScreen.SetPixel(posx + 1, posy + 6, Col);
                VGAScreen.SetPixel(posx + 2, posy + 6, Col);
                VGAScreen.SetPixel(posx + 3, posy + 6, Col);
                VGAScreen.SetPixel(posx + 4, posy + 6, Col);

                if (Transparent == false)
                {
                    VGAScreen.SetPixel(posx + 1, posy, 63);
                    VGAScreen.SetPixel(posx + 2, posy, 63);
                    VGAScreen.SetPixel(posx + 3, posy, 63);
                    VGAScreen.SetPixel(posx + 4, posy, 63);
                    VGAScreen.SetPixel(posx + 1, posy + 1, 63);
                    VGAScreen.SetPixel(posx + 2, posy + 1, 63);
                    VGAScreen.SetPixel(posx + 3, posy + 1, 63);
                    VGAScreen.SetPixel(posx + 4, posy + 1, 63);
                    VGAScreen.SetPixel(posx + 1, posy + 2, 63);
                    VGAScreen.SetPixel(posx + 2, posy + 2, 63);
                    VGAScreen.SetPixel(posx + 3, posy + 2, 63);
                    VGAScreen.SetPixel(posx + 4, posy + 2, 63);
                    VGAScreen.SetPixel(posx + 1, posy + 3, 63);
                    VGAScreen.SetPixel(posx + 2, posy + 3, 63);
                    VGAScreen.SetPixel(posx + 3, posy + 3, 63);
                    VGAScreen.SetPixel(posx + 4, posy + 3, 63);
                    VGAScreen.SetPixel(posx + 1, posy + 4, 63);
                    VGAScreen.SetPixel(posx + 2, posy + 4, 63);
                    VGAScreen.SetPixel(posx + 3, posy + 4, 63);
                    VGAScreen.SetPixel(posx + 4, posy + 4, 63);
                    VGAScreen.SetPixel(posx + 1, posy + 5, 63);
                    VGAScreen.SetPixel(posx + 2, posy + 5, 63);
                    VGAScreen.SetPixel(posx + 3, posy + 5, 63);
                    VGAScreen.SetPixel(posx + 4, posy + 5, 63);
                }
            }


            else if (letter == "u")
            {

                VGAScreen.SetPixel(posx + 0, posy + 2, Col);
                VGAScreen.SetPixel(posx + 4, posy + 2, Col);
                VGAScreen.SetPixel(posx + 0, posy + 3, Col);
                VGAScreen.SetPixel(posx + 4, posy + 3, Col);
                VGAScreen.SetPixel(posx + 0, posy + 4, Col);
                VGAScreen.SetPixel(posx + 4, posy + 4, Col);
                VGAScreen.SetPixel(posx + 0, posy + 5, Col);
                VGAScreen.SetPixel(posx + 4, posy + 5, Col);
                VGAScreen.SetPixel(posx + 1, posy + 6, Col);
                VGAScreen.SetPixel(posx + 2, posy + 6, Col);
                VGAScreen.SetPixel(posx + 3, posy + 6, Col);



                if (Transparent == false)
                {
                    VGAScreen.SetPixel(posx, posy, BgCol);
                    VGAScreen.SetPixel(posx + 1, posy, BgCol);
                    VGAScreen.SetPixel(posx + 2, posy, BgCol);
                    VGAScreen.SetPixel(posx + 3, posy, BgCol);
                    VGAScreen.SetPixel(posx + 4, posy, BgCol);
                    VGAScreen.SetPixel(posx + 0, posy + 1, BgCol);
                    VGAScreen.SetPixel(posx + 1, posy + 1, BgCol);
                    VGAScreen.SetPixel(posx + 2, posy + 1, BgCol);
                    VGAScreen.SetPixel(posx + 3, posy + 1, BgCol);
                    VGAScreen.SetPixel(posx + 4, posy + 1, BgCol);
                    VGAScreen.SetPixel(posx + 1, posy + 2, BgCol);
                    VGAScreen.SetPixel(posx + 2, posy + 2, BgCol);
                    VGAScreen.SetPixel(posx + 3, posy + 2, BgCol);
                    VGAScreen.SetPixel(posx + 1, posy + 3, BgCol);
                    VGAScreen.SetPixel(posx + 2, posy + 3, BgCol);
                    VGAScreen.SetPixel(posx + 3, posy + 3, BgCol);
                    VGAScreen.SetPixel(posx + 1, posy + 4, BgCol);
                    VGAScreen.SetPixel(posx + 2, posy + 4, BgCol);
                    VGAScreen.SetPixel(posx + 3, posy + 4, BgCol);
                    VGAScreen.SetPixel(posx + 1, posy + 5, BgCol);
                    VGAScreen.SetPixel(posx + 2, posy + 5, BgCol);
                    VGAScreen.SetPixel(posx + 3, posy + 5, BgCol);
                    VGAScreen.SetPixel(posx + 0, posy + 6, BgCol);
                    VGAScreen.SetPixel(posx + 4, posy + 6, BgCol);
                }

            }
            else if (letter == "o")
            {

                VGAScreen.SetPixel(posx + 1, posy + 2, Col);
                VGAScreen.SetPixel(posx + 2, posy + 2, Col);
                VGAScreen.SetPixel(posx + 3, posy + 2, Col);
                VGAScreen.SetPixel(posx + 0, posy + 3, Col);
                VGAScreen.SetPixel(posx + 4, posy + 3, Col);
                VGAScreen.SetPixel(posx + 0, posy + 4, Col);
                VGAScreen.SetPixel(posx + 4, posy + 4, Col);
                VGAScreen.SetPixel(posx + 0, posy + 5, Col);
                VGAScreen.SetPixel(posx + 4, posy + 5, Col);
                VGAScreen.SetPixel(posx + 1, posy + 6, Col);
                VGAScreen.SetPixel(posx + 2, posy + 6, Col);
                VGAScreen.SetPixel(posx + 3, posy + 6, Col);


                if (Transparent == false)
                {
                    VGAScreen.SetPixel(posx, posy, 63);
                    VGAScreen.SetPixel(posx + 1, posy, 63);
                    VGAScreen.SetPixel(posx + 2, posy, 63);
                    VGAScreen.SetPixel(posx + 3, posy, 63);
                    VGAScreen.SetPixel(posx + 4, posy, 63);
                    VGAScreen.SetPixel(posx + 0, posy + 1, 63);
                    VGAScreen.SetPixel(posx + 1, posy + 1, 63);
                    VGAScreen.SetPixel(posx + 2, posy + 1, 63);
                    VGAScreen.SetPixel(posx + 3, posy + 1, 63);
                    VGAScreen.SetPixel(posx + 4, posy + 1, 63);
                    VGAScreen.SetPixel(posx + 0, posy + 2, 63);
                    VGAScreen.SetPixel(posx + 4, posy + 2, 63);
                    VGAScreen.SetPixel(posx + 1, posy + 3, 63);
                    VGAScreen.SetPixel(posx + 2, posy + 3, 63);
                    VGAScreen.SetPixel(posx + 3, posy + 3, 63);
                    VGAScreen.SetPixel(posx + 1, posy + 4, 63);
                    VGAScreen.SetPixel(posx + 2, posy + 4, 63);
                    VGAScreen.SetPixel(posx + 3, posy + 4, 63);
                    VGAScreen.SetPixel(posx + 1, posy + 5, 63);
                    VGAScreen.SetPixel(posx + 2, posy + 5, 63);
                    VGAScreen.SetPixel(posx + 3, posy + 5, 63);
                    VGAScreen.SetPixel(posx + 0, posy + 6, 63);
                    VGAScreen.SetPixel(posx + 4, posy + 6, 63);
                }
            }

            else if (letter == "t")
            {

                VGAScreen.SetPixel(posx + 2, posy, Col);
                VGAScreen.SetPixel(posx + 2, posy + 1, Col);
                VGAScreen.SetPixel(posx + 1, posy + 2, Col);
                VGAScreen.SetPixel(posx + 2, posy + 2, Col);
                VGAScreen.SetPixel(posx + 3, posy + 2, Col);
                VGAScreen.SetPixel(posx + 2, posy + 3, Col);
                VGAScreen.SetPixel(posx + 2, posy + 4, Col);
                VGAScreen.SetPixel(posx + 2, posy + 5, Col);
                VGAScreen.SetPixel(posx + 2, posy + 6, Col);
                VGAScreen.SetPixel(posx + 3, posy + 6, Col);


                if (Transparent == false)
                {
                    VGAScreen.SetPixel(posx, posy, 63);
                    VGAScreen.SetPixel(posx + 1, posy, 63);
                    VGAScreen.SetPixel(posx + 3, posy, 63);
                    VGAScreen.SetPixel(posx + 4, posy, 63);
                    VGAScreen.SetPixel(posx + 0, posy + 1, 63);
                    VGAScreen.SetPixel(posx + 1, posy + 1, 63);
                    VGAScreen.SetPixel(posx + 3, posy + 1, 63);
                    VGAScreen.SetPixel(posx + 4, posy + 1, 63);
                    VGAScreen.SetPixel(posx + 0, posy + 2, 63);
                    VGAScreen.SetPixel(posx + 4, posy + 2, 63);
                    VGAScreen.SetPixel(posx + 0, posy + 3, 63);
                    VGAScreen.SetPixel(posx + 1, posy + 3, 63);
                    VGAScreen.SetPixel(posx + 3, posy + 3, 63);
                    VGAScreen.SetPixel(posx + 4, posy + 3, 63);
                    VGAScreen.SetPixel(posx + 0, posy + 4, 63);
                    VGAScreen.SetPixel(posx + 1, posy + 4, 63);
                    VGAScreen.SetPixel(posx + 3, posy + 4, 63);
                    VGAScreen.SetPixel(posx + 4, posy + 4, 63);
                    VGAScreen.SetPixel(posx + 0, posy + 5, 63);
                    VGAScreen.SetPixel(posx + 1, posy + 5, 63);
                    VGAScreen.SetPixel(posx + 3, posy + 5, 63);
                    VGAScreen.SetPixel(posx + 4, posy + 5, 63);
                    VGAScreen.SetPixel(posx + 0, posy + 6, 63);
                    VGAScreen.SetPixel(posx + 1, posy + 6, 63);
                    VGAScreen.SetPixel(posx + 4, posy + 6, 63);
                }
            }

            else if (letter == "c")
            {
                VGAScreen.SetPixel(posx + 1, posy + 2, Col);
                VGAScreen.SetPixel(posx + 2, posy + 2, Col);
                VGAScreen.SetPixel(posx + 3, posy + 2, Col);
                VGAScreen.SetPixel(posx + 4, posy + 2, Col);
                VGAScreen.SetPixel(posx + 0, posy + 3, Col);
                VGAScreen.SetPixel(posx + 0, posy + 4, Col);
                VGAScreen.SetPixel(posx + 0, posy + 5, Col);
                VGAScreen.SetPixel(posx + 1, posy + 6, Col);
                VGAScreen.SetPixel(posx + 2, posy + 6, Col);
                VGAScreen.SetPixel(posx + 3, posy + 6, Col);
                VGAScreen.SetPixel(posx + 4, posy + 6, Col);

                if (Transparent == false)
                {
                    VGAScreen.SetPixel(posx, posy, 63);
                    VGAScreen.SetPixel(posx + 1, posy, 63);
                    VGAScreen.SetPixel(posx + 2, posy, 63);
                    VGAScreen.SetPixel(posx + 3, posy, 63);
                    VGAScreen.SetPixel(posx + 4, posy, 63);
                    VGAScreen.SetPixel(posx + 0, posy + 1, 63);
                    VGAScreen.SetPixel(posx + 1, posy + 1, 63);
                    VGAScreen.SetPixel(posx + 2, posy + 1, 63);
                    VGAScreen.SetPixel(posx + 3, posy + 1, 63);
                    VGAScreen.SetPixel(posx + 4, posy + 1, 63);
                    VGAScreen.SetPixel(posx + 0, posy + 2, 63);
                    VGAScreen.SetPixel(posx + 1, posy + 3, 63);
                    VGAScreen.SetPixel(posx + 2, posy + 3, 63);
                    VGAScreen.SetPixel(posx + 3, posy + 3, 63);
                    VGAScreen.SetPixel(posx + 4, posy + 3, 63);
                    VGAScreen.SetPixel(posx + 1, posy + 4, 63);
                    VGAScreen.SetPixel(posx + 2, posy + 4, 63);
                    VGAScreen.SetPixel(posx + 3, posy + 4, 63);
                    VGAScreen.SetPixel(posx + 4, posy + 4, 63);
                    VGAScreen.SetPixel(posx + 1, posy + 5, 63);
                    VGAScreen.SetPixel(posx + 2, posy + 5, 63);
                    VGAScreen.SetPixel(posx + 3, posy + 5, 63);
                    VGAScreen.SetPixel(posx + 4, posy + 5, 63);
                    VGAScreen.SetPixel(posx + 0, posy + 6, 63);

                }
            }
        
        }


        static void DrawNumber(int number, uint posx, uint posy, uint Col)
        {

            if (number == 1)
            {

                VGAScreen.SetPixel(posx, posy, 63);
                VGAScreen.SetPixel(posx + 1, posy, Col);
                VGAScreen.SetPixel(posx + 2, posy, Col);
                VGAScreen.SetPixel(posx + 3, posy, Col);
                VGAScreen.SetPixel(posx + 4, posy, 63);
                VGAScreen.SetPixel(posx + 0, posy + 1, Col);
                VGAScreen.SetPixel(posx + 1, posy + 1, 63);
                VGAScreen.SetPixel(posx + 2, posy + 1, 63);
                VGAScreen.SetPixel(posx + 3, posy + 1, 63);
                VGAScreen.SetPixel(posx + 4, posy + 1, Col);
                VGAScreen.SetPixel(posx + 0, posy + 2, Col);
                VGAScreen.SetPixel(posx + 1, posy + 2, 63);
                VGAScreen.SetPixel(posx + 2, posy + 2, 63);
                VGAScreen.SetPixel(posx + 3, posy + 2, 63);
                VGAScreen.SetPixel(posx + 4, posy + 2, Col);
                VGAScreen.SetPixel(posx + 0, posy + 3, Col);
                VGAScreen.SetPixel(posx + 1, posy + 3, 63);
                VGAScreen.SetPixel(posx + 2, posy + 3, 63);
                VGAScreen.SetPixel(posx + 3, posy + 3, 63);
                VGAScreen.SetPixel(posx + 4, posy + 3, Col);
                VGAScreen.SetPixel(posx + 0, posy + 4, Col);
                VGAScreen.SetPixel(posx + 1, posy + 4, 63);
                VGAScreen.SetPixel(posx + 2, posy + 4, 63);
                VGAScreen.SetPixel(posx + 3, posy + 4, 63);
                VGAScreen.SetPixel(posx + 4, posy + 4, Col);
                VGAScreen.SetPixel(posx + 0, posy + 5, Col);
                VGAScreen.SetPixel(posx + 1, posy + 5, 63);
                VGAScreen.SetPixel(posx + 2, posy + 5, 63);
                VGAScreen.SetPixel(posx + 3, posy + 5, 63);
                VGAScreen.SetPixel(posx + 4, posy + 5, Col);
                VGAScreen.SetPixel(posx + 0, posy + 6, 63);
                VGAScreen.SetPixel(posx + 1, posy + 6, Col);
                VGAScreen.SetPixel(posx + 2, posy + 6, Col);
                VGAScreen.SetPixel(posx + 3, posy + 6, Col);
                VGAScreen.SetPixel(posx + 4, posy + 6, 63);
            }
            else if (number == 2)
            {
                VGAScreen.SetPixel(posx, posy, 63);
                VGAScreen.SetPixel(posx + 1, posy, 0);
                VGAScreen.SetPixel(posx + 2, posy, 0);
                VGAScreen.SetPixel(posx + 3, posy, 0);
                VGAScreen.SetPixel(posx + 4, posy, 63);
                VGAScreen.SetPixel(posx + 0, posy + 1, 0);
                VGAScreen.SetPixel(posx + 1, posy + 1, 63);
                VGAScreen.SetPixel(posx + 2, posy + 1, 63);
                VGAScreen.SetPixel(posx + 3, posy + 1, 63);
                VGAScreen.SetPixel(posx + 4, posy + 1, 0);
                VGAScreen.SetPixel(posx + 0, posy + 2, 63);
                VGAScreen.SetPixel(posx + 1, posy + 2, 63);
                VGAScreen.SetPixel(posx + 2, posy + 2, 63);
                VGAScreen.SetPixel(posx + 3, posy + 2, 63);
                VGAScreen.SetPixel(posx + 4, posy + 2, 0);
                VGAScreen.SetPixel(posx + 0, posy + 3, 63);
                VGAScreen.SetPixel(posx + 1, posy + 3, 63);
                VGAScreen.SetPixel(posx + 2, posy + 3, 63);
                VGAScreen.SetPixel(posx + 3, posy + 3, 0);
                VGAScreen.SetPixel(posx + 4, posy + 3, 63);
                VGAScreen.SetPixel(posx + 0, posy + 4, 63);
                VGAScreen.SetPixel(posx + 1, posy + 4, 63);
                VGAScreen.SetPixel(posx + 2, posy + 4, 0);
                VGAScreen.SetPixel(posx + 3, posy + 4, 63);
                VGAScreen.SetPixel(posx + 4, posy + 4, 63);
                VGAScreen.SetPixel(posx + 0, posy + 5, 63);
                VGAScreen.SetPixel(posx + 1, posy + 5, 0);
                VGAScreen.SetPixel(posx + 2, posy + 5, 63);
                VGAScreen.SetPixel(posx + 3, posy + 5, 63);
                VGAScreen.SetPixel(posx + 4, posy + 5, 63);
                VGAScreen.SetPixel(posx + 0, posy + 6, 0);
                VGAScreen.SetPixel(posx + 1, posy + 6, 0);
                VGAScreen.SetPixel(posx + 2, posy + 6, 0);
                VGAScreen.SetPixel(posx + 3, posy + 6, 0);
                VGAScreen.SetPixel(posx + 4, posy + 6, 0);


            }
            else if (number == 3)
            {
                VGAScreen.SetPixel(posx, posy, 63);
                VGAScreen.SetPixel(posx + 1, posy, 0);
                VGAScreen.SetPixel(posx + 2, posy, 0);
                VGAScreen.SetPixel(posx + 3, posy, 0);
                VGAScreen.SetPixel(posx + 4, posy, 63);
                VGAScreen.SetPixel(posx + 0, posy + 1, 63);
                VGAScreen.SetPixel(posx + 1, posy + 1, 63);
                VGAScreen.SetPixel(posx + 2, posy + 1, 63);
                VGAScreen.SetPixel(posx + 3, posy + 1, 63);
                VGAScreen.SetPixel(posx + 4, posy + 1, 0);
                VGAScreen.SetPixel(posx + 0, posy + 2, 63);
                VGAScreen.SetPixel(posx + 1, posy + 2, 63);
                VGAScreen.SetPixel(posx + 2, posy + 2, 63);
                VGAScreen.SetPixel(posx + 3, posy + 2, 63);
                VGAScreen.SetPixel(posx + 4, posy + 2, 0);
                VGAScreen.SetPixel(posx + 0, posy + 3, 63);
                VGAScreen.SetPixel(posx + 1, posy + 3, 0);
                VGAScreen.SetPixel(posx + 2, posy + 3, 0);
                VGAScreen.SetPixel(posx + 3, posy + 3, 0);
                VGAScreen.SetPixel(posx + 4, posy + 3, 63);
                VGAScreen.SetPixel(posx + 0, posy + 4, 63);
                VGAScreen.SetPixel(posx + 1, posy + 4, 63);
                VGAScreen.SetPixel(posx + 2, posy + 4, 63);
                VGAScreen.SetPixel(posx + 3, posy + 4, 63);
                VGAScreen.SetPixel(posx + 4, posy + 4, 0);
                VGAScreen.SetPixel(posx + 0, posy + 5, 63);
                VGAScreen.SetPixel(posx + 1, posy + 5, 63);
                VGAScreen.SetPixel(posx + 2, posy + 5, 63);
                VGAScreen.SetPixel(posx + 3, posy + 5, 63);
                VGAScreen.SetPixel(posx + 4, posy + 5, 0);
                VGAScreen.SetPixel(posx + 0, posy + 6, 63);
                VGAScreen.SetPixel(posx + 1, posy + 6, 0);
                VGAScreen.SetPixel(posx + 2, posy + 6, 0);
                VGAScreen.SetPixel(posx + 3, posy + 6, 0);
                VGAScreen.SetPixel(posx + 4, posy + 6, 63);

            }
            else if (number == 4)
            {
                VGAScreen.SetPixel(posx, posy, 63);
                VGAScreen.SetPixel(posx + 1, posy, 63);
                VGAScreen.SetPixel(posx + 2, posy, 63);
                VGAScreen.SetPixel(posx + 3, posy, 0);
                VGAScreen.SetPixel(posx + 4, posy, 63);
                VGAScreen.SetPixel(posx + 0, posy + 1, 63);
                VGAScreen.SetPixel(posx + 1, posy + 1, 63);
                VGAScreen.SetPixel(posx + 2, posy + 1, 0);
                VGAScreen.SetPixel(posx + 3, posy + 1, 0);
                VGAScreen.SetPixel(posx + 4, posy + 1, 63);
                VGAScreen.SetPixel(posx + 0, posy + 2, 63);
                VGAScreen.SetPixel(posx + 1, posy + 2, 0);
                VGAScreen.SetPixel(posx + 2, posy + 2, 63);
                VGAScreen.SetPixel(posx + 3, posy + 2, 0);
                VGAScreen.SetPixel(posx + 4, posy + 2, 63);
                VGAScreen.SetPixel(posx + 0, posy + 3, 0);
                VGAScreen.SetPixel(posx + 1, posy + 3, 0);
                VGAScreen.SetPixel(posx + 2, posy + 3, 0);
                VGAScreen.SetPixel(posx + 3, posy + 3, 0);
                VGAScreen.SetPixel(posx + 4, posy + 3, 0);
                VGAScreen.SetPixel(posx + 0, posy + 4, 63);
                VGAScreen.SetPixel(posx + 1, posy + 4, 63);
                VGAScreen.SetPixel(posx + 2, posy + 4, 63);
                VGAScreen.SetPixel(posx + 3, posy + 4, 0);
                VGAScreen.SetPixel(posx + 4, posy + 4, 63);
                VGAScreen.SetPixel(posx + 0, posy + 5, 63);
                VGAScreen.SetPixel(posx + 1, posy + 5, 63);
                VGAScreen.SetPixel(posx + 2, posy + 5, 63);
                VGAScreen.SetPixel(posx + 3, posy + 5, 0);
                VGAScreen.SetPixel(posx + 4, posy + 5, 63);
                VGAScreen.SetPixel(posx + 0, posy + 6, 63);
                VGAScreen.SetPixel(posx + 1, posy + 6, 63);
                VGAScreen.SetPixel(posx + 2, posy + 6, 63);
                VGAScreen.SetPixel(posx + 3, posy + 6, 0);
                VGAScreen.SetPixel(posx + 4, posy + 6, 63);
            }
            else if (number == 5)
            {
            VGAScreen.SetPixel(posx, posy, 0);
            VGAScreen.SetPixel(posx + 1, posy, 0);
            VGAScreen.SetPixel(posx + 2, posy, 0);
            VGAScreen.SetPixel(posx + 3, posy, 0);
            VGAScreen.SetPixel(posx + 4, posy, 0);
            VGAScreen.SetPixel(posx + 0, posy + 1, 0);
            VGAScreen.SetPixel(posx + 1, posy + 1, 63);
            VGAScreen.SetPixel(posx + 2, posy + 1, 63);
            VGAScreen.SetPixel(posx + 3, posy + 1, 63);
            VGAScreen.SetPixel(posx + 4, posy + 1, 63);
            VGAScreen.SetPixel(posx + 0, posy + 2, 0);
            VGAScreen.SetPixel(posx + 1, posy + 2, 63);
            VGAScreen.SetPixel(posx + 2, posy + 2, 63);
            VGAScreen.SetPixel(posx + 3, posy + 2, 63);
            VGAScreen.SetPixel(posx + 4, posy + 2, 63);
            VGAScreen.SetPixel(posx + 0, posy + 3, 0);
            VGAScreen.SetPixel(posx + 1, posy + 3, 0);
            VGAScreen.SetPixel(posx + 2, posy + 3, 0);
            VGAScreen.SetPixel(posx + 3, posy + 3, 0);
            VGAScreen.SetPixel(posx + 4, posy + 3, 63);
            VGAScreen.SetPixel(posx + 0, posy + 4, 63);
            VGAScreen.SetPixel(posx + 1, posy + 4, 63);
            VGAScreen.SetPixel(posx + 2, posy + 4, 63);
            VGAScreen.SetPixel(posx + 3, posy + 4, 63);
            VGAScreen.SetPixel(posx + 4, posy + 4, 0);
            VGAScreen.SetPixel(posx + 0, posy + 5, 63);
            VGAScreen.SetPixel(posx + 1, posy + 5, 63);
            VGAScreen.SetPixel(posx + 2, posy + 5, 63);
            VGAScreen.SetPixel(posx + 3, posy + 5, 63);
            VGAScreen.SetPixel(posx + 4, posy + 5, 0);
            VGAScreen.SetPixel(posx + 0, posy + 6, 0);
            VGAScreen.SetPixel(posx + 1, posy + 6, 0);
            VGAScreen.SetPixel(posx + 2, posy + 6, 0);
            VGAScreen.SetPixel(posx + 3, posy + 6, 0);
            VGAScreen.SetPixel(posx + 4, posy + 6, 63);

            }
            else if (number == 0)
            {
                VGAScreen.SetPixel(posx, posy, 63);
                VGAScreen.SetPixel(posx + 1, posy, 0);
                VGAScreen.SetPixel(posx + 2, posy, 0);
                VGAScreen.SetPixel(posx + 3, posy, 0);
                VGAScreen.SetPixel(posx + 4, posy, 63);
                VGAScreen.SetPixel(posx + 0, posy + 1, 0);
                VGAScreen.SetPixel(posx + 1, posy + 1, 63);
                VGAScreen.SetPixel(posx + 2, posy + 1, 63);
                VGAScreen.SetPixel(posx + 3, posy + 1, 63);
                VGAScreen.SetPixel(posx + 4, posy + 1, 0);
                VGAScreen.SetPixel(posx + 0, posy + 2, 0);
                VGAScreen.SetPixel(posx + 1, posy + 2, 63);
                VGAScreen.SetPixel(posx + 2, posy + 2, 63);
                VGAScreen.SetPixel(posx + 3, posy + 2, 63);
                VGAScreen.SetPixel(posx + 4, posy + 2, 0);
                VGAScreen.SetPixel(posx + 0, posy + 3, 0);
                VGAScreen.SetPixel(posx + 1, posy + 3, 63);
                VGAScreen.SetPixel(posx + 2, posy + 3, 63);
                VGAScreen.SetPixel(posx + 3, posy + 3, 63);
                VGAScreen.SetPixel(posx + 4, posy + 3, 0);
                VGAScreen.SetPixel(posx + 0, posy + 4, 0);
                VGAScreen.SetPixel(posx + 1, posy + 4, 63);
                VGAScreen.SetPixel(posx + 2, posy + 4, 63);
                VGAScreen.SetPixel(posx + 3, posy + 4, 63);
                VGAScreen.SetPixel(posx + 4, posy + 4, 0);
                VGAScreen.SetPixel(posx + 0, posy + 5, 0);
                VGAScreen.SetPixel(posx + 1, posy + 5, 63);
                VGAScreen.SetPixel(posx + 2, posy + 5, 63);
                VGAScreen.SetPixel(posx + 3, posy + 5, 63);
                VGAScreen.SetPixel(posx + 4, posy + 5, 0);
                VGAScreen.SetPixel(posx + 0, posy + 6, 63);
                VGAScreen.SetPixel(posx + 1, posy + 6, 0);
                VGAScreen.SetPixel(posx + 2, posy + 6, 0);
                VGAScreen.SetPixel(posx + 3, posy + 6, 0);
                VGAScreen.SetPixel(posx + 4, posy + 6, 63);
            }
        }
    }

    }
