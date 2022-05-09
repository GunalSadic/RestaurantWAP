using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RestaurantV2
{
    public partial class AddRegistrationForm : Form
    {
        public Form1 parent;
        public AddRegistrationForm(Form1 form)
        {
            parent = form;
            InitializeComponent();
        }

        private void addBtn_Click(object sender, EventArgs e)
        {
            if (ValidateChildren())
            {
                int Id = int.Parse(idBox.Text);
                string creatorName = creatorBox.Text;
                double price = double.Parse(priceBox.Text);

                Reservation reservation = new Reservation(Id, creatorName, price);
                parent.addReservation(reservation);

                Close();
            }
        }

        private void idBox_Validating(object sender, CancelEventArgs e)
        {
            try
            {
                int value = int.Parse(idBox.Text);

                if (value <= 0)
                {
                    throw new ArgumentException();
                }
            }
            catch (FormatException)
            {
                errProvider.SetError((Control)sender, "The Id should be a number");
                e.Cancel = true;
            }
            catch (ArgumentException)
            {
                errProvider.SetError((Control)sender, "The Id should be a number bigger than 0");
                e.Cancel = true;
            }
        }

        private void creatorBox_Validating(object sender, CancelEventArgs e)
        {
            if (creatorBox.Text.Length < 3)
            {
                errProvider.SetError((Control)sender, "The name should be at least 3 characters long");
                e.Cancel = true;
            }
        }

        private void priceBox_Validating(object sender, CancelEventArgs e)
        {
            try
            {
                double value = double.Parse(priceBox.Text);

                if (value <= 0)
                {
                    throw new ArgumentException();
                }
            }
            catch (FormatException)
            {
                errProvider.SetError((Control)sender, "The price should be a number");
                e.Cancel = true;
            }
            catch (ArgumentException)
            {
                errProvider.SetError((Control)sender, "The price should be a number bigger than 0");
                e.Cancel = true;
            }
        }

        private void idBox_Validated(object sender, EventArgs e)
        {
            errProvider.SetError((Control)sender, string.Empty);
        }

        private void creatorBox_Validated(object sender, EventArgs e)
        {
            errProvider.SetError((Control)sender, string.Empty);
        }

        private void priceBox_Validated(object sender, EventArgs e)
        {
            errProvider.SetError((Control)sender, string.Empty);
        }
    }
}
