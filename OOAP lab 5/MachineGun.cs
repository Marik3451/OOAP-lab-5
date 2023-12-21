using System;

namespace OOAP_lab_5
{
    class MachineGun : IWeapon
    {
        public string Name { get; set; } = "Machine Gun";
        public int Range { get; } = 800;
        public int Power { get; } = 40;
        public int Weight { get; } = 10;

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