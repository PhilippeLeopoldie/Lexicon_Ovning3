namespace Ovning3FordonsHanteringsSystem.SystemError;

public class EngineFailureError : SystemError
{
    public override string ErrorMessage()
    {
        return "Motorfel: Kontrollera motorstatus!";
    }
}
