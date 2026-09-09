public class Solution {
    public int CarFleet(int target, int[] position, int[] speed) {
        var cars = new (int position, int speed)[position.Length];
        for(int i = 0; i < position.Length; i++)
        {
            cars[i] = (position[i], speed[i]);
        }
        Array.Sort(cars, (a,b) => a.position.CompareTo(b.position));
        float fleettime = 0;
        int count = 0;
        for(int i = position.Length - 1; i >= 0; i--)
        {
            float time = (float)(target - cars[i].position) / cars[i].speed;
            if(time > fleettime)
            {
                count++;
                fleettime = time;
            }
        }
        return count;
    }
}
