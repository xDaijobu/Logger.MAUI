namespace Logger.MAUI.Models;

public class Report
{
    public dynamic Error { get; set; }
    public dynamic StackTrace { get; set; }
    public DateTime DateTime { get; set; }
    public Dictionary<string, int> DeviceParameters { get; set; }
    public Dictionary<string, int> ApplicationParameters { get; set; }
    public Dictionary<string, int> CustomParameters { get; set; }
    public Exception Exception { get; set; }
    public PlatformType PlatformType { get; set; }
    public byte[]? ScreenShoot { get; set; }

    public Report(dynamic error, dynamic stackTrace, DateTime dateTime, Dictionary<string, int> deviceParameters, Dictionary<string, int> applicationParameters, Dictionary<string, int> customParameters, Exception exception, PlatformType platformType, byte[]? screenShoot)
    {
        Error = error;
        StackTrace = stackTrace;
        DateTime = dateTime;
        DeviceParameters = deviceParameters;
        ApplicationParameters = applicationParameters;
        CustomParameters = customParameters;
        Exception = exception;
        PlatformType = platformType;
        ScreenShoot = screenShoot;
    }

    public string ToJson(bool enableDeviceParameters = true, bool enableApplicationParameters = true,
        bool enableStackTrace = true, bool enableCustomParameters = false)
    {
        
    }
}