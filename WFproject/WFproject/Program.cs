using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WFproject
{
    internal static class Program
    {
        /// <summary>
        /// Главная точка входа для приложения.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new LoginForm());
        }
    } 
    /*class Options
    {
       
        // логика
            public void Option(string[] args)
            {
                int rubToUsd = 85;
                double rubToUsdA = 0.0125;
                int usdToRub = 80;
                int rubToEur = 95;
                double rubToEurA = 0.0115;
                int eurToRub = 90;
                double balanceRub = 215000;
                double balanceUsd = 4500;
                double balanceEur = 5600;
                int currencyCount;
                string userMessage;
                bool isUserWantsOut = false;

                Console.WriteLine("Добро пожаловать! forofonof.bank к вашим услугам.");
                Console.WriteLine("Какую операцию желание совершить?");

                while (false == isUserWantsOut)
                {
                    Console.WriteLine("1 - Узнать баланс вашего счета.");
                    Console.WriteLine("2 - Обменять Рубли на Доллары.");
                    Console.WriteLine("3 - Обменять Рубли на Евро.");
                    Console.WriteLine("4 - Обменять Доллары на Рубли.");
                    Console.WriteLine("5 - Обменять Евро на Рубли.");
                    Console.WriteLine("6 - Выйти из программы.");
                    userMessage = Console.ReadLine();

                    switch (userMessage)
                    {
                        case "1":
                            Console.WriteLine($"У нас на счету: {balanceRub} рублей. {balanceUsd} долларов. {balanceEur} евро.");
                            break;
                        case "2":
                            Console.WriteLine($"Сколько желаете обменять рублей? Баланс: {balanceRub} рублей.");
                            Console.WriteLine($"Курс обмена: {rubToUsd} рублей за один доллар.");

                            currencyCount = Convert.ToInt32(Console.ReadLine());

                            if (balanceRub >= currencyCount)
                            {
                                balanceRub -= currencyCount;
                                balanceUsd += currencyCount / rubToUsd;
                                Console.WriteLine($"Сделка успешно завершена! Ваш баланс: {balanceRub} рублей. {balanceUsd} долларов.");
                            }
                            else
                            {
                                Console.WriteLine("У вас недостаточно средств, чтобы совершить обмен.");
                                Console.WriteLine($"Ваш баланс: {balanceRub} рублей.");
                                Console.WriteLine("Попробуйте еще раз.");
                            }

                            break;
                        case "3":
                            Console.WriteLine($"Сколько желаете обменять рублей? Баланс: {balanceRub} рублей.");
                            Console.WriteLine($"Курс обмена: {rubToEur} рублей за один евро.");

                            currencyCount = Convert.ToInt32(Console.ReadLine());

                            if (balanceRub >= currencyCount)
                            {
                                balanceRub -= currencyCount;
                                balanceEur += currencyCount / rubToEur;

                                Console.WriteLine($"Сделка успешно завершена! Ваш баланс: {balanceRub} рублей. {balanceEur} евро.");
                            }
                            else
                            {
                                Console.WriteLine("У вас недостаточно средств, чтобы совершить обмен.");
                                Console.WriteLine($"Ваш баланс: {balanceRub} рублей.");
                                Console.WriteLine("Попробуйте еще раз.");
                            }

                            break;
                        case "4":
                            Console.WriteLine($"Сколько желаете обменять долларов? Баланс: {balanceUsd} долларов.");
                            Console.WriteLine($"Курс обмена: {usdToRub} рублей за один доллар.");

                            currencyCount = Convert.ToInt32(Console.ReadLine());

                            if (balanceUsd >= currencyCount)
                            {
                                balanceUsd -= currencyCount;
                                balanceRub += currencyCount / rubToUsdA;
                                Console.WriteLine($"Сделка успешно завершена! Ваш баланс: {balanceUsd} Долларов. {balanceRub} рублей.");
                            }
                            else
                            {
                                Console.WriteLine("У вас недостаточно средств, чтобы совершить обмен.");
                                Console.WriteLine($"Ваш баланс: {balanceUsd} долларов.");
                                Console.WriteLine("Попробуйте еще раз.");
                            }

                            break;
                        case "5":
                            Console.WriteLine($"Сколько желаете обменять евро? Баланс: {balanceEur} евро.");
                            Console.WriteLine($"Курс обмена: {eurToRub} рублей за один евро.");

                            currencyCount = Convert.ToInt32(Console.ReadLine());

                            if (balanceEur >= currencyCount)
                            {
                                balanceEur -= currencyCount;
                                balanceRub += currencyCount / rubToEurA;
                                Console.WriteLine($"Сделка успешно завершена! Ваш баланс: {balanceEur} евро. {balanceRub} рублей.");
                            }
                            else
                            {
                                Console.WriteLine("У вас недостаточно средств, чтобы совершить обмен.");
                                Console.WriteLine($"Ваш баланс: {balanceEur} евро.");
                                Console.WriteLine("Попробуйте еще раз.");
                            }

                            break;
                        case "6":
                            isUserWantsOut = true;
                            break;
                        default:
                            Console.WriteLine("Ошибка! Вы указали неверную операцию, попробуйте еще раз.");
                            break;
                    }
                }
            }
        */
}
    

