namespace Ovning3FordonsHanteringsSystem.SystemError;

public class BrakeFailureError : SystemError
{
    public override string ErrorMessage()
    {
        return "Bromsfel: Fordonet är osäkert att köra!";
    }
}
