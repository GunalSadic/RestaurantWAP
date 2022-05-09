using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RestaurantV2
{
    public partial class Form1 : Form
    {
        public Restaurant restaurant = new Restaurant();
        public Form1()
        {
            InitializeComponent();
        }

        private void sortReservations()
        {
            restaurant.reservations.Sort();
            registrationView.Items.Clear();

            foreach (Reservation reservation in restaurant.reservations)
            {
                ListViewItem item = new ListViewItem(reservation.Id.ToString());
                item.SubItems.Add(reservation.creatorName);
                item.SubItems.Add(reservation.price.ToString());

                registrationView.Items.Add(item);
            }
        }

        private void addResBtn_Click(object sender, EventArgs e)
        {
            AddRegistrationForm form = new AddRegistrationForm(this);
            form.Show();

        }

        public void addReservation(Reservation reservation)
        {
            restaurant.reservations.Add(reservation);
            sortReservations();
        }

        public void editReservation(Reservation reservation, int index)
        {
            restaurant.reservations[index] = reservation;

            registrationView.Items[index].SubItems[0].Text = reservation.Id.ToString();
            registrationView.Items[index].SubItems[1].Text = reservation.creatorName;
            registrationView.Items[index].SubItems[2].Text = reservation.price.ToString();

            sortReservations();
        }

        private void registrationView_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            int index = registrationView.SelectedIndices[0];
            EditRegistrationForm form = new EditRegistrationForm(this, index, restaurant.reservations.ElementAt(index));
            form.Show();
        }

        private void serializeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            BinaryFormatter formatter = new BinaryFormatter();
            using (FileStream fs = File.Create("Serialized.bin"))
            {
                formatter.Serialize(fs, restaurant);
            }
        }

        private void deserializeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            BinaryFormatter formatter = new BinaryFormatter();
            using (FileStream fs = File.OpenRead("Serialized.bin"))
            {
                restaurant = (Restaurant)formatter.Deserialize(fs);
                sortReservations();
            }
        }
    }
}
