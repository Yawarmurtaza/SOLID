namespace SolidWorkshop.LSP
{
    using NonComplaint;

    public class YouTubePlayerClient
    {
        public void Run()
        {
            YouTubePlayer youTubePlayer = new YouTubePlayer();
            ExecutePlayer(youTubePlayer);

            // trying mobile player now..

            YouTubeMobilePlayer mobilePlayer = new YouTubeMobilePlayer();
            ExecutePlayer(mobilePlayer);
        }

        private void ExecutePlayer(YouTubePlayer player)
        {
            player.Play(); // play the video
            player.Next(); // play the next track.
            player.Pause(); // pause it

            player.VolumeUp(); // volume up please...
            
        }
    }
}