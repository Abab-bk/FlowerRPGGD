using System.Threading.Tasks;
using Godot;
using Microsoft.Extensions.Logging;
using ZLogger;

namespace Game.Scripts;

/// <summary>
/// 调试日志输出
/// </summary>
public static class Logger
{
    private class RpgProcessor : IAsyncLogProcessor
    {
        public ValueTask DisposeAsync() => default;

        public void Post(IZLoggerEntry log)
        {
            GD.Print($"[{log.LogInfo.LogLevel}] {log}");
            log.Return();
        }
    }
    
    private static ILogger _logger;
    
    public static ILogger GetLogger() => _logger;
    
    public static void Init()
    {
        using var factory = LoggerFactory.Create(logging =>
        {
            logging.SetMinimumLevel(LogLevel.Information);
            logging.AddZLoggerLogProcessor(new RpgProcessor());
            // logging.AddZLoggerRollingFile(
            //     (dt, index) =>
            //     Path.Combine(
            //         Environment.GetFolderPath(Environment.SpecialFolder.CommonApplicationData),
            //         $"FlowerRpgGD/Logs/{dt:yyyy-MM-dd}_{index}.log"
            //         ),
            //     1024 * 1024
            //     );
            // logging.AddZLoggerFile(
            //     Path.Combine(
            //         Environment.GetFolderPath(Environment.SpecialFolder.CommonApplicationData),
            //         "FlowerRpgGD/Logs/log.log"
            //         )
            //     );
        });
        _logger = factory.CreateLogger("Game");
    }
    
    /// <summary>
    /// 输出日志
    /// </summary>
    public static void Log(string message)
    {
        _logger.LogInformation(message);
    }
    
    /// <summary>
    /// 输出错误日志
    /// </summary>
    public static void LogError(string message)
    {
        _logger.LogError(message);
    }
}