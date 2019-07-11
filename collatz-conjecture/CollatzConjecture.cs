using System;

public static class CollatzConjecture
{
    public static int Steps(int number)
    {
        // test require exception, imho is not a class responsability.
        if (number <= 0)
        {
            throw new ArgumentException();
        }
        
        return new CollatzConjectureCalculator(number).GetSteps();
    }
}


public class CollatzConjectureCalculator 
{
    private readonly int _number;
    private int _steps;
    private int _stepNumber;


    public CollatzConjectureCalculator(int number)
    {
        _number = number;
        _stepNumber = number;
        _steps = 0;
    }

    private void MakeStep() 
    {
        _steps++;

        if (_stepNumber.Module())
        {
            _stepNumber = _stepNumber / 2;
            return;    
        }

        _stepNumber = (_stepNumber * 3) + 1;
    }

    public int GetSteps()
    {
        // if we have 0 or a negative number we simply return 0, imho is correct because the calculus would return 0
        // the exception can be thrown outside of the class.
        while (_stepNumber != 1 && _stepNumber > 0)
        {
            MakeStep();
        };

        return _steps;
    }
}

public static class CollatzConjectureExtension {
    public static bool Module(this int number, int divideBy = 2) => (number % divideBy) == 0;
}