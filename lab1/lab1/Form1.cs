using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace lab1
{
    public partial class Form1 : Form
    {
        private string initialDescription = "Здесь будет информация об элементах данной вкладки после взаимодействия";
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            radioButton1.CheckedChanged += new EventHandler(radioButtons_CheckedChanged);
            radioButton2.CheckedChanged += new EventHandler(radioButtons_CheckedChanged);
            this.decription1.Text = this.initialDescription;

            var squirrels = new List<Squirrel>();
            squirrels.Add(new Squirrel { Id = 1, Name = "Эмма", Age = 1 });
            squirrels.Add(new Squirrel { Id = 2, Name = "Шишик", Age = 2 });
            this.dataGridView1.DataSource = squirrels;
        }

        private void buttonLoadProgressBar_Click(object sender, EventArgs e)
        {
            this.decription1.Text = this.initialDescription;
            for (int i = 0; i < 10; i++)
            {
                this.progressBar1.Increment(1);
                System.Threading.Thread.Sleep(200);
            }
            Form successDialog = new SuccessDialog();
            successDialog.ShowDialog();
            progressBar1.Value = 0;

            this.decription1.Text = "Важные свойства и методы ProgressBar:\n" +
                "1.Step - Размер одного шага\n" +
                "3.Minimum - Минимальное значение\n" +
                "4.Maximum - Максимальное значение\n" +
                "5.Size - Размеры элемента (высота и ширина)\n" +
                "6.Value - Значение шкалы\n" +
                "7.Increment() - Метод, увеличивающий текущее состояние шкалы\n" +
                "События:\n" +
                "1.Click - Вызовется, когда на элемент кликнут\n" +
                "2.MouseHover - Вызовется, когда на элемент наведут курсор";
        }

        private void buttonOpenForm_Click(object sender, EventArgs e)
        {
            Form form2 = new Form2();
            form2.Show();
            this.decription1.Text = this.initialDescription;
        }

        private void label1_MouseHover(object sender, EventArgs e)
        {
            this.decription1.Text = "Важные свойства и методы Label:\n" +
                "1. Name - Имя элемента в коде \n" +
                "2. Font - Шрифт \n" +
                "3. Text - Текст элемента \n" +
                "4. AutoSize - Автоматическое вычисление размера элемента под содержимое \n" +
                "5. Size - Размеры элемента (высота и ширина) \n" +
                "6. BackColor - Цвет фона \n" +
                "7. ForeColor - Цвет текста \n" +
                "8. Cursor - Тип курсора при наведении \n" +
                "9. Padding - Внутренние отступы \n" +
                "События: \n" +
                "1. Click - Вызовется при клике \n" +
                "2. MouseHover - Вызовется при наведении на элемент \n" +
                "3. TextChanged - Вызовется при изменении текста";
        }

        private void buttonAbout_Click(object sender, EventArgs e)
        {
            this.decription1.Text = "Важные свойства и методы Button:\n" +
                "1. Name - Имя элемента в коде \n" +
                "2. Font - Шрифт \n" +
                "3. Text - Текст элемента \n" +
                "4. AutoSize - Автоматическое вычисление размера элемента под содержимое \n" +
                "5. Size - Размеры элемента (высота и ширина) \n" +
                "6. BackColor - Цвет фона \n" +
                "7. BackgroundImage - Изображение на фоне \n" +
                "8. ForeColor - Цвет текста \n" +
                "9. Cursor - Тип курсора при наведении \n" +
                "10. Padding - Внутренние отступы \n" +
                "11. Focus() - Метод, устанавливающий фокус на элемент \n" +
                "События: \n" +
                "1. Click - Вызовется при клике \n" +
                "2. MouseHover - Вызовется при наведении на элемент";
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.decription1.Text = "Важные свойства и методы ComboBox:\n" +
                "1. Name - Имя элемента в коде \n" +
                "2. Font - Шрифт \n" +
                "3. Text - Текст элемента \n" +
                "4. Size - Размеры элемента (высота и ширина) \n" +
                "5. BackColor - Цвет фона \n" +
                "6. ForeColor - Цвет текста \n" +
                "7. Cursor - Тип курсора при наведении \n" +
                "8. Items - Элементы в выпадающем списке \n" +
                "9. SelectedIndex - Выбранный индекс \n" +
                "10. SelectedItem - Выбранный элемент \n" +               
                "11. Focus() - Метод, устанавливающий фокус на элемент \n" +
                "События: \n" +
                "1. Click - Вызовется при клике \n" +
                "2. SelectedIndexChanged - Вызовется, когда активный индекс будет изменен \n" +
                "3. SelectedValueChanged - Вызовется, когда текущее значение будет изменено \n" +
                "4. MouseHover - Вызовется при наведении на элемент";
        }

        private void radioButtons_CheckedChanged(object sender, EventArgs e)
        {
            this.decription1.Text = "Важные свойства и методы RadioButton:\n" +
                "1. Name - Имя элемента в коде \n" +
                "2. Font - Шрифт \n" +
                "3. Text - Текст элемента \n" +
                "4. Size - Размеры элемента (высота и ширина) \n" +
                "5. BackColor - Цвет фона \n" +
                "6. ForeColor - Цвет текста \n" +
                "7. Cursor - Тип курсора при наведении \n" +
                "8. Checked - Выбран ли \n" +
                "9. Focus() - Метод, устанавливающий фокус на элемент \n" +
                "События: \n" +
                "1. Click - Вызовется при клике \n" +
                "2. CheckedChanged - Вызовется, когда свойство Checked будет изменено \n" +
                "3. MouseHover - Вызовется при наведении на элемент";
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            this.decription1.Text = "Важные свойства и методы DateTimePicker:\n" +
                "1. Name - Имя элемента в коде \n" +
                "2. Font - Шрифт \n" +
                "3. Value - Значение элемента \n" +
                "4. Size - Размеры элемента (высота и ширина) \n" +
                "5. Cursor - Тип курсора при наведении \n" +
                "6. Format - Формат отображения даты \n" +
                "7. MinDate - Минимальная дата \n" +
                "8. MaxDate - Максимальная дата \n" +
                "9. CalendarForeColor - Цвет текста в области месяца \n" +
                "10. CalendarMonthBackground - Фоновый цвет в области месяца \n" +
                "11. CalendarTitleBackColor - Фоновый цвет заголовка календаря \n" +
                "12. CalendarTitleForeColor - Цвет заголовка календаря \n" +
                "13. CalendarTrailingForeColor - Цвет завершающих дней предыдущего месяца и начальных дней следующего месяца \n" +
                "14. Focus() - Метод, устанавливающий фокус на элемент \n" +
                "События: \n" +
                "1. Click - Вызовется при клике \n" +
                "2. Enter - Вызовется, когда элемент будет в фокусе \n" +
                "3. ValueChanged - Вызовется, когда значение будет изменено";
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            this.decription1.Text = "Важные свойства и методы MenuStrip:\n" +
                "1. Name - Имя элемента в коде \n" +
                "2. Font - Шрифт \n" +
                "3. Items - Элементы в меню \n" +
                "4. Size - Размеры элемента (высота и ширина) \n" +
                "5. BackColor - Цвет фона \n" +
                "6. Padding - Внутренние отступы \n" +
                "7. Focus() - Метод, устанавливающий фокус на элемент \n" +
                "События: \n" +
                "1. ItemClicked - Вызовется при клике на элемент меню" +
                "2. Click - Вызовется при на все меню \n" +
                "3. MouseHover - Вызовется при наведении на все меню";
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.decription1.Text = "Важные свойства и методы PictureBox:\n" +
                "1. Name - Имя элемента в коде \n" +
                "2. Size - Размеры элемента (высота и ширина) \n" +
                "3. Cursor - Тип курсора при наведении \n" +
                "4. Image - Изображение \n" +
                "События: \n" +
                "1. Click - Вызовется при клике";
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            this.decription1.Text = "Важные свойства и методы NumericUpDown:\n" +
                "1. Name - Имя элемента в коде \n" +
                "2. Size - Размеры элемента (высота и ширина) \n" +
                "3. Cursor - Тип курсора при наведении \n" +
                "4. Value - Текущее значение \n" +
                "5. BackColor - Цвет фона \n" +
                "6. TextAlign - Центрирование текста \n" +
                "7. UpDownAlign - Расположение стрелок \n" +
                "8. ReadOnly - Включить только для чтения \n" +
                "10. Minimum - Минимальное значение \n" +
                "11. Maximum - Максимальное значение \n" +
                "12. Increment - Шаг при изменении значения стрелками \n" +
                "13. ForeColor - Цвет текста \n" +
                "14. Focus() - Метод, устанавливающий фокус на элемент \n" +
                "События: \n" +
                "1. Click - Вызовется при клике \n" +
                "2. ValueChanged - Вызовется, когда значение будет изменено \n" +
                "3. MouseHover - Вызовется при наведении на элемент \n";
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            this.decription1.Text = "Важные свойства и методы CheckBox:\n" +
                "1. Name - Имя элемента в коде \n" +
                "2. Cursor - Тип курсора при наведении \n" +
                "3. Text - Текст элемента \n" +
                "4. Font - Шрифт \n" +
                "5. Checked - Выбран ли \n" +
                "6. CheckState - Состояние элемента \n" +
                "7. ForeColor - Цвет текста \n" +
                "8. Focus() - Метод, устанавливающий фокус на элемент \n" +
                "События: \n" +
                "1. Click - Вызовется при клике \n" +
                "2. CheckedChanged - Вызовется, когда состояние будет изменено";
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            this.decription1.Text = "Важные свойства и методы TextBox:\n" +
                "1. Name - Имя элемента в коде \n" +
                "2. Font - Шрифт \n" +
                "3. Text - Текст элемента \n" +
                "4. Size - Размеры элемента (высота и ширина) \n" +
                "5. BackColor - Цвет фона \n" +
                "6. ForeColor - Цвет текста \n" +
                "7. Multiline - Можно ли писать на несколько строк \n" +
                "8. Cursor - Тип курсора при наведении \n" +
                "9. TextAlign - Выравнивание текста \n" +
                "10. MaxLength - Максимальное количество символов \n" +
                "11. ReadOnly - Только для чтения (Да/Нет) \n" +
                "12. Focus() - Метод, устанавливающий фокус на элемент \n" +
                "События: \n" +
                "1. Click - Вызовется при клике \n" +
                "2. MouseHover - Вызовется при наведении на элемент \n" +
                "3. TextChanged - Вызовется при изменении текста";
        }

        private void maskedTextBox1_TextChanged(object sender, EventArgs e)
        {
            this.decription1.Text = "Важные свойства и методы MaskedTextBox:\n" +
                "1. Name - Имя элемента в коде \n" +
                "2. Font - Шрифт \n" +
                "3. Text - Текст элемента \n" +
                "4. Size - Размеры элемента (высота и ширина) \n" +
                "5. BackColor - Цвет фона \n" +
                "6. ForeColor - Цвет текста \n" +
                "7. Multiline - Можно ли писать на несколько строк \n" +
                "8. Cursor - Тип курсора при наведении \n" +
                "9. TextAlign - Выравнивание текста \n" +
                "10. MaxLength - Максимальное количество символов \n" +
                "11. ReadOnly - Только для чтения (Да/Нет) \n" +
                "12. Mask - Маска, которой должен соответствовать текст \n" +
                "13. Focus() - Метод, устанавливающий фокус на элемент \n" +
                "События: \n" +
                "1. Click - Вызовется при клике \n" +
                "2. MouseHover - Вызовется при наведении на элемент \n" +
                "3. TextChanged - Вызовется при изменении текста \n" +
                "4. MaskInputRejected - Сработает, если введеный символ не соответствует маске";
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {
            this.decription1.Text = "Важные свойства и методы GroupBox:\n" +
                "1. Name - Имя элемента в коде \n" +
                "2. Font - Шрифт \n" +
                "3. Text - Текст элемента (сверху) \n" +
                "4. Size - Размеры элемента (высота и ширина) \n" +
                "5. BackColor - Цвет фона \n" +
                "6. BackgroundImage - Фоновое изображение \n" +
                "7. Cursor - Тип курсора при наведении \n" +
                "8. Focus() - Метод, устанавливающий фокус на элемент \n" +
                "9. Contains() - Метод, проверяющий, содержится ли дочерний элемент \n" +
                "События: \n" +
                "1. Click - Вызовется при клике \n" +
                "2. Enter - Вызовется при фокусировании на дочернем элементе";
        }

        private void panel1_Enter(object sender, EventArgs e)
        {
            this.decription1.Text = "Важные свойства и методы Panel:\n" +
                "1. Name - Имя элемента в коде \n" +
                "2. Font - Шрифт \n" +
                "3. Size - Размеры элемента (высота и ширина) \n" +
                "4. BackColor - Цвет фона \n" +
                "5. BackgroundImage - Фоновое изображение \n" +
                "6. Cursor - Тип курсора при наведении \n" +
                "7. Focus() - Метод, устанавливающий фокус на элемент \n" +
                "8. Contains() - Метод, проверяющий, содержится ли дочерний элемент \n" +
                "События: \n" +
                "1. Click - Вызовется при клике \n" +
                "2. Enter - Вызовется при фокусировании на дочернем элементе";
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.decription1.Text = "Важные свойства и методы ListBox:\n" +
                "1. Name - Имя элемента в коде \n" +
                "2. Font - Шрифт \n" +
                "3. ForeColor - Цвет текста \n" +
                "4. Size - Размеры элемента (высота и ширина) \n" +
                "5. BackColor - Цвет фона \n" +
                "6. Items - Элементы в списке \n" +
                "7. Cursor - Тип курсора при наведении \n" +
                "8. SelectedIndex - Индекс выбранного элемента \n" +
                "9. SelectedIndices - Индексы выбранных элементов \n" +
                "10. SelectdItem - Выбранный элемент \n" +
                "11. SelectedItems - Выбранные элементы \n" +
                "12. Sorted - Сортирован ли список \n" +
                "13. Focus() - Метод, устанавливающий фокус на элемент \n" +
                "События: \n" +
                "1. Click - Вызовется при клике \n" +
                "2. SelectedIndexChanged - Вызовется, когда активный индекс изменится \n" +
                "3. SelectedValueChanged - Вызовется, когда значение будет изменено";
        }

        private void dataGridView1_Click(object sender, EventArgs e)
        {
            this.decription1.Text = "Важные свойства и методы DataGridView:\n" +
                "1. Name - Имя элемента в коде \n" +
                "2. Size - Размеры элемента (высота и ширина) \n" +
                "3. BackColor - Цвет фона \n" +
                "4. Cursor - Тип курсора при наведении \n" +
                "5. ReadOnly - Только для чтения \n" +
                "6. MultiSelect - Множественный выбор \n" +
                "7. DataSource - Данные для элемента \n" +
                "8. RowTemplate - Шаблон для строк (настройки) \n" +
                "9. CurrentCell - Текущая ячейка \n" +
                "10. CurrentRow - Текущая строка \n" +
                "11. RowCount - Количество строк \n" +
                "12. Columns - Колонки \n" +
                "13. Rows - Строки \n" +
                "14. SelectedCells - Выбранные ячейки \n" +
                "15. SelectedColumns - Выбранные колонки \n" +
                "16. SelectedRows - Выбранные строки \n" +
                "17. SortOrder - Порядок сортировки \n" +
                "18. SortedColumn - Столбец, по которому выполнена сортировка \n" +
                "19. BeginEdit() - Метод, переводящий текущую ячейку в режим редактирования \n" +
                "20. CancelEdit() - Метод, отменяющий режим редактирования для текущей выбранной ячейки \n" +
                "21. ClearSelection() - Метод, отменяющий текущие выделения ячеек \n" +
                "22. EndEdit() - Метод, завершающий изменение в текущей ячейке \n" +
                "События: \n" +
                "1. CellBeginEdit - Вызовется при запуске режима правки для \nвыбранных ячеек \n" +
                "2. CellClick - Вызовется при клике по ячейке \n" +
                "3. CellEndEdit - Вызовется при при остановке режима правки \nдля выбранной ячейки \n" +
                "4. ColumnSortModeChanged - Вызовется при изменении значения \nсвойства SortMode для столбца \n" +
                "5. Sorted - Вызовется когда завершится операция сортировки  \n" +
                "6. CellValueChanged - Вызовется при изменении значения ячейки " +
                "7. Click - Вызовется при клике по всему элементу";
        }

        private void openFolderButton_Click(object sender, EventArgs e)
        {
            if (folderBrowserDialog1.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                System.Diagnostics.Process.Start(folderBrowserDialog1.SelectedPath);
            }

            this.decription1.Text = "Важные свойства и методы FolderBrowserDialog:\n" +
                "1. Name - Имя элемента в коде \n" +
                "2. Description - Описание для пользователя \n" +
                "3. RootFolder - Корневой каталог, с которого начинается обзор \n" +
                "4. SelectedPath - Путь к выбранной папке \n" +
                "5. ShowNewFolderButton - Показывать ли кнопку создания новой папки \n" +
                "6. ShowDialog() - Метод, запускающий диалоговое окно с выбором \n" +
                "События: \n" +
                "1. Disposed - Вызовется при удалении компонента \n" +
                "2. HelpRequest - Вызовется при нажатии 'Help' в диалоговом окне";
        }

        private void saveImage_Click(object sender, EventArgs e)
        {
            if (saveFileDialog1.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                pictureBox1.Image.Save(saveFileDialog1.FileName);
            }

            this.decription1.Text = "Важные свойства и методы SaveFileDialog:\n" +
                "1. Name - Имя элемента в коде \n" +
                "2. Title - Заголовок диалогового окна \n" +
                "3. InitialDirectory - Первоначальная директория \n" +
                "4. FileName - Имя файла \n" +
                "5. AddExtension - Добавлять ли расширения к именам файлов автоматически \n" +
                "6. DefaultExt - Расширение файла по умолчанию \n" +
                "7. CheckFileExists - Проверить, существет ли выбранный файл \n" +
                "8. CheckPathExists - Проверить, существет ли выбранный путь \n" +
                "9. Filter - Фильтр по файлам \n" +
                "10. ShowDialog() - Метод, запускающий диалоговое окно с выбором, куда сохранить \n" +
                "11. OpenFile() - Метод, открывающий данный файл \n" +
                "События: \n" +
                "1. Disposed - Вызовется при удалении компонента \n" +
                "2. FileOk - Вызовется когда пользователь нажимает 'Открыть' или 'Сохранить' в диалоговом окне \n" +
                "3. HelpRequest - Вызовется при нажатии 'Help' в диалоговом окне";


        }

        private void openFileButton_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                System.Diagnostics.Process.Start(openFileDialog1.FileName);
            }

            this.decription1.Text = "Важные свойства и методы OpenFileDialog:\n" +
                "1. Name - Имя элемента в коде \n" +
                "2. Title - Заголовок диалогового окна \n" +
                "3. InitialDirectory - Первоначальная директория \n" +
                "4. AddExtension - Добавлять ли расширения к именам файлов автоматически \n" +
                "5. DefaultExt - Расширение файла по умолчанию \n" +
                "6. CheckFileExists - Проверить, существет ли выбранный файл \n" +
                "7. CheckPathExists - Проверить, существет ли выбранный путь \n" +
                "8. Filter - Фильтр по файлам \n" +
                "9. Multiselect - Возможность выбрать несколько элементов \n" +
                "10. ShowDialog() - Метод, запускающий диалоговое окно с выбором, куда сохранить \n" +
                "11. OpenFile() - Метод, открывающий данный файл \n" +
                "События: \n" +
                "1. Disposed - Вызовется при удалении компонента \n" +
                "2. FileOk - Вызовется когда пользователь нажимает 'Открыть' или 'Сохранить' в диалоговом окне \n" +
                "3. HelpRequest - Вызовется при нажатии 'Help' в диалоговом окне";
        }
    }
}
