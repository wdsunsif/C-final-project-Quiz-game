class User
    {
        public string Username { get; set; }
        public string Password { get; set; }
        public DateTime DateOfBirth { get; set; }
    }

    class QuizQuestion
    {
        public string QuestionText { get; set; }
        public List<string> CorrectAnswers { get; set; }
        public List<string> Options { get; set; }
    }

    class Quiz
    {
        public string Category { get; set; }
        public List<QuizQuestion> Questions { get; set; }
    }

    class QuizResult
    {
        public string Username { get; set; }
        public string QuizCategory { get; set; }
        public int Score { get; set; }
    }

    class Program
    {
        static List<User> users = new List<User>();
        static User currentUser;
        static List<Quiz> quizzes = new List<Quiz>();
        static List<QuizResult> quizResults = new List<QuizResult>();

        static void Main(string[] args)
        {
            SetupQuiz();
            while (true)
            {
                Console.WriteLine("Добро пожаловать в приложение Викторина");
                Console.WriteLine("             1. Войти");
                Console.WriteLine("        2. Зарегестрироваться");
                Console.WriteLine("             3. Выйти");
                Console.Write("          Выберите выбор: ");
                string choice = Console.ReadLine();

                switch (choice)
                {
                    case "1":
                        Login();
                        break;
                    case "2":
                        Register();
                        break;
                    case "3":
                        Environment.Exit(0);
                        break;
                    default:
                        Console.WriteLine("Неправильный выбор. Попробуй еще раз!");
                        break;
                }
            }
        }

        static void SetupQuiz()
        {
    QuizQuestion historyQuestion1 = new QuizQuestion
    {
        QuestionText = "Кто был первым президентом США?\n" + " Авраам Линкольн\n" + "Томас Джефферсон\n" + "Джон Адамс\n" + "Джордж Вашингтон\n",
        CorrectAnswers = new List<string> { "Джордж Вашингтон" },
        Options = new List<string> { "Авраам Линкольн", "Томас Джефферсон", "Джон Адамс", "Джордж Вашингтон" }
    };
    
    QuizQuestion historyQuestion2 = new QuizQuestion
    {
        QuestionText = "Какая древняя цивилизация построила Великую Китайскую стену?\n" + "Римляне\n" + "Греки" + "Египтяне\n" +"Китайцы\n",
        CorrectAnswers = new List<string> { "Китайцы" },
        Options = new List<string> { "Римляне", "Греки", "Египтяне", "Китайцы" }
    };
    
    QuizQuestion historyQuestion3 = new QuizQuestion
    {
        QuestionText = "Когда началась революция во Франции?\n" + "1776\n" + "1789\n" + "1812\n" + "1848\n",
        CorrectAnswers = new List<string> { "1789" },
        Options = new List<string> { "1776", "1789", "1812", "1848" }
    };
    
    QuizQuestion historyQuestion4 = new QuizQuestion
    {
        QuestionText = "Кто был первым человеком, ступившим на Луну?\n" + "Юрий Гагарин\n" + "Нил Армстронг\n"  + "Баз Алдрина\n" + "Майкл Коллинз\n",
        CorrectAnswers = new List<string> { "Нил Армстронг" },
        Options = new List<string> { "Юрий Гагарин", "Нил Армстронг", "Баз Алдрина", "Майкл Коллинз" }
    };
    
    QuizQuestion historyQuestion5 = new QuizQuestion
    {
        QuestionText = "В каком году Христофор Колумб открыл Америку?\n" + "1453\n" + "1492\n" + "1519\n" + "1532\n",
        CorrectAnswers = new List<string> { "1492" },
        Options = new List<string> { "1453", "1492", "1519", "1532" }
    };
    
    QuizQuestion historyQuestion6 = new QuizQuestion
    {
        QuestionText = "Кто была первой женщиной-премьер-министром Великобритании?\n" + "Маргарет Тэтчер\n" + "Тереза Мэй\n" + "Ангела Меркель\n" + "Хиллари Клинтон\n",
        CorrectAnswers = new List<string> { "Маргарет Тэтчер" },
        Options = new List<string> { "Маргарет Тэтчер", "Тереза Мэй", "Ангела Меркель", "Хиллари Клинтон" }
    };
    
    QuizQuestion historyQuestion7 = new QuizQuestion
    {
        QuestionText = "Какая древняя цивилизация была известна строительством пирамид?\n" + "Греки\n" + "Римляне\n" + "Египтяне\n" + "Майя\n",
        CorrectAnswers = new List<string> { "Египтяне" },
        Options = new List<string> { "Греки", "Римляне", "Египтяне", "Майя" }
    };
    
    QuizQuestion historyQuestion8 = new QuizQuestion
    {
        QuestionText = "Когда началась первая мировая война?\n" + "1914\n" + "1939\n" + "1945\n" + "1918\n",
        CorrectAnswers = new List<string> { "1914" },
        Options = new List<string> { "1914", "1939", "1945", "1918" }
    };
    
    QuizQuestion historyQuestion9 = new QuizQuestion
    {
        QuestionText = "Кто был основателем Монгольской империи?\n" + "Джингис хан\n" + "Батый\n" + "Тамерлан\n" + "Чингиз хан\n",
        CorrectAnswers = new List<string> { "Чингиз хан" },
        Options = new List<string> { "Джингис хан", "Батый", "Тамерлан", "Чингиз хан" }
    };
    
    QuizQuestion historyQuestion10 = new QuizQuestion
    {
        QuestionText = "Какая европейская страна после Второй мировой войны разделилась на Восток и Запад?\n" + "Италия\n" + "Франция\n" + "Германия\n" + "Испания\n",
        CorrectAnswers = new List<string> { "Германия" },
        Options = new List<string> { "Италия", "Франция", "Германия", "Испания" }
    };
    QuizQuestion geographyQuestion1 = new QuizQuestion
    {
        QuestionText = "Какой океан в мире самый большой?\n" + "Атлантический океан\n" + "Индийский океан\n" +"Тихий океан\n" + "Северный Ледовитый океан\n",
        CorrectAnswers = new List<string> { "Тихий океан" },
        Options = new List<string> { "Атлантический океан", "Индийский океан", "Тихий океан", "Северный Ледовитый океан" }
    };
    
    QuizQuestion geographyQuestion2 = new QuizQuestion
    {
        QuestionText = "Какая страна известна как «Страна восходящего солнца»?\n" + "Китай\n" +"Индия\n" +"Япония\n" +"Южная Корея\n",
        CorrectAnswers = new List<string> { "Япония" },
        Options = new List<string> { "Китай", "Индия", "Япония", "Южная Корея" }
    };
    
    QuizQuestion geographyQuestion3 = new QuizQuestion
    {
        QuestionText = "Какая река самая длинная в мире?\n" + "Амазонка\n" + "Нил\n" + "Миссисипи\n"+"Жёлтая река (Хуанхэ)\n" ,
        CorrectAnswers = new List<string> { "Нил" },
        Options = new List<string> { "Амазонка", "Нил", "Миссисипи", "Жёлтая река (Хуанхэ)" }
    };
    
    QuizQuestion geographyQuestion4 = new QuizQuestion
    {
        QuestionText = "Какая столица Австралии?\n" + "Сидней\n" +"Мельбурн\n"+ "Канберра\n"+ "Брисбен\n",
        CorrectAnswers = new List<string> { "Канберра" },
        Options = new List<string> { "Сидней", "Мельбурн", "Канберра", "Брисбен" }
    };
    
    QuizQuestion geographyQuestion5 = new QuizQuestion
    {
        QuestionText = "Какая самая маленькая страна в мире?\n" + "Монако\n"+ "Норвегия\n"+ "Ватикан\n"+ "Лихтенштейн\n",
        CorrectAnswers = new List<string> { "Ватикан" },
        Options = new List<string> { "Монако", "Норвегия", "Ватикан", "Лихтенштейн" }
    };
    QuizQuestion geographyQuestion6 = new QuizQuestion
    {
        QuestionText = "Какая страна самая большая по площади?\n" + "Китай\n"+ "США\n"+ "Канада\n"+ "Россия\n",
        CorrectAnswers = new List<string> { "Россия" },
        Options = new List<string> { "Китай", "США", "Канада", "Россия" }
    };
    
        QuizQuestion geographyQuestion7 = new QuizQuestion
    {
        QuestionText = "Какая самая высокая гора в мире?\n" + "Кангчендзонга\n" + "К2\n" + "Макалу\n" +"Эверест\n",
        CorrectAnswers = new List<string> { "Эверест" },
        Options = new List<string> { "Кангчендзонга", "К2", "Макалу", "Эверест" }
    };
    
        QuizQuestion geographyQuestion8 = new QuizQuestion
    {
        QuestionText = "Какой континент самый засушливый?\n" + "Африка\n"+ "Австралия\n"+ "Антарктида\n"+ "Южная Америка\n",
        CorrectAnswers = new List<string> { "Антарктида" },
        Options = new List<string> { "Африка", "Австралия", "Антарктида", "Южная Америка" }
    };
    
        QuizQuestion geographyQuestion9 = new QuizQuestion
    {
        QuestionText = "В какой стране больше всего пирамид?\n" + "Египет\n"+ "Мексика\n"+ "Гватемала\n"+ "Судан\n",
        CorrectAnswers = new List<string> { "Судан" },
        Options = new List<string> { "Египет", "Мексика", "Гватемала", "Судан" }
    };
    
        QuizQuestion geographyQuestion10 = new QuizQuestion
    {
        QuestionText = "Какой город называют «Городом любви»?\n" + "Рим\n"+ "Венеция\n"+ "Париж\n"+ "Лондон\n",
        CorrectAnswers = new List<string> { "Париж" },
        Options = new List<string> { "Рим", "Венеция", "Париж", "Лондон" }
    };
        QuizQuestion biologyQuestion1 = new QuizQuestion
    {
        QuestionText = "Какова электростанция клетки?\n" + "Ядро\n" +"Митохондрия\n" +"Эндоплазматическая сеть\n" + "Хлоропласт\n",
        CorrectAnswers = new List<string> { "Митохондрия" },
        Options = new List<string> { "Ядро", "Митохондрия", "Эндоплазматическая сеть", "Хлоропласт" }
    };
    
        QuizQuestion biologyQuestion2 = new QuizQuestion
    {
        QuestionText = "Какой орган в организме человека является самым большим?\n" + "Сердце\n"+ "Печень\n"+ "Мозг\n"+ "Кожа\n",
        CorrectAnswers = new List<string> { "Кожа" },
        Options = new List<string> { "Сердце", "Печень", "Мозг", "Кожа" }
    };
    
        QuizQuestion biologyQuestion3 = new QuizQuestion
    {
        QuestionText = "Каков процесс, посредством которого растения добывают себе пищу?\n" + "Дыхание\n"+ "Транспирация\n"+ "Фотосинтез\n"+ "Ассимиляция\n",
        CorrectAnswers = new List<string> { "Фотосинтез" },
        Options = new List<string> { "Дыхание", "Транспирация", "Фотосинтез", "Ассимиляция" }
    };
    
        QuizQuestion biologyQuestion4 = new QuizQuestion
    {
        QuestionText = "Какое химическое вещество придает листьям зеленый цвет?\n" + "Каротин\n"+ "Меланин\n"+ "Хлорофилл\n"+ "Антоциан\n" ,
        CorrectAnswers = new List<string> { "Хлорофилл" },
        Options = new List<string> { "Каротин", "Меланин", "Хлорофилл", "Антоциан" }
    };
    
        QuizQuestion biologyQuestion5 = new QuizQuestion
    {
        QuestionText = "Какой газ в основном выделяют растения в процессе фотосинтеза?\n" + "Азот\n"+ "Кислород\n"+ "Углекислый газ\n"+ "Водород\n",
        CorrectAnswers = new List<string> { "Кислород" },
        Options = new List<string> { "Азот", "Кислород", "Углекислый газ", "Водород" }
    };
    
        QuizQuestion biologyQuestion6 = new QuizQuestion
    {
        QuestionText = "Как называется самая длинная кость человеческого тела?\n" + "Реберная\n"+ "Плечевая\n" +"Бедренная\n"+ "Черепная\n",
        CorrectAnswers = new List<string> { "Бедренная" },
        Options = new List<string> { "Реберная", "Плечевая", "Бедренная", "Черепная" }
    };
    
        QuizQuestion biologyQuestion7 = new QuizQuestion
    {
        QuestionText = "Как называется изучение живых организмов?\n" + "Геология\n"+ "Физика\n"+ "Химия\n"+ "Биология\n",
        CorrectAnswers = new List<string> { "Биология" },
        Options = new List<string> { "Геология", "Физика", "Химия", "Биология" }
    };
    
        QuizQuestion biologyQuestion8 = new QuizQuestion
    {
        QuestionText = "Какая система органов отвечает за перекачку крови по всему организму?\n" + "Дыхательная система\n"+ "Пищеварительная система\n"+"Нервная система\n"+ "Сердечно-сосудистая система\n",
        CorrectAnswers = new List<string> { "Сердечно-сосудистая система" },
        Options = new List<string> { "Дыхательная система", "Пищеварительная система", "Нервная система", "Сердечно-сосудистая система" }
    };
    
        QuizQuestion biologyQuestion9 = new QuizQuestion
    {
        QuestionText = "Как называется процесс деления клеток?\n" + "Мейоз\n"+ "Митоз\n"+ "Метаморфоз\n"+ "Митозис\n",
        CorrectAnswers = new List<string> { "Митоз" },
        Options = new List<string> { "Мейоз", "Митоз", "Метаморфоз", "Митозис" }
    };
    
        QuizQuestion biologyQuestion10 = new QuizQuestion
    {
        QuestionText = "Что является основной единицей жизни?\n" + "Вирус\n"+ "Молекула\n"+ "Организм\n"+"Клетка\n",
        CorrectAnswers = new List<string> { "Клетка" },
        Options = new List<string> { "Вирус", "Молекула", "Организм", "Клетка" }
    };
        List<QuizQuestion> allQuestions = new List<QuizQuestion>
        {
        historyQuestion1, historyQuestion2, historyQuestion3,
        historyQuestion4, historyQuestion5, historyQuestion6, historyQuestion7,
        historyQuestion8, historyQuestion9, historyQuestion10,
        geographyQuestion1, geographyQuestion2, geographyQuestion3,
        geographyQuestion4, geographyQuestion5, geographyQuestion6, geographyQuestion7,
        geographyQuestion8, geographyQuestion9, geographyQuestion10,
        biologyQuestion1, biologyQuestion2, biologyQuestion3,
        biologyQuestion4, biologyQuestion5, biologyQuestion6,
        biologyQuestion7, biologyQuestion8, biologyQuestion9, biologyQuestion10
        };
        
        
        
            
            Quiz historyQuiz = new Quiz
            {
                Category = "История",
                Questions = new List<QuizQuestion> { historyQuestion1, historyQuestion2, historyQuestion3,
                    historyQuestion4, historyQuestion5, historyQuestion6, historyQuestion7,
                    historyQuestion8, historyQuestion9, historyQuestion10 }
            };
            quizzes.Add(historyQuiz);

            Quiz geographyQuiz = new Quiz
            {
                Category = "География",
                Questions = new List<QuizQuestion> { geographyQuestion1, geographyQuestion2, geographyQuestion3,
                    geographyQuestion4, geographyQuestion5, geographyQuestion6, geographyQuestion7,
                    geographyQuestion8, geographyQuestion9, geographyQuestion10 }
            };
            quizzes.Add(geographyQuiz);

            Quiz biologyQuiz = new Quiz
            {
                Category = "Биология",
                Questions = new List<QuizQuestion> { biologyQuestion1, biologyQuestion2, biologyQuestion3,
                    biologyQuestion4, biologyQuestion5, biologyQuestion6,
                    biologyQuestion7, biologyQuestion8, biologyQuestion9, biologyQuestion10 }
            };
            quizzes.Add(biologyQuiz);
            Quiz mixedQuiz = new Quiz
            {
                Category = "Смешанная викторина",
                Questions = new List<QuizQuestion>()
            };
            foreach (var quiz in quizzes)
            {
                mixedQuiz.Questions.AddRange(quiz.Questions);
            }

            quizzes.Add(mixedQuiz);
        }

        static void Login()
        {
            Console.Write("Введи имя пользователя: ");
            string username = Console.ReadLine();
            Console.Write("Введи пароль: ");
            string password = Console.ReadLine();

            User user = users.FirstOrDefault(u => u.Username == username && u.Password == password);
            if (user != null)
            {
                currentUser = user;
                Console.WriteLine($"С возвращением, {currentUser.Username}!");
                MainMenu();
            }
            else
            {
                Console.WriteLine("Неправильное имя или пароль!");
            }
        }

        static void Register()
        {
            Console.Write("Введи имя пользователя: ");
            string username = Console.ReadLine();
            Console.Write("Введи пароль: ");
            string password = Console.ReadLine();
            Console.Write("Введи дату рождения (YYYY-MM-DD): ");
            DateTime dob;
            if (!DateTime.TryParse(Console.ReadLine(), out dob))
            {
                Console.WriteLine("Неправильный формат. Попробуй еще раз.");
                return;
            }

            if (users.Any(u => u.Username == username))
            {
                Console.WriteLine("Имя пользователя уже существует с таким именем. Попробуй ввести другой.");
            }
            else
            {
                User newUser = new User
                {
                    Username = username,
                    Password = password,
                    DateOfBirth = dob
                };
                users.Add(newUser);
                Console.WriteLine("Регистрация прошла успешно!");
            }
        }

        static void MainMenu()
        {
            while (true)
            {
                Console.WriteLine("Главное меню:");
                Console.WriteLine("1. Начать викторину");
                Console.WriteLine("2. Посмотреть результаты викторины");
                Console.WriteLine("3. Посмотреть результаты топ 20 викторин");
                Console.WriteLine("4. Изменить настройки");
                Console.WriteLine("5. Выйти");
                Console.Write("Выбери выбор: ");
                string choice = Console.ReadLine();

                switch (choice)
                {
                    case "1":
                        StartQuiz();
                        break;
                    case "2":
                        ViewQuizResults();
                        break;
                    case "3":
                        ViewTopQuizResults();
                        break;
                    case "4":
                        ChangeSettings();
                        break;
                    case "5":
                        currentUser = null;
                        return;
                    default:
                        Console.WriteLine("Неправильный выбор");
                        break;
                }
            }
        }

        static void StartQuiz()
        {
            Console.WriteLine("Доступные категории викторины:");
            for (int i = 0; i < quizzes.Count; i++)
            {
                Console.WriteLine($"{i + 1}. {quizzes[i].Category}");
            }

            Console.Write("Выбрать категорию викторины: ");
            int categoryIndex;
            if (!int.TryParse(Console.ReadLine(), out categoryIndex) || categoryIndex < 1 || categoryIndex > quizzes.Count)
            {
                Console.WriteLine("Неправильный выбор");
                return;
            }

            Quiz selectedQuiz = quizzes[categoryIndex - 1];

            if (selectedQuiz.Category == "Смешанная викторина")
            {
                StartMixedQuiz();
                return;
            }

            Console.WriteLine($"Начинается викторина {selectedQuiz.Category} ...");
            List<QuizQuestion> questions = selectedQuiz.Questions;

            int score = 0;
            foreach (var question in questions)
            {
                Console.WriteLine(question.QuestionText);

                Console.Write("Твой ответ: ");
                string userAnswer = Console.ReadLine();

                bool correct = question.CorrectAnswers.Any(answer => userAnswer.Equals(answer, StringComparison.OrdinalIgnoreCase));
                if (correct)
                {
                    Console.WriteLine("Правильно!");
                    score++;
                }
                else
                {
                    Console.WriteLine("Неправильно!");
                }
            }

            Console.WriteLine($"Викторина завершена! Твой результат: {score}");
            QuizResult result = new QuizResult { Username = currentUser.Username, QuizCategory = selectedQuiz.Category, Score = score };
            quizResults.Add(result);
            Console.WriteLine("Результаты викторины сохранены!");
        }

        static void StartMixedQuiz()
        {
            Console.WriteLine("Начинаем смешанную викторину...");

            Random random = new Random();
            List<QuizQuestion> mixedQuestions = quizzes.Last().Questions.OrderBy(q => random.Next()).Take(20).ToList();

            int score = 0;
            foreach (var question in mixedQuestions)
            {
                Console.WriteLine(question.QuestionText);
                Console.Write("Твой ответ: ");
                string userAnswer = Console.ReadLine();

                bool correct = question.CorrectAnswers.Any(answer => userAnswer.Equals(answer, StringComparison.OrdinalIgnoreCase));
                if (correct)
                {
                    Console.WriteLine("Правильно!");
                    score++;
                }
                else
                {
                    Console.WriteLine("Неправильно!");
                }
            }

            Console.WriteLine($"Викторина завершена! Твой результат: {score}");
            QuizResult result = new QuizResult { Username = currentUser.Username, QuizCategory = "Смешанная викторина", Score = score };
            quizResults.Add(result);
            Console.WriteLine("Результаты викторины сохранены!");
        }

        static void ViewQuizResults()
        {
            Console.WriteLine($"Результаты викторины пользователя {currentUser.Username}:");
            var userResults = quizResults.Where(r => r.Username == currentUser.Username);
            foreach (var result in userResults)
            {
                Console.WriteLine($"Категория: {result.QuizCategory}, Баллы: {result.Score}");
            }
        }

        static void ViewTopQuizResults()
        {
            Console.WriteLine("Топ 20 результат викторин:");
            var topResults = quizResults.OrderByDescending(r => r.Score).Take(20);
            foreach (var result in topResults)
            {
                Console.WriteLine($"Пользователь: {result.Username}, Категория: {result.QuizCategory}, Баллы: {result.Score}");
            }
        }

        static void ChangeSettings()
        {
            Console.WriteLine("Изменить настройки меню:");
            Console.WriteLine("1. Изменить пароль");
            Console.WriteLine("2. Изменить дату рождения");
            Console.Write("Выбрать опцию: ");
            string choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    Console.Write("Введи текущий пароль: ");
                    string currentPassword = Console.ReadLine();
                    if (currentPassword == currentUser.Password)
                    {
                        Console.Write("Введи новый пароль: ");
                        string newPassword = Console.ReadLine();
                        currentUser.Password = newPassword;
                        Console.WriteLine("Пароль изменен!");
                    }
                    else
                    {
                        Console.WriteLine("Неправильный пароль!!");
                    }
                    break;
                case "2":
                    Console.Write("Введи дату рождения (YYYY-MM-DD): ");
                    DateTime newDob;
                    if (!DateTime.TryParse(Console.ReadLine(), out newDob))
                    {
                        Console.WriteLine("Неправильный формат!!!");
                        return;
                    }
                    currentUser.DateOfBirth = newDob;
                    Console.WriteLine("Дата рождения изменена!");
                    break;
                default:
                    Console.WriteLine("Неправильный выбор.");
                    break;
            }
        }
    }
