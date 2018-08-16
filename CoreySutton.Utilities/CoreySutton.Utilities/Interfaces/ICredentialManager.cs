using System.Security;

namespace CoreySutton.Utilities
{
    public interface ICredentialManager
    {
        SecureString GetPassword();
        bool GetShouldSaveCredentials();
        string GetUsername();
        void Save();
    }
}