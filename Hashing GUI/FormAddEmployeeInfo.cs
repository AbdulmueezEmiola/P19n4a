using System;
using System.Windows.Forms;
using Hashing;
// ReSharper disable LocalizableElement
// ReSharper disable StringLiteralTypo
// ReSharper disable CommentTypo

namespace Hashing_GUI
{
    public partial class FormAddEmployeeInfo : Form
    {
        //Функция, которая выполнится при успешном заполнении формы
        public Action<EmployeeInfo> OnSubmit { get; }

        public FormAddEmployeeInfo(Action<EmployeeInfo> onSubmit)
        {
            OnSubmit = onSubmit;
            InitializeComponent();
        }

        private void ButtonSubmit_Click(object sender, System.EventArgs e)
        {
            var result = int.TryParse(TextBoxEmployeeNumber.Text, out var number) &&
                         TextBoxEmployeeSalary.Text != "" &&
                         TextBoxEmployeeEmployee.Text != "";
            if (result)
            {
                var info = new EmployeeInfo(new EmployeeNumber(number), TextBoxEmployeeSalary.Text, TextBoxEmployeeEmployee.Text);
                OnSubmit(info);
                Close();
            }
            else
            {
                MessageBox.Show("Обнаружены недопустимые значения.\n" +
                                "Проверьте правильность входных данных\n" +
                                "и попробуйте ещё раз", "Ошибка", MessageBoxButtons.OK);
            }
        }

    }
}
