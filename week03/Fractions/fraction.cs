// Author: Sergio Nieto
// Encapsulation is like a secret club for your variables. No outsiders allowed!

public class Fraction
{
    // Private attributes
    private int _top;    // The numerator
    private int _bottom; // The denominator

    // Constructors
    public Fraction()
    {
        _top = 1;    // Default numerator
        _bottom = 1; // Default denominator
    }

    public Fraction(int top)
    {
        _top = top;      // Custom numerator
        _bottom = 1;     // Denominator is still 1
    }

    public Fraction(int top, int bottom)
    {
        _top = top;      // Custom numerator
        _bottom = bottom; // Custom denominator
    }

    // Getters and Setters
    public int GetTop()
    {
        return _top; // "Here's the numerator" 
    }

    public void SetTop(int top)
    {
        _top = top; // "Changing the numerator? Bold move.
    }

    public int GetBottom()
    {
        return _bottom; // "Here's the denominator. Handle with care."
    }

    public void SetBottom(int bottom)
    {
        _bottom = bottom; // "Changing the denominator? Don't divide by zero
    }

    // Methods
    public string GetFractionString()
    {
        return $"{_top}/{_bottom}"; // "Here's your fraction"
    }

    public double GetDecimalValue()
    {
        return (double)_top / _bottom; // "Here's the decimal version"
    }
}