using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*Создайте 2 интерфейса IPlayable и IRecodable. 
    В каждом из интерфейсов создайте по 3 метода 
    void Play() / void Pause() / void Stop() и void Record() / void Pause() / void Stop() соответственно.
    Создайте производный класс Player от базовых интерфейсов IPlayable и IRecodable. 
    Написать программу, которая выполняет проигрывание и запись. */
namespace _2HW
{
    interface IPlayable
    {
        void Play();
        void Pause();
        void Stop();
    }
    interface IRecodable
    {
        void Record();
        void Pause();
        void Stop();
    }
    class Player : IPlayable, IRecodable
    {
        public void Play()
        {
            Console.WriteLine("playing");
        }
        public void Record()
        {
            Console.WriteLine("recording");
        }
        void IPlayable.Pause()
        {
            Console.WriteLine("playing - pause");
        }
        void IRecodable.Pause()
        {
            Console.WriteLine("recording - pause");
        }
        void IPlayable.Stop()
        {
            Console.WriteLine("playing - stop");
        }
        void IRecodable.Stop()
        {
            Console.WriteLine("recording - stop");
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            IPlayable play=new Player();
            play.Play();
            play.Pause();
            play.Stop();
            Console.WriteLine(new string('-',25));
            IRecodable record=new Player();
            record.Record();
            record.Pause();
            record.Stop();
            Console.ReadKey();
        }
    }
}
