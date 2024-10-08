namespace TVReceiver
{
    public class TV
    {
        bool isOn;
        int setVolume;

        public void turnOnTv()
        {
            isOn = true;
            Console.WriteLine("Turn On TV");
        }
    }
}
