using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatikaListTask
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // ▼ Greeting ▼
            Console.WriteLine("Welcome to the Patika Plus Gala! Here are the guest list:\n*******************");

            // ▼ Creating generic list ▼
            List<string> guestList = new List<string>();

            // ▼ Adding 10 random full names to list with 'FakeData' package ▼
            for (int i = 0; i < 10; i++)
            {
                // ▼ FakeData is a 'NuGet packege' in project to create random full names ▼
                guestList.Add(FakeData.NameData.GetFullName());
            }

            // ▼ Printing all guest ▼
            foreach (string guest in guestList)
            {
                Console.WriteLine(guest);
            }
            Console.WriteLine("*******************");
        }
    }
}
