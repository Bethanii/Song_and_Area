using System;
using static System.Console;

namespace Quiz2
{
    class Program
    {
        public static int getWidth()
        {
            int val;
            bool w;
            do
            {
                WriteLine("Enter the width: ");
                w = Int32.TryParse(ReadLine(), out val);
            } while (!w);
            return val;
        }
        public static int getLength() { 
            int v;
            bool l;
            do
            {
                WriteLine("Enter the length: ");
                l = Int32.TryParse(ReadLine(), out v);
            } while (!l);
            return v;
        }
        public static int getArea(int Width, int Length)
        {
            return Width*Length;
        }
        static void Main(string[] args)
        {
            int w = getWidth();
            int l = getLength();
            WriteLine("The width is: " + w + "\n" + "The length is: " + l +"\n" + "The area is: " +getArea(w, l));

            WriteLine("How many songs will be created?");
            int songs = Convert.ToInt32(ReadLine());
            Song[] s = new Song[songs];

            for (int i = 0; i < songs; i++)
            {
                s[i] = new Song();
                WriteLine("What is the song name? ");
                s[i].Name = ReadLine();
                WriteLine("Who is the artist? ");
                s[i].Performer = ReadLine();

            }
            for (int i = 0; i < songs; i++)
            {
                WriteLine(s[i].Name + " by " + s[i].Performer);
            }
        }
    }
class Song 
    {
        string name;
        string performer;
        public string Name
        {
            get
            {
                return name;
            }
            set
            {
                name = value;
            }
        }
        public string Performer
        {
            get
            {
                return performer;
            }
            set
            {
                performer = value;
            }
        }
    }
}
