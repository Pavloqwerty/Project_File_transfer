using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Drawing;
using System.Drawing.Imaging;
using System.Runtime.Serialization.Formatters.Binary;

public class PacketEditor : BinaryWriter
{
    public MemoryStream _rm;
    public BinaryFormatter _rr;
    /// <summary>
    /// Create constructor 
    /// </summary>
    public PacketEditor()
        : base()
    {
        _rm = new MemoryStream();
        _rr = new BinaryFormatter();
        OutStream = _rm;
    }
    /// <summary>
    /// Add Image 
    /// </summary>
    /// <param name="img"></param>
    public void Create(Image img)
    {
        var mm = new MemoryStream();

        img.Save(mm, ImageFormat.Jpeg);

        mm.Close();

        byte[] imageSize = mm.ToArray();

        Create(imageSize.Length);
        Create(imageSize);
    }

    private void Create(byte[] imageSize)
    {
        throw new NotImplementedException();
    }

    private void Create(int length)
    {
        throw new NotImplementedException();
    }

    public void WriteR(object obiect)
    {
        _rr.Serialize(_rm, obiect);
    }

    public byte[] ReceiveBites()
    {
        Close();

        byte[] dane = _rm.ToArray();

        return dane;
    }
}
/// <summary>
/// Reading data 
/// </summary>
public class PacketRead : BinaryReader
{
    public BinaryFormatter _fb;
    private Stream BasStream;

    public PacketRead(byte[] daata)
        : base(new MemoryStream(daata))
    {
        _fb = new BinaryFormatter();
    }

    public Image ReadImg()
    {
        long nil = ReadInt64();

        byte[] byties = ReadBytes(nil);

        Image imge;

        using (MemoryStream sm = new MemoryStream(byties))
        {
            imge = Image.FromStream(sm);
        }

        return imge;
    }

    private byte[] ReadBytes(long nil)
    {
        throw new NotImplementedException();
    }

    public M ReadObj<M>()
    {
        return (M)_fb.Deserialize(BasStream);
    }
}