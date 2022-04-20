using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lab3
{
    public partial class CreatePublication : Form
    {
        List<Author> Authors;
        List<Publisher> Publishers;
        string _Id;
        Publication _data;
        public CreatePublication(List<Author> authors, List<Publisher> publishers, Publication data = null)
        {
            _data = data;
            Authors = authors;
            Publishers = publishers;
            InitializeComponent();

        }

        private void CreatePublication_Load(object sender, EventArgs e)
        {
            publisher.DataSource = Publishers;
            authorslist.DataSource = Authors;

            _Id = Guid.NewGuid().ToString("N");
            if (_data != null)
            {
                create.Text = "Изменить";
                _Id = _data.Id;
                title.Text = _data.Title;
                doi.Text = _data.Doi;
                udc.Text = _data.Udc;
                count.Value = _data.CountPages;
                date.Value = _data.CreationDate;
                citation.Value = _data.Citation;
                authorslist.SelectedItems.Clear();

                for (int i = 0; i < publisher.Items.Count; i++)
                {
                    if ((publisher.Items[i] as Publisher).Id == _data.Publisher.Id)
                    {
                        publisher.SelectedItem = publisher.Items[i];
                    }
                }

                for (int i = 0; i < authorslist.Items.Count; i++)
                {
                    foreach (Author author in _data.Authors)
                    {
                        if ((authorslist.Items[i] as Author).Id == author.Id)
                        {
                            authorslist.SelectedItems.Add(authorslist.Items[i]);
                        }
                    }
                }
            }
        }

        private void create_Click(object sender, EventArgs e)
        {
            List<Author> authors = new List<Author>();
            foreach (Author author in authorslist.SelectedItems)
            {
                authors.Add(author);
            }
            var mainForm = Application.OpenForms.OfType<Main>().Single();
            mainForm.AddNewPublication(new Publication()
            {
                Id = _Id,
                Title = title.Text,
                Doi = doi.Text,
                Udc = udc.Text,
                CountPages = Convert.ToInt32(count.Value),
                CreationDate = date.Value.Date,
                Publisher = Publishers.Single(p => p.Id == (publisher.SelectedItem as Publisher).Id),
                Citation = Convert.ToInt32(citation.Value),
                Authors = authors
            });

            if (_data != null)
            {
                MessageBox.Show("Публикация успешно обновлена", "Успех!");
            }
            else
            {
                MessageBox.Show("Публикация успешно создана", "Успех!");
            }
               
            this.Close();
        }
    }
}
