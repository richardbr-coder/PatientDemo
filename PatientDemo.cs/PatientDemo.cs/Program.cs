using System;
using static System.Console;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatientDemo.cs
{
    class Program
    {
        static void Main(string[] args)
        {
            Patient[] patientAry = new Patient[5];

            for (int i = 0; i < 5; i++)
            {
                patientAry[i] = new Patient();

                WriteLine("Enter Patient Id");
                patientAry[i].IdNumb = Convert.ToInt32(ReadLine());

                WriteLine("Enter Patient Name");
                patientAry[i].Name = ReadLine();

                WriteLine("Enter Patient Age");
                patientAry[i].Age = Convert.ToInt32(ReadLine());

                WriteLine("Enter Amount Due");
                patientAry[i].AmountDue = Convert.ToDouble(ReadLine());

            }

            //Sort patient
            for (int x = 0; x < 5; x++)
            {
                for (int y = 0; y < 5; y++)
                {
                    if (patientAry[x].IdNumb > patientAry[y].IdNumb)
                    {
                        Patient temp = patientAry[y];
                        patientAry[y] = patientAry[x];
                        patientAry[x] = temp;
                    }
                }
            }

            //display
            for (int kk = 0; kk < 5; kk++)
            {
                WriteLine(patientAry[kk].ToString());
            }
            ReadLine();
        }

    }
}
    

    public class Patient
    {
        private int idNumb;
        private string name;
        private int age;
        private double amountDue;

        public int IdNumb{ get { return idNumb; } set { idNumb = value; } }
        public string Name { get { return name; } set { name = value;} }
        public int Age { get { return age; } set { age = value; } }
        public double AmountDue { get { return amountDue; } set { amountDue = value; } }//this is the amount due to the hospital

        public override string ToString()
        {
            string details = "Patient name: " + name + "\n";
            details += "Patient ID number: " + idNumb + "\n";
            details += "Patient age: " + age + "\n";
            details += "Patient amount due: " + amountDue + "\n";
            return details;
        } 
    }

    

