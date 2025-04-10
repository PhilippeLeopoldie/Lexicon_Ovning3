namespace Ovning3FordonsHanteringsSystem.SystemError;

public class BrakeFailureError : SystemError
{
    public override void ErrorMessage()
    {
        Util.Log("Bromsfel: Fordonet är osäkert att köra!");
    }
}
