class RouteManager
{
    private int coveredDistance = 0;
    private int distancePerStop = 5;

    public void AddDistanceForStop()
    {
        coveredDistance += distancePerStop;
    }

    public int FetchTotalDistance()
    {
        return coveredDistance;
    }
}
