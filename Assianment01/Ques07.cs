using System;

public class Patient
{
    // Static variable shared among all patients
    public static string HospitalName = "City General Hospital";

    // Static variable to keep track of total patients
    public static int TotalPatients = 0;

    // Readonly variable to uniquely identify each patient
    public readonly string PatientID;

    // Instance variables for patient details
    public string Name { get; set; }
    public int Age { get; set; }
    public string Ailment { get; set; }

    // Constructor to initialize Name, Age, Ailment, and PatientID
    public Patient(string name, int age, string ailment)
    {
        this.Name = name;
        this.Age = age;
        this.Ailment = ailment;

        // Assigning unique PatientID
        this.PatientID = Guid.NewGuid().ToString();
        
        // Incrementing the total patient count
        TotalPatients++;
    }

    // Static method to get the total number of patients admitted
    public static int GetTotalPatients()
    {
        return TotalPatients;
    }

    // Method to display patient details
    public void DisplayPatientDetails()
    {
        Console.WriteLine("Hospital Name: " + HospitalName);
        Console.WriteLine("Patient Name: " + Name);
        Console.WriteLine("Patient Age: " + Age);
        Console.WriteLine("Patient Ailment: " + Ailment);
        Console.WriteLine("Patient ID: " + PatientID);
    }
}

class Program
{
    static void Main(string[] args)
    {
        Patient patient1 = new Patient("Shivam", 45, "Fever");
        Patient patient2 = new Patient("Shivani", 30, "Headache");

        if (patient1 is Patient)
        {
            patient1.DisplayPatientDetails();
        }

        if (patient2 is Patient)
        {
            patient2.DisplayPatientDetails();
        }

        Console.WriteLine("Total Patients Admitted: " + Patient.GetTotalPatients());
    }
}
