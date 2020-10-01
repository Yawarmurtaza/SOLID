namespace SolidWorkshop.LSP.Complaint
{
    using System;

    public abstract class BaseYouTubePlayer
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

    }

    public class YouTubeWebPlayer : BaseYouTubePlayer
    {
        public virtual void VolumeUp()
        {
            Console.WriteLine("YouTubePlayer volume up.");
        }

        public virtual void VolumeDown()
        {
            Console.WriteLine("YouTubePlayer volume down.");
        }
    }

    public class YouTubeMobilePlayer : BaseYouTubePlayer
    {
        public void CastToTv()
        {
            Console.WriteLine("YouTubeMobilePlayer cast to TV.");
        }

        public void SetPlaybackSpeed()
        {
            Console.WriteLine("YouTubeMobilePlayer sets player speed.");
        }
    }
}