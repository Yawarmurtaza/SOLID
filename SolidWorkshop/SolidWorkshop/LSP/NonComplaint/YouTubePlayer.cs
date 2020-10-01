namespace SolidWorkshop.LSP.NonComplaint
{
    using System;

    public class YouTubePlayer
    {
        public virtual void Play()
        {
            Console.WriteLine("YouTubePlayer is playing");
        }

        public virtual void Pause()
        {
            Console.WriteLine("YouTubePlayer is paused");
        }

        public virtual void Next()
        {
            Console.WriteLine("YouTubePlayer plays next track.");
        }

        public virtual void Previous()
        {
            Console.WriteLine("YouTubePlayer plays previous track.");
        }

        public virtual void VolumeUp()
        {
            Console.WriteLine("YouTubePlayer volume up.");
        }

        public virtual void VolumeDown()
        {
            Console.WriteLine("YouTubePlayer volume down.");
        }
    }

    public class YouTubeMobilePlayer : YouTubePlayer
    {
        public void CastToTv()
        {
            Console.WriteLine("YouTubeMobilePlayer cast to TV.");
        }

        public void SetPlaybackSpeed()
        {
            Console.WriteLine("YouTubeMobilePlayer sets player speed.");
        }

        public override void VolumeUp()
        {
            throw new NotSupportedException("Volume up is not supported in mobile player");
        }

        public override void VolumeDown()
        {
            throw new NotSupportedException("Volume down is not supported in mobile player");
        }
    }
}