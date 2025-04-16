public abstract class Activity
{
    private string _date;
    private int _lengthMinutes;

    public Activity(string date, int lengthMinutes)
    {
        _date = date;
        _lengthMinutes = lengthMinutes;
    }

    public string Date => _date;
    public int LengthMinutes => _lengthMinutes;

    public abstract double GetDistance(); // in km
    public abstract double GetSpeed();    // in kph
    public abstract double GetPace();     // min per km

    public virtual string GetSummary()
    {
        return $"{_date} {this.GetType().Name} ({_lengthMinutes} min): " +
               $"Distance {GetDistance():0.0} km, " +
               $"Speed {GetSpeed():0.0} kph, " +
               $"Pace: {GetPace():0.00} min per km";
    }
}
