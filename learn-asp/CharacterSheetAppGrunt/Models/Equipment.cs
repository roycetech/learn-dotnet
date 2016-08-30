using System;
using System.Collections.Generic;


namespace CharacterSheetAppGrunt.Models
{
  public class Equipment
  {
    public String Name;

    public static void Create(String equipmentName) {
      Equipment equipment = new Equipment();
      equipment.Name = equipmentName;

      GlobalVariables.Equipments.Add(equipment);
    }

    public static List<Equipment> GetAll() {
      return GlobalVariables.Equipments;
    }

  }
}

