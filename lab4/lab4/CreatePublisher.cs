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
    public partial class CreatePublisher : Form
    {
        string _Id;
        Publisher _data;
        public CreatePublisher(Publisher data = null)
        {
            _data = data;
            InitializeComponent();
        }

        private void CreatePublisher_Load(object sender, EventArgs e)
        {
            _Id = Guid.NewGuid().ToString("N");
            if (_data != null)
            {
                create.Text = "Изменить";
                this.Text = "Изменить";
                _Id = _data.Id;
                place.Text = _data.Place;
                phone.Text = _data.PhoneNumber;
                address.Text = _data.Address;
            }
        }

        private void create_Click(object sender, EventArgs e)
        {
            Regex rgx = new Regex(@"^[\+]?[(]?[0-9]{3}[)]?[-\s\.]?[0-9]{3}[-\s\.]?[0-9]{4,6}$");
            if (rgx.IsMatch(phone.Text))
            {
                var form = Application.OpenForms.OfType<Publishers>().Single();
                form.AddNew(new Publisher()
                {
                    Id = _Id,
                    Place = place.Text,
                    PhoneNumber = phone.Text,
                    Address = address.Text
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
            else
            {
                MessageBox.Show("Телефон не соотвествует критериям", "Ошибка!");
            }
        }
    }
}
