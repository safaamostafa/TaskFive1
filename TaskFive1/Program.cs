using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaskFive1
{
    class Program
    {
        static void Main(string[] args)
        {
            string SchoolOne = "a";
            string SchoolTwo = "b";
            string SchoolThree = "c";
            string SchoolFour = "d";
            string SchoolFive = "e";
            int TeacherNumber = 0;
            int TeacherNumber2 = 0;
            int TeacherNumber3 = 0;
            int TeacherNumber4 = 0;
            int TeacherNumber5 = 0;
       
            int NumberStudents = 0;
            int NumberStudents2 = 0;
            int NumberStudents3 = 0;
            int NumberStudents4 = 0;
            int NumberStudents5 = 0;
            int AvgOne= 0;
            int AvgTwo = 0;
            int AvgThree = 0;
            int AvgFour = 0;
            int AvgFive = 0;
            Console.WriteLine("****Enter name of School plz****");
            string SchoolName = Console.ReadLine();
            if (SchoolName == SchoolOne || SchoolName == SchoolTwo || SchoolName == SchoolThree ||
                 SchoolName ==SchoolFour || SchoolName == SchoolFive)
            {
                int TotalSalary = 0;
                int DegreeOne = 0;
                int DegreeTwo = 0;
                int DegreeThree = 0;
                int DegreeFour = 0;
                Console.WriteLine("**** Enter number of Teacher plz");
                TeacherNumber = int.Parse(Console.ReadLine());
                
                
                for (int i=1; i<= TeacherNumber; i++) {
                    Console.WriteLine("Enter Teacher name plz");
                    string name = Console.ReadLine();
                    Console.WriteLine(" Enter the Salary plz");
                    int salary = int.Parse(Console.ReadLine());
                    TotalSalary += salary;
                    if (salary >= 10000)
                    {
                        Console.WriteLine(" Degree One");
                        DegreeOne++;
                    }
                    else if (salary >= 7000 && salary < 10000)
                    {
                        Console.WriteLine(" Degree Two");
                        DegreeTwo++;
                    }
                    else if (salary >= 5000 && salary < 7000)
                    {
                        Console.WriteLine(" Degree Three");
                        DegreeThree++;
                    }
                    else if (salary >= 1000 && salary < 5000)
                    {
                        Console.WriteLine(" Degree Four");
                        DegreeFour++;
                    }
                    else {
                        Console.WriteLine("Sorry");
                    }
                }//for (int i=0; i<= TeacherNumber; i++) {

                Console.WriteLine("The Number of Teachers of school " + SchoolName + "= " + TeacherNumber);
                int SalaryAvgOne = TotalSalary / TeacherNumber;
                Console.WriteLine("THe average of salary for"+ SchoolName+ "="+ SalaryAvgOne);
                Console.WriteLine("Degree one = {0} \n Degree Two = {1}\n Degree Three = {2}\n Degree Four = {3}",
                   DegreeOne, DegreeTwo, DegreeThree, DegreeFour);

                Console.WriteLine("****************************************************************");

                Console.WriteLine("Enter Numner of Students plz");
                NumberStudents = int.Parse(Console.ReadLine());
                int x = 1;
                
                int TotalGrade = 0;
                int excellent = 0;
                int VeryGood = 0;
                int good = 0;
                int pass = 0;
                int fail = 0;

                do
                {


                    Console.WriteLine("enter ur name plz");
                    string name = Console.ReadLine();
                    Console.WriteLine("enter ur grade plz");
                    int grade = int.Parse(Console.ReadLine());
                    TotalGrade += grade;
                    if (grade > 90 && grade <= 100)
                    {
                        Console.WriteLine("Excellent");
                        excellent++;
                    }
                    else if (grade > 80 && grade <= 90)
                    {
                        Console.WriteLine("VeryGood");
                        VeryGood++;
                    }
                    else if (grade > 70 && grade <= 80)
                    {
                        Console.WriteLine("Good");
                        good++;
                    }
                    else if (grade > 49 && grade <= 70)
                    {
                        Console.WriteLine("Pass");
                        pass++;
                    }
                    else
                    {
                        Console.WriteLine("sorry");
                        fail++;
                    }
                    x++;
                }  //for (int x = 0; x < NumberStudents; x++)
                while (x <= NumberStudents);
        
                Console.WriteLine("The name of school is  " +    SchoolName  );

                Console.WriteLine("The Number of Students of school " + SchoolName+ "= "+ NumberStudents );
                AvgOne = TotalGrade / NumberStudents;
                
                int original_grade = 100;
                if (AvgOne >= original_grade)
                {
                    Console.WriteLine("Good");
                }
                if (AvgOne < original_grade)
                {
                    Console.WriteLine("bad");
                }
                Console.WriteLine("average School "+SchoolName+" = {0}", AvgOne);
                Console.WriteLine("excellent = {0} \n very good = {1}\n good = {2}\n pass = {3}\n fail = {4}",
                    excellent, VeryGood, good, pass, fail);
            } // if (SchoolName == SchoolOne)


            Console.WriteLine("****Enter name of School plz****");
            string SchoolName2 = Console.ReadLine();
            if (SchoolName2 == SchoolOne || SchoolName2 == SchoolTwo || SchoolName2 == SchoolThree ||
                 SchoolName2 == SchoolFour || SchoolName2 == SchoolFive)
            {
                int TotalSalary = 0;
                int DegreeOne = 0;
                int DegreeTwo = 0;
                int DegreeThree = 0;
                int DegreeFour = 0;
                Console.WriteLine("**** Enter number of Teacher plz");
                TeacherNumber2 = int.Parse(Console.ReadLine());


                for (int i = 1; i <= TeacherNumber2; i++)
                {
                    Console.WriteLine("Enter Teacher name plz");
                    string name = Console.ReadLine();
                    Console.WriteLine(" Enter the Salary plz");
                    int salary = int.Parse(Console.ReadLine());
                    TotalSalary += salary;
                    if (salary >= 10000)
                    {
                        Console.WriteLine(" Degree One");
                        DegreeOne++;
                    }
                    else if (salary >= 7000 && salary < 10000)
                    {
                        Console.WriteLine(" Degree Two");
                        DegreeTwo++;
                    }
                    else if (salary >= 5000 && salary < 7000)
                    {
                        Console.WriteLine(" Degree Three");
                        DegreeThree++;
                    }
                    else if (salary >= 1000 && salary < 5000)
                    {
                        Console.WriteLine(" Degree Four");
                        DegreeFour++;
                    }
                    else {
                        Console.WriteLine(" Sory");
                    }
                }//for (int i=0; i<= TeacherNumber; i++) {

                Console.WriteLine("The Number of Teachers of school " + SchoolName2 + "= " + TeacherNumber2);
                int SalaryAvgTwo = TotalSalary / TeacherNumber2;
                Console.WriteLine("THe average of salary for" + SchoolName2 + "=" + SalaryAvgTwo);
                Console.WriteLine("Degree one = {0} \n Degree Two = {1}\n Degree Three = {2}\n Degree Four = {3}",
                   DegreeOne, DegreeTwo, DegreeThree, DegreeFour);


                Console.WriteLine("****************************************************************");

                Console.WriteLine("**** Enter number of students plz");
                NumberStudents2 = int.Parse(Console.ReadLine());
                int x = 1;

                int TotalGrade = 0;
                int excellent = 0;
                int VeryGood = 0;
                int good = 0;
                int pass = 0;
                int fail = 0;

                do
                {


                    Console.WriteLine("enter ur name plz");
                    string name = Console.ReadLine();
                    Console.WriteLine("enter ur grade plz");
                    int grade = int.Parse(Console.ReadLine());
                    TotalGrade += grade;
                    if (grade > 90 && grade <= 100)
                    {
                        Console.WriteLine("Excellent");
                        excellent++;
                    }
                    else if (grade > 80 && grade <= 90)
                    {
                        Console.WriteLine("VeryGood");
                        VeryGood++;
                    }
                    else if (grade > 70 && grade <= 80)
                    {
                        Console.WriteLine("Good");
                        good++;
                    }
                    else if (grade > 49 && grade <= 70)
                    {
                        Console.WriteLine("Pass");
                        pass++;
                    }
                    else
                    {
                        Console.WriteLine("sorry");
                        fail++;
                    }
                    x++;
                }  //for (int x = 0; x < NumberStudents; x++)
                while (x <= NumberStudents2);
                Console.WriteLine("The name of school is  " + SchoolName2);
                Console.WriteLine("The Number of Students of school " + SchoolName2 + "= " + NumberStudents2);
                AvgTwo = TotalGrade / NumberStudents2;

                int original_grade = 100;
                if (AvgTwo >= original_grade)
                {
                    Console.WriteLine("Good");
                }
                if (AvgTwo < original_grade)
                {
                    Console.WriteLine("bad");
                }
                Console.WriteLine("average School "+ SchoolName2+" = {0}", AvgTwo);
                Console.WriteLine("excellent = {0} \n very good = {1}\n good = {2}\n pass = {3}\n fail = {4}",
                    excellent, VeryGood, good, pass, fail);
            } // if (SchoolName2 == SchoolTwo)


            Console.WriteLine("****Enter name of School plz****");
            string SchoolName3 = Console.ReadLine();
            if (SchoolName3 == SchoolOne || SchoolName3 == SchoolTwo || SchoolName3 == SchoolThree ||
                 SchoolName3 == SchoolFour || SchoolName3 == SchoolFive)
            {
                int TotalSalary = 0;
                int DegreeOne = 0;
                int DegreeTwo = 0;
                int DegreeThree = 0;
                int DegreeFour = 0;
                Console.WriteLine("**** Enter number of Teacher plz");
                TeacherNumber3 = int.Parse(Console.ReadLine());


                for (int i = 1; i <= TeacherNumber3; i++)
                {
                    Console.WriteLine("Enter Teacher name plz");
                    string name = Console.ReadLine();
                    Console.WriteLine(" Enter the Salary plz");
                    int salary = int.Parse(Console.ReadLine());
                    TotalSalary += salary;
                    if (salary >= 10000)
                    {
                        Console.WriteLine(" Degree One");
                        DegreeOne++;
                    }
                    else if (salary >= 7000 && salary < 10000)
                    {
                        Console.WriteLine(" Degree Two");
                        DegreeTwo++;
                    }
                    else if (salary >= 5000 && salary < 7000)
                    {
                        Console.WriteLine(" Degree Three");
                        DegreeThree++;
                    }
                    else if (salary >= 1000 && salary < 5000)
                    {
                        Console.WriteLine(" Degree Four");
                        DegreeFour++;
                    }
                    else
                    {
                        Console.WriteLine(" Sory");
                    }
                }//for (int i=0; i<= TeacherNumber; i++) {

                Console.WriteLine("The Number of Teachers of school " + SchoolName3 + "= " + TeacherNumber3);
                int SalaryAvgThree = TotalSalary / TeacherNumber3;
                Console.WriteLine("THe average of salary for" + SchoolName3 + "=" + SalaryAvgThree);
                Console.WriteLine("Degree one = {0} \n Degree Two = {1}\n Degree Three = {2}\n Degree Four = {3}",
                   DegreeOne, DegreeTwo, DegreeThree, DegreeFour);


                Console.WriteLine("****************************************************************");

                Console.WriteLine("**** Enter number of student plz");
                NumberStudents3 = int.Parse(Console.ReadLine());
                int x = 1;

                int TotalGrade = 0;
                int excellent = 0;
                int VeryGood = 0;
                int good = 0;
                int pass = 0;
                int fail = 0;

                do
                {


                    Console.WriteLine("enter ur name plz");
                    string name = Console.ReadLine();
                    Console.WriteLine("enter ur grade plz");
                    int grade = int.Parse(Console.ReadLine());
                    TotalGrade += grade;
                    if (grade > 90 && grade <= 100)
                    {
                        Console.WriteLine("Excellent");
                        excellent++;
                    }
                    else if (grade > 80 && grade <= 90)
                    {
                        Console.WriteLine("VeryGood");
                        VeryGood++;
                    }
                    else if (grade > 70 && grade <= 80)
                    {
                        Console.WriteLine("Good");
                        good++;
                    }
                    else if (grade > 49 && grade <= 70)
                    {
                        Console.WriteLine("Pass");
                        pass++;
                    }
                    else
                    {
                        Console.WriteLine("sorry");
                        fail++;
                    }
                    x++;
                }  //for (int x = 0; x < NumberStudents; x++)
                while (x <= NumberStudents3);
                Console.WriteLine("The name of school is  " + SchoolName3);
                Console.WriteLine("The Number of Students of school " + SchoolName3 + "= " + NumberStudents3);
                AvgThree = TotalGrade / NumberStudents3;

                int original_grade = 100;
                if (AvgThree >= original_grade)
                {
                    Console.WriteLine("Good");
                }
                if (AvgThree < original_grade)
                {
                    Console.WriteLine("bad");
                }
                Console.WriteLine("average School " + SchoolName3 + " = {0}",AvgThree);
                Console.WriteLine("excellent = {0} \n very good = {1}\n good = {2}\n pass = {3}\n fail = {4}",
                    excellent, VeryGood, good, pass, fail);
            } // if (SchoolName3 == SchoolThree)


            Console.WriteLine("****Enter name of School plz****");
            string SchoolName4 = Console.ReadLine();
            if (SchoolName4 == SchoolOne || SchoolName4 == SchoolTwo || SchoolName4 == SchoolThree ||
                 SchoolName4 == SchoolFour || SchoolName4 == SchoolFive)
            {

                int TotalSalary = 0;
                int DegreeOne = 0;
                int DegreeTwo = 0;
                int DegreeThree = 0;
                int DegreeFour = 0;

                Console.WriteLine("**** Enter number of Teacher plz");
                TeacherNumber4 = int.Parse(Console.ReadLine());


                for (int i = 1; i <= TeacherNumber4; i++)
                {
                    Console.WriteLine("Enter Teacher name plz");
                    string name = Console.ReadLine();
                    Console.WriteLine(" Enter the Salary plz");
                    int salary = int.Parse(Console.ReadLine());
                    TotalSalary += salary;
                    if (salary >= 10000)
                    {
                        Console.WriteLine(" Degree One");
                        DegreeOne++;
                    }
                    else if (salary >= 7000 && salary < 10000)
                    {
                        Console.WriteLine(" Degree Two");
                        DegreeTwo++;
                    }
                    else if (salary >= 5000 && salary < 7000)
                    {
                        Console.WriteLine(" Degree Three");
                        DegreeThree++;
                    }
                    else if (salary >= 1000 && salary < 5000)
                    {
                        Console.WriteLine(" Degree Four");
                        DegreeFour++;
                    }
                    else
                    {
                        Console.WriteLine(" Sory");
                    }
                }//for (int i=0; i<= TeacherNumber; i++) {

                Console.WriteLine("The Number of Teachers of school " + SchoolName4 + "= " + TeacherNumber4);
                int SalaryAvgFour = TotalSalary / TeacherNumber4;
                Console.WriteLine("THe average of salary for" + SchoolName4 + "=" + SalaryAvgFour);
                Console.WriteLine("Degree one = {0} \n Degree Two = {1}\n Degree Three = {2}\n Degree Four = {3}",
                   DegreeOne, DegreeTwo, DegreeThree, DegreeFour);


                Console.WriteLine("****************************************************************");


                Console.WriteLine("enter num of std plz");
                NumberStudents4 = int.Parse(Console.ReadLine());
                int x = 1;

                int TotalGrade = 0;
                int excellent = 0;
                int VeryGood = 0;
                int good = 0;
                int pass = 0;
                int fail = 0;

                do
                {


                    Console.WriteLine("enter ur name plz");
                    string name = Console.ReadLine();
                    Console.WriteLine("enter ur grade plz");
                    int grade = int.Parse(Console.ReadLine());
                    TotalGrade += grade;
                    if (grade > 90 && grade <= 100)
                    {
                        Console.WriteLine("Excellent");
                        excellent++;
                    }
                    else if (grade > 80 && grade <= 90)
                    {
                        Console.WriteLine("VeryGood");
                        VeryGood++;
                    }
                    else if (grade > 70 && grade <= 80)
                    {
                        Console.WriteLine("Good");
                        good++;
                    }
                    else if (grade > 49 && grade <= 70)
                    {
                        Console.WriteLine("Pass");
                        pass++;
                    }
                    else
                    {
                        Console.WriteLine("sorry");
                        fail++;
                    }
                    x++;
                }  //for (int x = 0; x < NumberStudents; x++)
                while (x <= NumberStudents4);
                Console.WriteLine("The name of school is  " + SchoolName4);
                Console.WriteLine("The Number of Students of school " + SchoolName4 + "= " + NumberStudents4);
                AvgFour = TotalGrade / NumberStudents4;

                int original_grade = 100;
                if (AvgFour >= original_grade)
                {
                    Console.WriteLine("Good");
                }
                if (AvgFour < original_grade)
                {
                    Console.WriteLine("bad");
                }
                Console.WriteLine("average School " + SchoolName4 + " = {0}", AvgFour);
                Console.WriteLine("excellent = {0} \n very good = {1}\n good = {2}\n pass = {3}\n fail = {4}",
                    excellent, VeryGood, good, pass, fail);
            } // if (SchoolName4 == SchoolTwo)

            Console.WriteLine("****Enter name of School plz****");
            string SchoolName5 = Console.ReadLine();
            if (SchoolName5 == SchoolOne || SchoolName5 == SchoolTwo || SchoolName5 == SchoolThree ||
                 SchoolName5 == SchoolFour || SchoolName5 == SchoolFive)
            {
                int TotalSalary = 0;
                int DegreeOne = 0;
                int DegreeTwo = 0;
                int DegreeThree = 0;
                int DegreeFour = 0;
                Console.WriteLine("**** Enter number of Teacher plz");
                TeacherNumber5 = int.Parse(Console.ReadLine());


                for (int i = 1; i <= TeacherNumber5; i++)
                {
                    Console.WriteLine("Enter Teacher name plz");
                    string name = Console.ReadLine();
                    Console.WriteLine(" Enter the Salary plz");
                    int salary = int.Parse(Console.ReadLine());
                    TotalSalary += salary;
                    if (salary >= 10000)
                    {
                        Console.WriteLine(" Degree One");
                        DegreeOne++;
                    }
                    else if (salary >= 7000 && salary < 10000)
                    {
                        Console.WriteLine(" Degree Two");
                        DegreeTwo++;
                    }
                    else if (salary >= 5000 && salary < 7000)
                    {
                        Console.WriteLine(" Degree Three");
                        DegreeThree++;
                    }
                    else if (salary >= 1000 && salary < 5000)
                    {
                        Console.WriteLine(" Degree Four");
                        DegreeFour++;
                    }
                    else
                    {
                        Console.WriteLine(" Sory");
                    }
                }//for (int i=0; i<= TeacherNumber; i++) {

                Console.WriteLine("The Number of Teachers of school " + SchoolName5 + "= " + TeacherNumber5);
                int SalaryAvgFive = TotalSalary / TeacherNumber5;
                Console.WriteLine("THe average of salary for" + SchoolName5 + "=" + SalaryAvgFive);
                Console.WriteLine("Degree one = {0} \n Degree Two = {1}\n Degree Three = {2}\n Degree Four = {3}",
                   DegreeOne, DegreeTwo, DegreeThree, DegreeFour);


                Console.WriteLine("****************************************************************");

                Console.WriteLine("enter num of std plz");
                NumberStudents5 = int.Parse(Console.ReadLine());
                int x = 1;

                int TotalGrade = 0;
                int excellent = 0;
                int VeryGood = 0;
                int good = 0;
                int pass = 0;
                int fail = 0;

                do
                {


                    Console.WriteLine("enter ur name plz");
                    string name = Console.ReadLine();
                    Console.WriteLine("enter ur grade plz");
                    int grade = int.Parse(Console.ReadLine());
                    TotalGrade += grade;
                    if (grade > 90 && grade <= 100)
                    {
                        Console.WriteLine("Excellent");
                        excellent++;
                    }
                    else if (grade > 80 && grade <= 90)
                    {
                        Console.WriteLine("VeryGood");
                        VeryGood++;
                    }
                    else if (grade > 70 && grade <= 80)
                    {
                        Console.WriteLine("Good");
                        good++;
                    }
                    else if (grade > 49 && grade <= 70)
                    {
                        Console.WriteLine("Pass");
                        pass++;
                    }
                    else
                    {
                        Console.WriteLine("sorry");
                        fail++;
                    }
                    x++;
                }  //for (int x = 0; x < NumberStudents; x++)
                while (x <= NumberStudents5);
                Console.WriteLine("The name of school is  " + SchoolName5);
                Console.WriteLine("The Number of Students of school " + SchoolName5 + "= " + NumberStudents5);
                AvgFive = TotalGrade / NumberStudents5;

                int original_grade = 100;
                if (AvgFive >= original_grade)
                {
                    Console.WriteLine("Good");
                }
                if (AvgFive < original_grade)
                {
                    Console.WriteLine("bad");
                }
                Console.WriteLine("average School " + SchoolName5 + " = {0}", AvgFive);
                Console.WriteLine("excellent = {0} \n very good = {1}\n good = {2}\n pass = {3}\n fail = {4}",
                    excellent, VeryGood, good, pass, fail);
            } // if (SchoolName1 == SchoolTwo)


            if ((AvgOne >= AvgTwo) && (AvgOne >= AvgThree) && (AvgOne >= AvgFour) && (AvgOne >= AvgFive))
            {
                Console.WriteLine("The better School is: {0}", SchoolName);
                Console.WriteLine("   ****************        ****************        ****************        **************              ");
                Console.WriteLine("   ****************        ****************        ****************        ****************");
                Console.WriteLine("   ***          ***        ***          ***        ***          ***        ***             ****");
                Console.WriteLine("   ***          ***        ***          ***        ***          ***        ***              ****");
                Console.WriteLine("   ***                     ***          ***        ***          ***        ***               ****");
                Console.WriteLine("   ***                     ***          ***        ***          ***        ***                **** ");
                Console.WriteLine("   ***                     ***          ***        ***          ***        ***                 ****              ");
                Console.WriteLine("   ***        *******      ***          ***        ***          ***        ***                 ****");
                Console.WriteLine("   ***        *******      ***          ***        ***          ***        ***                 ****");
                Console.WriteLine("   ***        *******      ***          ***        ***          ***        ***                ****");
                Console.WriteLine("   ***          ***        ***          ***        ***          ***        ***               ****");
                Console.WriteLine("   ***          ***        ***          ***        ***          ***        ***              ****");
                Console.WriteLine("   ***          ***        ***          ***        ***          ***        ***             ****");
                Console.WriteLine("   ***          ***        ***          ***        ***          ***        ***            ****");
                Console.WriteLine("   ****************        ****************        ****************        ******************");
                Console.WriteLine("   ****************        ****************        ****************        ****************");

                
                
                
            }
            if ((AvgTwo >= AvgOne) && (AvgTwo >= AvgThree) && (AvgTwo >= AvgFour) && (AvgTwo >= AvgFive))
            {
                Console.WriteLine("The better School is: {0} ", SchoolName2);
                Console.WriteLine("   ****************        ****************        ****************        **************              ");
                Console.WriteLine("   ****************        ****************        ****************        ****************");
                Console.WriteLine("   ***          ***        ***          ***        ***          ***        ***             ****");
                Console.WriteLine("   ***          ***        ***          ***        ***          ***        ***              ****");
                Console.WriteLine("   ***                     ***          ***        ***          ***        ***               ****");
                Console.WriteLine("   ***                     ***          ***        ***          ***        ***                **** ");
                Console.WriteLine("   ***                     ***          ***        ***          ***        ***                 ****              ");
                Console.WriteLine("   ***        *******      ***          ***        ***          ***        ***                 ****");
                Console.WriteLine("   ***        *******      ***          ***        ***          ***        ***                 ****");
                Console.WriteLine("   ***        *******      ***          ***        ***          ***        ***                ****");
                Console.WriteLine("   ***          ***        ***          ***        ***          ***        ***               ****");
                Console.WriteLine("   ***          ***        ***          ***        ***          ***        ***              ****");
                Console.WriteLine("   ***          ***        ***          ***        ***          ***        ***             ****");
                Console.WriteLine("   ***          ***        ***          ***        ***          ***        ***            ****");
                Console.WriteLine("   ****************        ****************        ****************        ******************");
                Console.WriteLine("   ****************        ****************        ****************        ****************");
               
                

            }
            if ((AvgThree >= AvgOne) && (AvgThree >= AvgTwo) && (AvgThree >= AvgFour) && (AvgThree >= AvgFive))
            {
                Console.WriteLine("The better School is: {0} ", SchoolName3);
                Console.WriteLine("   ****************        ****************        ****************        **************              ");
                Console.WriteLine("   ****************        ****************        ****************        ****************");
                Console.WriteLine("   ***          ***        ***          ***        ***          ***        ***             ****");
                Console.WriteLine("   ***          ***        ***          ***        ***          ***        ***              ****");
                Console.WriteLine("   ***                     ***          ***        ***          ***        ***               ****");
                Console.WriteLine("   ***                     ***          ***        ***          ***        ***                **** ");
                Console.WriteLine("   ***                     ***          ***        ***          ***        ***                 ****              ");
                Console.WriteLine("   ***        *******      ***          ***        ***          ***        ***                 ****");
                Console.WriteLine("   ***        *******      ***          ***        ***          ***        ***                 ****");
                Console.WriteLine("   ***        *******      ***          ***        ***          ***        ***                ****");
                Console.WriteLine("   ***          ***        ***          ***        ***          ***        ***               ****");
                Console.WriteLine("   ***          ***        ***          ***        ***          ***        ***              ****");
                Console.WriteLine("   ***          ***        ***          ***        ***          ***        ***             ****");
                Console.WriteLine("   ***          ***        ***          ***        ***          ***        ***            ****");
                Console.WriteLine("   ****************        ****************        ****************        ******************");
                Console.WriteLine("   ****************        ****************        ****************        ****************");

                
                

            }
            if ((AvgFour >= AvgOne) && (AvgFour >= AvgTwo) && (AvgFour >= AvgThree) && (AvgFour >= AvgFive))
            {
                Console.WriteLine("The better School is: {0} ", SchoolName4);
                Console.WriteLine("   ****************        ****************        ****************        **************              ");
                Console.WriteLine("   ****************        ****************        ****************        ****************");
                Console.WriteLine("   ***          ***        ***          ***        ***          ***        ***             ****");
                Console.WriteLine("   ***          ***        ***          ***        ***          ***        ***              ****");
                Console.WriteLine("   ***                     ***          ***        ***          ***        ***               ****");
                Console.WriteLine("   ***                     ***          ***        ***          ***        ***                **** ");
                Console.WriteLine("   ***                     ***          ***        ***          ***        ***                 ****              ");
                Console.WriteLine("   ***        *******      ***          ***        ***          ***        ***                 ****");
                Console.WriteLine("   ***        *******      ***          ***        ***          ***        ***                 ****");
                Console.WriteLine("   ***        *******      ***          ***        ***          ***        ***                ****");
                Console.WriteLine("   ***          ***        ***          ***        ***          ***        ***               ****");
                Console.WriteLine("   ***          ***        ***          ***        ***          ***        ***              ****");
                Console.WriteLine("   ***          ***        ***          ***        ***          ***        ***             ****");
                Console.WriteLine("   ***          ***        ***          ***        ***          ***        ***            ****");
                Console.WriteLine("   ****************        ****************        ****************        ******************");
                Console.WriteLine("   ****************        ****************        ****************        ****************");
                

                
            }

          
            if ((AvgFive >= AvgOne) && (AvgFive >= AvgTwo) && (AvgFive >= AvgThree) && (AvgFive >= AvgFour))
            {
                Console.WriteLine("The better School is: {0} ", SchoolName3);
                Console.WriteLine("   ****************        ****************        ****************        **************              ");
                Console.WriteLine("   ****************        ****************        ****************        ****************");
                Console.WriteLine("   ***          ***        ***          ***        ***          ***        ***             ****");
                Console.WriteLine("   ***          ***        ***          ***        ***          ***        ***              ****");
                Console.WriteLine("   ***                     ***          ***        ***          ***        ***               ****");
                Console.WriteLine("   ***                     ***          ***        ***          ***        ***                **** ");
                Console.WriteLine("   ***                     ***          ***        ***          ***        ***                 ****              ");
                Console.WriteLine("   ***        *******      ***          ***        ***          ***        ***                 ****");
                Console.WriteLine("   ***        *******      ***          ***        ***          ***        ***                 ****");
                Console.WriteLine("   ***        *******      ***          ***        ***          ***        ***                ****");
                Console.WriteLine("   ***          ***        ***          ***        ***          ***        ***               ****");
                Console.WriteLine("   ***          ***        ***          ***        ***          ***        ***              ****");
                Console.WriteLine("   ***          ***        ***          ***        ***          ***        ***             ****");
                Console.WriteLine("   ***          ***        ***          ***        ***          ***        ***            ****");
                Console.WriteLine("   ****************        ****************        ****************        ******************");
                Console.WriteLine("   ****************        ****************        ****************        ****************");

              
               
               
            }

            Console.WriteLine("----------------------------------------------------------------------------------------------");
            if ((AvgOne <= AvgTwo) && (AvgOne <= AvgThree) && (AvgOne <= AvgFour) && (AvgOne <= AvgFive))
            {
                Console.WriteLine("The worest School is: {0} ", SchoolName);

                Console.WriteLine("   ****************                           *                          **************              ");
                Console.WriteLine("   ****************                          ***                         ****************");
                Console.WriteLine("   ***             ***                      *****                        ***             ****");
                Console.WriteLine("   ***              ***                    *******                       ***              ****");
                Console.WriteLine("   ***                ***                 *********                      ***               ****");
                Console.WriteLine("   ***               ***                 ***     ***                     ***                **** ");
                Console.WriteLine("   ***              ***                 ***       ***                    ***                 ****              ");
                Console.WriteLine("   ******************                  ***         ***                   ***                 ****");
                Console.WriteLine("   ******************                 *****************                  ***                 ****");
                Console.WriteLine("   ***             ***               *******************                 ***                ****");
                Console.WriteLine("   ***              ***             ***               ***                ***               ****");
                Console.WriteLine("   ***                ***          ***                 ***               ***              ****");
                Console.WriteLine("   ***               ***          ***                   ***              ***             ****");
                Console.WriteLine("   ***              ***          ***                     ***             ***            ****");
                Console.WriteLine("   ****************             ***                       ***            ******************");
                Console.WriteLine("   ****************            ***                          ***          ****************");

                Console.Read();
                return;

            }
            
            if ((AvgTwo <= AvgOne) && (AvgTwo <= AvgThree) && (AvgTwo <= AvgFour) && (AvgTwo <= AvgFive))
            {
                Console.WriteLine("The worest School is: {0} ", SchoolName2);
                
                Console.WriteLine("   ****************                           *                          **************              ");
                Console.WriteLine("   ****************                          ***                         ****************");
                Console.WriteLine("   ***             ***                      *****                        ***             ****");
                Console.WriteLine("   ***              ***                    *******                       ***              ****");
                Console.WriteLine("   ***                ***                 *********                      ***               ****");
                Console.WriteLine("   ***               ***                 ***     ***                     ***                **** ");
                Console.WriteLine("   ***              ***                 ***       ***                    ***                 ****              ");
                Console.WriteLine("   ******************                  ***         ***                   ***                 ****");
                Console.WriteLine("   ******************                 *****************                  ***                 ****");
                Console.WriteLine("   ***             ***               *******************                 ***                ****");
                Console.WriteLine("   ***              ***             ***               ***                ***               ****");
                Console.WriteLine("   ***                ***          ***                 ***               ***              ****");
                Console.WriteLine("   ***               ***          ***                   ***              ***             ****");
                Console.WriteLine("   ***              ***          ***                     ***             ***            ****");
                Console.WriteLine("   ****************             ***                       ***            ******************");
                Console.WriteLine("   ****************            ***                          ***          ****************");

                Console.ReadLine();
                return;
            }
            if ((AvgThree <= AvgOne) && (AvgThree <= AvgTwo) && (AvgThree <= AvgFour) && (AvgThree <= AvgFive))
            {
                Console.WriteLine("The worest School is: {0} ", SchoolName3);
                
                Console.WriteLine("   ****************                           *                          **************              ");
                Console.WriteLine("   ****************                          ***                         ****************");
                Console.WriteLine("   ***             ***                      *****                        ***             ****");
                Console.WriteLine("   ***              ***                    *******                       ***              ****");
                Console.WriteLine("   ***                ***                 *********                      ***               ****");
                Console.WriteLine("   ***               ***                 ***     ***                     ***                **** ");
                Console.WriteLine("   ***              ***                 ***       ***                    ***                 ****              ");
                Console.WriteLine("   ******************                  ***         ***                   ***                 ****");
                Console.WriteLine("   ******************                 *****************                  ***                 ****");
                Console.WriteLine("   ***             ***               *******************                 ***                ****");
                Console.WriteLine("   ***              ***             ***               ***                ***               ****");
                Console.WriteLine("   ***                ***          ***                 ***               ***              ****");
                Console.WriteLine("   ***               ***          ***                   ***              ***             ****");
                Console.WriteLine("   ***              ***          ***                     ***             ***            ****");
                Console.WriteLine("   ****************             ***                       ***            ******************");
                Console.WriteLine("   ****************            ***                          ***          ****************");

                Console.ReadLine();
                return;
            }
            if ((AvgFour <= AvgOne) && (AvgFour <= AvgTwo) && (AvgFour <= AvgThree) && (AvgFour <= AvgFive))
            {
                Console.WriteLine("The worest School is: {0} ", SchoolName4);
              
                Console.WriteLine("   ****************                           *                          **************              ");
                Console.WriteLine("   ****************                          ***                         ****************");
                Console.WriteLine("   ***             ***                      *****                        ***             ****");
                Console.WriteLine("   ***              ***                    *******                       ***              ****");
                Console.WriteLine("   ***                ***                 *********                      ***               ****");
                Console.WriteLine("   ***               ***                 ***     ***                     ***                **** ");
                Console.WriteLine("   ***              ***                 ***       ***                    ***                 ****              ");
                Console.WriteLine("   ******************                  ***         ***                   ***                 ****");
                Console.WriteLine("   ******************                 *****************                  ***                 ****");
                Console.WriteLine("   ***             ***               *******************                 ***                ****");
                Console.WriteLine("   ***              ***             ***               ***                ***               ****");
                Console.WriteLine("   ***                ***          ***                 ***               ***              ****");
                Console.WriteLine("   ***               ***          ***                   ***              ***             ****");
                Console.WriteLine("   ***              ***          ***                     ***             ***            ****");
                Console.WriteLine("   ****************             ***                       ***            ******************");
                Console.WriteLine("   ****************            ***                          ***          ****************");

                Console.ReadLine();
                return;
            }


            if ((AvgFive <= AvgOne) && (AvgFive <= AvgTwo) && (AvgFive <= AvgThree) && (AvgFive <= AvgFour))
            {
                Console.WriteLine("The worest School is: {0} ", SchoolName5);
                Console.WriteLine("   ****************                           *                          **************              ");
                Console.WriteLine("   ****************                          ***                         ****************");
                Console.WriteLine("   ***             ***                      *****                        ***             ****");
                Console.WriteLine("   ***              ***                    *******                       ***              ****");
                Console.WriteLine("   ***                ***                 *********                      ***               ****");
                Console.WriteLine("   ***               ***                 ***     ***                     ***                **** ");
                Console.WriteLine("   ***              ***                 ***       ***                    ***                 ****              ");
                Console.WriteLine("   ******************                  ***         ***                   ***                 ****");
                Console.WriteLine("   ******************                 *****************                  ***                 ****");
                Console.WriteLine("   ***             ***               *******************                 ***                ****");
                Console.WriteLine("   ***              ***             ***               ***                ***               ****");
                Console.WriteLine("   ***                ***          ***                 ***               ***              ****");
                Console.WriteLine("   ***               ***          ***                   ***              ***             ****");
                Console.WriteLine("   ***              ***          ***                     ***             ***            ****");
                Console.WriteLine("   ****************             ***                       ***            ******************");
                Console.WriteLine("   ****************            ***                          ***          ****************");

                Console.ReadLine();
                return;



            }





        }
    }
}
