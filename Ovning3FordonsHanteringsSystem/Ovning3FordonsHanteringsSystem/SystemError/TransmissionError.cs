namespace Ovning3FordonsHanteringsSystem.SystemError;

public class TransmissionError : SystemError
{
    public override void ErrorMessage()
    {
        Util.Log("Växellådsproblem: Reparation krävs!");
    }
}
