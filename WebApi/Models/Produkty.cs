//------------------------------------------------------------------------------
// <auto-generated>
//    Ten kod źródłowy został wygenerowany na podstawie szablonu.
//
//    Ręczne modyfikacje tego pliku mogą spowodować nieoczekiwane zachowanie aplikacji.
//    Ręczne modyfikacje tego pliku zostaną zastąpione w przypadku ponownego wygenerowania kodu.
// </auto-generated>
//------------------------------------------------------------------------------

namespace WebApi.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class Produkty
    {
        public int IdProduktu { get; set; }
        public string NazwaProduktu { get; set; }
        public string Opis { get; set; }
        public Nullable<int> Ilosc { get; set; }
        public Nullable<decimal> CenaNetto { get; set; }
        public Nullable<decimal> CenaBrutto { get; set; }
    }
}