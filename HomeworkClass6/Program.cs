using HomeworkClass6;

    
        Student[] students = new Student[]
        {
            new Student { Name = "Damjan", Academy = "SEDC", Group = "G2" },
            new Student { Name = "Andrej", Academy = "SEDC", Group = "G3" },
            new Student { Name = "Marko", Academy = "SEDC", Group = "G4" },
            new Student { Name = "Zarko", Academy = "SEDC", Group = "G5" },
            new Student { Name = "Petar", Academy = "SEDC", Group = "G6" }
        };

        Console.Write("Enter a name: ");
        string name = Console.ReadLine();

        Student student = students.FirstOrDefault(s => s.Name == name);
        if (student != null)
        {
            Console.WriteLine("Name: {0}", student.Name);
            Console.WriteLine("Academy: {0}", student.Academy);
            Console.WriteLine("Group: {0}", student.Group);
        }
        else
        {
            Console.WriteLine("No student found with name '{0}'", name);
        }
    

