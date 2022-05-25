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
    public partial class CreateGenre : Form
    {
        List<Work> Works;
        string _Id;
        Genre _data;
        public CreateGenre(List<Work> works, Genre data = null)
        {
            _data = data;
            Works = works;
            InitializeComponent();
        }

        private void CreateAuthor_Load(object sender, EventArgs e)
        {
            work.DataSource = Works;
            _Id = Guid.NewGuid().ToString("N");
            if (_data != null)
            {
                create.Text = "Изменить";
                this.Text = "Изменить";
                _Id = _data.Id;
                genre.Text = _data.Name;

                for (int i = 0; i < work.Items.Count; i++)
                {
                    if ((work.Items[i] as Work).Id == _data.WorkId)
                    {
                        work.SelectedItem = work.Items[i];
                    }
                }
            }
        }

        private void create_Click(object sender, EventArgs e)
        {
            var form = Application.OpenForms.OfType<Genres>().Single();
            form.AddNew(new Genre()
            {
                Id = _Id,
                Name = genre.Text,
                WorkId = Works.Single(p => p.Id == (work.SelectedItem as Work).Id).Id,
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
    }
}
