using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Net.Sockets;
using System.Net;
using file_transfer.Infrastructure;

internal delegate void SocketConfirmOperator(object sender, SocketConfirm e);
/// <summary>
/// Creating socket
/// </summary>
internal class SocketConfirm : FactArgs
{
    public Socket Confirm
    {
        get;
        private set;
    }
  
    public IPAddress Locate
    {
        get;
        private set;
    }

    public IPEndPoint EndMark
    {
        get;
        private set;
    }

    /// <summary>
    /// Socket Confirm End Point
    /// </summary>
    /// <param name="fb"></param>
    public SocketConfirm(Socket fb)
    {
        Confirm = fb;
        Locate = ((IPEndPoint)fb.RemoteEndPoint).Address;
        EndMark = (IPEndPoint)fb.RemoteEndPoint;
    }
}
/// <summary>
/// Creating clas Listener
/// </summary>
internal class Listener
{
    #region Variables
    private Socket _soket = null;
    private bool _run = false;
    private int _localport = -1;
    #endregion

    #region Properties
    public Socket SoketBazowy
    {
        get { return _soket; }
    }

    public bool Run
    {
        get { return _run; }
    }

    public int LocalPort
    {
        get { return _localport; }
    }
    #endregion

    public event SocketConfirmOperator Confirm;

    public Listener()
    {

    }

    public void Begin(int port)
    {
        if (_run)
            return;

        _localport = port;
        _run = true;
        _soket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
        _soket.Bind(new IPEndPoint(IPAddress.Any, port));
        _soket.Listen(100);
        _soket.BeginAccept(confirmCallback, null);
    }
    /// <summary>
    /// Stoping Socket
    /// </summary>
    public void Stop()
    {
        if (!_run)
            return;

        _run = false;
        _soket.Close();
    }
    /// <summary>
    /// Checking answer
    /// </summary>
    /// <param name="ar"></param>
    private void confirmCallback(IAsyncResult ar)
    {
        try
        {
            Socket sck = _soket.EndAccept(ar);
                Confirm(this, new SocketConfirm(sck));
        }
        catch
        {
        }

        if (_run)
            _soket.BeginAccept(confirmCallback, null);
    }
}

namespace file_transfer.Infrastructure
{
    public class FactArgs
    {
    }
}