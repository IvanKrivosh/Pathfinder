using PathfinderLogger;

DayOfWeek weekDay = DayOfWeek.Friday;
string message = "Some text";
string fileName = "log.txt";
FileLogWritter fileLogger = new FileLogWritter(fileName);
ConsoleLogWritter consoleLogger = new ConsoleLogWritter();
SecureWritter weekdayFileLogger = new SecureWritter(weekDay, fileLogger);
Pathfinder pathfinderFile = new Pathfinder(fileLogger);
Pathfinder pathfinderConsole = new Pathfinder(consoleLogger);
Pathfinder pathfinderWeekDayFile = new Pathfinder(weekdayFileLogger);
Pathfinder pathfinderWeekDayConsole = new Pathfinder(new SecureWritter(weekDay, consoleLogger));
Pathfinder pathfinderConsoleWeekDayFile = new Pathfinder(new GroupingLogger(consoleLogger, weekdayFileLogger));

pathfinderFile.Find(message);
pathfinderConsole.Find(message);
pathfinderWeekDayFile.Find(message);
pathfinderWeekDayConsole.Find(message);
pathfinderConsoleWeekDayFile.Find(message);

Console.ReadKey();