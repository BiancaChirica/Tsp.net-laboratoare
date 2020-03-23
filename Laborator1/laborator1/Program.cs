using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Threading;

namespace laborator1
{
    public class MyApp
    {
        public static event Action<String> Finalized = delegate { };
        private readonly string threadName = "";
        static private List<String> listaInfo = new List<String>();
       static private int Number = 15;
        public MyApp()
        {
        Finalized(ThreadN);
         }

    public string ThreadN
    {
        get { return threadName; }
    }


    static private void ThreadAlg1()
        {

            listaInfo.Add("Start fir: " + Thread.CurrentThread.Name + " Timestamp: " + DateTime.Now.ToString() + " Numar prim dat = " + Number);
            if (Thread.CurrentThread.Name == null)
            {
                Thread.CurrentThread.Name = "Thread 1";
            }
            Thread.Sleep(30);
            int rez = Algoritmi.FindNumberAlg2(Number);
            listaInfo.Add("End fir: " + Thread.CurrentThread.Name + " Timestamp: " + DateTime.Now.ToString() + " Numar prim dat = " + rez);

        }

        static private void ThreadAlg2()
        {
            listaInfo.Add("Start fir: " + Thread.CurrentThread.Name + " Timestamp: " + DateTime.Now.ToString() + " Numar natural dat = " + Number);

            if (Thread.CurrentThread.Name == null)
            {
                Thread.CurrentThread.Name = "Thread 2";
            }
            int rez = Algoritmi.FindNumberAlg2(Number);
            Thread.Sleep(10);

            listaInfo.Add("End fir: " + Thread.CurrentThread.Name + " Timestamp: " + DateTime.Now.ToString() + " Numar prim dat = " + rez);


        }


        [STAThread]
        static void Main(string[] args)
        {
            // ex 1
               EventProgram obj1 = new EventProgram();
              String rez = obj1.SetEvent("Bianca");
               Console.WriteLine(rez);
               

            // ex 2 

            MyApp.Finalized += i => listaInfo.Add("thread : " + i + " closed");

            Thread th1 = new Thread(ThreadAlg1);
            th1.Start();
            MyApp.Finalized += i => listaInfo.Add("thread : " + i + " closed");
            Thread th2 = new Thread(ThreadAlg2);
            th2.Start();
            MyApp.Finalized += i => listaInfo.Add("thread : " + i + " closed");

            th1.Join();
            th2.Join();
            Console.WriteLine("All operations have completed. Press enter to exit");

            foreach(String item in listaInfo)
                Console.WriteLine(item);
            Console.ReadLine();


            Console.ReadKey();
        }
    }

}
