using System;
using HttpServer;
using EZ_B;

namespace Serial_Test {

  public class HTTPDServer {

    private HttpListener   _httpListener;
    private bool           _isRunning;
    private EZB _ezb;
    private int            _tcpPort;

    public HTTPDServer(EZB ezb) {

      _ezb = ezb;
    }

    public int tcpPort {
      get {
        return _tcpPort;
      }
    }

    public bool IsRunning {
      get {
        return _isRunning;
      }
    }

    private static bool isPortInUse(int port) {

      try {

        new System.Net.Sockets.TcpClient(new System.Net.IPEndPoint(System.Net.IPAddress.Any, port)).Close();
        return false;
      } catch {

        return true;
      }
    }

    void _httpListener_RequestReceived(object sender, RequestEventArgs e) {

      try {

        IHttpClientContext response       = (IHttpClientContext)sender;
        string             remoteIp       = e.Request.Headers["remote_addr"];

        handleRequest(e.Request, response, remoteIp);
      } catch {

      }
    }

    void handleRequest(IHttpRequest request, IHttpClientContext response, string remoteIp) {

      try {

        string path        = request.UriPath.ToLower().Trim();
        string queryString = request.QueryString.ToString().Trim();

        if (path.Contains("/forward")) 
          _ezb.Movement.GoForward();

        if (path.Contains("/backward"))
          _ezb.Movement.GoReverse();

        if (path.Contains("/left"))
          _ezb.Movement.GoLeft();

        if (path.Contains("/right"))
          _ezb.Movement.GoRight();

        if (path.Contains("/stop"))
          _ezb.Movement.GoStop();

        response.Respond(Resource1.mainMenu);
      } catch {

        response.Respond(Resource1.mainMenu);
      }

      response.Disconnect(System.Net.Sockets.SocketError.Success);
    }

    public void StartServer(int tcpPort) {

      try {

        if (isPortInUse(tcpPort))
          throw new Exception("TCP Port for Web Service is in use.");

        _httpListener = HttpListener.Create(System.Net.IPAddress.Any, tcpPort);
        _httpListener.RequestReceived += _httpListener_RequestReceived;

        _httpListener.Start(5);

        _tcpPort = tcpPort;
        _isRunning = true;
      } catch {

        StopServer();
      }
    }

    public void StopServer() {

      try {

        if (_httpListener != null) {

          _httpListener.Stop();
          _httpListener = null;
        }

        _isRunning = false;
      } catch {

      }
    }
  }
}