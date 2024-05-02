class Program
{
    static void Main(string[] args)
    {
        Job EzraJob = new Job();
        EzraJob._jobTitle = " Dental Receptionist";
        EzraJob._company = "Comfort Dental";
        EzraJob._startYear = 2019;
        EzraJob._endYear = 2021;


        Job EzraJob2 = new Job();
        EzraJob2._jobTitle = "Manager";
        EzraJob2._company = "McDonalds";
        EzraJob2._startYear = 2003;
        EzraJob2._endYear = 2023;

        Resume myResume = new Resume();
        myResume._name = "Ezra Crandall";

        myResume._jobs.Add(EzraJob);
        myResume._jobs.Add(EzraJob2);

        myResume.Display();
    }
}