using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PagedList;

namespace lab3
{
    public partial class Main : Form
    {
        int pageNumber = 1;
        int pageSize = 2;
        IPagedList<Publication> publicationsCrop;
        List<Publication> publications = new List<Publication>();
        public List<Author> authors = new List<Author>();
        public List<Publisher> publishers = new List<Publisher>();
        public void AddNewPublication(Publication newPublication)
        {
            var existingIndex = publications.FindIndex(r => r.Id == newPublication.Id);
            if (existingIndex != -1)
            {
                publications[existingIndex] = newPublication;
            } 
            else
            {
                publications.Add(newPublication);
            }

            RenderTable();
        }

        void RenderTable()
        {
            publicationsCrop = publications.ToPagedList(pageNumber, pageSize);

            publicationBindingSource.Clear();
            foreach (Publication publication in publicationsCrop.ToList())
            {
                publicationBindingSource.Add(publication);
            }
            prevBtn.Enabled = publicationsCrop.HasPreviousPage;
            nextBtn.Enabled = publicationsCrop.HasNextPage;
            lblPageNumber.Text = string.Format("Страница {0}/{1}", publications.Count > 0 ? pageNumber : 0, publicationsCrop.PageCount);
        }

        public Main()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            authors.Add(new Author()
            {
                Id = "0",
                FullName = "Осипов Генадий Генадьевич",
                BirthDate = new DateTime(1980, 10, 26),
                PlaceOfWork = "ЦРУ",
                CitationIndex = 87,
                ScienceDegree = "Доктор наук"
            });
            authors.Add(new Author()
            {
                Id = "1",
                FullName = "Юровский Юлий Юрьевич",
                BirthDate = new DateTime(1987, 11, 11),
                PlaceOfWork = "Wikileaks",
                CitationIndex = 56,
                ScienceDegree = "Кандидат наук"
            });

            publishers.Add(new Publisher()
            {
                Id = "0",
                Name = "Здоровье и молодость",
                Type = "Сайт", 
                CreationDate = new DateTime(2007, 09, 12)
            });
            publishers.Add(new Publisher()
            {
                Id = "1",
                Name = "Биотехнологии 21 века",
                Type = "Журнал",
                CreationDate = new DateTime(2002, 04, 07)
            });

            AddNewPublication(new Publication()
            {
                Id = "0",
                Title = "Регенерация конечностей",
                Doi = "12.2300/123d2",
                Udc = "681.58",
                CountPages = 20,
                CreationDate = new DateTime(2003, 10, 26),
                Publisher = publishers[0],
                Citation = 23,
                Authors = new List<Author> { authors[0], authors[1] }
            });
            AddNewPublication(new Publication()
            {
                Id = "1",
                Title = "Россия разработала новое биологическое оружие",
                Doi = "14.5640 / 5932",
                Udc = "780.10",
                CountPages = 36,
                CreationDate = new DateTime(2014, 07, 17),
                Publisher = publishers[1],
                Citation = 2035,
                Authors = new List<Author> { authors[0] }
            });
            AddNewPublication(new Publication()
            {
                Id = "2",
                Title = "Тест",
                Doi = "14.5640 / 5932",
                Udc = "780.10",
                CountPages = 36,
                CreationDate = new DateTime(2014, 07, 17),
                Publisher = publishers[1],
                Citation = 2035,
                Authors = new List<Author> { authors[0] }
            });

            RenderTable();
        }

        private void dataGridView1_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (e.Value is Publisher)
            {
                e.Value = (e.Value as Publisher).Name;
            }
            if (this.dataGridView1.Columns[e.ColumnIndex].Name == "authorsDataGridViewTextBoxColumn")
            {
                List<Author> authorsCollection = (e.Value as List<Author>);
                if (authorsCollection != null && authorsCollection.Count > 0)
                {
                    e.Value = "";
                    Author LastAuthor = authorsCollection.Last();
                    foreach (Author author in authorsCollection)
                    {
                        e.Value += author.FullName + (author.Equals(LastAuthor) ? "" : ", ");
                    }
                }
            }
        }

        private void removePublication_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Вы точно хотите удалить данную работу?", "Предупреждение", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                string id = Convert.ToString(dataGridView1.Rows[dataGridView1.CurrentRow.Index].Cells[0].Value);
                var itemToRemove = publications.SingleOrDefault(r => r.Id == id);
                if (itemToRemove != null)
                {
                    publications.Remove(itemToRemove);
                }

                pageNumber = 1;

                RenderTable();
            }
        }

        private void prevBtn_Click(object sender, EventArgs e)
        {
            if (publicationsCrop.HasPreviousPage)
            {
                --pageNumber;
                RenderTable();
            }
        }

        private void nextBtn_Click(object sender, EventArgs e)
        {
            if (publicationsCrop.HasNextPage)
            {
                ++pageNumber;
                RenderTable();
            }
        }

        private void menuStripNewPublicationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CreatePublication createPublicationForm = new CreatePublication(authors, publishers);
            createPublicationForm.Show();
        }

        private void addPublication_Click(object sender, EventArgs e)
        {
            CreatePublication createPublicationForm = new CreatePublication(authors, publishers);
            createPublicationForm.Show();
        }

        private void change_Click(object sender, EventArgs e)
        {
            string id = Convert.ToString(dataGridView1.Rows[dataGridView1.CurrentRow.Index].Cells[0].Value);
            var publication = publications.SingleOrDefault(r => r.Id == id);
            CreatePublication createPublicationForm = new CreatePublication(authors, publishers, publication);
            createPublicationForm.Show();
        }

        private void newAuthorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CreateAuthor CreateAuthorForm = new CreateAuthor();
            CreateAuthorForm.Show();
        }

        private void newPublisherToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CreatePublisher CreatePublisherForm = new CreatePublisher();
            CreatePublisherForm.Show();
        }
    }
}
