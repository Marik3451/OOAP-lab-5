using System;
using System.Windows.Forms;

namespace OOAP_lab_5
{
    class Pistol : IWeapon
    {
        public string Name { get; set; } = "Pistol";
        public int Range { get; } = 100;
        public int Power { get; } = 15;
        public int Weight { get; } = 2;

        private bool hasOptics;
        private bool hasSilencer;

        public bool HasAccessory(Type type)
        {
            if (type == typeof(Optics))
            {
                return hasOptics;
            }
            else if (type == typeof(Silencer))
            {
                return hasSilencer;
            }
            else
            {
                // Якщо тип не відповідає жодному аксесуару, повертаємо false
                return false;
            }
        }

        public void SetAccessory(Type type, bool @checked)
        {
            if (type == typeof(Optics))
            {
                hasOptics = @checked;
            }
            else if (type == typeof(Silencer))
            {
                hasSilencer = @checked;
            }
            // Інакше можливо ви хочете викинути або обробити виняток, якщо тип не відповідає жодному аксесуару
        }

    }
}