using System;

namespace OOP3
{
    class FileLoggerService : ILoggerService // Ampulden Ara birim uyguladık !
    {
        public void Log()
        {
            Console.WriteLine("Dosyaya loglandı.");
        }
    }
}
