namespace Ovning3FordonsHanteringsSystem.SystemError;

public class EngineFailureError : SystemError
{
    public override void ErrorMessage()
    {
        Util.Log("Motorfel: Kontrollera motorstatus!");
    }
}
