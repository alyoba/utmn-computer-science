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
    public partial class ScienceDegrees : Form
    {
        int pageNumber = 1;
        int pageSize = 2;
        IPagedList<ScienceDegree> listCrop;
        List<ScienceDegree> items = new List<ScienceDegree>();
        public ScienceDegrees(ref List<ScienceDegree> scienceDegrees)
        {
            items = scienceDegrees;
            InitializeComponent();
        }
        public void AddNew(ScienceDegree newItem)
        {
            var existingIndex = items.FindIndex(r => r.Id == newItem.Id);
            if (existingIndex != -1)
            {
                items[existingIndex] = newItem;
            } 
            else
            {
                items.Add(newItem);
            }
            var mainForm = Application.OpenForms.OfType<Main>().Single();
            mainForm.AddNew(newItem);
            RenderTable();
        }

        void RenderTable()
        {
            listCrop = items.ToPagedList(pageNumber, pageSize);

            scienceDegreeBindingSource.Clear();
            foreach (ScienceDegree item in listCrop.ToList())
            {
                scienceDegreeBindingSource.Add(item);
            }
            prevBtn.Enabled = listCrop.HasPreviousPage;
            nextBtn.Enabled = listCrop.HasNextPage;
            lblPageNumber.Text = string.Format("Страница {0}/{1}", items.Count > 0 ? pageNumber : 0, listCrop.PageCount);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            RenderTable();
        }
        private void remove_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Вы точно хотите удалить?", "Предупреждение", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                string id = Convert.ToString(dataGridView1.Rows[dataGridView1.CurrentRow.Index].Cells[0].Value);
                var itemToRemove = items.SingleOrDefault(r => r.Id == id);
                if (itemToRemove != null)
                {
                    items.Remove(itemToRemove);
                    var mainForm = Application.OpenForms.OfType<Main>().Single();
                    mainForm.RenderTable();
                }

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
            CreateScienceDegree createForm = new CreateScienceDegree();
            createForm.Show();
        }

        private void change_Click(object sender, EventArgs e)
        {
            string id = Convert.ToString(dataGridView1.Rows[dataGridView1.CurrentRow.Index].Cells[0].Value);
            var item = items.SingleOrDefault(r => r.Id == id);
            CreateScienceDegree createForm = new CreateScienceDegree(item);
            createForm.Show();
        }
    }
}
