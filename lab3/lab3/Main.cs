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
        IPagedList<Work> publicationsCrop;
        List<Work> publications = new List<Work>();
        public List<UDK> udks = new List<UDK>();
        public List<ScienceDegree> scienceDegrees = new List<ScienceDegree>();
        public List<Genre> genres = new List<Genre>();
        public List<Workplace> workplaces = new List<Workplace>();
        public List<Author> authors = new List<Author>();
        public List<Publisher> publishers = new List<Publisher>();
        public void AddNew(Work newItem)
        {
            var existingIndex = publications.FindIndex(r => r.Id == newItem.Id);
            if (existingIndex != -1)
            {
                publications[existingIndex] = newItem;
            } 
            else
            {
                publications.Add(newItem);
            }

            RenderTable();
        }
        public void AddNew(Author newItem)
        {
            var existingIndex = authors.FindIndex(r => r.Id == newItem.Id);
            if (existingIndex != -1)
            {
                authors[existingIndex] = newItem;
            }
            else
            {
                authors.Add(newItem);
            }

            RenderTable();
        }
        public void AddNew(UDK newItem)
        {
            var existingIndex = udks.FindIndex(r => r.Id == newItem.Id);
            if (existingIndex != -1)
            {
                udks[existingIndex] = newItem;
            }
            else
            {
                udks.Add(newItem);
            }

            RenderTable();
        }
        public void AddNew(ScienceDegree newItem)
        {
            var existingIndex = scienceDegrees.FindIndex(r => r.Id == newItem.Id);
            if (existingIndex != -1)
            {
                scienceDegrees[existingIndex] = newItem;
            }
            else
            {
                scienceDegrees.Add(newItem);
            }

            RenderTable();
        }
        public void AddNew(Genre newItem)
        {
            var existingIndex = genres.FindIndex(r => r.Id == newItem.Id);
            if (existingIndex != -1)
            {
                genres[existingIndex] = newItem;
            }
            else
            {
                genres.Add(newItem);
            }

            RenderTable();
        }
        public void AddNew(Workplace newItem)
        {
            var existingIndex = workplaces.FindIndex(r => r.Id == newItem.Id);
            if (existingIndex != -1)
            {
                workplaces[existingIndex] = newItem;
            }
            else
            {
                workplaces.Add(newItem);
            }

            RenderTable();
        }
        public void AddNew(Publisher newItem)
        {
            var existingIndex = publishers.FindIndex(r => r.Id == newItem.Id);
            if (existingIndex != -1)
            {
                publishers[existingIndex] = newItem;
            }
            else
            {
                publishers.Add(newItem);
            }

            RenderTable();
        }
        public void RenderTable()
        {
            publicationsCrop = publications.ToPagedList(pageNumber, pageSize);
            publicationBindingSource.Clear();
            foreach (Work publication in publicationsCrop.ToList())
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
            AddNew(new UDK()
            {
                Id = "0",
                Name = "345.45"
            });
            AddNew(new UDK()
            {
                Id = "1",
                Name = "123.32"
            });
            AddNew(new UDK()
            {
                Id = "2",
                Name = "753.32"
            });

            AddNew(new ScienceDegree()
            {
                Id = "0",
                Name = "Доктор наук"
            });
            AddNew(new ScienceDegree()
            {
                Id = "1",
                Name = "Кандидат наук"
            });

            AddNew(new Publisher()
            {
                Id = "0",
                Place = "Здоровье и молодость",
                Address = "улица Ленина 48",
                PhoneNumber = "+79089089898"
            });
            AddNew(new Publisher()
            {
                Id = "1",
                Place = "Биотехнологии 21 века",
                Address = "улица Ленина 48",
                PhoneNumber = "+79089089898"
            });

            AddNew(new Workplace()
            {
                Id = "0",
                Name = "Здоровье и молодость",
                Address = "улица Ленина 48",
                PhoneNumber = "+79089089898"
            });
            AddNew(new Workplace()
            {
                Id = "1",
                Name = "Биотехнологии 21 века",
                Address = "улица Ленина 48",
                PhoneNumber = "+79089089898"
            });

            AddNew(new Author()
            {
                Id = "0",
                FullName = "Осипов Генадий Генадьевич",
                BirthDate = new DateTime(1980, 10, 26),
                WorkplaceId = workplaces[0].Id,
                ScienceDegreeId = scienceDegrees[0].Id
            });
            AddNew(new Author()
            {
                Id = "1",
                FullName = "Юровский Юлий Юрьевич",
                BirthDate = new DateTime(1987, 11, 11),
                WorkplaceId = workplaces[1].Id,
                ScienceDegreeId = scienceDegrees[1].Id
            });

            AddNew(new Work()
            {
                Id = "0",
                Title = "Регенерация конечностей",
                Doi = "12.2300/123d2",
                UdcId = udks[0].Id,
                CountPages = 20,
                CreationDate = new DateTime(2003, 10, 26),
                PublisherId = publishers[0].Id,
                AuthorsIds = new List<string> { authors[0].Id, authors[1].Id }
            });
            AddNew(new Work()
            {
                Id = "1",
                Title = "Россия разработала новое биологическое оружие",
                Doi = "14.5640 / 5932",
                UdcId = udks[1].Id,
                CountPages = 36,
                CreationDate = new DateTime(2014, 07, 17),
                PublisherId = publishers[1].Id,
                AuthorsIds = new List<string> { authors[0].Id }
            });
            AddNew(new Work()
            {
                Id = "2",
                Title = "Тест",
                Doi = "14.5640 / 5932",
                UdcId = udks[2].Id,
                CountPages = 36,
                CreationDate = new DateTime(2014, 07, 17),
                PublisherId = publishers[1].Id,
                AuthorsIds = new List<string> { authors[0].Id }
            });

            AddNew(new Genre()
            {
                Id = "0",
                WorkId = publications[0].Id,
                Name = "Биотехнологии"
            });
            AddNew(new Genre()
            {
                Id = "1",
                WorkId = publications[1].Id,
                Name = "Биотехнологии"
            });
            AddNew(new Genre()
            {
                Id = "2",
                WorkId = publications[2].Id,
                Name = "Природа"
            });
        }

        private void dataGridView1_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (this.dataGridView1.Columns[e.ColumnIndex].Name == "PublisherId")
            {
                Publisher publisher = publishers.SingleOrDefault(p => p.Id == (e.Value as string));
                if (publisher != null)
                {
                    e.Value = publisher.Place;
                }
                else
                {
                    e.Value = "";
                }
            }
            if (this.dataGridView1.Columns[e.ColumnIndex].Name == "UdcId")
            {
                UDK udk = udks.SingleOrDefault(u => u.Id == (e.Value as string));
                if (udk != null)
                {
                    e.Value = udk.Name;
                } else
                {
                    e.Value = "";
                }
            }
            if (this.dataGridView1.Columns[e.ColumnIndex].Name == "authorsDataGridViewTextBoxColumn")
            {
                List<string> authorsIdCollection = (e.Value as List<string>);
                if (authorsIdCollection != null && authorsIdCollection.Count > 0)
                {
                    e.Value = "";
                   
                    List<Author> filteredAuthors = authorsIdCollection
                        .ConvertAll<Author>(id => authors.SingleOrDefault(a => a.Id == id))
                        .Where<Author>(a => a != null)
                        .ToList();

                    Author LastAuthor = filteredAuthors.LastOrDefault();

                    foreach (Author author in filteredAuthors)
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

        private void addPublication_Click(object sender, EventArgs e)
        {
            CreatePublication createPublicationForm = new CreatePublication(ref authors, ref publishers, ref udks);
            createPublicationForm.Show();
        }

        private void change_Click(object sender, EventArgs e)
        {
            string id = Convert.ToString(dataGridView1.Rows[dataGridView1.CurrentRow.Index].Cells[0].Value);
            var publication = publications.SingleOrDefault(r => r.Id == id);
            CreatePublication createPublicationForm = new CreatePublication(ref authors, ref publishers, ref udks, publication);
            createPublicationForm.Show();
        }

        private void newAuthorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Authors form = new Authors(ref scienceDegrees, ref workplaces, ref authors);
            form.Show();
        }

        private void newPublisherToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Publishers form = new Publishers(ref publishers);
            form.Show();
        }

        private void udcToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Udks form = new Udks(ref udks);
            form.Show();
        }

        private void workplaceToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Workplaces form = new Workplaces(ref workplaces);
            form.Show();
        }

        private void scienceDegreeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ScienceDegrees form = new ScienceDegrees(ref scienceDegrees);
            form.Show();
        }

        private void genreToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Genres form = new Genres(ref publications, ref genres);
            form.Show();
        }
    }
}
