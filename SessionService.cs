public class SessionService
{
    private string _currentUserName = string.Empty;
    private bool _isUserRegistered = false;

    public string CurrentUserName => _currentUserName;
    public bool IsUserRegistered => _isUserRegistered;

    public void SetUser(string userName)
    {
        _currentUserName = userName;
    }

    public void SetUserRegistered(bool isRegistered)
    {
        _isUserRegistered = isRegistered;
    }
}
