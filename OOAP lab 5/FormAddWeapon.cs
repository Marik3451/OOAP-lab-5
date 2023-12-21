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
    // FormAddWeapon.cs
    public partial class FormAddWeapon : Form
    {
        private ArmoryFacade armory;

        public FormAddWeapon(ArmoryFacade armory)
        {
            InitializeComponent();
            this.armory = armory;

            // Наповнення ComboBox із типами зброї
            comboBoxWeaponType.Items.Add("Pistol");
            comboBoxWeaponType.Items.Add("Rifle");
            comboBoxWeaponType.Items.Add("Machine Gun");
        }

        private void btnAddWeapon_Click(object sender, EventArgs e)
        {
            // Отримання обраних значень з ComboBox і CheckBox
            string selectedWeaponType = comboBoxWeaponType.SelectedItem.ToString();
            bool hasOptics = checkBoxOptics.Checked;
            bool hasSilencer = checkBoxSilencer.Checked;

            // Створення нової зброї відповідно до вибору користувача
            IWeapon newWeapon = CreateWeapon(selectedWeaponType, hasOptics, hasSilencer);
            if (newWeapon != null)
            {
                armory.AddWeapon(newWeapon);
                MessageBox.Show("Weapon added successfully!");
                this.Close();
            }
            else
            {
                MessageBox.Show("Error creating weapon.");
            }
        }

        private IWeapon CreateWeapon(string weaponType, bool hasOptics, bool hasSilencer)
        {
            // Створення об'єкта відповідного типу зброї
            IWeapon newWeapon = null;
            switch (weaponType)
            {
                case "Pistol":
                    newWeapon = new Pistol();
                    break;
                case "Rifle":
                    newWeapon = new Rifle();
                    break;
                case "Machine Gun":
                    newWeapon = new MachineGun();
                    break;
            }

            // Додавання аксесуарів в залежності від вибору користувача
            if (newWeapon != null)
            {
                if (hasOptics)
                {
                    IWeaponAccessory optics = new Optics();
                    newWeapon = new WeaponWithAccessory(newWeapon, optics);
                }

                if (hasSilencer)
                {
                    IWeaponAccessory silencer = new Silencer();
                    newWeapon = new WeaponWithAccessory(newWeapon, silencer);
                }
            }

            return newWeapon;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }

}
