using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lab3
{
    public partial class CreateAuthor : Form
    {
        List<ScienceDegree> ScienceDegrees;
        List<Workplace> Workplaces;
        string _Id;
        Author _data;
        public CreateAuthor(List<ScienceDegree> scienceDegrees, List<Workplace> workplaces, Author data = null)
        {
            _data = data;
            ScienceDegrees = scienceDegrees;
            Workplaces = workplaces;
            InitializeComponent();
        }

        private void CreateAuthor_Load(object sender, EventArgs e)
        {
            scienceDegree.DataSource = ScienceDegrees;
            workplace.DataSource = Workplaces;
            _Id = Guid.NewGuid().ToString("N");
            if (_data != null)
            {
                create.Text = "Изменить";
                this.Text = "Изменить";
                _Id = _data.Id;
                fullName.Text = _data.FullName;
                date.Value = _data.BirthDate;

                for (int i = 0; i < scienceDegree.Items.Count; i++)
                {
                    if ((scienceDegree.Items[i] as ScienceDegree).Id == _data.ScienceDegreeId)
                    {
                        scienceDegree.SelectedItem = scienceDegree.Items[i];
                    }
                }

                for (int i = 0; i < workplace.Items.Count; i++)
                {
                    if ((workplace.Items[i] as Workplace).Id == _data.WorkplaceId)
                    {
                        workplace.SelectedItem = workplace.Items[i];
                    }
                }
            }
        }

        private void create_Click(object sender, EventArgs e)
        {
            Regex rgx = new Regex(@"^[a-zA-ZА-Яа-я .]+$");
            if (rgx.IsMatch(fullName.Text))
            {
                var authorsForm = Application.OpenForms.OfType<Authors>().Single();
                authorsForm.AddNew(new Author()
                {
                    Id = _Id,
                    FullName = fullName.Text,
                    BirthDate = date.Value.Date,
                    WorkplaceId = Workplaces.Single(p => p.Id == (workplace.SelectedItem as Workplace).Id).Id,
                    ScienceDegreeId = ScienceDegrees.Single(p => p.Id == (scienceDegree.SelectedItem as ScienceDegree).Id).Id,
                });

                if (_data != null)
                {
                    MessageBox.Show("Успешно обновлено", "Успех!");
                }
                else
                {
                    MessageBox.Show("Успешно создано", "Успех!");
                }
                this.Close();
            } 
            else
            {
                MessageBox.Show("Имя не соотвествует критериям", "Ошибка!");
            }
        }
    }
}
