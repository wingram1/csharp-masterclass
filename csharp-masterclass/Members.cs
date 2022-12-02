using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cSharpMasterclass
{
    internal class Members
    {
        private string name;
        private string title;
        private int salary;

        public int age;

        public string Name { 
            get { return name; }
            set 
            {
                name = value;
            } 
        }

        public void Introducing(bool isFriend)
        {
            Console.WriteLine($"Hi, my name is {name}, and my job title is {title}. I am {age} years old.");

            if (isFriend)
            {
                SharingPrivateInfo();
            }
                
           
        }

        private void SharingPrivateInfo()
        {
                Console.WriteLine($"My salary is {salary}");
        }

        // member constructor
        public Members()
        {
            age = 30;
            name = "Lucy";
            salary = 60000;
            title = "Developer";
            Console.WriteLine("New member created.");
        }
        
        // finalizer/destructor. Basically happens when object runs out of scope
        ~Members()
        {
            //cleanup statements
            Console.WriteLine("Deconstruction of Members Object");
        }
    }
}
