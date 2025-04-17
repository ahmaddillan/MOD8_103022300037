using System;
using System.Collections.Generic;
using System.Text.Json;
using System.Text.Json.Serialization;

public class BankTransferConfig
{
    public string lang { get; set; }
    public transfer Transfer { get; set; }
    public confirmation Confirmation { get; set; }
    public List<string> methods { get; set; }

    public class transfer
    {
        public int threshold { get; set; }
        public int low_fee { get; set; }
        public int high_fee { get; set; }
    }
    public class confirmation
    {
        public string en { get; set; }
        public string id { get; set; }

    }
    public const String filepath = @"bank_transfer_config.json";
    public BankTransferConfig() { }
    
    public BankTransferConfig readJson() {
        string jsonString = File.ReadAllText("banl_transfer_config.json");
        var options = new JsonSerializerOptions
        {
            PropertyNameCaseInsensitive = true
        };

        BankTransferConfig? json = JsonSerializer.Deserialize<BankTransferConfig>(jsonString,options);
        if (json == null) {
            throw new Exception("gagal membaca file");
        }
        return json;
    }

    public void writeNewConfig( ) {
        JsonSerializerOptions options = new JsonSerializerOptions()
        {
            WriteIndented = true
        };

        string jsonString = JsonSerializer.Serialize(BankTransferConfig,options);
        File.WriteAllText(filepath, jsonString);
    }

    public void setDefault() { 
        lang = "en";
        methods = new List<string> { "bank_transfer" };
        Transfer = new transfer {
            threshold = 25000000
            low_fee = 6500
            high_fee = 15000

        };

        Confirmation = new confirmation {
            en = "yes",
            id = "ya"
        };
    }

    public void UbahBahasa() {
        if (lang.Tolower() == "en")

            lang = "id";

        else
            lang = "en";

        writeNewConfig();
    }
}
