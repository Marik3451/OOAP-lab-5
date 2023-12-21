using System;

namespace OOAP_lab_5
{
    class Rifle : IWeapon
    {
        public string Name { get; set; } = "Rifle";
        public int Range { get; } = 500;
        public int Power { get; } = 30;
        public int Weight { get; } = 5;

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
