using System;
using System.Security;

namespace CoreySutton.Utilities
{
    public class CredentialManager : ICredentialManager
    {
        protected string Username;
        protected SecureString Password;

        private readonly ISettingManager _appSettingsManager;
        private readonly bool _useSavedCredentials = false;

        public CredentialManager(ISettingManager appSettingsManager)
        {
            _appSettingsManager = appSettingsManager;
  
            if (GetUseSavedCredentials())
            {
                _useSavedCredentials = true;
            }
        }

        private bool GetUseSavedCredentials()
        {
            string promptMsg = Resources.Prompts.Prompt_UseSavedCredentials;
            string emptyErrMsg = Resources.Errors.Error_InvalidUseSavedCredentials_Empty;
            string notYesNoErrMsg = Resources.Errors.Error_InvalidUseSavedCredentials_NotYesNo;

            return ConsoleIoUtil.GetYesNo(promptMsg, emptyErrMsg, notYesNoErrMsg);
        }

        public string GetUsername()
        {
            if (_useSavedCredentials && !string.IsNullOrEmpty(Username))
            {
                Console.WriteLine($"Saved Username: {Username}");
                return Username;
            }

            while (true)
            {
                Console.Write(Resources.Prompts.Prompt_Username);

                string inputLine = Console.ReadLine();

                if (string.IsNullOrEmpty(inputLine))
                {
                    Console.WriteLine(Resources.Errors.Error_InvalidUsername_Empty);
                }
                else
                {
                    Username = inputLine;
                }

                return inputLine;
            }
        }

        public SecureString GetPassword()
        {
            string promptMsg = Resources.Prompts.Prompt_Password;

            return ConsoleIoUtil.GetSecureString(promptMsg);
        }

        public bool GetShouldSaveCredentials()
        {
            string promptMsg = Resources.Prompts.Prompt_ShouldSaveCredentials;
            string emptyErrMsg = Resources.Errors.Error_InvalidShouldSaveCredentials_Empty;
            string notYesNoErrMsg = Resources.Errors.Error_InvalidShouldSaveCredentials_NotYesNo;

            return ConsoleIoUtil.GetYesNo(promptMsg, emptyErrMsg, notYesNoErrMsg);
        }

        public virtual void Save()
        {
            _appSettingsManager.SaveAsEncrypted("Username", "UsernameEntropy", Username);
        }
    }
}
