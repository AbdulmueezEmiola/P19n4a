using System;
using System.IO;
// ReSharper disable CommentTypo
// ReSharper disable StringLiteralTypo

namespace Hashing
{
    public class EmployeeInfo
    {
        //Номер сотрудника
        public readonly EmployeeNumber Number;

        //З/п сотрудника
        private string _salary;
        public string Salary
        {
            get => _salary;
            private set
            {
                if (value.Length == 0)
                    throw new ArgumentException("З/п не может быть пустой.");
                _salary = value;
            }
        }

        //Сотрудник (ФИО)
        private string _employee;
        public string Employee
        {
            get => _employee;
            private set
            {
                if (value.Length == 0)
                    throw new ArgumentException("Сотрудник не может быть пустым.");
                _employee = value;
            }
        }


        public EmployeeInfo(EmployeeNumber number, string salary, string employee)
        {
            Salary = salary;
            Employee = employee;
            Number = number;
        }

        /// <summary>
        /// Деконструкция объекта, используется для
        /// более простого получения всех полей.
        /// </summary>
        /// <param name="number">Номер</param>
        /// <param name="salary">З/п</param>
        /// <param name="employee">Сотрудник</param>
        public void Deconstruct(out EmployeeNumber number, out string salary, out string employee)
        {
            number = Number;
            salary = Salary;
            employee = Employee;
        }

        /// <summary>
        /// Возвращает ключ (номер сотрудника)
        /// </summary>
        /// <returns>Ключ</returns>
        public string GetKey()
        {
            return Number.ToString();
        }

        public override string ToString()
        {
            return $"{Number} {_salary} {_employee}";
        }


        /// <summary>
        /// Запись информации о сотруднике в текстовый файл
        /// </summary>
        /// <param name="writer">Объект, производящий запись</param>
        public void WriteAsText(StreamWriter writer)
        {
            writer.WriteLine($"Номер: {Number}");
            writer.WriteLine($"З/п: {_salary}");
            writer.WriteLine($"Сотрудник: {_employee}");
        }

        /// <summary>
        /// Попытка считать информацию о сотрудниках из текстового файла
        /// </summary>
        /// <param name="reader">Объект, производящий считывание</param>
        /// <param name="employeeInfo">Информация о сотруднике</param>
        /// <returns>Успешно ли была прочитана информация</returns>
        public static bool TryReadAsText(StreamReader reader, out EmployeeInfo employeeInfo)
        {
            string tmpSalary = "", tmpEmployee = "";

            bool result = EmployeeNumber.TryReadAsText(reader, out var tmpNumber) &&
                          FileUtils.GetValueFromFile(reader, ref tmpSalary) &&
                          FileUtils.GetValueFromFile(reader, ref tmpEmployee);
            if (result)
                employeeInfo = new EmployeeInfo(tmpNumber, tmpSalary, tmpEmployee);
            else
                employeeInfo = null;
            return result;
        }
    }
}