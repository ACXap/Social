using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Security;
using vkpars.Data;
using vkpars.Repository;
using vkpars.Service;

namespace vkpars
{
    class Program
    {
        private static readonly string _folder = Path.Combine(Directory.GetCurrentDirectory(), "Data");
        private static ILogger _logger;
        private static IRepositoryInputVK _repInput;
        private static IRepositoryOutputVK _repOutput;

        static void Main(string[] args)
        {
            StartMessage();

            ConnectDB();

            Console.WriteLine(new string('-', 100));

            List<string> files = GetFiles().ToList();


            var startTime = DateTime.Now;
            Console.WriteLine($"Начало обработки: {startTime}");

            foreach (var item in files)
            {
                Console.WriteLine(new string('-', 100));
                Console.WriteLine($"Файл: {item}");

                var persons = _repInput.GetPersons(item);

                //ProcessInput(persons, item);

                ProcessCopy(persons, item);
            }

            Console.WriteLine(new string('-', 100));
            var stopTime = DateTime.Now;
            Console.WriteLine($"Окончание обработки: {stopTime}");
            Console.WriteLine($"Затрачено (сек): {(stopTime - startTime).TotalSeconds}");

            ExitMessage();
        }

        private static void StartMessage()
        {
            Console.WriteLine("Добро пожаловать");
            Console.WriteLine($"Для работы с файлами, разместите их в папку: {_folder} (txt, csv)");
            Console.WriteLine($"А так же указать настройки подключения в файле: {Path.Combine(Directory.GetCurrentDirectory(), "set.ini")}");

            Console.WriteLine(new string('-', 100));
        }

        private static void ConnectDB()
        {
            while (true)
            {
                try
                {

                    Init(GetSettings());
                    Console.Write($"Проверка соединения...");
                    Console.WriteLine(_repOutput.CheckConnect());
                    break;
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                    Console.WriteLine("Проверьте настройки подключения. И попробуйте снова");
                }
            }
        }

        private static IEnumerable<string> GetFiles()
        {
            try
            {
                var files = Directory.GetFiles(_folder ).Where(x=>x.EndsWith(".txt") || x.EndsWith(".csv") );
                Console.WriteLine($"Всего файлов для обработки: {files.Count()}");
                return files;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                ExitMessage();
                Environment.Exit(-1);
            }

            return null;
        }

        private static void ProcessUniver(List<EntityPerson> persons)
        {
            foreach (var person in persons)
            {
                if (person.University != 0 && !string.IsNullOrEmpty(person.UniversityName)
                        && person.Faculty != 0 && !string.IsNullOrEmpty(person.FacultyName) && person.Graduation != 0
                        && !string.IsNullOrEmpty(person.EducationForm) && !string.IsNullOrEmpty(person.EducationStatus))
                {
                    if (person.Universities == null) person.Universities = new List<University>();

                    person.Universities.Add(new University()
                    {
                        Id = person.University,
                        Name = person.UniversityName,
                        Faculty = person.Faculty,
                        FacultyName = person.FacultyName,
                        Graduation = person.Graduation,
                        EducationForm = person.EducationForm,
                        EducationStatus = person.EducationStatus
                    });
                }
            }
        }

        private static void ProcessCopy(List<EntityPerson> persons, string file)
        {
            ProcessUniver(persons);

            try
            {
                _repOutput.CreateUser(persons, file);
                _repOutput.CreatePhote(persons);
                _repOutput.CreateCareer(persons);
                _repOutput.CreateMilitary(persons);
                _repOutput.CreateRelationPartner(persons);
                _repOutput.CreateRelation(persons);
                _repOutput.CreateSchool(persons);
                _repOutput.CreateUniversity(persons);
            }
            catch (Exception ex)
            {
                var log = $"{file} Error: {ex.Message}";
                _logger.AddLog(log);
                Console.WriteLine(log);
            }
        }

        private static void ProcessInput(List<EntityPerson> persons, string file)
        {
            ProcessUniver(persons);

            foreach (var person in persons)
            {
                try
                {
                    _repOutput.CreateUser(person, file);

                    if (person.HasPhoto == 1)
                    {
                        _repOutput.CreatePhote(person);
                    }

                    if (person.Careers != null && person.Careers.Any())
                    {
                        _repOutput.CreateCareer(person);
                    }

                    if (person.Military != null && person.Military.Any())
                    {
                        _repOutput.CreateMilitary(person);
                    }

                    if (person.RelationPartner != null)
                    {
                        _repOutput.CreateRelationPartner(person);
                    }

                    if (person.Relatives != null && person.Relatives.Any())
                    {
                        _repOutput.CreateRelation(person);
                    }

                    if (person.Schools != null && person.Schools.Any())
                    {
                        _repOutput.CreateSchool(person);
                    }

                    if (person.Universities != null && person.Universities.Any())
                    {
                        _repOutput.CreateUniversity(person);

                    }
                }
                catch (Exception ex)
                {
                    var log = $"{person.Id} Error: {ex.Message}";
                    _logger.AddLog(log);
                    Console.WriteLine(log);
                }
            }
        }

        private static void Init(SettingsConnect set)
        {
            var c = set.GetConnectString();


            _logger = new LoggerFile();
            _repInput = new RepositoryInputFileVK(_logger);
            _repOutput = new RepositoryOutputVK(set, _logger);
        }

        private static SettingsConnect GetSettings()
        {
            var str = File.ReadAllLines("set.ini");

            var user = str[2].Split('=')[1].Trim();
            Console.WriteLine($"Пользователь: {user}");

            return new SettingsConnect()
            {
                Server = str[0].Split('=')[1].Trim(),
                Port = int.Parse(str[1].Split('=')[1].Trim()),
                UserId = user,
                Database = str[3].Split('=')[1].Trim(),
                Timeout = int.Parse(str[4].Split('=')[1].Trim()),
                CommandTimeout = int.Parse(str[4].Split('=')[1].Trim()),
                Password = GetPass()
            };
        }

        private static void ExitMessage()
        {
            Console.WriteLine("Для выхода, нажмите любую клавишу");
            Console.ReadKey();
        }

        private static SecureString GetPass()
        {
            Console.Write("Пароль к базе данных:");
            SecureString pass = new SecureString();
            do
            {
                ConsoleKeyInfo key = Console.ReadKey(true);
                if (key.Key != ConsoleKey.Backspace && key.Key != ConsoleKey.Enter)
                {
                    pass.AppendChar(key.KeyChar);
                    Console.Write("*");
                }
                else
                {
                    if (key.Key == ConsoleKey.Backspace)
                    {
                        pass.Clear();
                        Console.Clear();
                        Console.Write("Пароль к базе данных:");
                    }
                    else if (key.Key == ConsoleKey.Enter)
                    {
                        Console.WriteLine();
                        break;
                    }
                }
            } while (true);

            return pass;
        }
    }
}