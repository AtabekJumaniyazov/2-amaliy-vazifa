
class TaskManager
{
    class Task
    {
        public string Description { get; set; }
        public bool IsCompleted { get; set; }

        public Task(string description)
        {
            Description = description;
            IsCompleted = false;
        }
    }

    static void Main()
    {
        List<Task> tasks = new List<Task>();
        bool running = true;

        while (running)
        {
            Console.WriteLine("\nVazifa menejeriga xush kelibsiz!");
            Console.WriteLine("1. Vazifa qo'shish");
            Console.WriteLine("2. Vazifani o'chirish");
            Console.WriteLine("3. Vazifani bajarilgan deb belgilash");
            Console.WriteLine("4. Vazifalarni ko'rish");
            Console.WriteLine("5. Chiqish");
            Console.Write("Tanlang: ");
            string choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    Console.Write("Vazifa tavsifini kiriting: ");
                    string description = Console.ReadLine();
                    tasks.Add(new Task(description));
                    Console.WriteLine("Vazifa qo'shildi.");
                    break;

                case "2":
                    Console.Write("O'chiriladigan vazifa raqamini kiriting: ");
                    int deleteIndex;
                    if (int.TryParse(Console.ReadLine(), out deleteIndex) && deleteIndex > 0 && deleteIndex <= tasks.Count)
                    {
                        tasks.RemoveAt(deleteIndex - 1);
                        Console.WriteLine("Vazifa o'chirildi.");
                    }
                    else
                    {
                        Console.WriteLine("Noto'g'ri raqam.");
                    }
                    break;

                case "3":
                    Console.Write("Bajarilgan deb belgilanishi kerak bo'lgan vazifa raqamini kiriting: ");
                    int completeIndex;
                    if (int.TryParse(Console.ReadLine(), out completeIndex) && completeIndex > 0 && completeIndex <= tasks.Count)
                    {
                        tasks[completeIndex - 1].IsCompleted = true;
                        Console.WriteLine("Vazifa bajarilgan deb belgilandi.");
                    }
                    else
                    {
                        Console.WriteLine("Noto'g'ri raqam.");
                    }
                    break;

                case "4":
                    Console.WriteLine("\nVazifalar ro'yxati:");
                    for (int i = 0; i < tasks.Count; i++)
                    {
                        Console.WriteLine($"{i + 1}. {tasks[i].Description} - {(tasks[i].IsCompleted ? "Bajarilgan" : "Bajarilmagan")}");
                    }
                    break;

                case "5":
                    running = false;
                    break;

                default:
                    Console.WriteLine("Noto'g'ri tanlov. Iltimos, yana urinib ko'ring.");
                    break;
            }
        }
    }
}
