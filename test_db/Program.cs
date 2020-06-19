using System;
using System.Collections.Generic;
using System.Linq;
using VK.Repository;

namespace test_db
{
    class Program
    {
        static void Main(string[] args)
        {
            var s = "Server=localhost;Port=5432;User Id=postgres;Password=1;Database=postgres;Timeout=300;CommandTimeout=300;";

            var a = new RepositoryOutputVK(s);

            var b = new RepositoryInputFileVK(null);

            var c = b.GetPersons("1.txt");

            foreach (var item in c)
            {
                try
                {
                    a.CreateUser(item, "1.txt");

                    if (item.HasPhoto == 1)
                    {
                        a.CreatePhote(item);
                    }

                    if (item.Careers != null && item.Careers.Any())
                    {
                        a.CreateCareer(item);
                    }

                    if (item.Military != null && item.Military.Any())
                    {
                        a.CreateMilitary(item);
                    }

                    if (item.RelationPartner != null)
                    {
                        a.CreateRelationPartner(item);
                    }

                    if (item.Relatives != null && item.Relatives.Any())
                    {
                        a.CreateRelation(item);
                    }

                    if (item.Schools != null && item.Schools.Any())
                    {
                        a.CreateSchool(item);
                    }

                    // Там есть отдельно один универ, его наверно надо запихнуть в коллекцию

                    if (item.University != 0 && !string.IsNullOrEmpty(item.UniversityName)
                        && item.Faculty != 0 && !string.IsNullOrEmpty(item.FacultyName) && item.Graduation != 0
                        && !string.IsNullOrEmpty(item.EducationForm) && !string.IsNullOrEmpty(item.EducationStatus))
                    {
                        if (item.Universities == null) item.Universities = new List<VK.Data.University>();

                        item.Universities.Add(new VK.Data.University()
                        {
                            Id = item.University,
                            Name = item.UniversityName,
                            Faculty = item.Faculty,
                            FacultyName = item.FacultyName,
                            Graduation = item.Graduation,
                            EducationForm = item.EducationForm,
                            EducationStatus = item.EducationStatus
                        });
                    }

                    if (item.Universities != null && item.Universities.Any())
                    {
                        a.CreateUniversity(item);
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"{item.Id} Error: {ex.Message}");
                }

            }

            Console.WriteLine("Ok");
            Console.ReadLine();
        }
    }
}