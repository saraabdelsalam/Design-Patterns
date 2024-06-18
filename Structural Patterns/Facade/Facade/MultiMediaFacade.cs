

using Structural_Patterns.Facade.SubSystem;

namespace Structural_Patterns.Facade.Facade
{
    public class MultiMediaFacade
    {
        private readonly VideoPlayer _videoPlayer = new();
        private readonly AudioPlayer _audioPlayer = new();
        private readonly SubtitlesService _subtitleService = new();
     

        public void WatchMovie(string movie, string audioTrack, string subtitle)
        {
            _videoPlayer.PlayVideo(movie);
            _audioPlayer.PlayAudio(audioTrack);
            _subtitleService.DisplaySubtitle(subtitle);
            Console.WriteLine("Enjoy the movie on the big screen!");
        }

        public void ListenToMusic(string song)
        {
            _audioPlayer.PlayAudio(song);
            Console.WriteLine("Feel the music with visualizations on the display.");
        }
    }
}
