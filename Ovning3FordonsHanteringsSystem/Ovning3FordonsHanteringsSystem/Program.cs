using Ovning3FordonsHanteringsSystem.SystemError;
using Ovning3FordonsHanteringsSystem;
using Ovning3FordonsHanteringsSystem.Vehicles;



internal class Program
{
    /*  F: Vad händer om du försöker lägga till en Car i en lista av Motorcycle? 
        Jag får ett kompileringsfel eftersom en lista av typen 'Motorcycle' inte 
        kan innehålla objekt av typen 'Car', typen matchar inte. 
      
       
     *  F: Vilken typ bör en lista vara för att rymma alla fordonstyper? 
        Listan måste vara av typen 'vehicle' för att kunna rymma alla fordonstyper som äver från 'Vehicle'.


     *  F: Kommer du åt metoden Clean() från en lista med typen List<Vehicle>? 
        Nej, eftersom 'Vehicle' inte implementerar ICleanable, daför man måste först
        kontrolerra om dett fordon implementerar interfacet.


     *  F: Vad är fördelarna med att använda ett interface här istället för arv? 
        Man kan implementera flera interfaces, medan man barra kan  arv från en basklass
     */


    static void Main(string[] args)
    {
        try
        {
            var stopProgram = 0;
            var input = 0;
            do
            {
                input = Util.intValidation(MainMenu.StartPresentation());
                MainMenu.Run(input);
            }
            while(input != stopProgram);
        }
        catch (Exception e)
        {
            e.Message.Log();
        }
    }
}
