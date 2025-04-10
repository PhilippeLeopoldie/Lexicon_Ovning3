namespace Ovning3FordonsHanteringsSystem.SystemError;

public class TransmissionError : SystemError
{
    public override string ErrorMessage()
    {
        return "Växellådsproblem: Reparation krävs!";
    }
}
