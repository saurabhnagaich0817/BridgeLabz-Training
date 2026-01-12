class PipeUtilityImpl : IPipeCutting
{
    private PipeNode head;
    public void InitializePriceChart()
    {
        head = new PipeNode(1, 1);
        PipeNode curr = head;
        curr.SetNext(new PipeNode(2, 5)); curr = curr.GetNext();
        curr.SetNext(new PipeNode(3, 8)); curr = curr.GetNext();
        curr.SetNext(new PipeNode(4, 9)); curr = curr.GetNext();
        curr.SetNext(new PipeNode(5, 17)); curr = curr.GetNext();
        curr.SetNext(new PipeNode(6, 17));
    }

  
    public int GetOptimizedRevenue(int rodLength)
    {
        int maxRevenue = 0;
        PipeNode temp = head;

        while (temp != null)
        {
            if (temp.GetLength() <= rodLength)
            {
                int pieces = rodLength / temp.GetLength();
                int revenue = pieces * temp.GetPrice();

                if (revenue > maxRevenue)
                    maxRevenue = revenue;
            }
            temp = temp.GetNext();
        }
        return maxRevenue;
    }

    
    public int GetNonOptimizedRevenue(int rodLength)
    {
        PipeNode temp = head;

        while (temp != null)
        {
            if (temp.GetLength() == rodLength)
                return temp.GetPrice();

            temp = temp.GetNext();
        }
        return 0;
    }
}
