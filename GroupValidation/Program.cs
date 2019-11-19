using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GroupValidation
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Fill in group name");
            string groupName = Console.ReadLine();
            Console.WriteLine("Fill in group ID");
            string groupID = Console.ReadLine();
            Group GroupAddingResult = Group.CreateGroup(groupName, groupID, out string message);
            if (message == null)
            {
                message = "Group is added successfully";
            }
            Console.WriteLine(message);
            Console.ReadLine();
        }
    }
}
