using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Personalregister;

 public class Personal
{
    
   public string PersonNummer { get; set; }
    
    public string Fornamn {  get; set; }
  
    public string Efternamn { get; set; }
    
    public decimal Lon { get; set; }

    
}
