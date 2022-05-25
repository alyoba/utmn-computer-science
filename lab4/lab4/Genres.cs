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
    public partial class Genres : Form
    {
        int pageNumber = 1;
        int pageSize = 2;
        IPagedList<Genre> listCrop;
        List<Work> Works = new List<Work>();
        List<Genre> items = new List<Genre>();
        public Genres(ref List<Work> works, ref List<Genre> genres)
        {
            Works = works;
            items = genres;
            InitializeComponent();
        }
        public void AddNew(Genre newItem)
        {
            var mainForm = Application.OpenForms.OfType<Main>().Single();
            mainForm.connection.Open();
            OleDbCommand command = new OleDbCommand();
            command.Connection = mainForm.connection;
            var existingIndex = items.FindIndex(r => r.Id == newItem.Id);
            if (existingIndex != -1)
            {
                command.CommandText = "UPDATE Genre SET workId = '" + newItem.WorkId + "', genre = '" + newItem.Name + "' WHERE id = " + newItem.Id;
                items[existingIndex] = newItem;
            }
            else
            {
                command.CommandText = "INSERT INTO Genre (workId, genre) VALUES('" + newItem.WorkId + "', '" + newItem.Name + "'); ";
                items.Add(newItem);
            }
            command.ExecuteReader();
            mainForm.connection.Close();
            mainForm.LoadEntity("Genre");
            RenderTable();
        }

        void RenderTable()
        {
            listCrop = items.ToPagedList(pageNumber, pageSize);

            genreBindingSource.Clear();
            foreach (Genre item in listCrop.ToList())
            {
                genreBindingSource.Add(item);
            }
            prevBtn.Enabled = listCrop.HasPreviousPage;
            nextBtn.Enabled = listCrop.HasNextPage;
            lblPageNumber.Text = string.Format("Страница {0}/{1}", items.Count > 0 ? pageNumber : 0, listCrop.PageCount);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            RenderTable();
        }

        private void dataGridView1_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (this.dataGridView1.Columns[e.ColumnIndex].Name == "WorkId")
            {
                Work work = Works.SingleOrDefault(p => p.Id == (e.Value as string));
                if (work != null)
                {
                    e.Value = work.Title;
                }
                else
                {
                    e.Value = "";
                }
            }
        }

        private void remove_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Вы точно хотите удалить?", "Предупреждение", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                string id = Convert.ToString(dataGridView1.Rows[dataGridView1.CurrentRow.Index].Cells[0].Value);
                var mainForm = Application.OpenForms.OfType<Main>().Single();
                mainForm.connection.Open();
                OleDbCommand command = new OleDbCommand();
                command.Connection = mainForm.connection;
                command.CommandText = "DELETE FROM Genre WHERE id = " + id;
                command.ExecuteReader();
                mainForm.connection.Close();
                mainForm.LoadEntity("Genre");
                pageNumber = 1;

                RenderTable();
            }
        }

        private void prevBtn_Click(object sender, EventArgs e)
        {
            if (listCrop.HasPreviousPage)
            {
                --pageNumber;
                RenderTable();
            }
        }

        private void nextBtn_Click(object sender, EventArgs e)
        {
            if (listCrop.HasNextPage)
            {
                ++pageNumber;
                RenderTable();
            }
        }

        private void add_Click(object sender, EventArgs e)
        {
            CreateGenre createAuthorForm = new CreateGenre(Works);
            createAuthorForm.Show();
        }

        private void change_Click(object sender, EventArgs e)
        {
            string id = Convert.ToString(dataGridView1.Rows[dataGridView1.CurrentRow.Index].Cells[0].Value);
            var item = items.SingleOrDefault(r => r.Id == id);
            CreateGenre createAuthorForm = new CreateGenre(Works, item);
            createAuthorForm.Show();
        }
    }
}
