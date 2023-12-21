using System;

namespace OOAP_lab_5
{
    class WeaponWithAccessory : IWeapon
    {
        private readonly IWeapon baseWeapon;
        private readonly IWeaponAccessory accessory;

        public WeaponWithAccessory(IWeapon baseWeapon, IWeaponAccessory accessory)
        {
            this.baseWeapon = baseWeapon;
            this.accessory = accessory;
        }

        public string Name
        {
            get => $"{baseWeapon.Name} with {accessory.Name}";
            set
            {
                // Можливо, ви хочете дозволити встановлення імені базової зброї або здавати помилку
                baseWeapon.Name = value;
            }
        }
        public int Range => baseWeapon.Range;
        public int Power => baseWeapon.Power + accessory.Power;
        public int Weight => baseWeapon.Weight + accessory.Weight;

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