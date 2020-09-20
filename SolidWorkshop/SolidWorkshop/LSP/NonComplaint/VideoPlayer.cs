namespace SolidWorkshop.LSP.NonComplaint
{
    public abstract class VideoPlayer
    {
        private bool powerOn;
        private bool recordLoaded;
        public bool playingRecord;

        public virtual void PowerOn()
        {
            powerOn = true;
        }

        public virtual void PowerOff()
        {
            powerOn = false;
        }

        public virtual void LoadRecord()
        {
            if (powerOn)
            {
                recordLoaded = true;
            }
        }

        public virtual void EjectRecord()
        {
            if (powerOn)
            {
                recordLoaded = false;
            }
        }

        public virtual void Play()
        {
            if (powerOn && recordLoaded)
            {
                playingRecord = true;
            }
        }

        public virtual void Forward()
        {
        }

        public virtual void Rewind()
        {
        }

        public virtual void Pause() { }
    }

    public class Vhs : VideoPlayer
    {
        public void Record(Media input) { }

        public void FastForward()
        {
            // stop and fast forward till end or stop is clicked.. .
        }

        public void FastRewind()
        {
            // stop and fast rewind till start or stop is clicked.. .
        }
    }

    public class DvdPlayer : VideoPlayer
    {
        public void Seek(int seconds)
        {
        }

        public void Forward10Secs()
        {
        }

        public void Rewind10Secs()
        {
        }
    }

    public class Media { }
}