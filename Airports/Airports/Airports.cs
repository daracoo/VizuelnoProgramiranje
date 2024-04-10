using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Airports
{
    public partial class Airports : Form
    {
        public Airports()
        {
            InitializeComponent();
        }

        private void btnAddAirport_Click(object sender, EventArgs e)
        {
            AddAirport addAirport = new AddAirport();
            if(addAirport.ShowDialog()  == DialogResult.OK)
            {
                lbAirports.Items.Add(addAirport.airport);
            }
        }
        private void btnDeleteAirport_Click(object sender, EventArgs e)
        {
            if(lbAirports.SelectedIndex == -1) // proverka dali e seletiran element
            {
                return;
            }
            DialogResult dg = MessageBox.Show("Дали сте сигурни?", "Избриши", MessageBoxButtons.OKCancel);
            if(dg == DialogResult.OK)//dokolku e stegnato OK
            {
                int selectedIndex = lbAirports.SelectedIndex;//se zema selektirano
                lbAirports.Items.RemoveAt(selectedIndex);//se brisi
            }
        }

        private void Airports_Load(object sender, EventArgs e)
        {

        }

        private void btnAddDestination_Click(object sender, EventArgs e)
        {
            if(lbAirports.SelectedIndex != -1)//selektiran e aerodrom
            {
                AddDestination addDestinationForm = new AddDestination();
                if(addDestinationForm.ShowDialog() == DialogResult.OK )
                {
                    Airport selectedAirport = lbAirports.Items[lbAirports.SelectedIndex] as Airport; //prvo treba da go zemime soodvenio aerodrom so e selektiran
                    selectedAirport.Destinations.Add(addDestinationForm.createdDestination); //na aerodromo mu dodeluva destinacija
                    LoadDestinations();
                }
            }

        }
        private void LoadDestinations()//ovaj metod go zema selektirano aerodrom i mu gi dodava destinaciite
        {
            lbDestinations.Items.Clear();
            tbAverageDestination.Clear();
            tbMostExpensiveDestination.Clear();
            if(lbAirports.SelectedIndex != -1)
            {
                Airport selectedAirport = lbAirports.Items[lbAirports.SelectedIndex] as Airport;
                foreach (Destination destination in selectedAirport.Destinations)
                {
                    lbDestinations.Items.Add(destination);
                }
                //average destination
                double sum = 0;
                foreach(Destination destination in selectedAirport.Destinations)
                {
                    sum += destination.Distance;
                }
                if(selectedAirport.Destinations.Count != 0)
                {
                    double average = sum / selectedAirport.Destinations.Count;
                    tbAverageDestination.Text = $"{average}";
                }
                else
                {
                    tbAverageDestination.Text = "Овај аеродром нема дестинации";
                }

                //most expensive destination
                if(selectedAirport.Destinations.Count == 0)
                {
                    tbMostExpensiveDestination.Text = "Овај аеродром нема дестинации";
                }
                else
                {
                    Destination max = selectedAirport.Destinations[0];
                    for(int i=0; i<selectedAirport.Destinations.Count; i++) 
                    {
                        if (selectedAirport.Destinations[i].Price > max.Distance)
                        {
                            max = selectedAirport.Destinations[i];
                        }
                    }
                    tbMostExpensiveDestination.Text = max.ToString();
                }
                
            }
        }

        private void lbAirports_SelectedIndexChanged(object sender, EventArgs e)//koga ce se promeni aeordrom vo listava se menuva i destinacite
        {
            LoadDestinations();
        }

        private void lbAirports_SelectedValueChanged(object sender, EventArgs e)
        {
            LoadDestinations();
        }
    }
}
