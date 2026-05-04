namespace Files2;
using System.Text;

class Program
{
    static void Main(string[] args)
    {
        Console.OutputEncoding = System.Text.Encoding.UTF8;
        // Low level streams
        using (FileStream fs = new FileStream("archivo.bin", FileMode.Create, FileAccess.Write))
        {
            byte[] data = { 0xF0, 0x9F , 0x99 , 0x82, 72, 111, 108, 97, 32, 109, 117, 110, 100, 111 }; // "Hola mundo"
            fs.Write(data, 0, data.Length);
        }

        using (FileStream fs = new FileStream("archivo.bin", FileMode.Open, FileAccess.Read))
        {
            byte[] buffer = new byte[4]; // A buffer of size 1kb is created. It avoids reading byte by byte.
            UTF8Encoding temp = new UTF8Encoding(true); // The file has byte data, it must be decoded.
            int readLen; // Actual size of the bytes read.
            
            while ((readLen = fs.Read(buffer,0,buffer.Length)) > 0) // Keep reading by blocks until there is no data.
            {
                Console.WriteLine(temp.GetString(buffer,0,readLen));
            }
        }
    }
}
