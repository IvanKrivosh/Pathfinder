using PathfinderLogger;

DayOfWeek weekDay = DayOfWeek.Thursday;
string message = "Some text";
string fileName = "log.txt";
FileLogWritter fileLogger = new FileLogWritter(fileName);
ConsoleLogWritter consoleLogger = new ConsoleLogWritter();
Pathfinder pathfinderFile = new Pathfinder(fileLogger);
Pathfinder pathfinderConsole = new Pathfinder(consoleLogger);
Pathfinder pathfinderWeekDayFile = new Pathfinder(new SecureWritter(weekDay, fileLogger));
Pathfinder pathfinderWeekDayConsole = new Pathfinder(new SecureWritter(weekDay, consoleLogger));
Pathfinder pathfinderWeekDayFileConsole = new Pathfinder(new SecureWritter(weekDay));

pathfinderFile.Find(message);
pathfinderConsole.Find(message);
pathfinderWeekDayFile.Find(message);
pathfinderWeekDayConsole.Find(message);
pathfinderWeekDayFileConsole.Find(message);

Console.ReadKey();