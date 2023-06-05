namespace Anket.winforms
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            Application.Run(new Form1());
        }
    }
    public class Human
    {

        public string Name { get; set; }    
        public string Surname { get; set; }    
        public string FatherName { get; set; }    
        public string Country { get; set; }    
        public string City { get; set; }    
        public string Phone { get; set; }    
        public DateTime BirthdayDate { get; set; }    
        public string Gender { get; set; }    

        public Human(string name, string surname, string fatherName, string country, string city, string phone, DateTime birthdayDate, string gender)
        {
            Name=name;
            Surname=surname;
            FatherName=fatherName;
            Country=country;
            City=city;
            Phone=phone;
            BirthdayDate=birthdayDate;
            Gender=gender;
        }

    }
}