using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OOAP_lab_5
{
    public partial class Form1 : Form
    {
        private readonly ArmoryFacade armory;
        public Form1()
        {
            armory = new ArmoryFacade();
            InitializeComponent();
            PopulateListBox();
            ShuffleListGun();
        }

        private void ShuffleListGun()
        {
            armory.AddWeapon(new Pistol());
            armory.AddWeapon(new Rifle());
            armory.AddWeapon(new MachineGun());
            armory.AddAccessoryToWeapon(new Pistol(), new Silencer());
            armory.AddAccessoryToWeapon(new Rifle(), new Silencer());

            foreach (var weapon in armory)
            {
                listBox1.Items.Add(weapon.Name);
            }
        }

        private void PopulateListBox()
        {
            foreach (var weapon in armory)
            {
                listBox1.Items.Add(weapon.Name);
            }
        }
        private void BtnCalculateTotalCost_Click(object sender, EventArgs e)
        {
            MessageBox.Show($"Total cost of the armory: {armory.CalculateTotalCost()}$");
        }

        private void BtnGetMostExpensive_Click(object sender, EventArgs e)
        {
            MessageBox.Show($"Most expensive weapon: {armory.GetMostExpensiveWeapon()?.Name}");
        }

        private void BtnDepreciateWeapons_Click(object sender, EventArgs e)
        {
            if (listBox1.SelectedItem != null)
            {
                // Отримуємо вибраний елемент
                string selectedWeaponName = listBox1.SelectedItem.ToString();

                // Знаходимо об'єкт IWeapon за його іменем
                IWeapon selectedWeapon = armory.FirstOrDefault(weapon => weapon.Name == selectedWeaponName);

                if (selectedWeapon != null)
                {
                    // Викликаємо метод DepreciateWeapons для вибраної зброї
                    armory.DepreciateWeaponse(selectedWeapon, 2010);
                }
                else
                {
                    MessageBox.Show("Selected item is not a valid weapon.");
                }
            }
            else
            {
                MessageBox.Show("Please select a valid weapon.");
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            FormAddWeapon formAddWeapon = new FormAddWeapon(armory);
            formAddWeapon.ShowDialog();

            // Оновлення ListBox після закриття вікна додавання зброї
            listBox1.Items.Clear();
            PopulateListBox();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (listBox1.SelectedItem != null)
            {
                listBox1.Items.Remove(listBox1.SelectedItem);
            }
        }

        private void buttonShowPrice_Click(object sender, EventArgs e)
        {
            if (listBox1.SelectedItem != null)
            {
                string selectedWeaponName = listBox1.SelectedItem.ToString();

                // Знаходження об'єкта IWeapon за його іменем
                IWeapon selectedWeapon = armory.FirstOrDefault(weapon => weapon.Name == selectedWeaponName);

                if (selectedWeapon != null)
                {
                    try
                    {
                        int cost = armory.CalculateWeaponCost(selectedWeapon);
                        MessageBox.Show($"Cost of selected weapon: {cost} $");
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Error calculating weapon cost: {ex.Message}");
                    }
                }
                else
                {
                    MessageBox.Show("Selected item is not a valid weapon.");
                }
            }
            else
            {
                MessageBox.Show("Please select a valid weapon.");
            }
        }

    }
}


