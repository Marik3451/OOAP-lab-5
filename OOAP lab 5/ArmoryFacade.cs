using System.Collections.Generic;
using System;
using System.Collections;
using System.Windows.Forms;

namespace OOAP_lab_5
{
    public class ArmoryFacade : IEnumerable<IWeapon>
    {
        private readonly List<IWeapon> weapons = new List<IWeapon>();

        public void AddWeapon(IWeapon weapon)
        {
            weapons.Add(weapon);
        }

        public void AddAccessoryToWeapon(IWeapon weapon, IWeaponAccessory accessory)
        {
            var weaponWithAccessory = new WeaponWithAccessory(weapon, accessory);
            weapons.Add(weaponWithAccessory);
        }

        public int CalculateTotalCost()
        {
            int totalCost = 0;
            foreach (var weapon in weapons)
            {
                totalCost += CalculateWeaponCost(weapon);
            }
            return totalCost;
        }

        public int CalculateWeaponCost(IWeapon weapon)
        {
            // Перевірка на null і інші необхідні перевірки, які може вам знадобитися зробити
            if (weapon != null)
            {
                return weapon.Power * weapon.Range;
            }
            else
            {
                // Ви можете викидати виключення або повертати спеціальне значення
                throw new ArgumentNullException("weapon", "Weapon cannot be null");
                // або
                // return -1;
            }
        }

        public IWeapon GetMostExpensiveWeapon()
        {
            if (weapons.Count == 0)
                return null;

            IWeapon mostExpensiveWeapon = weapons[0];
            foreach (var weapon in weapons)
            {
                if (CalculateWeaponCost(weapon) > CalculateWeaponCost(mostExpensiveWeapon))
                {
                    mostExpensiveWeapon = weapon;
                }
            }
            return mostExpensiveWeapon;
        }

        /*public void DepreciateWeapons(int depreciationYear)
        {
            foreach (var weapon in weapons)
            {
                // Моделюємо знос на підставі року випуску
                int yearsInUse = DateTime.Now.Year - depreciationYear;
                // Зменшуємо вартість на 10% за кожен рік використання
                int depreciationRate = 10;
                int depreciation = (int)(CalculateWeaponCost(weapon) * (yearsInUse * depreciationRate / 100.0));
                MessageBox.Show($"Depreciating {weapon.Name} by {depreciation}$ due to {yearsInUse} years of use.");
            }
        }*/

        public void DepreciateWeaponse(IWeapon weapon, int depreciationYear)
        {
            // Моделюємо знос на підставі року випуску
            int yearsInUse = DateTime.Now.Year - depreciationYear;
            // Зменшуємо вартість на 10% за кожен рік використання
            int depreciationRate = 10;
            int depreciation = (int)(CalculateWeaponCost(weapon) * (yearsInUse * depreciationRate / 144.0));

            MessageBox.Show($"Depreciating {weapon.Name} by {depreciation}$ due to {yearsInUse} years of use.");
        }

        public IEnumerator<IWeapon> GetEnumerator()
        {
            return weapons.GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }

}