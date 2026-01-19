using System;

class ParcelPoint
{
    private string name;

    public ParcelPoint(string name)
    {
        this.name = name;
    }

    public override string ToString()
    {
        return name;
    }

    public override bool Equals(object obj)
    {
        ParcelPoint other = obj as ParcelPoint;
        return other != null && name.Equals(other.name);
    }
}
