using System;

namespace OOAP_lab_5
{
    public interface IWeapon
    {
        string Name { get; set; }
        int Range { get; }
        int Power { get; }
        int Weight { get; }

        bool HasAccessory(Type type);

        void SetAccessory(Type type, bool @checked);
        
    }
}