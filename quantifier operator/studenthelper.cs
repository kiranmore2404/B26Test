using System.Diagnostics.CodeAnalysis;

public class studenthelper : IEqualityComparer<student>
{
    public bool Equals(student? x, student? y)
    {
   return x.name.Equals(y.name) && x.rollnumber.Equals(y.rollnumber) && x.gender.Equals(y.gender) && x.city.Equals(y.city);

    }

    public int GetHashCode([DisallowNull] student obj)
    {
        return obj.name.GetHashCode()
            ^ obj.rollnumber.GetHashCode()
            ^obj.gender.GetHashCode()
            ^ obj.city.GetHashCode();


    }
}