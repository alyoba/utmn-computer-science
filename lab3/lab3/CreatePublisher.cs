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
    public partial class CreatePublisher : Form
    {
        public CreatePublisher()
        {
            InitializeComponent();
        }

        private void create_Click(object sender, EventArgs e)
        {
            var mainForm = Application.OpenForms.OfType<Main>().Single();
            mainForm.publishers.Add(new Publisher()
            {
                Id = Guid.NewGuid().ToString("N"),
                Name = title.Text,
                CreationDate = date.Value.Date,
                Type = type.Text,
            });

            MessageBox.Show("Издатель успешно добавлен", "Успех!");
            this.Close();
        }
    }
}
