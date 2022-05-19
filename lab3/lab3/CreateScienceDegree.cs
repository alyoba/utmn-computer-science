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
    public partial class CreateScienceDegree : Form
    {
        string _Id;
        ScienceDegree _data;
        public CreateScienceDegree(ScienceDegree data = null)
        {
            _data = data;
            InitializeComponent();
        }

        private void CreatePublisher_Load(object sender, EventArgs e)
        {
            _Id = Guid.NewGuid().ToString("N");
            Console.WriteLine(_data);
            if (_data != null)
            {
                create.Text = "Изменить";
                this.Text = "Изменить";
                _Id = _data.Id;
                content.Text = _data.Name;
            }
        }

        private void create_Click(object sender, EventArgs e)
        {
            
            var form = Application.OpenForms.OfType<ScienceDegrees>().Single();
            form.AddNew(new ScienceDegree()
            {
                Id = _Id,
                Name = content.Text,
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
