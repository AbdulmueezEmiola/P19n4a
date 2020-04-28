    using System;
using System.IO;
using System.Windows.Forms;
// ReSharper disable CommentTypo
// ReSharper disable StringLiteralTypo


namespace Hashing
{
    public class EmployeeNumber
    {
        //Номер
        public int NumberCode { get; set; }

        public EmployeeNumber(string source)
        {
            if (!int.TryParse(source, out var tmpNumberCode))
                throw new ArgumentException("Строка не может быть преобразована в номер сотрудника.");

            NumberCode = tmpNumberCode;
        }

        public EmployeeNumber(int numberCode = 000001)
        {
            NumberCode = numberCode;
        }

        /// <summary>
        /// Преобразование номера в строку
        /// </summary>
        /// <returns>Номер в виде строки</returns>
        public override string ToString()
        {
            return NumToStr(NumberCode, 6);
        }

        /// <summary>
        /// Конвертация числа в строку с заполнением недостающих разрядов нулями.
        /// </summary>
        /// <param name="num">Число.</param>
        /// <param name="minLength">Минимально заданное кол-во разрядов.</param>
        /// <returns>Строковое представление числа.</returns>
        private static string NumToStr(int num, int minLength)
        {
            var result = num.ToString();
            while (result.Length < minLength)
                result = '0' + result;
            return result;
        }

        /// <summary>
        /// Попытка чтения номера из файла
        /// </summary>
        /// <param name="reader">Объект, читающий данные из потока</param>
        /// <param name="number">Номер сотрудника</param>
        /// <returns>Успешно ли прошло чтение и конвертация</returns>
        public static bool TryReadAsText(StreamReader reader, out EmployeeNumber number)
        {
            var tmpNumber = ""; var tmp = 0;
            number = null;
            bool result = FileUtils.GetValueFromFile(reader, ref tmpNumber) && int.TryParse(tmpNumber, out tmp);
            if (result)
                number = new EmployeeNumber(tmp);
            return result;

        } 

    }

}
