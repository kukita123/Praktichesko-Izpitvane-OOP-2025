namespace Primer
{
    internal class Program
    {
        public static double OutputIBM(Patient patient)
        {
            return (double)patient.Weight / Math.Pow(patient.Height, 2);
        }

        public static void OutputMessage(Patient patient)
        {
            double mess = patient.Height * 100 - patient.Weight;
            if (mess >= 90 && mess <= 120)
                Console.WriteLine("Patient {0}: Normal weight.", patient.Name);
            else if (mess > 120)
                Console.WriteLine("Patient {0}: Risk of underweight", patient.Name);
            else if (mess < 90)
                Console.WriteLine("Patient {0}: Risk of being overweight", patient.Name);
        }

        public static int CountPatient(Patient[] patients)
        {
            int count = 0;
            for (int i = 0; i < patients.Length; i++)
            {
                if (patients[i].Height >= 1.7)
                    count++;
            }
            return count;
        }
        static void Main(string[] args)
        {
            Random r = new Random();
            int n = r.Next(3, 10);
            
            Patient[] patients = new Patient[n];
            for (int i = 0; i < patients.Length; i++)
            {
                patients[i] = new Patient();
            }
            for (int i = 0; i < patients.Length; i++)
            {
                Console.WriteLine("Enter patient number");
                patients[i].Number = int.Parse(Console.ReadLine());
                Console.WriteLine("Enter patient name");
                patients[i].Name = Console.ReadLine();
                Console.WriteLine("Enter patient weight");
                patients[i].Weight = int.Parse(Console.ReadLine());
                Console.WriteLine("Enter patient height");
                patients[i].Height = double.Parse(Console.ReadLine());
            }

            Console.WriteLine("These are the patients:");
            for (int i = 0; i < patients.Length; i++)
            {
                patients[i].PrintPatient();
            }

            Console.WriteLine("Enter patient number to display IBM");
            int ibm = int.Parse(Console.ReadLine());
            for (int i = 0; i < patients.Length; i++)
            {
                if (patients[i].Number == ibm)
                {
                    Console.WriteLine("IBM of patient {0} is {1:f2}", patients[i].Name, OutputIBM(patients[i]));
                    OutputMessage(patients[i]);
                }
            }
            Console.WriteLine("Number of patients with height over 1.70 are: {0}", CountPatient(patients));
        }
    }
}
