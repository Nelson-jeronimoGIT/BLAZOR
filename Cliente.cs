 namespace AppEmpresa.Data;
 using System.Text.Json.Serialization; 
  
  public class Cliente
 {       
        [JsonPropertyName("Id_cliente")]
        public Int32? Id_cliente { get; set; }
        [JsonPropertyName("Nombres")]
        public string? nombres { get; set; }
         [JsonPropertyName("Apellidos")]
            public string? apellido { get; set; }
         [JsonPropertyName("Direccion")]
         public string? Direccion { get; set; }
         [JsonPropertyName("Telefono")]
       public string? telefono { get; set; }
        [JsonPropertyName("Fecha_Nacimiento")]
        public DateTime? fecha_nacimeto { get; set; }
         
       
    
    
        
        
    }
}