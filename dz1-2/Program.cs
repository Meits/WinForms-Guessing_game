using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace dz1_2
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {

            int  i;
            DialogResult result, result2;
            int[] bufer = new int[100];
            bool game, retry;
            int numb;
            Random rnd = new Random();

            do
            {
                retry = false;
                game = true;
                i = 0;
                do
                {
                    numb = rnd.Next(1, 2000);

                    result = MessageBox.Show("Вы загадали число - " + numb + "?", "Угадайка", MessageBoxButtons
    .YesNo);
                    if (result == DialogResult.Yes)
                    {
                        game = false;
                    }
                    ++i;
                } while (game);

                result2 = MessageBox.Show("ВИгра окончена, загаданное число-" + numb + ", использовано попыток - " + i + " Начать заново?", "Угадайка", MessageBoxButtons
    .YesNo);
                if(result2 == DialogResult.Yes)
                {
                    retry = true;
                }
            } while (retry);
            
        }
    }
}
