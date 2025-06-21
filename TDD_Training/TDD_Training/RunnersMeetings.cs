namespace TDD_Training;

internal class RunnersMeetings
{
    public int FindMaxMeetingCardinality(int[] startPosition, int[] speed)
    {
        var maxCardinality = -1;

        for (var i = 0; i < startPosition.Length; i++)
        {
            for (var j = i + 1; j < startPosition.Length; j++)
            {
                var meetingTime = CalculateMeetingTime(startPosition[i], speed[i], startPosition[j], speed[j]);
                
                if (meetingTime.HasValue)
                {
                    var cardinality = CountRunnersAtTime(startPosition, speed, meetingTime.Value);
                    maxCardinality = Math.Max(maxCardinality, cardinality);
                }
            }
        }

        return maxCardinality;
    }
    private static double? CalculateMeetingTime(int pos1, int speed1, int pos2, int speed2)
    {
        if (speed1 == speed2)
        {
            return pos1 == pos2 ? 0 : null;
        }

        var time = (double)(pos2 - pos1) / (speed1 - speed2);
        
        return time > 0 ? time : null;
    }
    private static int CountRunnersAtTime(int[] startPosition, int[] speed, double time)
    {
        var positions = new Dictionary<double, int>();

        for (var i = 0; i < startPosition.Length; i++)
        {
            var position = startPosition[i] + speed[i] * time;
            
            positions[position] = positions.GetValueOrDefault(position, 0) + 1;
        }

        return positions.Values.Max();
    }
}