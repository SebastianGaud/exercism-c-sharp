using System;
using System.Collections.Generic;


public enum Planets
{
    Earth,
    Mercury,
    Venus,
    Mars,
    Jupiter,
    Saturn,
    Uranus,
    Neptune
}

public interface IPlanetYearCoefficentCollection
{
    double this[Planets planet] { get; }
}

//- Earth: orbital period 365.25 Earth days, or 31557600 seconds
//- Mercury: orbital period 0.2408467 Earth years
//- Venus: orbital period 0.61519726 Earth years
//- Mars: orbital period 1.8808158 Earth years
//- Jupiter: orbital period 11.862615 Earth years
//- Saturn: orbital period 29.447498 Earth years
//- Uranus: orbital period 84.016846 Earth years
//- Neptune: orbital period 164.79132 Earth years
public class PlanetYearCoefficentCollection : IPlanetYearCoefficentCollection
{
    private Dictionary<Planets, double> _earthRelatedCoefficent = new Dictionary<Planets, double>
    {
        { Planets.Earth, 1 },
        { Planets.Mercury, 0.2408467 },
        { Planets.Venus, 0.61519726 },
        { Planets.Mars, 1.8808158 },
        { Planets.Jupiter, 11.862615 },
        { Planets.Saturn, 29.447498 },
        { Planets.Uranus, 84.016846 },
        { Planets.Neptune, 164.79132 },
    };


    public double this[Planets planet]
    {
        get
        {

            if (_earthRelatedCoefficent.ContainsKey(planet))
            {
                return _earthRelatedCoefficent[planet];
            }

            throw new ArgumentException("Can't find this planet!!!!");
        }
    }
}

public interface IPlanetTimeCalculator
{
    double PlanetSeconds(Planets planet);
}

public class PlanetTimeCalculator : IPlanetTimeCalculator
{
    private readonly IPlanetYearCoefficentCollection _planetCoefficents;
    const int EarthYearSecondConst = 31557600;

    public PlanetTimeCalculator(IPlanetYearCoefficentCollection planetCoefficents)
    {
        this._planetCoefficents = planetCoefficents;
    }

    public double PlanetSeconds(Planets planet)
    {
        return _planetCoefficents[planet] * (double)EarthYearSecondConst;
    }
}

public class SpaceAge
{
    private readonly long _seconds;
    private readonly IPlanetTimeCalculator _timeCalculator;

    public SpaceAge(long seconds)
    {
        _seconds = seconds;
        _timeCalculator = new PlanetTimeCalculator(new PlanetYearCoefficentCollection());
    }

    public double OnEarth() => On(Planets.Earth);

    public double OnMercury() => On(Planets.Mercury);

    public double OnVenus() => On(Planets.Venus);

    public double OnMars() => On(Planets.Mars);

    public double OnJupiter() => On(Planets.Jupiter);

    public double OnSaturn() => On(Planets.Saturn);

    public double OnUranus() => On(Planets.Uranus);

    public double OnNeptune() => On(Planets.Neptune);

    private double On(Planets planet)
    {
        return Math.Round(_seconds / _timeCalculator.PlanetSeconds(planet), 2);
    }
}