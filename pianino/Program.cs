namespace pianino
{
    internal class Program
    {
        public static string currentOctaveName = "Small Octave";
        static void Main(string[] args)
        {
            double[]? currentOctave = SwitchOctave("F1");
            while (true)
            {
                Console.WriteLine("Чтобы сменить октаву нажмите: F1, F2, F3 or F4");
                Console.WriteLine($"Выбранная октава: {currentOctaveName}");
                var currentKey = Console.ReadKey();
                switch (currentKey.Key)
                {
                    case ConsoleKey.F1:
                        currentOctave = SwitchOctave("F1");
                        break;

                    case ConsoleKey.F2:
                        currentOctave = SwitchOctave("F2");
                        break;

                    case ConsoleKey.F3:
                        currentOctave = SwitchOctave("F3");
                        break;

                    case ConsoleKey.F4:
                        currentOctave = SwitchOctave("F4");
                        break;

                    case ConsoleKey.Q:
                        PlayNote(0, currentOctave);
                        break;

                    case ConsoleKey.D2:
                        PlayNote(1, currentOctave);
                        break;

                    case ConsoleKey.W:
                        PlayNote(2, currentOctave);
                        break;

                    case ConsoleKey.E:
                        PlayNote(3, currentOctave);
                        break;

                    case ConsoleKey.D3:
                        PlayNote(4, currentOctave);
                        break;

                    case ConsoleKey.R:
                        PlayNote(5, currentOctave);
                        break;

                    case ConsoleKey.T:
                        PlayNote(6, currentOctave);
                        break;

                    case ConsoleKey.D5:
                        PlayNote(7, currentOctave);
                        break;

                    case ConsoleKey.Y:
                        PlayNote(8, currentOctave);
                        break;

                    case ConsoleKey.D6:
                        PlayNote(9, currentOctave);
                        break;

                    case ConsoleKey.U:
                        PlayNote(10, currentOctave);
                        break;

                    case ConsoleKey.D7:
                        PlayNote(11, currentOctave);
                        break;
                }
                Console.Clear();
            }
        }
        public static void PlayNote(int freqId, double[]? currentOctave)
        {
            Console.Beep((int)currentOctave[freqId], 500);
        }
        public static double[]? SwitchOctave(string keyInfo)
        {
            double[] smallOctave = new double[] { 130.8, 138.6, 146.8, 155.6, 164.8, 174.6, 185.0, 196.0, 207.7, 220.0, 233.1, 246.9 };
            double[] firstOctave = new double[] { 261.6, 277.2, 293.7, 311.1, 329.6, 349.2, 370.0, 392.0, 415.3, 440.0, 466.2, 493.9 };
            double[] secondctave = new double[] { 523.3, 554.4, 587.3, 622.3, 659.3, 698.5, 740.0, 784.0, 830.6, 880.0, 932.3, 987.8 };
            double[] thirdOctave = new double[] { 1047, 1109, 1175, 1245, 1319, 1397, 1480, 1568, 1661, 1760, 1865, 1976 };
            switch (keyInfo)
            {
                case "F1":
                    currentOctaveName = "Малая октава";
                    return smallOctave;
                case "F2":
                    currentOctaveName = "Первая октава";
                    return firstOctave;
                case "F3":
                    currentOctaveName = "Вторая октава";
                    return secondctave;
                case "F4":
                    currentOctaveName = "Третья октава";
                    return thirdOctave;
            }
            return null;
        }
    }
}