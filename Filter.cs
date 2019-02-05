public interface IFilter 
{
    bool execute(OlympicWinner winner);
}

public class NameFilter : IFilter
{
    private string _name;
    public NameFilter(string name)
    {
        _name = name;
    }
    public bool execute(OlympicWinner winner)
    {
        return winner.Athlete.Contains(_name);
    }
}

public class YearFilter : IFilter
{
    private int _year;
    public YearFilter(int year)
    {
        _year = year;
    }
    public bool execute(OlympicWinner winner)
    {
        return winner.Year == _year;
    }
    
}

public class AndFilter : IFilter
{
    private IFilter _filter1;
    private IFilter _filter2;
    public AndFilter(IFilter filter1, IFilter filter2)
    {
        _filter1 = filter1;
        _filter2 = filter2;
    }
    public bool execute(OlympicWinner winner)
    {
        return _filter1.execute(winner) && _filter2.execute(winner);
    }
    
}

public class OrFilter : IFilter
{
    private IFilter _filter1;
    private IFilter _filter2;
    public OrFilter(IFilter filter1, IFilter filter2)
    {
        _filter1 = filter1;
        _filter2 = filter2;
    }
    public bool execute(OlympicWinner winner)
    {
        return _filter1.execute(winner) || _filter2.execute(winner);
    }
    
}

public class NotFilter : IFilter
{
    private IFilter _filter1;
    public NotFilter(IFilter filter1, IFilter filter2)
    {
        _filter1 = filter1;        
    }
    public bool execute(OlympicWinner winner)
    {
        return !_filter1.execute(winner);
    }
    
}