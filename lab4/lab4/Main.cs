using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
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
        private string dbPath = @"C:\Users\79829\source\repos\utmn-computer-science\lab4\database.accdb";
        public OleDbConnection connection = new OleDbConnection();
        int pageNumber = 1;
        int pageSize = 2;
        IPagedList<Work> publicationsCrop;
        public List<Work> publications = new List<Work>();
        public List<UDK> udks = new List<UDK>();
        public List<ScienceDegree> scienceDegrees = new List<ScienceDegree>();
        public List<Genre> genres = new List<Genre>();
        public List<Workplace> workplaces = new List<Workplace>();
        public List<Author> authors = new List<Author>();
        public List<Publisher> publishers = new List<Publisher>();
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
        public void AddNewToDb(Work newItem)
        {
            string itemId = newItem.Id;
            connection.Open();
            OleDbCommand command = new OleDbCommand();
            command.Connection = connection;
            var existingIndex = publications.FindIndex(r => r.Id == newItem.Id);
            if (existingIndex != -1)
            {
                OleDbCommand command2 = new OleDbCommand();
                command2.Connection = connection;
                command2.CommandText = "DELETE FROM [Work&Authors] WHERE workId = " + newItem.Id + ";";
                command2.ExecuteReader();
            }

            if (existingIndex != -1)
            {
                command.CommandText = "UPDATE Works SET title = '" + newItem.Title + "', pages = '" + newItem.CountPages + "', udcId = '" + newItem.UdcId + "', dates = '" + newItem.CreationDate.ToString("dd.MM.yyy H:mm:ss") + "', publicationHouseId = '" + newItem.PublisherId + "', doi = '" + newItem.Doi + "' WHERE id = " + newItem.Id;
                publications[existingIndex] = newItem;
                command.ExecuteReader();
            }
            else
            {
                command.CommandText = "INSERT INTO Works (title, pages, udcId, dates, publicationHouseId, doi) VALUES('" + newItem.Title + "', '" + newItem.CountPages + "', '" + newItem.UdcId + "', '" + newItem.CreationDate.ToString("dd.MM.yyy H:mm:ss") + "', '" + newItem.PublisherId + "', '" + newItem.Doi + "'); ";
                command.ExecuteNonQuery();

                command.CommandText = "SELECT @@IDENTITY";
                itemId = Convert.ToString(command.ExecuteScalar());
                publications.Add(newItem);
            }

            Console.WriteLine("item id = " + itemId);
            

            if (newItem.AuthorsIds.Count > 0)
            {
                foreach (string authorId in newItem.AuthorsIds)
                {
                    OleDbCommand command3 = new OleDbCommand();
                    command3.Connection = connection;
                    command3.CommandText = "INSERT INTO [Work&Authors] (workId, AuthorId) VALUES (" + itemId + ", " + authorId + ");\n";
                    command3.ExecuteNonQuery();
                }
            }

            connection.Close();
            LoadEntity("Works");
            RenderTable();
        }
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
        public void LoadEntity(string entityName)
        {
            switch (entityName)
            {
                case "UDK":
                    udks.Clear();
                    break;
                case "ScienceDegree":
                    scienceDegrees.Clear();
                    break;
                case "Publishers":
                    publishers.Clear();
                    break;
                case "Workplace":
                    workplaces.Clear();
                    break;
                case "Author":
                    authors.Clear();
                    break;
                case "Genre":
                    genres.Clear();
                    break;
                case "Works":
                    publications.Clear();
                    break;
            }
            connection.Open();
            OleDbCommand command = new OleDbCommand();
            command.Connection = connection;
            command.CommandText = "SELECT * FROM " + entityName + " WHERE 1";
            OleDbDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                switch (entityName)
                {
                    case "UDK":
                        AddNew(new UDK()
                        {
                            Id = reader.GetValue(0).ToString(),
                            Name = reader.GetString(1)
                        });
                        break;
                    case "ScienceDegree":
                        AddNew(new ScienceDegree()
                        {
                            Id = reader.GetValue(0).ToString(),
                            Name = reader.GetString(1)
                        });
                        break;
                    case "Publishers":
                        AddNew(new Publisher()
                        {
                            Id = reader.GetValue(0).ToString(),
                            Place = reader.GetString(1),
                            Address = reader.GetString(2),
                            PhoneNumber = reader.GetString(3)
                        });
                        break;
                    case "Workplace":
                        AddNew(new Workplace()
                        {
                            Id = reader.GetValue(0).ToString(),
                            Name = reader.GetString(1),
                            PhoneNumber = reader.GetString(2),
                            Address = reader.GetString(3),
                        });
                        break;
                    case "Author":
                        AddNew(new Author()
                        {
                            Id = reader.GetValue(0).ToString(),
                            FullName = reader.GetString(1),
                            BirthDate = DateTime.Parse(reader.GetValue(2).ToString()),
                            WorkplaceId = reader.GetValue(3).ToString(),
                            ScienceDegreeId = reader.GetValue(4).ToString()
                        });
                        break;
                    case "Genre":
                        AddNew(new Genre()
                        {
                            Id = reader.GetValue(0).ToString(),
                            WorkId = reader.GetValue(1).ToString(),
                            Name = reader.GetString(2)
                        });
                        break;
                    case "Works":
                        OleDbCommand command2 = new OleDbCommand();
                        command2.Connection = connection;
                        command2.CommandText = "SELECT [Work&Authors].* FROM[Work&Authors] WHERE([Work&Authors].workId = "+ reader.GetValue(0).ToString() + ")";
                        OleDbDataReader reader2 = command2.ExecuteReader();
                        List<string> authorsIds = new List<string>();
                        while (reader2.Read())
                        {
                            authorsIds.Add(reader2.GetValue(2).ToString());
                        }
                        reader2.Close();

                        AddNew(new Work()
                        {
                            Id = reader.GetValue(0).ToString(),
                            Title = reader.GetString(1),
                            CountPages = Convert.ToInt32(reader.GetValue(2).ToString()),
                            UdcId = reader.GetValue(3).ToString(),
                            CreationDate = DateTime.Parse(reader.GetValue(4).ToString()),
                            PublisherId = reader.GetValue(5).ToString(),
                            Doi = reader.GetString(6),
                            AuthorsIds = authorsIds
                        });
                        break;
                }
            }
            reader.Close();
            connection.Close();
        }
        public Main()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            connection.ConnectionString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source="+ dbPath + ";Persist Security Info=False;";

            LoadEntity("UDK");
            LoadEntity("ScienceDegree");
            LoadEntity("Publishers");
            LoadEntity("Workplace");
            LoadEntity("Author");
            LoadEntity("Works");
            LoadEntity("Genre");
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
                var mainForm = Application.OpenForms.OfType<Main>().Single();
                mainForm.connection.Open();

                OleDbCommand command2 = new OleDbCommand();
                command2.Connection = connection;
                command2.CommandText = "DELETE FROM [Work&Authors] WHERE workId = " + id + ";";
                command2.ExecuteReader();

                OleDbCommand command = new OleDbCommand();
                command.Connection = mainForm.connection;
                command.CommandText = "DELETE FROM Works WHERE id = " + id;
                command.ExecuteReader();
                mainForm.connection.Close();
                mainForm.LoadEntity("Works");

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
