namespace Homework_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool isNumber = false;
            bool isEmpty = false;
            bool isChar = false;
            int number = 0;
            string textInfo = "";
            string text = "";
            Lines lines = new Lines();
            do
            {
                Console.WriteLine("Введите размерность таблицы (от 1 до 6):");
                text = Console.ReadLine();
                if ((Int32.TryParse(text, out number)) && (number > 0 && number < 7))
                {
                    //Console.WriteLine("Вы ввели правильную размерность таблицы - {0}", number);
                    break;
                }
                else
                {
                    isNumber = false;
                }
            }
            while (isNumber == false);

            do
            {
                Console.WriteLine("Введите произвольный текст:");
                textInfo = Console.ReadLine();
                if (!String.IsNullOrEmpty(textInfo) && textInfo.Length + text.Length <= 38)
                {
                    //Console.WriteLine("Вы ввели текст: {0}", textInfo);
                    break;
                }
                else
                {
                    isEmpty = false;
                }
            }
            while (isEmpty == false);

            do
            {
                Console.WriteLine("Введите число (от 1 до 3):");
                string text1 = Console.ReadLine();
                if ((Int32.TryParse(text1, out int numberS)) && (numberS > 0 && numberS < 4))
                {
                    switch (numberS)
                    {
                        case 1:
                            lines.oneLine(number, textInfo);
                            break;
                        case 2:
                            lines.twoLine(number, textInfo);
                            break;
                        case 3:
                            lines.threeLine(number, textInfo);
                            break;
                    }
                }
                else
                {
                    isChar = false;
                }

            }
            while (isChar == false);

            Console.ReadKey();
        }
    }
}