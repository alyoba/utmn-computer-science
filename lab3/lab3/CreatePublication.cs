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
        List<UDK> Udcs;
        List<Publisher> Publishers;
        string _Id;
        Work _data;
        public CreatePublication(ref List<Author> authors, ref List<Publisher> publishers, ref List<UDK> udcs, Work data = null)
        {
            _data = data;
            Authors = authors;
            Udcs = udcs;
            Publishers = publishers;
            InitializeComponent();

        }

        private void CreatePublication_Load(object sender, EventArgs e)
        {
            publisher.DataSource = Publishers;
            udc.DataSource = Udcs;
            authorslist.DataSource = Authors;

            _Id = Guid.NewGuid().ToString("N");
            if (_data != null)
            {
                create.Text = "Изменить";
                _Id = _data.Id;
                title.Text = _data.Title;
                doi.Text = _data.Doi;
                count.Value = _data.CountPages;
                date.Value = _data.CreationDate;
                authorslist.SelectedItems.Clear();

                for (int i = 0; i < publisher.Items.Count; i++)
                {
                    if ((publisher.Items[i] as Publisher).Id == _data.PublisherId)
                    {
                        publisher.SelectedItem = publisher.Items[i];
                    }
                }

                for (int i = 0; i < udc.Items.Count; i++)
                {
                    if ((udc.Items[i] as UDK).Id == _data.UdcId)
                    {
                        udc.SelectedItem = udc.Items[i];
                    }
                }

                for (int i = 0; i < authorslist.Items.Count; i++)
                {
                    foreach (string authorId in _data.AuthorsIds)
                    {
                        if ((authorslist.Items[i] as Author).Id == authorId)
                        {
                            authorslist.SelectedItems.Add(authorslist.Items[i]);
                        }
                    }
                }
            }
        }

        private void create_Click(object sender, EventArgs e)
        {
            List<string> authors = new List<string>();
            foreach (Author author in authorslist.SelectedItems)
            {
                authors.Add(author.Id);
            }
            var mainForm = Application.OpenForms.OfType<Main>().Single();
            mainForm.AddNew(new Work()
            {
                Id = _Id,
                Title = title.Text,
                Doi = doi.Text,
                UdcId = Udcs.Single(p => p.Id == (udc.SelectedItem as UDK).Id).Id,
                CountPages = Convert.ToInt32(count.Value),
                CreationDate = date.Value.Date,
                PublisherId = Publishers.Single(p => p.Id == (publisher.SelectedItem as Publisher).Id).Id,
                AuthorsIds = authors
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
