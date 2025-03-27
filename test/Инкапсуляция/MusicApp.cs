public class MusicApp
{
    private List<string> _favoriteMusic = new ();

    public void AddMusic(string music)
    {
        if (string.IsNullOrEmpty(music) && !_favoriteMusic.Contains(music))
        {
            _favoriteMusic.Add(music);
        }
    }

    public void RemoveMusic(string music)
    {
        _favoriteMusic.Remove(music);
    }

    public List<string> GetFavirite()
    {
        return new List<string>(_favoriteMusic);
    }
}