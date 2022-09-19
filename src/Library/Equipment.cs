//-------------------------------------------------------------------------------
// <copyright file="Equipment.cs" company="Universidad Católica del Uruguay">
// Copyright (c) Programación II. Derechos reservados.
// </copyright>
//-------------------------------------------------------------------------------

using System.Text.Json;
using System.Text.Json.Serialization;

namespace Recipies
{
    public class Equipment : IJsonConvertible
    {
        public string Description { get; set; }
        public double HourlyCost { get; set; }
        
        [JsonConstructor]
        public Equipment(string description, double hourlyCost)
        {
            this.Description = description;
            this.HourlyCost = hourlyCost;
        }

        public string ConvertToJson()
        {
            return JsonSerializer.Serialize(this);
        }
        public void LoadFromJson(string json)
        {
            Equipment deserialized = JsonSerializer.Deserialize<Equipment>(json);
            this.Description = deserialized.Description;
            this.HourlyCost = deserialized.HourlyCost;
        }
    }
}