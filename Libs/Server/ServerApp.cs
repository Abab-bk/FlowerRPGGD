using Microsoft.Extensions.Logging;
using SuperSimpleTcp;

namespace Server;

public class ServerApp
{
    public bool IsRunning { get; private set; }

    private readonly SimpleTcpServer _server;
    private readonly ILogger _logger;
    
    public ServerApp(string ip, int port, ILogger logger)
    {
        _server = new SimpleTcpServer(ip, port);
        _logger = logger;
    }

    public void Run()
    {
        if (IsRunning) return;
        IsRunning = true;

        _server.Events.ClientConnected += OnClientConnected;
        _server.Events.ClientDisconnected += OnClientDisconnected;
        _server.Events.DataReceived += OnDataReceived;
        
        _server.Start();
    }

    private void OnClientConnected(object? sender, ConnectionEventArgs e)
    {
        _logger.LogInformation("[Server] Client connected: {port}", e.IpPort);
    }

    private void OnClientDisconnected(object? sender, ConnectionEventArgs e)
    {
    }
    
    private void OnDataReceived(object? sender, DataReceivedEventArgs e)
    {
    }
}