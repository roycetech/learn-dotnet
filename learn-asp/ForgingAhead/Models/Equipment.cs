using System.ComponentModel.DataAnnotations;


namespace ForgingAhead.Models {
    public class Equipment 
    {
        [Key]
        public string Name { get; set; }
    }

    public static void Create(String equipmentName) {
      Equipment equipment = new Equipment();
      equipment.Name = equipmentName;

      GlobalVariables.Equipments.Add(equipment);
    }

    public static List<Equipment> GetAll() {
      return GlobalVariables.Equipments;
    }

}