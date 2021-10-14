namespace ActiveLogin.Authentication.GrandId.Api.Models
{
    public class BankIdFederatedLoginRequest
    {
        public BankIdFederatedLoginRequest(string? callbackUrl = null, bool? useChooseDevice = null, bool? useSameDevice = null, bool? askForPersonalIdentityNumber = null, string? personalIdentityNumber = null, bool? requireMobileBankId = null, string? customerUrl = null, bool? showGui = null, string? signUserVisibleData = null, string? signUserNonVisibleData = null, string? appRedirect = null)
        {
            CallbackUrl = callbackUrl;
            UseChooseDevice = useChooseDevice;
            UseSameDevice = useSameDevice;
            AskForPersonalIdentityNumber = askForPersonalIdentityNumber;
            PersonalIdentityNumber = personalIdentityNumber;
            RequireMobileBankId = requireMobileBankId;
            CustomerUrl = customerUrl;
            ShowGui = showGui;
            SignUserVisibleData = signUserVisibleData;
            SignUserNonVisibleData = signUserNonVisibleData;
            AppRedirect = appRedirect;
        }

        /// <summary>
        /// The url to return the user to.
        /// </summary>
        public string? CallbackUrl { get; }

        /// <summary>
        /// Present the user with a menu choice between "this device" and "other device" (this corresponds to setting "UseSameDevice" to true or false).
        /// </summary>
        public bool? UseChooseDevice { get; }

        /// <summary>
        /// Try to launch bankid automatically on the device the user is using. This can interfer with setting "RequireMobileBankId".
        /// </summary>
        public bool? UseSameDevice { get; }

        /// <summary>
        /// Ask the user for a personal identity number. PersonalIdentityNumber overrides this, but is required when "UseSameDevice" is false.
        /// </summary>
        public bool? AskForPersonalIdentityNumber { get; }

        /// <summary>
        /// The users 12 digit personal number without spaces, dashes or extra characters. Will be validated by checksum before proceeding.
        /// </summary>
        public string? PersonalIdentityNumber { get; }

        /// <summary>
        /// If set to true, only mobile certificates will be allowed to be used (mobile apps).
        /// </summary>
        public bool? RequireMobileBankId { get; }

        /// <summary>
        /// If wanted, this parameter can be set to a URL that will be shown as the "backwards" link on all screens.
        /// </summary>
        public string? CustomerUrl { get; }

        /// <summary>
        /// When set to false instead of a redirectUrl, returns "autoStartToken" which is used to (possibly) start BankId yourself.
        /// When an personal identity number is passed, no special launching except informing the user about starting bankid is required.
        /// </summary>
        public bool? ShowGui { get; }

        /// <summary>
        /// A string to show the user when signing.
        /// If set signing is enabled if available instead of authentication.
        /// </summary>
        public string? SignUserVisibleData { get; }

        /// <summary>
        /// The string to actually sign in the background.
        /// If not set, the value in userVisibleData is copied.
        /// </summary>
        public string? SignUserNonVisibleData { get; }

        /// <summary>
        /// The appRedirect parameter gets sent to the BankID application as the redirect parameter.
        /// This can be used to either forcibly stop or automate the flow after the user identifies in the BankID application.
        /// These are some of the recommendation for using the appRedirect parameter with different operating systems.
        /// With Android devices you rarely, if ever, need to pass anything to the appRedirect parameter. If you need to pass any value here it might be the string null.
        /// For iOS devices you have two options.
        /// Option 1: Pass the string null, this will halt the flow after the user identifies in the BankID application. After this the user needs to manually navigate back to the correct application. Either by clicking the top-left corner to go back, or by minimizing the BankID application.
        /// Option 2: Pass a URL with a custom scheme to instruct BankID to try to context switch to that application. For example myapp://redirect.
        /// </summary>
        public string? AppRedirect { get; }
    }
}
